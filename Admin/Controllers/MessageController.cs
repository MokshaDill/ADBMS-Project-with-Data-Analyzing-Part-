using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    [Route("api/Message")]
    [ApiController]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("SearchDonorAndMessages")]
        public IActionResult SearchDonorAndMessages(string nic)
        {
            using (var context = new MessageDbContext())
            {
                var query = from d in context.Donors
                            join m in context.Messages on d.NIC equals m.NIC
                            where d.NIC == nic
                            select new
                            {
                                d.NIC,
                                d.FirstName,
                                d.LastName,
                                m.MessageText,
                                m.Timestamp,
                                d.Email
                            };

                var results = query.ToList();
                return Ok(results);
            }
        }



    }


}
