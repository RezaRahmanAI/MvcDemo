using MvcDemo.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class ProfileController : Controller
    {

        static List<User> users = new List<User> {

                new User { Id = 1, Name = "Alice", Email = "dfsldfjs" },
                new User { Id = 2, Name = "Bob", Email = "dfkjooei" },
                new User { Id = 3, Name = "Charlie", Email = "dfjlsdfj" }
         };

        // GET: Profile
        public ActionResult Index()
        {
            return View(users);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return RedirectToAction("Index");
        }

        //public ActionResult Social()
        //{
        //    return View();
        //}
    }
}