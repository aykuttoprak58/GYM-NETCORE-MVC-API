using GYM.DataAccessLayer.Abstract;
using GYM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DataAccessLayer.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly GymDbContext _db;

        public UserRepository(GymDbContext db)
        {
            _db = db;
        }

        public UserEntity Add(UserEntity userEntity)
        {
            _db.userEntitity.Add(userEntity);
            _db.SaveChanges();  
            return userEntity;
            
        }

        public UserEntity Delete(int id)
        {
           var salon = _db.userEntitity.Find(id);   
            _db.userEntitity.Remove(salon); 
            _db.SaveChanges();
            return salon;
        }

        public List<UserEntity> GetAll()
        {
           var salon = _db.userEntitity.ToList();   
            return salon;   
        }

        public UserEntity GetById(int id)
        {
            var salon = _db.userEntitity.Find(id);
            return salon;
        }

        public UserEntity GetByName(string name)
        {
            var salon = _db.userEntitity.FirstOrDefault(x=>x.name ==name);
            return salon;
        }

        public UserEntity Update(UserEntity userEntity)
        {
            _db.userEntitity.Update(userEntity);    
            _db.SaveChanges (); 
            return userEntity;      
        }
    }
}
