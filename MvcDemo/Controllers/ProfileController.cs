using MvcDemo.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {

            var users = new List<User> {

                new User { Id = 1, Name = "Alice", Email = "dfsldfjs" },
                new User { Id = 2, Name = "Bob", Email = "dfkjooei" },
                new User { Id = 3, Name = "Charlie", Email = "dfjlsdfj" }
            };


            return View(users);
        }

        public ActionResult Social()
        {
            return View();
        }
    }
}