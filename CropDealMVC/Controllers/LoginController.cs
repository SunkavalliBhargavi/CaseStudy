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
    [RoutePrefix("api/Login")]
    public class LoginController : Controller
    {

        public ActionResult Homepage()
        {
            return View();
        }
        //public ActionResult Crop()
        //{
        //    return View();
        //}


        public ActionResult LoginUser()
        {
            return View();
        }
        public ActionResult RegisterUser()
        {
            return RedirectToAction("RegisterUser", "Register");
        }

        [HttpPost]

        public async Task<ActionResult> LoginUser(LoginViewModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LoginViewModel newUser = new LoginViewModel();
                    var service = new ServiceRepository();
                    {
                        using (var response = service.VerifyLogin("api/Login", login))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            newUser = JsonConvert.DeserializeObject<LoginViewModel>(apiResponse);
                        }
                    }
                    if (newUser != null)
                    {
                        ViewBag.message = "Login Success";
                    }
                    else
                    {
                        ViewBag.message = "incorrect";
                    }
                }
            }
            catch
            {

            }
            return RedirectToAction("Crop", "Crop");

        }
    }
}