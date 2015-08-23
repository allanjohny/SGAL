using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SGAL.MVC.Util
{
    public static class ExtensaoMVC
    {
        /// <summary>
        /// Extension Method que retorna uma SelectList para ser usada, por exemplo, no HtmlHelper DropDownList
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="enumerable">Extension method</param>
        /// <param name="valor">Propriedade com o valor do respectivo option</param>
        /// <param name="texto">Propriedade com o nome do respectivo option</param>
        /// <returns>SelectList com o primeiro valor "Selecione…"</returns>
        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> valor, Func<T, object> texto)
        {
            return ToSelectList(enumerable, valor, texto, "SELECIONE…");
        }

        /// <summary>
        /// Extension Method que retorna uma SelectList para ser usada, por exemplo, no HtmlHelper DropDownList
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="enumerable">Extension method</param>
        /// <param name="valor">Propriedade com o valor do respectivo option</param>
        /// <param name="texto">Propriedade com o nome do respectivo option</param>
        /// <param name="nomePrimeiroCampo">Nome da primeira linha. Padrão "Selecione…"</param>
        /// <returns>SelectList com o primeiro valor selecionado</returns>
        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> valor, Func<T, object> texto, string nomePrimeiroCampo)
        {
            return ToSelectList(enumerable, valor, texto, nomePrimeiroCampo, null);
        }

        /// <summary>
        /// Extension Method que retorna uma SelectList para ser usada, por exemplo, no HtmlHelper DropDownList
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="enumerable">Extension method</param>
        /// <param name="valor">Propriedade com o valor do respectivo option</param>
        /// <param name="texto">Propriedade com o nome do respectivo option</param>
        /// <param name="nomePrimeiroCampo">Nome da primeira linha. Padrão "Selecione…"</param>
        /// <param name="valorSelecionado">Valor que vai ser selecionado por padrãos</param>
        /// <returns>SelectList</returns>
        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> valor, Func<T, object> texto, string nomePrimeiroCampo, object valorSelecionado)
        {
            var list = enumerable.Select(x => new
            {
                Valor = valor.Invoke(x),
                Texto = texto.Invoke(x)
            }).ToList();
            if (nomePrimeiroCampo != null)
            {
                list.Insert(0, new { Valor = (object)null, Texto = (object)nomePrimeiroCampo });
            }

            return new SelectList(list, "Valor", "Texto", valorSelecionado);
        }

    }
}