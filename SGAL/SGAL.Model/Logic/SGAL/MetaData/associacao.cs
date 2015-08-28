using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SGAL.Model.Logic.SGAL
{
    [MetadataType(typeof(associacaoMetaData))]
    public partial class associacao
    {
        class associacaoMetaData
        {
            [Required(ErrorMessage = "Campo Obrigatório")]
            [DisplayName("Descrição")]
            public string descricao { get; set; }

            [DisplayName("Data de Abertura")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Required(ErrorMessage = "Campo Obrigatório")]
            public DateTime? dataabertura { get; set; }

            [DisplayName("Data de Fechamento")]
            public DateTime? datafechamento { get; set; }

            [DisplayName("Data de Inclusão")]
            public DateTime? datainclusao { get; set; }

            [DisplayName("Data de Alteração")]
            public DateTime? dataalteracao { get; set; }

            [Required(ErrorMessage = "Campo Obrigatório")]
            [DisplayName("Regional")]
            public int? regionalid { get; set; }

            [Required(ErrorMessage = "Campo Obrigatório")]
            [DisplayName("Federação")]
            public int? federacaoid { get; set; }
        }
    }
}
