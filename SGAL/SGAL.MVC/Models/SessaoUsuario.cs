//using System.Web;
//using SGE.Model.Logic.SGE;
//using SGE.Service.Logic.SGE;

//namespace SGAL.MVC.Models
//{
//    public class SessaoUsuario
//    {

//        public static usuario Sessao
//        {
//            get
//            {
//                if (HttpContext.Current.Session["Usuario"] == null)
//                {
//                    HttpContext.Current.Session["Usuario"] = new usuario();
//                    if (HttpContext.Current.User.Identity.IsAuthenticated)
//                    {
//                        DefinirUsuarioTemp(HttpContext.Current.User.Identity.Name);
//                    }
//                }
//                return (usuario)HttpContext.Current.Session["Usuario"];
//            }
//        }

//        public static void DefinirUsuarioTemp(string NomeLogin)
//        {
//            usuario usuario = new usuarioService().ObterPorLogin(NomeLogin);
//            Sessao.usuarioid = usuario.usuarioid;
//            Sessao.login = usuario.login;
//            Sessao.loginad = usuario.loginad;
//            Sessao.senha = usuario.senha;
//            Sessao.nome = usuario.nome;
//            Sessao.email = usuario.email;
//            Sessao.empresaid = usuario.empresaid;
//            Sessao.situacao = usuario.situacao;
//            Sessao.pessoaid = usuario.pessoaid;
//            Sessao.setorid = usuario.setorid;
//        }

//        public static void SessaoLimpar()
//        {
//            HttpContext.Current.Session["Usuario"] = null;
//        }
//    }
//}