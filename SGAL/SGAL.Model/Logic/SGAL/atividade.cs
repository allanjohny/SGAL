//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGAL.Model.Logic.SGAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class atividade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public atividade()
        {
            this.livropresenca = new HashSet<livropresenca>();
        }
    
        public int atividadeid { get; set; }
        public string descricao { get; set; }
        public string situacao { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<livropresenca> livropresenca { get; set; }
    }
}
