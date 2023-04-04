using System.ComponentModel.DataAnnotations;

namespace GYM_API.Models    
{
    public class courseEntity
    {
        [Key]
        public int courseId { get; set; }
        [Required]
        public string courseName { get; set;}

        ICollection<userEntity> userEntities { get; set; }

    }
}
