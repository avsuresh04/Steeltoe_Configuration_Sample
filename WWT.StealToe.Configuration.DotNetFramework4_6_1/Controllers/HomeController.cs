using System.Web.Mvc;

namespace WWT.StealToe.Configuration.DotNetFramework4_6_1.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult ReadFromApplicationYMLFile()
        {
            ViewBag.Title = "Reading Configuration value from application.yml file.";

            ViewData["Key1"] = "parent:child1";
            ViewData["Value1"] = ConfigServerConfig.GetConfigValueFromConfigServer("parent:child1") ?? "Not Returned from Config Server";
            ViewData["Key2"] = "parent:child2";
            ViewData["Value2"] = ConfigServerConfig.GetConfigValueFromConfigServer("parent:child2") ?? "Not Returned from Config Server";
            ViewData["Key3"] = "WWT.StealToe.Configuration.DotNetFramework4_6_1";
            ViewData["Value3"] = ConfigServerConfig.GetConfigValueFromConfigServer("WWT:StealToe:Configuration:DotNetFramework4_6_1") ?? "Not Returned from Config Server";
            return View();
        }

        public ActionResult ReadFromPropertiesFile()
        {
            ViewBag.Title = "Reading Configuration value from .properties file.";

            ViewData["Key1"] = "TestKey1";
            ViewData["Value1"] = ConfigServerConfig.GetConfigValueFromConfigServer("TestKey1") ?? "Not Returned from Config Server";
            ViewData["Key2"] = "TestKey2";
            ViewData["Value2"] = ConfigServerConfig.GetConfigValueFromConfigServer("TestKey2") ?? "Not Returned from Config Server";
            ViewData["Key3"] = "democonfigclient.message";
            ViewData["Value3"] = ConfigServerConfig.GetConfigValueFromConfigServer("democonfigclient:message") ?? "Not Returned from Config Server";
            return View();
        }

        public string Refresh()
        {
            ConfigServerConfig.Refresh();

            return "Refreshed the config values...";
        }
    }
}
