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
    
    public partial class CMS_Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMS_Site()
        {
            this.CMS_Content = new HashSet<CMS_Content>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> CMS_SettingId { get; set; }
        public Nullable<int> UserCreated { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Content> CMS_Content { get; set; }
        public virtual CMS_Settings CMS_Settings { get; set; }
        public virtual CMS_Menu CMS_Menu { get; set; }
    }
}
