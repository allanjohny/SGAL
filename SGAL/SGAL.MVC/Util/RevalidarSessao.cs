//using System.Web.Mvc;
//using SGAL.MVC.Models;

//namespace SGAL.MVC.Util
//{
//    public class RevalidarSessao : ActionFilterAttribute
//    {
//        public override void OnActionExecuting(ActionExecutingContext filterContext)
//        {
//            //Verifica se a sessão já foi iniciada
//            if (SessaoUsuario.Sessao == null)
//                filterContext.HttpContext.Response.Redirect("~/Account/LogIn");

//            //Verificação de Login
//            else if (SessaoUsuario.Sessao.usuarioid == 0)
//                filterContext.HttpContext.Response.Redirect("~/Account/LogIn");
//        }
//    }
//}