using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV2_ORIG.Models;

namespace ATV2_ORIG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }
        public IActionResult Servicos()
        {
            return View();
        }
        public IActionResult QuemSomos()
        {
            return View();
        }
        public IActionResult Confirmacao(Dados cliente)
        {
           List<Dados> dados = CadastroCliente.Listar();
           CadastroCliente.Incluir(cliente);
           return View(dados);

        }
    }
}
