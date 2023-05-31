using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RX108_Data;

namespace VIPL_CRM.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Email()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Email(email em, IFormFile file)
        {
            string to = em.to; //To address    
            string from = "dkraval07@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            message.Subject = em.subject;
            message.Body = em.message;
            message.BodyEncoding = Encoding.UTF8;
            if (file != null)
            {
                message.Attachments.Add(new Attachment(file.OpenReadStream(), file.FileName));
            }
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient(); //Gmail smtp    
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("dkraval07@gmail.com", "Inspiron1@5");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {

                client.Send(message);
                ViewBag.Msg = "Email Send Succesfully";
                ViewBag.Class = "alert alert-success";
            }

            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";

            }


            return View();
        }

    }
}