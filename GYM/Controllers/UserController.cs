using GYM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GYM.Controllers
{
    public class UserController : Controller
    {
        private readonly gymDbContext gymDbContext;
        private readonly DbSet<userEntity> dbset;
        public UserController(gymDbContext gymDbContext2)
        {
            gymDbContext = gymDbContext2;
            dbset = gymDbContext.Set<userEntity>();

       
        }

        [HttpGet]
        public IActionResult List()
        {
            var salon = gymDbContext.userEntitity.ToList();
            //var salon2 = dbset.ToList(); 
            return View(salon);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Add(userEntity userEntity)
        {
            gymDbContext.userEntitity.Add(userEntity);
            gymDbContext.SaveChanges(); 
            return RedirectToAction("List");   
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var salon = gymDbContext.userEntitity.Find(id);
            return View(salon); 

        }


        [HttpPost]
        public IActionResult Update(userEntity userEntity)
        {
            //var salon = gymDbContext.userEntitity.Find(userEntity.id);

            //salon.name = userEntity.name;
            //salon.surname = userEntity.surname; 
            //salon.age = userEntity.age; 
            //salon.gender = userEntity.gender;   
            //salon.salonId = userEntity.salonId; 
            //salon.courseId = userEntity.courseId;       
            //salon.tranierId = userEntity.tranierId;

            gymDbContext.userEntitity.Update(userEntity);

            gymDbContext.SaveChanges();
            return RedirectToAction("List");

        }

        [HttpGet]
        public IActionResult DeleteGet(int id)
        {
            var salon = gymDbContext.userEntitity.Find(id);
            return View(salon);

        }


        [HttpPost]
        public IActionResult DeletePost(int id) 
        {
            var salon = gymDbContext.userEntitity.Find(id);
            gymDbContext.userEntitity.Remove(salon);
            gymDbContext.SaveChanges();
            return RedirectToAction("List");

        }

    }
}
