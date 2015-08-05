using System.Collections.Generic;
using System.Linq;

namespace SGAL.Dominio
{
    public class RetornoServico
    {
        public IEnumerable<Validacao> Erros { get; set; }

        public bool Sucesso
        {
            get { return !Erros.Any(); }
        }
    }
}
