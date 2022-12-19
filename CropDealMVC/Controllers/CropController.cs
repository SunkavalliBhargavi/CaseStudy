using CropMVC.Models;
using CropMVC.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CropMVC.Controllers
{
    public class CropController : Controller
    {
        // GET: Crop
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Crop()
        {
            List<CropViewModel> crops = new List<CropViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("api/Crop"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    crops = JsonConvert.DeserializeObject<List<CropViewModel>>(apiResponse);
                }
            }
            return View(crops);
        }
        public async Task<ActionResult> Delete(int ID)
        {
            CropViewModel Crop = new CropViewModel();
            var service = new ServiceRepository();
            {
                using (var response = service.DeleteResponse("api/Crop/DeleteCrop" + "/" + ID))

                {
                    string apiResponse = await response.Content.ReadAsStringAsync();


                }
            }
            return RedirectToAction("Crop");
        }
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(CropViewModel crop)
        {
            if (ModelState.IsValid)
            {
                CropViewModel newCrop = new CropViewModel();
                var service = new ServiceRepository();
                {
                    using (var response = service.PostResponse("api/Crop/Post", crop))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        newCrop
                            = JsonConvert.DeserializeObject<CropViewModel>(apiResponse);
                    }
                }

                return RedirectToAction("Crop");
            }
            return View(crop);
        }


        public async Task<ActionResult> Edit(int ID)
        {
            CropViewModel crop = new CropViewModel();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("api/Crop/Update" + "/" + ID))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    crop = JsonConvert.DeserializeObject<CropViewModel>(apiResponse);
                }
            }
            return View(crop);
        }


        [HttpPost]
        public async Task<ActionResult> Edit(CropViewModel crop)
        {
            CropViewModel Crops = new CropViewModel();
            var service = new ServiceRepository();
            {
                using (var response = service.PutResponse("api/Crop/Update" + "/" + crop.ID, crop))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Crops = JsonConvert.DeserializeObject<CropViewModel>(apiResponse);
                }
            }
            return RedirectToAction("Crop");
        }

    }
}