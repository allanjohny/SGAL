using System.Web.Mvc;

namespace SGAL.MVC.Controllers
{
    public class BaseController : Controller
    {
        public string GerarBotoes(int id, string controller)
        {
            string retorno =
                new MvcHtmlString(@"<a class='btn btn-sm btn-primary' href='/" + controller + "/Editar/" + id +
                                  "'><i class='glyphicon glyphicon-pencil'/> Editar</a>").ToHtmlString();
            retorno +=
                new MvcHtmlString(" &nbsp;").ToHtmlString();

            retorno +=
                new MvcHtmlString("<a class='btn btn-sm btn-info' href='/" + controller + "/Detalhar/" + id + "'><i class='glyphicon glyphicon-search'/> Ver</a>").ToHtmlString();

            retorno +=
                new MvcHtmlString(" &nbsp;").ToHtmlString();

            retorno +=
                new MvcHtmlString("<a class='btn btn-sm btn-danger' href='/" + controller + "/Excluir/" + id + "'><i class='glyphicon glyphicon-trash'/>  Excluir</a>").ToHtmlString();

            return retorno;
        }
    }
}