using CropWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropWebApi.Repository
{
    public class AdminRepository : IUserRepository<ADMIN>
    {
        private readonly CropdealDBEntities _cropdealDbEntities;
        public AdminRepository(CropdealDBEntities cropdealDbEntities)
        {
            _cropdealDbEntities = cropdealDbEntities;
        }

        public void Add(ADMIN admin)
        {
            _cropdealDbEntities.ADMINs.Add(admin);
            _cropdealDbEntities.SaveChanges();
        }

        public void Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public ADMIN Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ADMIN> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ADMIN dbEntity)
        {
            throw new NotImplementedException();
        }
    }
}