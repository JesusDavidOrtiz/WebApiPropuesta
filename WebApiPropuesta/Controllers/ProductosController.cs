using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPropuesta.Utilidades;
using WebApiPropuesta.DTOs;
using WebApiPropuesta.Models;
using System.Linq;
using PagedList;

namespace WebApiPropuesta.Controllers
{
    
    public class ProductosController : Controller
    {
        private readonly ApiDbContext _apiDbContext;


        public ProductosController (ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;

        }
        //Http Get Index
         public IActionResult Index(int? pageSize, int? page)
        {
            IEnumerable<Productos> Listproductos = _apiDbContext.Productos;

            pageSize = (pageSize ?? 3);
            page = (page ?? 1);
            ViewBag.PageSize = pageSize;

            return View(Listproductos.ToPagedList(page.Value, pageSize.Value));
        }
        //Http Get Create
        public IActionResult Crear()
        {
            return View();
        }
      

        [HttpPost]
        public IActionResult Crear(Productos productos)
        {

            if (ModelState.IsValid)
            {                
                _apiDbContext.Add(productos);

                _apiDbContext.SaveChanges();

                TempData["mensaje"] = "El producto se agrego correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }
        //Http Get Edit
    
        public IActionResult Modificar(int? Codigo)
        {
           if(Codigo == null || Codigo == 0)
            {
                return NotFound();
            }

           //Optener Producto

           var productos = _apiDbContext.Productos.Find(Codigo);
            if(productos == null)
            {
                return NotFound();
            }

           return View(productos);

        }

        [HttpPost]
        public IActionResult Modificar(Productos productos)
        {

            if (ModelState.IsValid)
            {
                _apiDbContext.Update(productos);

                _apiDbContext.SaveChanges();

                TempData["mensaje"] = "El producto se modifico correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? Codigo)
        {
            if (Codigo == null || Codigo == 0)
            {
                return NotFound();
            }

            //Optener Producto

            var productos = _apiDbContext.Productos.Find(Codigo);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);

        }

    }
}
