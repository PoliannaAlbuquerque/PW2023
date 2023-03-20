using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeLevi_Polianna1.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Redirecionamento()
        {
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Aluno()
        {
            ViewBag.Mensagem = "Os melhores alunos são aqueles que estudam mais!";
            return View();
           
        }
        public ActionResult RedirecionamentoEstudo()
        {
            return RedirectToAction("Aluno", "Aula");

        }
        public ActionResult RedirecionamentoGoogle()
        { 
         return Redirect("https://www.google.com/");
        }
    }
}