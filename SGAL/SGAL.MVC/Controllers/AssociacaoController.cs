using System;
using System.Net;
using System.Web.Mvc;
using SGAL.Model.Logic.SGAL;
using SGAL.MVC.Util;
using SGAL.Servicos.Logic;

namespace SGAL.MVC.Controllers
{
    public class AssociacaoController : Controller
    {
        public ActionResult Index()
        {

            return View(new BaseService<associacao>().ObterTodos());
        }

        public ActionResult Criar()
        {
            CriarViewBags();
            return View();
        }

        public ActionResult Detalhar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            return View(new BaseService<associacao>().Obter(id.Value));
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind(Include = "descricao, dataabertura, regionalid, federacaoid")] associacao associacao)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                associacao.datainclusao = associacao.dataalteracao = DateTime.Now;

                var servico = new BaseService<associacao>();
                servico.Incluir(associacao);
                servico.Salvar();
                return RedirectToAction("Index");
            }

            return View(associacao);
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            associacao associacao = new BaseService<associacao>().Obter(id.Value);
            
            if (associacao == null)
                return HttpNotFound();
            
            CriarViewBags();
            return View(associacao);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "associacaoid, descricao, dataabertura, datainclusao, regionalid, federacaoid")] associacao associacao)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                associacao.dataalteracao = DateTime.Now;
                var servico = new BaseService<associacao>();
                servico.Alterar(associacao);
                servico.Salvar();
                return RedirectToAction("Index");
            }
            return View(associacao);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            associacao associacao = new BaseService<associacao>().Obter(id.Value);

            if (associacao == null)
                return HttpNotFound();
            
            return View(associacao);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarExclusao(int id)
        {
            var servico = new BaseService<associacao>();
            servico.Excluir(ent => ent.associacaoid == id);
            servico.Salvar();
            return RedirectToAction("Index");
        }

        private void CriarViewBags()
        {
            ViewBag.federacoes = new BaseService<federacao>().ObterTodos().ToSelectList(ent => ent.federacaoid, ent => ent.descricao, "Selecione..");
            ViewBag.regionais = new BaseService<regional>().ObterVarios(ent => ent.datafechamento == null).ToSelectList(ent => ent.regionalid, ent => ent.descricao, "Selecione..");
        }
    }
}
