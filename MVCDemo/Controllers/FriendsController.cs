using Microsoft.AspNetCore.Mvc;
using MVCDemo.FriendsService;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<Friend> friends = FriendServices.GetAll();
            return View(friends);
        }

        public IActionResult Details(int id)
        {
            Friend f = FriendServices.Get(id);
            return View(f);
        }
        public IActionResult List()
        {
            List<Friend> friends = FriendServices.GetAll();
            return View(friends);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend f)
        {
            FriendServices.Add(f);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            Friend f = FriendServices.Get(Id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Friend f)
        {
            FriendServices.Delete(f.FriendID);
            return RedirectToAction("List");
        }
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string Fname, string Fplace)
        {
            Friend f = new Friend { FriendID = id, FName = Fname, FPlace = Fplace };
            FriendServices.Update(f);
            return RedirectToAction("List");
        }
    }
}
