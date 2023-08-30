using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace atividade_4.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Cadastro()
        {
            if(HttpContext.Session.GetInt32("id") == null) {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Produto p)
        {
            if(HttpContext.Session.GetInt32("id") == null) {
                return RedirectToAction("Login", "Home");
            }

            //p.id = HttpContext.Session.GetInt32("id");

            ProdutoRepository produto = new ProdutoRepository();
            produto.inserir(p);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View("Cadastro");
        }

        public IActionResult Editar(int id)
        {
            ProdutoRepository produto = new ProdutoRepository();
            return View(produto.buscarPorId(id));
        }
        [HttpPost]
        public IActionResult Editar(Produto p)
        {
            ProdutoRepository produto = new ProdutoRepository();
            produto.editar(p);
            return RedirectToAction("Listagem");
        }
        
        public IActionResult Deletar(int id)
        {
            ProdutoRepository produto = new ProdutoRepository();
            produto.deletar(id);
            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem()
        {
            ProdutoRepository produto = new ProdutoRepository();
            return View(produto.listar());
        }
    }
}