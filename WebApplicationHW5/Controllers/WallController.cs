using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW5.DataAccess;

namespace WebApplicationHW5.Controllers
{
    public class WallController : Controller
    {
        // GET: Wall
        public ActionResult Index()
        {
            using (var context = new RecordContext())
            {
                var wall = context.Wall.ToList();
                ViewBag.Wall = wall;
               
            }

            return View();

        }
       
        // GET: Wall/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Wall/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wall/Create
        [HttpPost]
        public ActionResult Create(string nick,string text)
        {
            try
            {
                // TODO: Add insert logic here
                using (var context = new RecordContext())
                {

                    context.Wall.Add(new Models.Record
                    {
                        Nickname = nick,
                        Text = text
                    });

                    context.SaveChanges();

                    var wall = context.Wall.ToList();
                    ViewBag.Wall = wall;
                }

    
                return View("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Wall/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wall/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wall/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wall/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
