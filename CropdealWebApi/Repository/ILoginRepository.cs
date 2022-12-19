using CropWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropWebApi.Repository
{
    public interface ILoginRepository
    {
        UserProfile VerifyLogin(string Email, string Password);
    }
}