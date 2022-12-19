using CropMVC.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CropMVC.Models;

namespace CropMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]

        public async Task<ActionResult> RegisterUser(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                UserViewModel newUser = new UserViewModel();
                var service = new ServiceRepository();
                {
                    using (var response = service.PostResponse("https://localhost:44315/api/Register", userViewModel))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        newUser = JsonConvert.DeserializeObject<UserViewModel>(apiResponse);
                    }
                }
                return RedirectToAction("Homepage", "Login");
            }
            return View(userViewModel);
        }


    }
}