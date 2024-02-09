using Microsoft.AspNetCore.Mvc;
using Personels_Manager.Models;
using System.Diagnostics;

namespace Personels_Manager.Controllers
{
    public class HomeController : Controller
    {
        private List<Member> members = new List<Member>(); // در واقع اینجا باید از پایگاه داده استفاده کنید

        public HomeController(List<Member> members)
        {
            this.members = members;
        }


        // Action برای نمایش لیست اعضا
        public ActionResult Index()
        {
            return View(members);
        }

        // Action برای نمایش جزئیات یک عضو
        public ActionResult Details(int id)
        {
            var member = members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // Action برای نمایش فرم ثبت نام
        public ActionResult Create()
        {
            return View();
        }

        // Action برای ذخیره عضو جدید
        [HttpPost]
        public ActionResult Create(Member member)
        {
            // اضافه کردن عضو جدید به پایگاه داده
            members.Add(member);
            return RedirectToAction("Index");
        }

        // Action برای نمایش فرم ویرایش
        public ActionResult Edit(int id)
        {
            var member = members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // Action برای ذخیره تغییرات
        [HttpPost]
        public ActionResult Edit(Member member)
        {
            // ذخیره تغییرات در پایگاه داده
            // ...

            return RedirectToAction("Index");
        }

        // Action برای حذف عضو
        public ActionResult Delete(int id)
        {
            var member = members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // حذف عضو از پایگاه داده
            // ...

            return RedirectToAction("Index");
        }

        // Action برای جستجو
        public ActionResult Search(string searchString)
        {
            var searchResult = members.Where(m => m.FirstName.Contains(searchString) || m.LastName.Contains(searchString));
            return View(searchResult);
        }
    }

}
