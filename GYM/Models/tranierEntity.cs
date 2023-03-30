using System.ComponentModel.DataAnnotations;

namespace GYM.Models
{
    public class tranierEntity
    {
        [Key]
        public int tranierId { get; set; }
        [Required]
        public string tranierName { get; set; }

        ICollection<userEntity> userEntities { get; set; }

    }
}
