using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SGAL.Model.Logic.SGAL;
using SGAL.Servicos.Logic;
using SGAL.Util;

namespace SGAL.MVC.Controllers
{
    public class RegionalController : BaseController
    {
        public ActionResult Index()
        {

            return View(new BaseService<regional>().ObterTodos());
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Detalhar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            return View(new BaseService<regional>().Obter(id.Value));
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind(Include = "descricao, dataabertura")] regional regional)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                regional.datainclusao = regional.dataalteracao = DateTime.Now;

                var servico = new BaseService<regional>();
                servico.Incluir(regional);
                servico.Salvar();
                return RedirectToAction("Index");
            }

            return View(regional);
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            regional regional = new BaseService<regional>().Obter(id.Value);
            
            if (regional == null)
                return HttpNotFound();
            
            return View(regional);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "regionalid,descricao,dataabertura,datainclusao")] regional regional)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                regional.dataalteracao = DateTime.Now;
                var servico = new BaseService<regional>();
                servico.Alterar(regional);
                servico.Salvar();
                return RedirectToAction("Index");
            }
            return View(regional);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            regional regional = new BaseService<regional>().Obter(id.Value);

            if (regional == null)
                return HttpNotFound();
            
            return View(regional);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarExclusao(int id)
        {
            var servico = new BaseService<regional>();
            servico.Excluir(ent => ent.regionalid == id);
            servico.Salvar();
            return RedirectToAction("Index");
        }

        public JsonResult Listagem()
        {
            var listagem = new BaseService<regional>().ObterTodos();
            return Json(listagem.ToList().Select(ent => new
            {
                ent.descricao,
                datainclusao = ent.datainclusao.Value.DateTimeToStr(),
                dataalteracao = ent.dataalteracao.Value.DateTimeToStr(),
                botoes = GerarBotoes(ent.regionalid, this.ControllerContext.RouteData.Values["controller"].ToString())
            }), JsonRequestBehavior.AllowGet);
        }
    }
}
