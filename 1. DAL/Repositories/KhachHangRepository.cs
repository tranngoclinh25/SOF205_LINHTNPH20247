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
    public class KhachHangIRepository : IKhachHangRepository
    {
        private FpolyDBContext _dbContext;

        public KhachHangIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<KhachHang> getKhachHangsFromDb()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public bool addKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            khachHang.Id = Guid.Empty;
            _dbContext.KhachHangs.Add(khachHang);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            var temp = _dbContext.KhachHangs.FirstOrDefault(p => p.Id == khachHang.Id);
            temp.Ma = khachHang.Ma;
            temp.Ten = khachHang.Ten;
            temp.TenDem = khachHang.TenDem;
            temp.Ho = khachHang.Ho;
            temp.NgaySinh = khachHang.NgaySinh;
            temp.Sdt = khachHang.Sdt;
            temp.DiaChi = khachHang.DiaChi;
            temp.ThanhPho = khachHang.ThanhPho;
            temp.QuocGia = khachHang.QuocGia;
            temp.MatKhau = khachHang.MatKhau;
            _dbContext.KhachHangs.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            var temp = _dbContext.KhachHangs.FirstOrDefault(p => p.Id == khachHang.Id);
            _dbContext.KhachHangs.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public KhachHang getKhachHang(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.KhachHangs.FirstOrDefault(p => p.Id == id);
        }
    }
}
