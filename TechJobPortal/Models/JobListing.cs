using System.ComponentModel.DataAnnotations;

namespace TechJobPortal.Models
{
    public class JobListing{
        public int id { get; set; }

        [Required]
        public string title { get; set; }
         
        [Required]
        public string companyName { get; set; }

        public string location { get; set; }

        
        public enum jobType{
            FullTime, PartTime, Remote, Contract
        }

        public jobType type { get; set; }
        public DateTime postedDate { get; set; }

    }
}