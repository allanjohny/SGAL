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
    
    public partial class adepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public adepto()
        {
            this.adeptolivropresenca = new HashSet<adeptolivropresenca>();
            this.adeptomissaosagrada = new HashSet<adeptomissaosagrada>();
            this.adeptomodulo = new HashSet<adeptomodulo>();
            this.adeptorevistasagrada = new HashSet<adeptorevistasagrada>();
            this.associado = new HashSet<associado>();
            this.livropresenca = new HashSet<livropresenca>();
        }
    
        public int adeptoid { get; set; }
        public string nome { get; set; }
        public Nullable<System.DateTime> datanascimento { get; set; }
        public string email { get; set; }
        public string telefoneresidencial { get; set; }
        public string telefonecomercial { get; set; }
        public string telefonecelular { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<System.DateTime> dataprimeiravez { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<adeptolivropresenca> adeptolivropresenca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<adeptomissaosagrada> adeptomissaosagrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<adeptomodulo> adeptomodulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<adeptorevistasagrada> adeptorevistasagrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<associado> associado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<livropresenca> livropresenca { get; set; }
    }
}