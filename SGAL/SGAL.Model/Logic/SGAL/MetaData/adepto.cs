using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGAL.Model.Logic.SGAL
{
    [MetadataType(typeof(adeptoMetaData))]
    public partial class adepto
    {
        class adeptoMetaData
        {
            [Required(ErrorMessage = "Campo Obrigatório")]
            [DisplayName("Nome")]
            public string nome { get; set; }
            
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [DisplayName("Data de Nascimento")]
            public Nullable<System.DateTime> datanascimento { get; set; }
            
            [DisplayName("E-mail")]
            public string email { get; set; }

            [DisplayName("Tel. Residencial")]
            public string telefoneresidencial { get; set; }

            [DisplayName("Tel. Comercial")]
            public string telefonecomercial { get; set; }

            [DisplayName("Celular")]
            public string telefonecelular { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [DisplayName("Data de Inclusão")]
            public Nullable<System.DateTime> datainclusao { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [DisplayName("Data de Alteração")]
            public Nullable<System.DateTime> dataalteracao { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [DisplayName("Primeira vez na SNI")]
            public Nullable<System.DateTime> dataprimeiravez { get; set; }
        }
    }
}
