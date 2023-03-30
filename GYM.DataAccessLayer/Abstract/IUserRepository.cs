using GYM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DataAccessLayer.Abstract
{
    public interface IUserRepository
    {
        List<UserEntity> GetAll();

        UserEntity GetById(int id); 

        UserEntity GetByName(string name);  

        UserEntity Add(UserEntity userEntity);      

        UserEntity Update(UserEntity userEntity);       

        UserEntity Delete(int id);      
    }
}
