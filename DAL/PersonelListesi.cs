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
    
    public partial class PersonelListesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonelListesi()
        {
            this.GirisSayfasi = new HashSet<GirisSayfasi>();
        }
    
        public int Personel_ID { get; set; }
        public string Personel_Ad { get; set; }
        public string Personel_Soyad { get; set; }
        public string Departman { get; set; }
        public Nullable<bool> Yetki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirisSayfasi> GirisSayfasi { get; set; }
    }
}
