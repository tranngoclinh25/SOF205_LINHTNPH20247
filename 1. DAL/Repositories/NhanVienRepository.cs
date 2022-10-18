using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.Context;
using _1._DAL.DomainClass;
using _1._DAL.IRepositories;

namespace _1._DAL.Repositories
{
    public class NhanVienIRepository : INhanVienRepository
    {
        private FpolyDBContext _dbContext;

        public NhanVienIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<NhanVien> getNhanViensFromDb()
        {
            return _dbContext.NhanViens.ToList();
        }

        public bool addNhanVien(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            nhanVien.Id = Guid.Empty;
            _dbContext.NhanViens.Add(nhanVien);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateNhanVien(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            var temp = _dbContext.NhanViens.FirstOrDefault(p => p.Id == nhanVien.Id);
            temp.Ma = nhanVien.Ma;
            temp.Ten = nhanVien.Ten;
            temp.TenDem = nhanVien.TenDem;
            temp.Ho = nhanVien.Ho;
            temp.GioiTinh = nhanVien.GioiTinh;
            temp.NgaySinh = nhanVien.NgaySinh;
            temp.DiaChi = nhanVien.DiaChi;
            temp.Sdt = nhanVien.Sdt;
            temp.MatKhau = nhanVien.MatKhau;
            temp.IdCh = nhanVien.IdCh;
            temp.IdChNavigation = nhanVien.IdChNavigation;
            temp.IdCv = nhanVien.IdCv;
            temp.IdCvNavigation = nhanVien.IdCvNavigation;
            temp.IdGuiBc = null;
            temp.TrangThai = nhanVien.TrangThai;
            _dbContext.NhanViens.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            var temp = _dbContext.NhanViens.FirstOrDefault(p => p.Id == nhanVien.Id);
            _dbContext.NhanViens.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public NhanVien getNhanVien(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.NhanViens.FirstOrDefault(p => p.Id == id);
        }
    }
}
