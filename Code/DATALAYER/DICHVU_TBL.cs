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

    public partial class DICHVU_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU_TBL()
        {
            this.DATDICHVU_TBL = new HashSet<DATDICHVU_TBL>();
        }

        public string MADICHVU { get; set; }
        public string TENDICHVU { get; set; }
        public string MALOAIDV { get; set; }
        public int GIADICHVU { get; set; }
        public string MATRANGTHAI { get; set; }
        public string MOTA { get; set; }
        public string MALOAIHINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATDICHVU_TBL> DATDICHVU_TBL { get; set; }
        public virtual LOAIDV_TBL LOAIDV_TBL { get; set; }
        public virtual LOAIHINHDV_TBL LOAIHINHDV_TBL { get; set; }
        public virtual TRANGTHAIDV_TBL TRANGTHAIDV_TBL { get; set; }
    }
}
