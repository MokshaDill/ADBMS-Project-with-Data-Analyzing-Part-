using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Contributor.Models
{
    public class BloodCampCon
    {
        [Key]
        public int Camp_ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date")]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("Start Time")]
        public TimeSpan StartTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("End Time")]
        public TimeSpan EndTime { get; set; }


        public string Location { get; set; }

        public string Coordinator { get; set; }

        public string Organization { get; set; }
    }
}
