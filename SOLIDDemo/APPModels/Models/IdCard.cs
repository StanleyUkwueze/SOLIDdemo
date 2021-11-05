using System.ComponentModel.DataAnnotations.Schema;

namespace APPModels.Models
{
    public class IdCard
    {
        [ForeignKey("User")]
        public string UserId { get; set; }

        public string Title { get; set; }

        public User User { get; set; } // Navigation property
    }
}
