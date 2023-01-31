using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Linq;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DbEmpleadoContext context;
        public EmpleadoController(DbEmpleadoContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var empleado = context.Empleados.ToList();
            return View(empleado);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();

            return View("Register", empleado);
        }

        //post: Opera/Create
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Empleado empleado = TraerUna(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", empleado);
            }
        }

        private Empleado TraerUna(int id)
        {
            return context.Empleados.Find(id);
        }
        
    }
}

