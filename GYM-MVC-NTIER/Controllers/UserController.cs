using GYM.Business.Abstract;
using GYM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GYM_MVC_NTIER.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService UserService;

        public UserController(IUserService userService)
        {
            UserService = userService;
        }


        [HttpGet]
        public IActionResult EkleEkranı()
        {

            return View();
        }



        [HttpPost]
        public IActionResult Ekle(UserEntity userEntity)
        {
            UserService.Add(userEntity);
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public IActionResult Listele()
        {
            var salon = UserService.GetAll();

            return View(salon);
        }

        public IActionResult Detay(int id)
        {
            var salon = UserService.GetById(id);

            return View(salon);
        }


        [HttpGet]
        public IActionResult GüncelleEkranı(int id)
        {
            var salon = UserService.GetById(id);
            return View(salon);
        }

        [HttpPost]
        public IActionResult Güncelle(UserEntity userEntity)
        {
            UserService.Update(userEntity);
            return RedirectToAction("Listele");
        }

        [HttpGet]
        public IActionResult SilmeEkranı(int id)
        {
            var salon = UserService.GetById(id);
            return View(salon);
        }

        [HttpPost]
        public IActionResult Sil(int id)
        {
            UserService.Delete(id);
            return RedirectToAction("Listele");
        }





    }
}
