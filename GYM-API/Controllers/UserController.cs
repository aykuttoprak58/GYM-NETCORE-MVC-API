using GYM_API.Controllers;
using GYM_API.Models;
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
            var user = db.userEntitity.ToList();
            return Ok(user);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var user = db.userEntitity.Find(id);

            if (user != null)
            {
                return Ok(user);
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
            catch (Exception)
            {

                return BadRequest("kullanıcı Kaydedilmedi");
            }


        }

        [HttpPut]

        public IActionResult Update(userEntity userEntity)

        {

            var user = db.userEntitity.Find(userEntity.id);

            if (user != null)
            {

                db.userEntitity.Update(userEntity);
                db.SaveChanges();
                return Ok("Kullanıcı Güncellendi");

            }

            return BadRequest("Kullanıcı Güncellenmedi");

        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var user = db.userEntitity.Find(id);
            if (user != null)
            {

                db.Remove(user);
                db.SaveChanges();
                return Ok("Kullanıcı Silindi");
            }

            return BadRequest($"({id})'ye sahip kullanıcı bulunamadı");
        }


    }
}
