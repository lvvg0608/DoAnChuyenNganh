using MayMeiAccessory.Controllers;
using MayMeiAccessory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Linq;

namespace MayMeiAccessory.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly dbMayMeiStoreContext _context;
        public HomeController(dbMayMeiStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int totalMoney = _context.Orders.Sum(x => x.TotalMoney);           
            ViewBag.TotalMoney = totalMoney;

            int cus = _context.Customers.Count();
            ViewBag.Cus = cus;

            int order = _context.Orders.Count();
            ViewBag.Order = order;
            return View();
        }
    }
}
