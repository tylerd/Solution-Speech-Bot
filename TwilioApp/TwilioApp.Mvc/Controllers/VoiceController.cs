// In Package Manager, run:
// Install-Package Twilio.AspNet.Mvc -DependencyVersion HighestMinor

using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace TwilioApp.Mvc.Controllers
{
    public class VoiceController : TwilioController
    {
        [HttpPost]
        public ActionResult Index()
        {
            var response = new VoiceResponse();
            response.Say("This is from Tyler. Thank you for calling! Have a great day.");

            return TwiML(response);
        }
    }
}
