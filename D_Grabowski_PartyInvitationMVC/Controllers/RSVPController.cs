using D_Grabowski_PartyInvitationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_Grabowski_PartyInvitationMVC.Controllers
{
    public class RSVPController : Controller
    {
        // GET: RSVP
        [HttpGet]
        public ActionResult RSVP()
        {
            PartyResponse model = new PartyResponse
            {
                Name = "Enter Your Name here",
                Phone = "Phone Number here",
                Email = "and Email Address here"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult RSVP(PartyResponse model)
        {
            //if the state of model is valid that is not null
            if (ModelState.IsValid)
            {
                //get the current time and extract the hour
                int time = DateTime.Now.Hour;

                //if the time is before midday
                if (time < 12)
                {
                    //then we create a viewbag called "Greetings" and we load it with a string "Good Morning"
                    ViewBag.Greetings = "Good Morning";
                }
                else
                {
                    //else we load the viewbag called "Greetings" with a string "Good Afternoon"
                    ViewBag.Greetings = "Good Afternoon";
                }

                //then we return a new view called ThankYou.cshtml that will confirm the response
                //and also send the model to the view
                return View("ThankYou", model);
            }
            else
            {
                //else send the RSVP.cshtml form back and get guest's response
                return View();
            }

        }
    }
}