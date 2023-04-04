using GYM.Business.Asyn.Abstract;
using GYM.Entities.Asyn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GYM_API_NTIER_ASYN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAsynController : ControllerBase
    {
        private readonly IUserService userService;
        public UserAsynController(IUserService userService2)
        {

            userService = userService2;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await userService.GetAll();

            bool sonuc = user.IsNullOrEmpty();

            if (sonuc == false)
            {
                return Ok(user);

            }
            return BadRequest("KULLANCI TABLOSU BOŞ LÜTFEN KULLANICI EKLENİYİZ");


        }


        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await userService.GetById(id);
            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest($"Belirtilen id'ye sahip kullanıcı bulunamadı");

        }

        [HttpGet("name")]
        public async Task<IActionResult> GetByName(string name)
        {
            var user = await userService.GetByName(name);
            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest($"Belirtilen isme sahip kullanıcı bulunamadı");

        }


        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await userService.GetById(id);
            if (user != null)
            {
                await userService.Delete(id);
                return Ok("Kullanıcı Silindi");
            }

            return BadRequest("belirtilen id'ye ait kullanıcı bulunamadı");

        }

        [HttpPost]

        public async Task<IActionResult> Add(UserEntity entity)
        {
            if (ModelState.IsValid)
            {
                await userService.Add(entity);
                return Ok("Kullanıcı Eklendi");
            }
            return BadRequest("Kullanıcı eklenemedi");

        }


        [HttpPut]
        public async Task<IActionResult> Update(UserEntity entity)
        {
            var user = await userService.GetById(entity.id);
            if (user != null)
            {
                await userService.Update(entity);

                return Ok("Kullanıcı Güncellendi");
            }
            return BadRequest("Kullanıcı Güncellenmedi");

        }


    }
}
