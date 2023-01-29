using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using MayMeiAccessory.Models;

namespace MayMeiAccessory.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbMayMeiStoreContext _context;
        public ProductController(dbMayMeiStoreContext context)
        {
            _context = context;
        }
        /*[Route("shop.html", Name = ("ShopProduct"))]*/
        /*public IActionResult Index(int? page)
        {

            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 9;
                var lsTinDangs = _context.Products
                    .Where(x =>x.Active==true)
                    .Where(x =>x.UnitsInStock>0)
                    .AsNoTracking()
                    .OrderBy(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsTinDangs, pageNumber, pageSize);

                ViewBag.CurrentPage = pageNumber;
                ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }*/

        public IActionResult Index(int page = 1, int CatID = 0, string search="")
        {
            var pageNumber = page;
            var pageSize = 9;

            List<Product> lsProducts = new List<Product>();
            if (CatID != 0)
            {
                lsProducts = _context.Products
                .AsNoTracking()
                .Where(x => x.CatId == CatID && x.Active == true && x.UnitsInStock > 0)
                .Include(x => x.Cat)
                .OrderBy(x => x.ProductId).ToList();
            }

            else if(!String.IsNullOrEmpty(search))
            {
                lsProducts = _context.Products
                .AsNoTracking()
                .Where(x => x.Active == true && x.UnitsInStock > 0 && x.ProductName.Contains(search))
                .Include(x => x.Cat)
                .OrderBy(x => x.ProductId).ToList();
            }

            else
            {
                lsProducts = _context.Products
                .AsNoTracking()
                .Where(x => x.Active == true && x.UnitsInStock > 0)
                .Include(x => x.Cat)
                .OrderBy(x => x.ProductId).ToList();
                
            }



            PagedList<Product> models = new PagedList<Product>(lsProducts.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentCateID = CatID;

            ViewBag.CurrentPage = pageNumber;

            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");

            return View(models);
        }



        public IActionResult Filtter(int CatID = 0)
        {
            var url = $"/Product?CatID={CatID}";
            if (CatID == 0)
            {
                url = $"/Product";
            }
            return Json(new { status = "success", redirectUrl = url });
        }
        [Route("danhmuc/{Alias}", Name = ("ListProduct"))]
        public IActionResult List(string Alias, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);

                var lsTinDangs = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == danhmuc.CatId)
                    .OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsTinDangs, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

        [Route("/{Alias}-{id}.html", Name = ("ProductDetails"))]
        public IActionResult Details(int id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                    .Take(4)
                    .OrderByDescending(x => x.DateCreated)
                    .ToList();
                ViewBag.SanPham = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

    }
}
