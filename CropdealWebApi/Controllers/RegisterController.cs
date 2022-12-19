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
    public class RegisterController : ApiController
    {
        private IUserRepository<UserProfile> _dataRepository;

        public RegisterController()
        {
            this._dataRepository = new UserRepository(new CropdealDBEntities());
        }
        [HttpPost]
        public IHttpActionResult CreateUser([FromBody] UserProfile userObj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _dataRepository.Add(userObj);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(userObj);
        }
    }
}

