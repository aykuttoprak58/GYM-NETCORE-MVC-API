using GYM.Business.Abstract;
using GYM.DataAccessLayer;
using GYM.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GYM_API_NTIER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User2Controller : ControllerBase
    {
        private readonly IUserService userService;
        public User2Controller(IUserService userService2)
        {

            userService = userService2;
        }


        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult GetAll()
        {
            var user = userService.GetAll();

            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest("KULLANCI TABLOSU BOŞ LÜTFEN KULLANICI EKLENİYİZ");

        }

        /// <summary>
        /// Get User By id
        /// </summary>
        /// <returns></returns>

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var user = userService.GetById(id);
            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest($"Belirtilen id'ye sahip kullanıcı bulunamadı");

        }

        /// <summary>
        /// Get User By name
        /// </summary>
        /// <returns></returns>
        [HttpGet("name")]
        public IActionResult GetByName(string name)
        {
            var user = userService.GetByName(name);
            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest($"Belirtilen id'ye sahip kullanıcı bulunamadı");

        }



        /// <summary>
        /// Delete User
        /// </summary>
        /// <returns></returns>

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var user = userService.GetById(id);
            if (user != null)
            {
                userService.Delete(id);
                return Ok("Kullanıcı Silindi");
            }

            return BadRequest("belirtilen id'ye ait kullanıcı bulunamadı");

        }

        /// <summary>
        /// Add User
        /// </summary>
        /// <returns></returns>

        [HttpPost]

        public IActionResult Add(UserEntity entity)
        {
            if (ModelState.IsValid)
            {
                userService.Add(entity);
                return Ok("Kullanıcı Eklendi");
            }
            return BadRequest("Kullanıcı eklenemedi");

        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <returns></returns>

        [HttpPut]
        public async Task<IActionResult> Update(UserEntity entity)
        {
            var user = userService.GetById(entity.id);
            if (user != null)
            {
                userService.Update(entity);

                return Ok("Kullanıcı Güncellendi");
            }
            return BadRequest("Kullanıcı Güncellenmedi");

        }
    }
}
