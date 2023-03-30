using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Entities.Asyn
{
     public class TranierEntity
    {
        [Key]
        public int tranierId { get; set; }
        [Required]
        public string tranierName { get; set; }

        ICollection<UserEntity> userEntities { get; set; }
    }
}
