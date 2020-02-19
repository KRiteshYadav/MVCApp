
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FriendApp.Models;
using Microsoft.AspNetCore.Http;

namespace FriendApp.Controllers
{
    [Route("Friend")]
    public class FriendController : Controller
    {
        private readonly FriendDataContext _db;
        public FriendController(FriendDataContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        [Route("index")]
        public IActionResult Index()
        {
            var friend_details = _db.Friends.Take(5).ToArray();
            return View(friend_details);
        }
        [HttpGet, Route("insert")]
        public IActionResult Insert()
        {

            return View();
        }
        [HttpPost, Route("insert")]
        public IActionResult Insert(Friend friend_details)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Friends.Add(friend_details);
            _db.SaveChanges();
            return View();
        }




        [HttpGet , Route("update")]
        public IActionResult Update()
        {
            return View();
        }


        [HttpPost, Route("update")]
        public IActionResult Update(IFormCollection form)
        {
            var id = int.Parse(Request.Form["FriendId"]);
            var update = _db.Friends.SingleOrDefault(x => x.FriendId == id);
            if (update!=null){
                update.FriendName = Request.Form["FriendName"];
                update.Place = Request.Form["Place"];
                _db.SaveChanges();

            }
            return View();

        }
        [HttpGet, Route("delete")]
        public IActionResult Delete()
        {
            return View();
        }
        
        [HttpPost , Route("delete")]
        public IActionResult Delete(Friend friend)
        {
            var id = int.Parse(Request.Form["FriendId"]);
            var delete = _db.Friends.SingleOrDefault(x => x.FriendId == id);
            if (delete!=null){
                _db.Friends.Remove(delete);
                _db.SaveChanges();
                
            }
            return View();
        }



    }
}