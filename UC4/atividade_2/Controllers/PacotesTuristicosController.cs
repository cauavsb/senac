using Microsoft.AspNetCore.Mvc;

namespace atividade_2.Controllers
{
    public class PacotesTuristicosController : Controller
    {
        public IActionResult Cadastro()
        {
            //if(HttpContext.Session.GetInt32("id") == null) {
                //return RedirectToAction("Login", "Home");
            //}
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(PacotesTuristicos pc)
        {
            //if(HttpContext.Session.GetInt32("id") == null) {
                //return RedirectToAction("Login", "Home");
            //}

            //pc.usuario = HttpContext.Session.GetInt32("id");

            PacotesTuristicosRepository pacote = new PacotesTuristicosRepository();
            pacote.inserir(pc);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View("Cadastro");
        }

        public IActionResult Editar(int id)
        {
            PacotesTuristicosRepository pacote = new PacotesTuristicosRepository();
            return View(pacote.buscarPorId(id));
        }
        [HttpPost]
        public IActionResult Editar(PacotesTuristicos pc)
        {
            PacotesTuristicosRepository pacote = new PacotesTuristicosRepository();
            pacote.editar(pc);
            return RedirectToAction("Listagem");
        }
        
        public IActionResult Deletar(int id)
        {
            PacotesTuristicosRepository pacote = new PacotesTuristicosRepository();
            pacote.deletar(id);
            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem()
        {
            PacotesTuristicosRepository pacote = new PacotesTuristicosRepository();
            return View(pacote.listar());
        }
    }
}