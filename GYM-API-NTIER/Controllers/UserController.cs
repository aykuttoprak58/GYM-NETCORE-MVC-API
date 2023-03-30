using GYM.Business.Abstract;
using GYM.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM_API_NTIER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
      private readonly IUserService userService;

        public UserController(IUserService userService2)
        {
            userService = userService2;
        }
        [HttpGet]
        public List<UserEntity> GetAll() 
        {
           var user = userService.GetAll();

            return user;  

        }

        [HttpGet("id")]
        public UserEntity GetById(int id)
        {

            return userService.GetById(id);
        }

        [HttpDelete("id")]
        public UserEntity Delete(int id) 
        {

            return userService.Delete(id);    

        }

        [HttpPost]

        public UserEntity Add(UserEntity entity) 
        { 
        
        return userService.Add(entity);  

        }

        [HttpPut]
        public UserEntity Update(UserEntity entity) 
        { 
        
            return userService.Update(entity);  
        
        } 





    }
}
