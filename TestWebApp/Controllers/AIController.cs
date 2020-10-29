using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PermissionParts;
using RolesToPermission;

namespace TestWebApp.Controllers
{
    public class AIController : Controller
    {
        [HasPermission(Permissions.AI)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
