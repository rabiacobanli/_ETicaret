//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ETicaret.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparisler
    {
        public int SiparisID { get; set; }
        public string UserID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string TCKimlikNo { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual SiparisDetaylar SiparisDetaylar { get; set; }
    }
}
