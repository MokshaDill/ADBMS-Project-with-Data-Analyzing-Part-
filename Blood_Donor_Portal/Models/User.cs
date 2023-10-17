using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blood_Donor_Portal.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime Dob { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String PhNo { get; set; }
        public User()
        {

        }
    }
}
