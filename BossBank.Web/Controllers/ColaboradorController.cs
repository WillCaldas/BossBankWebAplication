using BossBank.Data.Context;
using BossBank.Data.Entities;
using BossBank.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BossBank.Web.Controllers
{
    public class ColaboradorController : Controller
    {
        private ColaboradorService ServColab { get; set; }

        public ColaboradorController(BossBankDbContext context)
        {
            ServColab = new ColaboradorService(context);
        }

        public IActionResult Index()
        {
            List<Colaborador> listCliente = ServColab.RepColab.GetAll();
            return View(listCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Colaborador objColab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ServColab.RepColab.Add(objColab);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Colaborador thisColab = ServColab.RepColab.GetPk(id);
            return View(thisColab);
        }

        public IActionResult Edit(int id)
        {
            Colaborador thisColab = ServColab.RepColab.GetPk(id);
            return View(thisColab);
        }

        [HttpPost]
        public IActionResult Edit(Colaborador Model)
        {
            Colaborador thisColab = ServColab.RepColab.Update(Model);
            int id = thisColab.ColaboradorId;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            ServColab.RepColab.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
