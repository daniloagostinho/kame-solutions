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
    
    public partial class HACK_EMAIL
    {
        public int ID_EMAIL { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public string EMAIL { get; set; }
    
        public virtual HACK_CLIENTE HACK_CLIENTE { get; set; }
    }
}