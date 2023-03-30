using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Models
{
    public class userEntity
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
        public int salonId { get; set;}
        [Required]
        [ForeignKey("courseEntity")]
        public int courseId{ get; set; }
        [Required]
        [ForeignKey("tranierEntity")]
        public int tranierId { get; set; }
      
        private salonEntity salonEntity { get; set; }
        private courseEntity courseEntity { get; set; }

        private tranierEntity tranierEntity { get; set; }        


           
    }
}
