﻿using BossBank.Data.Models;
using BossBank.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BossBank.Web.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteService ServClient { get; set; }
        public ClienteController()
        {
            ServClient = new ClienteService();
        }
        
        public IActionResult Index()
        {
            List<Cliente> listCliente = ServClient.RepCliente.GetAll();
            return View(listCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente objCliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ServClient.RepCliente.Add(objCliente);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente thisCliente = ServClient.RepCliente.GetPk(id);
            return View(thisCliente);
        }
    }
}
