//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Items()
        {
            this.tbl_ItemStock = new HashSet<tbl_ItemStock>();
        }
    
        public string ID { get; set; }
        public string Name { get; set; }
        public string HSN_SAC_NO { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> MeasuringUnit { get; set; }
        public string Manufacture { get; set; }
        public string BarCode { get; set; }
        public string ItemUniqueDescription { get; set; }
        public string Supplier { get; set; }
        public string Photo { get; set; }
        public Nullable<bool> UseBatchNo { get; set; }
        public Nullable<bool> UseMfgDate { get; set; }
        public Nullable<bool> UseExpiryDate { get; set; }
        public Nullable<System.DateTime> CreatedDatetime { get; set; }
        public string GST { get; set; }
    
        public virtual tbl_GST tbl_GST { get; set; }
        public virtual tbl_ItemType tbl_ItemType { get; set; }
        public virtual tbl_ItemUnits tbl_ItemUnits { get; set; }
        public virtual tbl_vendor tbl_vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ItemStock> tbl_ItemStock { get; set; }
    }
}