using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web.Models;

namespace Ms.Ngoc.Controllers
{
    public class cONTACTSController : RenderMvcController 
    {
        // GET: cONTACTS
        public ActionResult ContactsPage(RenderModel model)
        {
            if (Request.HttpMethod =="POST")
            {
                var fullName = Request["name"];
                var Email = Request["email"];
                var subject = Request["subject"];
                var message = Request["message"];
                //Creat Service
                var contentServices = Services.ContentService;
                var person = contentServices.CreateContent(fullName, model.Content.Id, "potential_Customer");
                //Creat Person
                person.SetValue("name_customer",fullName);
                person.SetValue("email",Email);
                person.SetValue("subject",subject);
                person.SetValue("message", message);
                //refesh page
                contentServices.SaveAndPublishWithStatus(person);
            }
            return CurrentTemplate(model);
        }
    }
}