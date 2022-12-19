using CropWebApi.Models;
using CropWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CropWebApi.Controllers
{

            [RoutePrefix("api/Login")]
        public class LoginController : ApiController
        {

            private ILoginRepository _loginRepository;
            public LoginController()
            {
                this._loginRepository = new LoginRepository(new CropdealDBEntities());
            }


            [HttpPost]
            public IHttpActionResult VerifyLogin(Models.Login objlogin)
            {
                UserProfile userProfile = null;

                try
                {
                    userProfile = _loginRepository.VerifyLogin(objlogin.Email, objlogin.Password);

                    if (userProfile != null)
                    {
                        //return NotFound();
                        return Ok(userProfile);

                    }

                }
                catch (Exception ex)
                {

                }
                return NotFound();
            }


        }
}
