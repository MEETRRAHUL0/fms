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
    
    public partial class tbl_vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_vendor()
        {
            this.tbl_Items = new HashSet<tbl_Items>();
            this.tbl_Purchase = new HashSet<tbl_Purchase>();
            this.tbl_Sale = new HashSet<tbl_Sale>();
            this.tbl_VendorAddress = new HashSet<tbl_VendorAddress>();
        }
    
        public int AutoID { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string PhoneNo { get; set; }
        public string VendorType { get; set; }
        public string Type { get; set; }
        public string Place { get; set; }
        public string DOB { get; set; }
        public string GSTNo { get; set; }
        public string TINNo { get; set; }
        public string PANNo { get; set; }
        public string CINNo { get; set; }
        public string AdhaarNo { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public string OpeningBalanceType { get; set; }
        public string OpeningBalanceDate { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public Nullable<int> CreditPeriod { get; set; }
        public Nullable<decimal> CreditInterestRate { get; set; }
        public Nullable<decimal> DebitInterestRate { get; set; }
        public string CreatedDatetime { get; set; }
        public string Photo { get; set; }
        public string Remark { get; set; }
        public string SuretyPerson { get; set; }
        public string SuretyPersonContactNo { get; set; }
        public string SuretyPersonAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Items> tbl_Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Purchase> tbl_Purchase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Sale> tbl_Sale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VendorAddress> tbl_VendorAddress { get; set; }
    }
}
