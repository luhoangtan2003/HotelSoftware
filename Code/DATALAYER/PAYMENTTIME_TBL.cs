//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATALAYER
{
    using System;
    using System.Collections.Generic;

    public partial class PAYMENTTIME_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAYMENTTIME_TBL()
        {
            this.HOADONPHONG_TBL = new HashSet<HOADONPHONG_TBL>();
        }

        public string MATHOIDIEM { get; set; }
        public string TENTHOIDIEM { get; set; }
        public string MOTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONPHONG_TBL> HOADONPHONG_TBL { get; set; }
    }
}