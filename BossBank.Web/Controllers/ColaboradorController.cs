using Microsoft.AspNetCore.Mvc;
using BossBank.Data.Services;
using BossBank.Data.Models;
using System.Collections.Generic;

namespace BossBank.Web.Controllers
{
    public class ColaboradorController : Controller
    {
        private ColaboradorService ServColaborador { get; set; }

        public ColaboradorController()
        {
            ServColaborador = new ColaboradorService();
        }

        public IActionResult Index()
        {
            List<Colaborador> listColaborador = ServColaborador.RepColaborador.GetAll();
            return View(listColaborador);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Colaborador ObjColaborador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ServColaborador.RepColaborador.Add(ObjColaborador);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Colaborador thisColab = ServColaborador.RepColaborador.GetPk(id);
            return View(thisColab);
        }

        [HttpPost]
        public IActionResult Edit(Colaborador Model)
        {
            Colaborador thisColab = ServColaborador.RepColaborador.Update(Model);
            int id = thisColab.IdColab;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Details(int id)
        {
            Colaborador thisColab = ServColaborador.RepColaborador.GetPk(id);
            return View(thisColab);
        }


        public IActionResult Delete(int id)
        {
            ServColaborador.RepColaborador.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
