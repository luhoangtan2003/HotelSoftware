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

    public partial class TRANGTHAIDATDV_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANGTHAIDATDV_TBL()
        {
            this.DATDICHVU_TBL = new HashSet<DATDICHVU_TBL>();
        }

        public string MATRANGTHAI { get; set; }
        public string TENTRANGTHAI { get; set; }
        public string MOTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATDICHVU_TBL> DATDICHVU_TBL { get; set; }
    }
}
