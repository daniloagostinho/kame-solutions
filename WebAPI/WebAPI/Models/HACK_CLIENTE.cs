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
    
    public partial class HACK_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HACK_CLIENTE()
        {
            this.HACK_EMAIL = new HashSet<HACK_EMAIL>();
            this.HACK_END = new HashSet<HACK_END>();
            this.HACK_TELEFONE = new HashSet<HACK_TELEFONE>();
        }
    
        public int ID_CLIENTE { get; set; }
        public string CPF { get; set; }
        public string NOME { get; set; }
        public Nullable<System.DateTime> NASC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HACK_EMAIL> HACK_EMAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HACK_END> HACK_END { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HACK_TELEFONE> HACK_TELEFONE { get; set; }
    }
}
