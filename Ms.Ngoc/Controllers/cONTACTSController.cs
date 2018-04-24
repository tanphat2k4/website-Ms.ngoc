﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web.Models;
using System.Net.Mail;
using System.Configuration;

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
                SendMail(model);
                //refesh page
                contentServices.SaveAndPublishWithStatus(person);
            }
            return CurrentTemplate(model);
        }
        private void SendMail(ContactModel model)
        {
            var formEmail = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["sendEmailForm"]);
            var formPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
            var toAddress = new MailAddress("tanphat2k4@gmail.com");
            string subject = ConfigurationManager.AppSettings["EmailSubject"];
            string body = model.message;
            var message = new MailMessage(formEmail, toAddress)
            {
                Subject = subject,
                Body = body
            };
            //connect ro SMTP credentials in web.config
            try
            {
                var smtp = new SmtpClient();
                smtp.Send(message);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

    }
   
}