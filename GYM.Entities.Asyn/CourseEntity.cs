using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Entities.Asyn
{
     public class CourseEntity
    {
        [Key]
        public int courseId { get; set; }
        [Required]
        public string courseName { get; set; }

        ICollection<UserEntity> userEntities { get; set; }
    }
}
