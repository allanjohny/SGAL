using System;
using System.Collections.Generic;
using System.Linq;

namespace SGAL.MVC.Util
{
    public class TabelaGenerica
    {
        public List<dynamic> Dados { get; set; }
        public string ClassesCss { get; set; }
        public int PaginaAtual { get; set; }
        public int Paginacao { get; set; }     
        public string TabelaId { get; set; }
        public Filtro[] Filtros { get; set; }
 
        public int TotalPaginas
        {
            get { return TotalRegistros/Paginacao; }
        }

        public int TotalRegistros 
        {
            get { return this.Dados.Count(); }
        }
    }
    
    public class Filtro
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}