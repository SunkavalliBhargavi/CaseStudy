using CropWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropWebApi.Repository
{
    public class UserRepository:IUserRepository<UserProfile>
    {
        private readonly CropdealDBEntities _CropDealDbEntities;
        public UserRepository(CropdealDBEntities cropDealDbEntities)
        {
            _CropDealDbEntities = cropDealDbEntities;
        }
        public void Add(UserProfile newUser)
        {
            _CropDealDbEntities.UserProfiles.Add(newUser);
            _CropDealDbEntities.SaveChanges();
        }


        public void Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public UserProfile Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserProfile> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UserProfile dbEntity)
        {
            throw new NotImplementedException();
        }
    }
}