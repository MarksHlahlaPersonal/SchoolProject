//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMS_Settings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMS_Settings()
        {
            this.CMS_Site = new HashSet<CMS_Site>();
        }
    
        public System.Guid CMS_SettingId { get; set; }
        public string Name { get; set; }
        public bool IsDeprecated { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Site> CMS_Site { get; set; }
    }
}
