using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermissionParts;
using RolesToPermission;

namespace TestWebApp.Controllers
{
    [HasPermission(Permissions.ADM)]
    public class ColorController : Controller
    {
        private static readonly List<string> MyData = new List<string>{ "Red", "Blue", "Green", "Yellow"};

        [HasPermission(Permissions.PR1_READ)]
        public ActionResult Index()
        {
            return View(MyData);
        }

        [HasPermission(Permissions.PR1_CREATE)]
        public ActionResult Create()
        {
            return View();
        }

        [HasPermission(Permissions.PR1_CREATE)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                MyData.Add(collection["Data"]);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HasPermission(Permissions.PR1_DELETE)]
        public ActionResult Delete(int id)
        {
            MyData.RemoveAt(id);
            return RedirectToAction(nameof(Index));
        }
    }
}