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
    
    public partial class adeptolivropresenca
    {
        public int adeptolivropresencaid { get; set; }
        public Nullable<int> livropresencaid { get; set; }
        public Nullable<int> adeptoid { get; set; }
        public Nullable<bool> primeiravez { get; set; }
        public string observacao { get; set; }
    
        public virtual adepto adepto { get; set; }
        public virtual livropresenca livropresenca { get; set; }
    }
}
