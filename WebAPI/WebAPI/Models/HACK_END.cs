//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HACK_END
    {
        public int ID_END { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public Nullable<int> NUMERO { get; set; }
        public string CIDADE { get; set; }
        public string CAPITAL { get; set; }
    
        public virtual HACK_CLIENTE HACK_CLIENTE { get; set; }
    }
}