using GYM.Business.Abstract;
using GYM.DataAccessLayer.Abstract;
using GYM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        UserEntity IUserService.Add(UserEntity userEntity)
        {
            return userRepository.Add(userEntity);
        }

        UserEntity IUserService.Delete(int id)
        {
            return userRepository.Delete(id);
        }

        List<UserEntity> IUserService.GetAll()
        {
            return userRepository.GetAll();
        }

        UserEntity IUserService.GetById(int id)
        {
            return userRepository.GetById(id);
        }

        UserEntity IUserService.GetByName(string name)
        {
            return userRepository.GetByName(name);
        }

        UserEntity IUserService.Update(UserEntity userEntity)
        {
            return userRepository.Update(userEntity);
        }
    }
}
