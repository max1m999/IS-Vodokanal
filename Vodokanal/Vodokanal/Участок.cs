//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vodokanal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Участок
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Участок()
        {
            this.Абонент = new HashSet<Абонент>();
            this.Директор = new HashSet<Директор>();
            this.Диспетчер = new HashSet<Диспетчер>();
            this.Проба = new HashSet<Проба>();
            this.Технический_сотрудник = new HashSet<Технический_сотрудник>();
        }
    
        public int Id_участка { get; set; }
        public string Адрес_участка { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Абонент> Абонент { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Директор> Директор { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Диспетчер> Диспетчер { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Проба> Проба { get; set; }
        public virtual Техническая_информация Техническая_информация { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Технический_сотрудник> Технический_сотрудник { get; set; }
    }
}
