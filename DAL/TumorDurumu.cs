//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineCRF_ProjeIT.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TumorDurumu
    {
        public int Tumor_ID { get; set; }
        public string TumorBolgesi { get; set; }
        public string TumorBoyutu { get; set; }
        public string TNM { get; set; }
        public string Evre { get; set; }
        public string TumorTipi { get; set; }
        public Nullable<int> Hasta_ID { get; set; }
    
        public virtual HastaBilgileri HastaBilgileri { get; set; }
    }
}
