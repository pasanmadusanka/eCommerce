using eCommerce.Contracts.Repository;
using eCommerce.DAL.Data;
using eCommerce.DAL.Repository;
using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<Customer> customers;
        IRepositoryBase<Product> products;
        public HomeController(IRepositoryBase<Customer> customers, IRepositoryBase<Product> products)
        {
            this.customers = customers;
            this.products = products;
        }
        public ActionResult Index()
        {
            var productList = products.GetAll();
            return View(productList);
        }

        public ActionResult Details(int id)
        {
            var productDet = products.GetById(id);
            return View(productDet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}