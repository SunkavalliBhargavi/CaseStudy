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
  
    public class AdminController : ApiController
    {
        private IUserRepository<ADMIN> _userRepository;
        public AdminController()
        {
            this._userRepository = new AdminRepository(new CropdealDBEntities());
        }
        [HttpPost]
        public IHttpActionResult CreateAdmin([FromBody] ADMIN admins)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _userRepository.Add(admins);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(admins);
        }
    }
}
