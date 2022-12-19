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
    [RoutePrefix("api/Crop")]
    public class CropController : ApiController
    {
       
        
        
            IUserRepository<CROP> _dataRepository;
            public CropController()
            {
                this._dataRepository = new CropRepository(new CropdealDBEntities());
            }
            [HttpGet]
            //[Route("")]
            public IEnumerable<CROP> GetAllCROP()
            {
                var crops = _dataRepository.GetAll();
                return crops;
            }

            [HttpDelete]
            [Route("DeleteCrop/{id}")]

            public IHttpActionResult DeleteCrop(int id)
            {
                try
                {
                    CROP crop = _dataRepository.Get(id);
                    if (crop == null)
                    {
                        return NotFound();
                    }
                    _dataRepository.Delete(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return Ok("Crop Details are deleted ..!");
            }
        [HttpPost]
        [Route("Post")]
        public IHttpActionResult Post([FromBody] CROP crop)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _dataRepository.Add(crop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(crop);
        }
        [HttpPut]
        [Route("Update/{id}")]

        public IHttpActionResult Update(int id, [FromBody] CROP cropid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (cropid == null)
            {
                return BadRequest("Crop is Not found");
            }
            if (id != cropid.ID)
            {
                return BadRequest();
            }
            _dataRepository.Update(cropid);

            return Ok(cropid);
        }
        
    }
}
