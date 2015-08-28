using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SGAL.Model.Logic.SGAL;
using SGAL.Servicos.Logic;
using SGAL.Util;

namespace SGAL.MVC.Controllers
{
    public class FederacaoController : BaseController
    {
        public ActionResult Index()
        {

            return View(new BaseService<federacao>().ObterTodos());
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Detalhar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            return View(new BaseService<federacao>().Obter(id.Value));
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind(Include = "descricao")] federacao federacao)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                federacao.datainclusao = federacao.dataalteracao = DateTime.Now;

                var servico = new BaseService<federacao>();
                servico.Incluir(federacao);
                servico.Salvar();
                return RedirectToAction("Index");
            }

            return View(federacao);
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            federacao federacao = new BaseService<federacao>().Obter(id.Value);
            
            if (federacao == null)
                return HttpNotFound();
            
            return View(federacao);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "federacaoid,descricao")] federacao federacao)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                federacao.dataalteracao = DateTime.Now;
                var servico = new BaseService<federacao>();
                servico.Alterar(federacao);
                servico.Salvar();
                return RedirectToAction("Index");
            }
            return View(federacao);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            federacao federacao = new BaseService<federacao>().Obter(id.Value);

            if (federacao == null)
                return HttpNotFound();
            
            return View(federacao);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarExclusao(int id)
        {
            var servico = new BaseService<federacao>();
            servico.Excluir(ent => ent.federacaoid == id);
            servico.Salvar();
            return RedirectToAction("Index");
        }

        public JsonResult Listagem()
        {
            var listagem = new BaseService<federacao>().ObterTodos();
            return Json(listagem.ToList().Select(ent => new
            {
                ent.descricao,
                datainclusao = ent.datainclusao.Value.DateTimeToStr(),
                dataalteracao = ent.dataalteracao.Value.DateTimeToStr(),
                botoes = GerarBotoes(ent.federacaoid, this.ControllerContext.RouteData.Values["controller"].ToString())
            }), JsonRequestBehavior.AllowGet);
        }
    }
}
