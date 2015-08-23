using System.Collections.Generic;
using System.Web.Mvc;
using SGAL.Core;

namespace SGAL.MVC.Util
{
    public static class ControllerUtil
    {
        /// <summary>
        /// Método personalizado para adicionar erros na ModelState da Controller passada por parâmetro
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="validacoes"></param>
        /// <param name="defaultErrorKey"></param>
        public static void AddModelErrors(this Controller controller, IEnumerable<Validacao> validacoes, string defaultErrorKey = null)
        {
            if (validacoes != null)
            {
                foreach (var validacao in validacoes)
                {
                    if (!string.IsNullOrEmpty(validacao.Campo))
                    {
                        controller.ModelState.AddModelError(validacao.Campo, validacao.Mensagem);
                    }
                    else if (defaultErrorKey != null)
                    {
                        controller.ModelState.AddModelError(defaultErrorKey, validacao.Mensagem);
                    }
                    else
                    {
                        controller.ModelState.AddModelError(string.Empty, validacao.Mensagem);
                    }
                }
            }
        }

        /// <summary>
        /// Método personalizado para adicionar erros na ModelState
        /// </summary>
        /// <param name="modelState"></param>
        /// <param name="validacoes"></param>
        /// <param name="defaultErrorKey"></param>
        public static void AddModelErrors(this ModelStateDictionary modelState, IEnumerable<Validacao> validacoes, string defaultErrorKey = null)
        {
            if (validacoes == null) return;

            foreach (var validacao in validacoes)
            {
                string key = validacao.Campo ?? defaultErrorKey ?? string.Empty;
                modelState.AddModelError(key, validacao.Mensagem);
            }
        }
    }
}