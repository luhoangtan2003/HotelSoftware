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

    public partial class QUYENHAN_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYENHAN_TBL()
        {
            this.TAIKHOAN_TBL = new HashSet<TAIKHOAN_TBL>();
        }

        public string MAQH { get; set; }
        public string ROLE { get; set; }
        public string MOTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN_TBL> TAIKHOAN_TBL { get; set; }
    }
}
