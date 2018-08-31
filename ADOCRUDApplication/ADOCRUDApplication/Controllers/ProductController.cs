using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace ADOCRUDApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            DBOperations dBOperations = new DBOperations();
            return View(dBOperations.GetProducts());
        }
    }
}