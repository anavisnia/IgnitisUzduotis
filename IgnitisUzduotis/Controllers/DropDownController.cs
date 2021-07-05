using IgnitisUzduotis.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace IgnitisUzduotis.Controllers
{
    public class DropDownController : Controller
    {
        private readonly DataContext _context;

        public DropDownController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index()
        {
            //ViewBag.Questions = _context.Questions.ToList();
            ViewData["Questions"] = _context.Questions.ToList();
            ViewBag.DropDowns = _context.DropDowns.ToList();
            return View();
        }


    }
}
