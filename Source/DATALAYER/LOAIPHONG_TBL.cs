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

    public partial class LOAIPHONG_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG_TBL()
        {
            this.PHONGNGHI_TBL = new HashSet<PHONGNGHI_TBL>();
        }

        public string MALOAIPHONG { get; set; }
        public string TENLOAIPHONG { get; set; }
        public int SUCCHUA { get; set; }
        public int SOGIUONG { get; set; }
        public int TIENTHEOD { get; set; }
        public int TIENTHEOH { get; set; }
        public string MOTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONGNGHI_TBL> PHONGNGHI_TBL { get; set; }
    }
}
