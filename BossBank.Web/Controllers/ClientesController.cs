using BossBank.Data.Entities;
using BossBank.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BossBank.Web.Controllers
{
    public class ClientesController : Controller
    {
        private ClienteService ServCliente { get; set; }

        public ClientesController()
        {
            ServCliente = new ClienteService();
        }

        public IActionResult Index()
        {
            List<Cliente> listCliente = ServCliente.RepCliente.GetAll();
            return View(listCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente objCLiente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ServCliente.RepCliente.Add(objCLiente);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente thisCliente = ServCliente.RepCliente.GetPk(id);
            return View(thisCliente);
        }
    }
}
