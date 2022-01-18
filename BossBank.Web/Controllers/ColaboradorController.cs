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
    }
}
