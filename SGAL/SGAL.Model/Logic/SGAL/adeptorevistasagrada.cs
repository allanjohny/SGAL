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
    
    public partial class adeptorevistasagrada
    {
        public int adeptorevistasagradaid { get; set; }
        public Nullable<int> adeptoid { get; set; }
        public Nullable<int> associacaoid { get; set; }
        public Nullable<int> revistasagradaid { get; set; }
        public Nullable<int> quantidade { get; set; }
        public Nullable<decimal> valorcota { get; set; }
    
        public virtual adepto adepto { get; set; }
        public virtual associacao associacao { get; set; }
        public virtual revistasagrada revistasagrada { get; set; }
    }
}