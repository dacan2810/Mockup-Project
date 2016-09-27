using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mockup_Project.DataServices;
using Mockup_Project.DataServices.Service;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace Mockup_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            user_informationService service = new user_informationService();
            user_information item = new user_information();
            //for (int i = 0; i < 50; i++)
            //{
            //    item.name = "name" + i;
            //    item.email = "email" + i + "@mail.com";
            //    item.address = "Address" + i;
            //    service.Add(item);
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    service.Delete(100);
            //}


            return View();
        }

        public ActionResult LoadData()
        {
            user_informationService service = new user_informationService();
            List<user_information> data = new List<user_information>();
            data = service.GetAll();
            Debug.WriteLine("Test" + data);
            var jsonSerialiser = new JavaScriptSerializer();
            string json = jsonSerialiser.Serialize(data);
            return Json(data,JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

    }
}