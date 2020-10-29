// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermissionParts;
using RolesToPermission;

namespace TestWebApp.Controllers
{
    public class ColorRoleController : Controller
    {
        private static readonly List<string> MyData = new List<string> { "A", "B", "G", "Y" };

        [HasPermission(Permissions.UserRead)]
        public ActionResult Index()
        {
            return View(MyData);
        }

        //[Authorize(Roles = "Manager")]
        [HasPermission(Permissions.UserChange)]
        public ActionResult Create()
        {
            return View();
        }

        //[Authorize(Roles = "Manager")]
        //http://192.168.0.103:5002/ColorRole
        [HasPermission(Permissions.UserChange)]
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

        //[Authorize(Roles = "Manager")]
        [HasPermission(Permissions.UserChange)]
        public ActionResult Delete(int id)
        {
            MyData.RemoveAt(id);
            return RedirectToAction(nameof(Index));
        }

    }
}