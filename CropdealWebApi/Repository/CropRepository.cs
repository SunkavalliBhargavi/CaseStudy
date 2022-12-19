using CropWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropWebApi.Repository
{
    public class CropRepository:IUserRepository<CROP>
    {
        CropdealDBEntities _cropDealDbEntities;
        public CropRepository(CropdealDBEntities cropDealDbEntities)
        {
            this._cropDealDbEntities = cropDealDbEntities;
        }
        public void Add(CROP Crop)
        {
            _cropDealDbEntities.CROPs.Add(Crop);
            _cropDealDbEntities.SaveChanges();
        }

        public void Delete(int ID)
        {
            CROP crop = _cropDealDbEntities.CROPs.Find(ID);
            _cropDealDbEntities.CROPs.Remove(crop);
            _cropDealDbEntities.SaveChanges();
        }

        public CROP Get(int id)
        {
            return _cropDealDbEntities.CROPs.Find(id);
        }

        public IEnumerable<CROP> GetAll()
        {
            _cropDealDbEntities.Configuration.ProxyCreationEnabled = false; //extraline
            return _cropDealDbEntities.CROPs.ToList();

        }

        public void Update(CROP CropNo)
        {
            _cropDealDbEntities.Entry(CropNo).State = System.Data.Entity.EntityState.Modified;
            _cropDealDbEntities.SaveChanges();
        }
    }
}
