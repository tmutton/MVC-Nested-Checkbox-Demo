using MVC_Nested_Checkbox_Demo.Models;
using System.Web.Mvc;

namespace MVC_Nested_Checkbox_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Notifications()
        {
            // read in the notification settings

            var model = new NotificationSettings()
            {
                ProjectFollows = new System.Collections.Generic.Dictionary<int, ProjectFollows>()
                {
                    { 21, new ProjectFollows() { Follows = true, ProjectName = "Revive West Pond" } },
                    { 273, new ProjectFollows() { Follows = false, ProjectName = "Improve Hammersmith" } },
                    { 374, new ProjectFollows() { Follows = true, ProjectName = "Help Newbury!" } },
                },
                NotificationsAboutProjectsICreate = true,
                Newsletter = true,
                UpdatesFromMovementsImFollowing = false,
                UpdatesFromProjectsIlike = false
            };

            return this.View("~/Views/Home/NotificationSettings.cshtml", model);
        }

        [HttpPost]
        public ActionResult Save(NotificationSettings model)
        {
            // get the notification settings back from the form and do something with them

            // return a thank you message
            return this.View("~/Views/Home/NotificationSettingsTy.cshtml");
        }
    }
}