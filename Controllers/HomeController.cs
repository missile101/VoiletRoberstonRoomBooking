using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Violet_Roberston_RoomBooking.YM.Models;
using Rotativa;
using System.IO;
using System.Drawing.Printing;

namespace Violet_Roberston_RoomBooking.YM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SplashScreen()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contact()// sends the empty contactform to the browser 
        {

            return View();

        }
        [HttpPost]
        public ActionResult Contact(Message message)// gets the form back with all the info from the user 
        {
            if(ModelState.IsValid)// if the message is a valid object-meaning it's not nulll then 

            {   // add a time stamp to the message when the user posted the form 
                message.DateofMessage = DateTime.Now;
                // and then send the message details to a confirmation page 
                return View("Confirmation",message);
            } 
            // id the message model is null then send the empty form back to the user -
            return View(message);
        }

        public ActionResult Fees()
        {
            return View();
        }

        public ActionResult ConvertPDF()
        {
            // This is the name of the pdf files once the fees web page gets converted
            string fileName = "BookingFees.pdf";

            // gets all the cookies that were sent by the client stored in a dictionary as a key value pair
            var cookies = Request.Cookies.AllKeys.ToDictionary(k => k, k => Request.Cookies[k].Value);

            // the object actionaspdf that will call the fees method and set the layout of the pdf file 
            var actionPDF = new ActionAsPdf("Fees")
            {
                FileName = fileName,
                PageSize = Rotativa.Options.Size.A4,
                PageOrientation = Rotativa.Options.Orientation.Portrait,
                PageMargins = new Rotativa.Options.Margins(5, 10, 5, 10),
                FormsAuthenticationCookieName = System.Web.Security.FormsAuthentication.FormsCookieName,
                Cookies = cookies
            };

            // file builder 
            byte[] applicationPDFData = actionPDF.BuildFile(ControllerContext);

            return actionPDF;

        
      
        }

        public ActionResult MapLocation()
        {
            return View();
        }


        public ActionResult Room1()
        {
            return View();
        }

        public ActionResult Room2()
        {
            return View();
        }
        public ActionResult Room3()
        {
            return View();
        }
        public ActionResult Room4()
        {
            return View();
        }
    }
}