using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Entities
{
     public class SalonEntity
    {
        [Key]
        public int salonId { get; set; }
        [Required]
        public string salonName { get; set; }

        ICollection<UserEntity> userEntities { get; set; }

    }
}
