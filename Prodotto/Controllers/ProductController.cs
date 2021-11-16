using Microsoft.AspNetCore.Mvc;
using Prodotto.EF.Data;
using Prodotto.EF.Entity;
using Prodotto.Models;
using Prodotto.Utile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodotto.Controllers
{
    public class ProductController : Controller
    {
        private NORTHWINDContext _context;
        

        public ProductController(NORTHWINDContext context)
        {
            _context = context;
        }

        public IActionResult Insert(ProductViewModel element)
        {
             if (_context.Products.Count() != 0)
            {
                element.ProductId = _context.Products.Max(x => x.ProductId) + 1;
            }
       else
            {
                element.ProductId = 1;
            }
            _context.Products.Add(element.ProjectToDbModel());// aggiunge il prodotto element nella tab products
            _context.SaveChanges();
            return View();
        }
      

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult Update(ProductViewModel element)
        {
            _context.Products.Update(element.ProjectFromViewModel()); //utilizzo metodo aggiorna del dbcontext
            _context.SaveChanges(); // salvo l'aggiornamento 
            return View();
        }

        public IActionResult Delete(ProductViewModel element)
        {
            _context.Remove(element);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Index()
        {
            List<ProductViewModel> lista = _context.Products.AsEnumerable().ProjectToViewModel().ToList();
            return View(lista);


        }
    }
}

         
