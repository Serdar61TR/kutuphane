//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace küytüphane_otomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class emanetler
    {
        public string alici { get; set; }
        public Nullable<long> alici_tc { get; set; }
        public Nullable<long> alici_tel { get; set; }
        public string kitap { get; set; }
        public long isbn_no { get; set; }
        public string yazari { get; set; }
        public string cevirmen { get; set; }
        public string kategori { get; set; }
        public Nullable<System.DateTime> alim_tarihi { get; set; }
    
        public virtual kitaplar kitaplar { get; set; }
        public virtual uyeler uyeler { get; set; }
    }
}
