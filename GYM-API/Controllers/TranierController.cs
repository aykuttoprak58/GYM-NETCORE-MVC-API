using GYM_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranierController : ControllerBase
    {
        gymDbContext db;

        public TranierController(gymDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var teacher = db.tranierEntitity.ToList();
            return Ok(teacher);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var teacher = db.tranierEntitity.Find(id);

            if (teacher != null)
            {
                return Ok(teacher);
            }

            return BadRequest($"{id}'ye sahip eğitmen mevcut değidldir");


        }


        [HttpPost]

        public IActionResult Add(tranierEntity tranierEntity)
        {
            try
            {
                db.Add(tranierEntity);
                db.SaveChanges();
                return Ok("eğitmen Kaydedildi");
            }
            catch (Exception)
            {

                return BadRequest("eğitmen Kaydedilmedi");
            }


        }

        [HttpPut]

        public IActionResult Update(tranierEntity tranierEntity)

        {

            var teacher = db.tranierEntitity.Find(tranierEntity.tranierId);

            if (teacher != null)
            {

                db.tranierEntitity.Update(tranierEntity);
                db.SaveChanges();
                return Ok("eğitmen Güncellendi");

            }

            return BadRequest("eğitmen Güncellenmedi");

        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var teacher = db.tranierEntitity.Find(id);
            if (teacher != null)
            {

                db.Remove(teacher);
                db.SaveChanges();
                return Ok("eğitmen Silindi");
            }

            return BadRequest($"({id})'ye sahip eğitmen bulunamadı");
        }





    }
}
