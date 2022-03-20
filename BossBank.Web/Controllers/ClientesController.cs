using BossBank.Data.Context;
using BossBank.Data.Entities;
using BossBank.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BossBank.Web.Controllers
{
    public class ClientesController : Controller
    {
        private ClienteService ServCliente { get; set; }

        public ClientesController(BossBankDbContext context)
        {
            ServCliente = new ClienteService(context);
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

        public IActionResult Edit(int id)
        {
            Cliente thisCliente = ServCliente.RepCliente.GetPk(id);
            return View(thisCliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente Model)
        {
            Cliente thisCliente = ServCliente.RepCliente.Update(Model);
            int id = thisCliente.ClienteID;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            ServCliente.RepCliente.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
