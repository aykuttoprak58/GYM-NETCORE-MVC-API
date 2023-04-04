using System.ComponentModel.DataAnnotations;

namespace GYM_API.Models
{
    public class salonEntity

    {
        [Key]
        public int salonId { get; set; }
        [Required]
        public string salonName { get; set; }

        ICollection<userEntity> userEntities { get; set; }


    }
}
