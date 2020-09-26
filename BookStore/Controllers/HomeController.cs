using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller //Controller'ı sonradan ekliyoruz. Bu şekilde controller oluyor.
    {
        public string Index()
        {
            return "index sayfası";
        }
    }
}
