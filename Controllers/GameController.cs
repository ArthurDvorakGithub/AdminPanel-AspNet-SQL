using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGameNetCore.Models;

namespace WebGameNetCore.Controllers
{
    public class GameController : Controller
    {
        Unit[] units;

        public GameController()
        {
            units = new Unit[] 
                { 
                new Unit("Pepa",50, "https://pbs.twimg.com/profile_images/804955993067098113/JWV44Cb5.jpg"), 
                new Unit("George",67, "https://i.pinimg.com/originals/34/65/b0/3465b041c0d13bb58b494437441a2473.png"), 
                new Unit("Papa Svin", 49, "https://i.pinimg.com/originals/bb/34/44/bb34446c83c62df816220303dee7cb90.png"),
                new Unit("Mama",50, "https://www.vokrug.tv/pic/person/c/6/a/1/c6a1c7d4a59b444b7f458646564ce815.jpeg"),
                new Unit("Mama",67, "https://www.vokrug.tv/pic/person/c/6/a/1/c6a1c7d4a59b444b7f458646564ce815.jpeg"),
                new Unit("Mama Svin", 49, "https://www.vokrug.tv/pic/person/c/6/a/1/c6a1c7d4a59b444b7f458646564ce815.jpeg")
                };
        }
        public IActionResult Index()
        {
            ViewData["Units"] = units;
            return View();
        }
    }
}
