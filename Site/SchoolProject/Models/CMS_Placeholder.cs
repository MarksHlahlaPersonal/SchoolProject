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
    
    public partial class CMS_Placeholder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMS_Placeholder()
        {
            this.CMS_Content = new HashSet<CMS_Content>();
        }
    
        public System.Guid PlaceholderId { get; set; }
        public string PlaceholderText { get; set; }
        public string ContextOrder { get; set; }
        public bool IsVisible { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Content> CMS_Content { get; set; }
    }
}
