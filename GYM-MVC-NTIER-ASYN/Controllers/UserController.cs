using Microsoft.AspNetCore.Mvc;
using GYM.Entities.Asyn;
using GYM.Business.Asyn.Abstract;

namespace GYM_MVC_NTIER_ASYN.Controllers
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
        public async Task<IActionResult> Ekle(UserEntity userEntity)
        {
            await UserService.Add(userEntity);
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public async Task<IActionResult> Listele()
        {
            var salon = await UserService.GetAll();

            return View(salon);
        }

        public async Task<IActionResult> Detay(int id)
        {
            var salon = await UserService.GetById(id);

            return View(salon);
        }





        [HttpGet]
        public async Task<IActionResult> GüncelleEkranı(int id)
        {
            var salon = await UserService.GetById(id);
            return View(salon);
        }

        [HttpPost]
        public async Task<IActionResult> Güncelle(UserEntity userEntity)
        {
            await UserService.Update(userEntity);
            return RedirectToAction("Listele");
        }

        [HttpGet]
        public async Task<IActionResult> SilmeEkranı(int id)
        {
            var salon = await UserService.GetById(id);
            return View(salon);
        }

        [HttpPost]
        public async Task<IActionResult> Sil(int id)
        {
            await UserService.Delete(id);
            return RedirectToAction("Listele");
        }

    }
}
