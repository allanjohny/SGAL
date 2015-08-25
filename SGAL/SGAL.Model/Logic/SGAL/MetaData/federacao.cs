using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGAL.Model.Logic.SGAL
{
    [MetadataType(typeof(federacaoMetaData))]
    public partial class federacao
    {
        class federacaoMetaData
        {
            [Required(ErrorMessage = "Campo Obrigatório")]
            [DisplayName("Descrição")]
            public string descricao { get; set; }

            [DisplayName("Data de Inclusão")]
            public DateTime? datainclusao { get; set; }

            [DisplayName("Data de Alteração")]
            public DateTime? dataalteracao { get; set; }
        }
    }
}
