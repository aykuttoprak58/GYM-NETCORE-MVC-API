using GYM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        gymDbContext db;

        public UserController(gymDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var salon = db.userEntitity.ToList();
            return Ok(salon);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var salon = db.userEntitity.Find(id);

            if (salon != null)
            {
                return Ok(salon);
            }

            return BadRequest($"{id}'ye sahip kullanıcı mevcut değidldir");


        }


        [HttpPost]

        public IActionResult Add(userEntity userEntity)
        {
            try
            {
                db.Add(userEntity);
                db.SaveChanges();
                return Ok("kullanıcı Kaydedildi");
            }
            catch (Exception )
            {

                return BadRequest("kullanıcı Kaydedilmedi");
            }


        }

        [HttpPut]

        public IActionResult Update(userEntity userEntity)

        {

            var salon = db.userEntitity.Find(userEntity.id);

            if (salon != null)
            {

                //db.userEntitity.Update(userEntity);
                salon.name = userEntity.name;
                salon.surname = userEntity.surname;
                salon.age = userEntity.age;
                salon.gender = userEntity.gender;
                salon.courseId = userEntity.courseId;
                salon.tranierId = userEntity.tranierId;
                salon.salonId = salon.salonId;
                db.SaveChanges();
                return Ok("Kullanıcı Güncellendi");

            }

            return BadRequest("Kullanıcı Güncellenmedi");

        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var salon = db.userEntitity.Find(id);
            if (salon != null)
            {

                db.Remove(salon);
                db.SaveChanges();
                return Ok("Kullanıcı Silindi");
            }

            return BadRequest($"({id})'ye sahip kullanıcı bulunamadı");
        }


    }
}
