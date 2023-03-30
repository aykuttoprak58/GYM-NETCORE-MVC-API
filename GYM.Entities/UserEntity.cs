using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Entities
{
     public class UserEntity
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        [ForeignKey("salonEntity")]
        public int salonId { get; set; }
        [Required]
        [ForeignKey("courseEntity")]
        public int courseId { get; set; }
        [Required]
        [ForeignKey("tranierEntity")]
        public int tranierId { get; set; }

        private SalonEntity salonEntity { get; set; }
        private CourseEntity courseEntity { get; set; }

        private TranierEntity tranierEntity { get; set; }
    }
}
