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
    public class HoaDonChiTietIRepository : IHoaDonChiTietRepository
    {
        private FpolyDBContext _dbContext;

        public HoaDonChiTietIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<HoaDonChiTiet> getHoaDonChiTietsFromDb()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }

        public bool addHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet == null) return false;
            _dbContext.HoaDonChiTiets.Add(hoaDonChiTiet);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
            if(hoaDonChiTiet == null) return false;
            var temp = _dbContext.HoaDonChiTiets.FirstOrDefault(p =>
                p.IdChiTietSp == hoaDonChiTiet.IdChiTietSp && p.IdHoaDon == hoaDonChiTiet.IdHoaDon);
            temp.SoLuong = hoaDonChiTiet.SoLuong;
            temp.DonGia = hoaDonChiTiet.DonGia;
            _dbContext.HoaDonChiTiets.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet == null) return false;
            var temp = _dbContext.HoaDonChiTiets.FirstOrDefault(p =>
                p.IdChiTietSp == hoaDonChiTiet.IdChiTietSp && p.IdHoaDon == hoaDonChiTiet.IdHoaDon);
            _dbContext.HoaDonChiTiets.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
