using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebGameNetCore.Models;

namespace WebGameNetCore.Controllers
{
    public class GameController : Controller
    {
        private ApDbContext _context;

        public GameController(ApDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Units"] = _context.Units.ToArray();
            return View();
        }

        public IActionResult UnitInfo(int id)
        {
            ViewData["Unit"] = _context.Units.FirstOrDefault(unit => unit.Id == id);
            return View();
        }

        public IActionResult TakeDamage(int id, int damage)
        {
            Unit unit = _context.Units.FirstOrDefault(unit => unit.Id == id);

            if (unit != null)
            {
                unit.ApplyDamage(damage);
                _context.Update(unit);
                _context.SaveChanges();

                return Redirect($"/Game/UnitInfo?id={id}");
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
