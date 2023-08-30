using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using atividade_2.Models;

namespace atividade_2.Controllers
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

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            UsuarioRepository u = new UsuarioRepository();
            Usuario usuario_encontrado = u.verificaLogin(user);

            if(usuario_encontrado == null) {
                ViewBag.Mensagem = "Falha no login! Por favor, tente novamente.";
                return View();
            }
            else {
                HttpContext.Session.SetInt32("id", usuario_encontrado.id);                
                HttpContext.Session.SetString("nome", usuario_encontrado.nome);

                return RedirectToAction("Listagem", "PacotesTuristicos");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult Privacy()
        {
            PacotesTuristicosRepository pc = new PacotesTuristicosRepository();
            pc.testeConexao();
            return View();
        }

        public IActionResult Listar()
        {
            PacotesTuristicosRepository pc = new PacotesTuristicosRepository();
            return View(pc.listar());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
