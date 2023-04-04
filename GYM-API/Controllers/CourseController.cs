using GYM_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
         gymDbContext db;

        public CourseController (gymDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var kurs = db.courseEntitity.ToList();
            return Ok(kurs);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var kurs = db.courseEntitity.Find(id);

            if (kurs != null)
            {
                return Ok(kurs);
            }

            return BadRequest($"{id}'ye sahip kurs mevcut değidldir");


        }


        [HttpPost]

        public IActionResult Add(courseEntity courseEntity)
        {
            try
            {
                db.Add(courseEntity);
                db.SaveChanges();
                return Ok("kurs Kaydedildi");
            }
            catch (Exception)
            {

                return BadRequest("kurs Kaydedilmedi");
            }


        }

        [HttpPut]

        public IActionResult Update(courseEntity courseEntity)

        {

            var kurs = db.courseEntitity.Find(courseEntity.courseId);

            if (kurs != null)
            {

                db.courseEntitity.Update(courseEntity);
                db.SaveChanges();
                return Ok("Kurs Güncellendi");

            }

            return BadRequest("Kurs Güncellenmedi");

        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var kurs = db.courseEntitity.Find(id);
            if (kurs != null)
            {

                db.Remove(kurs);
                db.SaveChanges();
                return Ok("Kurs Silindi");
            }

            return BadRequest($"({id})'ye sahip kurs bulunamadı");
        }
    }
}
