using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkAssign1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult RideHistory()
        {
            ViewBag.Message = "Your ride history description page.";

            return View();
        }

        public ActionResult Management()
        {
            ViewBag.Message = "Your management page.";

            return View();
        }

        public ActionResult ALS()
        {
            ViewBag.Message = "Your advanced life support page.";

            return View();
        }

        public ActionResult BLS()
        {
            ViewBag.Message = "Your basic life support page.";

            return View();
        }
        public ActionResult PatientTransport()
        {
            ViewBag.Message = "Your patient transport page.";

            return View();
        }

        public ActionResult MedicalUtility()
        {
            ViewBag.Message = "Your medical utility page.";

            return View();
        }
        public ActionResult EventMedical()
        {
            ViewBag.Message = "Your event medical page.";

            return View();
        }
        public ActionResult AirAmbulance()
        {
            ViewBag.Message = "Your air ambulance page.";

            return View();
        }
        public ActionResult ConfirmBooking(string bookingID)
        {
            ViewBag.BookingID = bookingID;

            return View();
        }
       
        public ActionResult ServiceType()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }
    }
}