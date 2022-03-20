using BossBank.Data.Entities;
using BossBank.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BossBank.Web.Controllers
{
    public class ContaCorrenteController : Controller
    {
        private readonly IRepositoryCliente _cliente;
        private readonly IRepositoryColaborador _colaborador;
        private readonly IRepositoryContaCorrente _contaCorrente;

        public ContaCorrenteController(IRepositoryCliente cliente, IRepositoryColaborador colaborador, IRepositoryContaCorrente contaCorrente)
        {
            _cliente = cliente;
            _colaborador = colaborador;
            _contaCorrente = contaCorrente;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContaCorrente contaCorrente)
        {
            return RedirectToAction("Index");
        }

        public IActionResult SearchCliente(string term)
        {
            var list = _cliente.GetAll();
            var listName = list.Select(var => var.Nome).ToList();
            var filtro = listName.Where(p => p.Contains(term, StringComparison.CurrentCultureIgnoreCase));

            return Json(filtro);
        }

        public IActionResult SearchColab(string term)
        {
            var list = _colaborador.GetAll();
            var listColab = list.Select(var => var.ColaboradorNome).ToList();
            var filtro = listColab.Where(p => p.Contains(term, StringComparison.CurrentCultureIgnoreCase));

            return Json(filtro);
        }
    }
}
