//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Umbraco.Web;
//using Umbraco.Web.Mvc;
//using UmbracoTraining.Models;

//namespace Ms.Ngoc.Controllers
//{
//    public class contactController : SurfaceController
//    {
//        private const string Partial_Views_Path = "~/Views/cONTACTS/";
//        // GET: contact
//        public ActionResult Index()
//        {
//            return View();
//        }
//        public ActionResult RenderContact()
//        {
//            return PartialView(string.Format("{0}ContactsPage.cshtml", Partial_Views_Path));
//        }
//        //public ActionResult HandelSubmitForm(ContactModel model)
//        //{
//        //    var message = Services.ConsentService.CreataContent(model.Name + "_" + DateTime.Now.ToString(), CurrentPage.Id, "potential_Customer");
//        //}

//    }
//}