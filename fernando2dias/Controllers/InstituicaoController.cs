using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fernando2dias.Controllers
{
    public class InstituicaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}