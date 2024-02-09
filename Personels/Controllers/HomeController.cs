using Microsoft.AspNetCore.Mvc;
using Personels.Models;
using System.Diagnostics;

namespace Personels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Storage.Users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member model)
        {
            Storage.Users.Add(model);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = Storage.Users.FirstOrDefault(m => m.Id == id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(Member model)
        {
            var user = Storage.Users.FirstOrDefault(m => m.Id == model.Id);
            user.Name=model.Name;
            user.Lastname = model.Lastname;
            user.NationalCode = model.NationalCode;
            user.PhoneNumber = model.PhoneNumber;
            user.SignUpDate = model.SignUpDate;
            user.BirthDate = model.BirthDate;
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var user = Storage.Users.FirstOrDefault(m => m.Id == id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Delete(Member model)
        {
            var user = Storage.Users.FirstOrDefault(m => m.Id == model.Id);

            Storage.Users.Remove(user);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
