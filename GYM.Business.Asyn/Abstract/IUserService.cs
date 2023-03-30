using GYM.Entities.Asyn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Business.Asyn.Abstract
{
    public interface IUserService
    {
        Task<List<UserEntity>> GetAll();

        Task<UserEntity> GetById(int id);

        Task<UserEntity> GetByName(string name);

        Task<UserEntity> Add(UserEntity userEntity);

        Task<UserEntity> Update(UserEntity userEntity);

        Task<UserEntity> Delete(int id);
    }
}
