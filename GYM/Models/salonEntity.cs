using System.ComponentModel.DataAnnotations;

namespace GYM.Models
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
