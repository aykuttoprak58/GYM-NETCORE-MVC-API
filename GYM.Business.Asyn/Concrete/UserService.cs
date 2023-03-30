using GYM.Business.Asyn.Abstract;
using GYM.DataAccessLayer.Asyn.Abstract;
using GYM.Entities.Asyn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Business.Asyn.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<UserEntity> Add(UserEntity userEntity)
        {
            return await userRepository.Add(userEntity);        
        }

        public async Task<UserEntity> Delete(int id)
        {
            return await userRepository.Delete(id);   
        }

        public async Task<List<UserEntity>> GetAll()
        {
            return await userRepository.GetAll();     
        }

        public async Task<UserEntity> GetById(int id)
        {
           return await userRepository.GetById(id); 
        }

        public async Task<UserEntity> GetByName(string name)
        {
            return await userRepository.GetByName(name);    
        }

        public async Task<UserEntity> Update(UserEntity userEntity)
        {
            return await userRepository.Update(userEntity);     
        }
    }
}
