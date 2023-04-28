using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atividade_3.Models;

namespace atividade_3.Controllers
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

        [HttpPost]
        
        public IActionResult Agendamento(Cadastro agen)
        {
            Dados.agendamentoAtual.incluir(agen);
            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem()
        {
            List<Cadastro> agen = Dados.agendamentoAtual.ListarAgendamentos();
            return View(agen);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
