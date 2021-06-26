using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Krasinski_Store.Areas.Admin.Controllers
{
    public class FrequencyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
