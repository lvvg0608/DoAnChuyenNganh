using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MayMeiAccessory.Models;

namespace MayMeiAccessory.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly dbMayMeiStoreContext _context;

        public SearchController(dbMayMeiStoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking()
                                  .Include(a => a.Cat)
                                  .Where(x => x.ProductName.Contains(keyword))
                                  .OrderByDescending(x => x.ProductName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }

        [HttpPost]
        public IActionResult FindCustomer(string keyword)
        {
            List<Customer> ls = new List<Customer>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListCustomersSearchPartial", null);
            }
            ls = _context.Customers
                                  .Where(x => x.FullName.Contains(keyword))
                                  .OrderByDescending(x => x.FullName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListCustomersSearchPartial", null);
            }
            else
            {
                return PartialView("ListCustomersSearchPartial", ls);
            }
        }
        [HttpPost]
        public IActionResult FindOrder(string keyword)
        {
            List<Order> ls = new List<Order>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListOrdersSearchPartial", null);
            }
            ls = _context.Orders.AsNoTracking()
                                  .Include(a =>a.Customer).Include(v =>v.TransactStatus)
                                  .Where(x => x.Customer.FullName.Contains(keyword))
                                  .OrderBy(x => x.Customer.FullName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListOrdersSearchPartial", null);
            }
            else
            {
                return PartialView("ListOrdersSearchPartial", ls);
            }
        }
        [HttpPost]
        public IActionResult FindAdminAccount(string keyword)
        {
            List<Account> ls = new List<Account>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListAdminAccountsSearchPartial", null);
            }
            ls = _context.Accounts.AsNoTracking()
                                  .Include(a =>a.Role)
                                  .Where(x => x.FullName.Contains(keyword))
                                  .OrderByDescending(x => x.FullName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListAdminAccountsSearchPartial", null);
            }
            else
            {
                return PartialView("ListAdminAccountsSearchPartial", ls);
            }
        }
        [HttpPost]
        public IActionResult FindAdminCategory(string keyword)
        {
            List<Category> ls = new List<Category>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListAdminCategoriesSearchPartial", null);
            }
            ls = _context.Categories.AsNoTracking()
                                  .Where(x => x.CatName.Contains(keyword))
                                  .OrderByDescending(x => x.CatName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListAdminCategoriesSearchPartial", null);
            }
            else
            {
                return PartialView("ListAdminCategoriesSearchPartial", ls);
            }
        }
    }
}
