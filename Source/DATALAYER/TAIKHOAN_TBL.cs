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

    public partial class TAIKHOAN_TBL
    {
        public string IDNV { get; set; }
        public string PASSWORD { get; set; }
        public string MAQH { get; set; }

        public virtual NHANVIEN_TBL NHANVIEN_TBL { get; set; }
        public virtual QUYENHAN_TBL QUYENHAN_TBL { get; set; }
    }
}
