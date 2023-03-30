using GYM.DataAccessLayer.Asyn.Abstract;
using GYM.Entities.Asyn;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DataAccessLayer.Asyn.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly GymDbContextAsyn _db;

        public UserRepository(GymDbContextAsyn db)
        {
            _db = db;
        }

        public async Task<UserEntity> Add(UserEntity userEntity)
        {
            _db.userEntitity.Add(userEntity);
            await _db.SaveChangesAsync();
            return userEntity;
        }

        public async Task<UserEntity> Delete (int id)
        {
            var user = _db.userEntitity.Find(id);   
            _db.userEntitity.Remove(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<List<UserEntity>> GetAll()
        {

            var user = await _db.userEntitity.ToListAsync();
            return user;
        }

        public async Task<UserEntity> GetById(int id)
        {
            var user = await _db.userEntitity.FindAsync(id);
            return user;        
        }

        public async Task<UserEntity> GetByName(string name)
        {
            var user = await _db.userEntitity.FirstOrDefaultAsync(z => z.name == name);
            return user;
        }

        public async Task<UserEntity> Update(UserEntity userEntity)
        {
            _db.userEntitity.Update(userEntity);    
            await _db.SaveChangesAsync();       
            return userEntity;  
        }
    }
}
