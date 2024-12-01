using DATALAYER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace LOGICLAYER
{
    public class DichVuBackend
    {
        readonly QLKSEntities Adapter = new QLKSEntities();

        public IQueryable<DichVuCustom> LoadDataTable()

        => from DichVu in Adapter.DICHVU_TBL.AsNoTracking()

           join LoaiDV in Adapter.LOAIDV_TBL.AsNoTracking()

           on DichVu.MALOAIDV equals LoaiDV.MALOAIDV

           join LoaiHinhDV in Adapter.LOAIHINHDV_TBL.AsNoTracking()

           on DichVu.MALOAIHINH equals LoaiHinhDV.MALOAIHINH

           join TrangThai in Adapter.TRANGTHAIDV_TBL.AsNoTracking()

           on DichVu.MATRANGTHAI equals TrangThai.MATRANGTHAI

           select new DichVuCustom { TENDICHVU = DichVu.TENDICHVU, TENLOAIDV = LoaiDV.TENLOAIDV, GIADICHVU = DichVu.GIADICHVU, MOTA = DichVu.MOTA, MADICHVU = DichVu.MADICHVU, MALOAIDV = LoaiDV.MALOAIDV, TENLOAIHINH = LoaiHinhDV.TENLOAIHINH, MALOAIHINH = LoaiHinhDV.MALOAIHINH, TENTRANGTHAI = TrangThai.TENTRANGTHAI, MATRANGTHAI = TrangThai.MATRANGTHAI };

        public List<DichVuCustom> LoadDataTable(String MaLoaiDV,

                                                String LoaiHinh,

                                                String TrangThai)
        {
            IQueryable<DichVuCustom> GetListDV = LoadDataTable();

            if (!String.IsNullOrEmpty(TrangThai))
            {
                GetListDV = GetListDV.Where(x => x.MATRANGTHAI == TrangThai);
            }

            if (!String.IsNullOrEmpty(MaLoaiDV))
            {
                GetListDV = GetListDV.Where(x => x.MALOAIDV == MaLoaiDV);
            }

            if (!String.IsNullOrEmpty(LoaiHinh))
            {
                GetListDV = GetListDV.Where(x => x.MALOAIHINH == LoaiHinh);
            }

            return GetListDV.ToList();
        }

        public void Add(DICHVU_TBL DichVu)
        {
            Adapter.DICHVU_TBL.Add(DichVu);

            Adapter.SaveChanges();
        }

        public void Edit(DICHVU_TBL DichVu)
        {
            String MaDichVu = DichVu.MADICHVU;

            DICHVU_TBL Row = Adapter.DICHVU_TBL.FirstOrDefault(x => x.MADICHVU == MaDichVu);

            Row.TENDICHVU = DichVu.TENDICHVU;

            Row.GIADICHVU = DichVu.GIADICHVU;

            Row.MOTA = DichVu.MOTA;

            Row.MALOAIHINH = DichVu.MALOAIHINH;

            Row.MALOAIDV = DichVu.MALOAIDV;

            Row.MATRANGTHAI = DichVu.MATRANGTHAI;

            Adapter.SaveChanges();
        }

        public void Remove(String MaDichVu)
        {
            DICHVU_TBL Row = Adapter.DICHVU_TBL.FirstOrDefault(x => x.MADICHVU == MaDichVu);

            Adapter.DICHVU_TBL.Remove(Row);

            Adapter.SaveChanges();
        }

        public Boolean Duplicate(String MaDichVu)
        {
            Boolean Is = Adapter.DICHVU_TBL.AsNoTracking().Any(x => x.MADICHVU == MaDichVu);

            return Is;
        }

        public List<DichVuCustom> SearchDichVu(String TenDichVu)
        {
            IQueryable<DichVuCustom> GetList = LoadDataTable();

            if (String.IsNullOrEmpty(TenDichVu))
            {
                return null;
            }

            return GetList.AsNoTracking().Where(x => x.TENDICHVU.Contains(TenDichVu)).ToList();
        }

        public Boolean Referenced(String MaDichVu)
        {
            Boolean Is = Adapter.DATDICHVU_TBL.AsNoTracking().Any(x => x.MADICHVU == MaDichVu);

            return Is;
        }
    }
}