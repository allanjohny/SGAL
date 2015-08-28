using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SGAL.Model.Logic.SGAL;
using SGAL.Servicos.Logic;
using SGAL.Util;

namespace SGAL.MVC.Controllers
{
    public class AdeptoController : BaseController
    {
        public ActionResult Index()
        {
            return View(new BaseService<adepto>().ObterTodos());
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Detalhar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            return View(new BaseService<adepto>().Obter(id.Value));
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind(Include = "nome,datanascimento,email,telefoneresidencial,telefonecomercial,telefonecelular,dataprimeiravez")] adepto adepto)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                adepto.datainclusao = adepto.dataalteracao = DateTime.Now;
                //Tratamento antes de incluir
                adepto.telefoneresidencial = adepto.telefoneresidencial.RemoveMascara();
                adepto.telefonecomercial = adepto.telefonecomercial.RemoveMascara();
                adepto.telefonecelular = adepto.telefonecelular.RemoveMascara();
                
                var servico = new BaseService<adepto>();
                servico.Incluir(adepto);
                servico.Salvar();
                return RedirectToAction("Index");
            }
            return View(adepto);
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            adepto adepto = new BaseService<adepto>().Obter(id.Value);

            if (adepto == null)
                return HttpNotFound();

            return View(adepto);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "adeptoid,nome,datanascimento,email,telefoneresidencial,telefonecomercial,telefonecelular,dataprimeiravez,datainclusao")] adepto adepto)
        {
            if (ModelState.IsValid)
            {
                //Campo atribuído automaticamente
                adepto.dataalteracao = DateTime.Now;
                var servico = new BaseService<adepto>();
                servico.Alterar(adepto);
                servico.Salvar();
                return RedirectToAction("Index");
            }
            return View(adepto);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            adepto adepto = new BaseService<adepto>().Obter(id.Value);

            if (adepto == null)
                return HttpNotFound();

            return View(adepto);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarExclusao(int id)
        {
            var servico = new BaseService<adepto>();
            servico.Excluir(ent => ent.adeptoid == id);
            servico.Salvar();
            return RedirectToAction("Index");
        }

        public JsonResult Listagem()
        {
            var listagem = new BaseService<adepto>().ObterTodos();
            return Json(listagem.ToList().Select(ent => new
            {
                ent.nome,
                datanascimento = ent.datanascimento.HasValue ? ent.datanascimento.Value.ToShortDateString() : "",
                ent.email,
                telefonecelular = ent.telefonecelular.FormataTelefone(),
                botoes = GerarBotoes(ent.adeptoid, this.ControllerContext.RouteData.Values["controller"].ToString())
            }), JsonRequestBehavior.AllowGet);
        }

    }
}
