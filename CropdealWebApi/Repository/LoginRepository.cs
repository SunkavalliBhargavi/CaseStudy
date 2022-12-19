using CropWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropWebApi.Repository
{
    public class LoginRepository:ILoginRepository
    {
        CropdealDBEntities _cropDealDbEntities = null;
        public UserProfile VerifyLogin(string email, string Password)
        {
            UserProfile userProfile = null;
            try
            {
                var checkValidUser = _cropDealDbEntities.UserProfiles.Where(m => m.Email == email &&
            m.Password == Password).FirstOrDefault();
                if (checkValidUser != null)
                {
                    userProfile = checkValidUser;
                }

                else
                {
                    userProfile = null;
                }
            }
            catch (Exception ex)
            {
            }
            return userProfile;
        }
        public LoginRepository(CropdealDBEntities cropDealDbEntities)
        {
            this._cropDealDbEntities = cropDealDbEntities;
        }
    }
}
