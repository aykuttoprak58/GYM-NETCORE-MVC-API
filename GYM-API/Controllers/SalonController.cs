using GYM_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonController : ControllerBase
    {
       
            gymDbContext db;

            public SalonController(gymDbContext db)
            {
                this.db = db;
            }

            [HttpGet]
            public IActionResult Get()
            {
                var salon = db.salonEntitity.ToList();
                return Ok(salon);
            }

            [HttpGet("id")]
            public IActionResult GetById(int id)
            {
                var salon = db.salonEntitity.Find(id);

                if (salon != null)
                {
                    return Ok(salon);
                }

                return BadRequest($"{id}'ye sahip salon mevcut değidldir");


            }


            [HttpPost]

            public IActionResult Add(salonEntity salonEntity)
            {
                try
                {
                    db.Add(salonEntity);
                    db.SaveChanges();
                    return Ok("salon Kaydedildi");
                }
                catch (Exception)
                {

                    return BadRequest("salon Kaydedilmedi");
                }


            }

            [HttpPut]

            public IActionResult Update (salonEntity salonEntity)

        {

                var salon = db.salonEntitity.Find(salonEntity.salonId);

                if (salon != null)
                {

                    db.salonEntitity.Update(salonEntity);
                    db.SaveChanges();
                    return Ok("salon Güncellendi");

                }

                return BadRequest("salon Güncellenmedi");

            }

            [HttpDelete]

            public IActionResult Delete(int id)
            {
                var salon = db.salonEntitity.Find(id);
                if (salon != null)
                {

                    db.Remove(salon);
                    db.SaveChanges();
                    return Ok("salon Silindi");
                }

                return BadRequest($"({id})'ye sahip salon bulunamadı");
            }
        
    }
}
