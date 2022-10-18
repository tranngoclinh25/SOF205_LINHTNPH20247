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
    public class HoaDonIRepository : IHoaDonRepository
    {
        private FpolyDBContext _dbContext;

        public HoaDonIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<HoaDon> getHoaDonsFromDb()
        {
            return _dbContext.HoaDons.ToList();
        }

        public bool addHoaDon(HoaDon hoaDon)
        {
            if (hoaDon == null) return false;
            hoaDon.Id = Guid.Empty;
            //var n = _dbContext.HoaDons.Max(p => int.Parse(p.Ma.Substring(2)));
            //hoaDon.Ma = $"HD {n+1}";
            //hoaDon.Ma = "HD2";
            _dbContext.HoaDons.Add(hoaDon);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateHoaDon(HoaDon hoaDon)
        {
            if (hoaDon == null) return false;
            var temp = _dbContext.HoaDons.FirstOrDefault(p=>p.Id == hoaDon.Id);
            temp.IdKh = hoaDon.IdKh;
            temp.IdNv = hoaDon.IdNv;
            temp.Ma = hoaDon.Ma;
            temp.NgayTao = hoaDon.NgayTao;
            temp.NgayThanhToan = hoaDon.NgayThanhToan;
            temp.NgayShip = hoaDon.NgayShip;
            temp.NgayNhan = hoaDon.NgayNhan;
            temp.TinhTrang = hoaDon.TinhTrang;
            temp.TenNguoiNhan = hoaDon.TenNguoiNhan;
            temp.DiaChi = hoaDon.DiaChi;
            temp.Sdt = hoaDon.Sdt;
            _dbContext.HoaDons.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteHoaDon(HoaDon hoaDon)
        {
            if (hoaDon == null) return false;
            var temp = _dbContext.HoaDons.FirstOrDefault(p => p.Id == hoaDon.Id);
            _dbContext.HoaDons.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public HoaDon getHoaDon(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDons.FirstOrDefault(p => p.Id == id);
        }
    }
}
