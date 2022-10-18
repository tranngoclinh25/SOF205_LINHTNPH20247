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
    public class ChiTietSpIRepository : IChiTietSpRepository
    {
        private FpolyDBContext _dbContext;

        public ChiTietSpIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<ChiTietSp> getChiTietSpsFromDB()
        {
           return  _dbContext.ChiTietSps.ToList();
        }

        public bool addChiTietSp(ChiTietSp chiTietSp)
        {
            if (chiTietSp == null) return false;
            chiTietSp.Id = Guid.Empty;
            _dbContext.ChiTietSps.Add(chiTietSp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateChiTietSp(ChiTietSp chiTietSp)
        {
            if(chiTietSp == null) return false;
            var temp = _dbContext.ChiTietSps.FirstOrDefault(p => p.Id == chiTietSp.Id);
            temp.IdSp = chiTietSp.IdSp;
            temp.IdNsx = chiTietSp.IdNsx;
            temp.IdMauSac = chiTietSp.IdMauSac;
            temp.IdDongSp = chiTietSp.IdDongSp;
            temp.NamBh = chiTietSp.NamBh;
            temp.MoTa = chiTietSp.MoTa;
            temp.SoLuongTon = chiTietSp.SoLuongTon;
            temp.GiaNhap = chiTietSp.GiaNhap;
            temp.GiaBan = chiTietSp.GiaBan;
            _dbContext.ChiTietSps.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteChiTietSp(ChiTietSp chiTietSp)
        {
            if(chiTietSp == null) return false;
            var temp = _dbContext.ChiTietSps.FirstOrDefault(p => p.Id == chiTietSp.Id);
            _dbContext.ChiTietSps.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public ChiTietSp getChiTietSp(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChiTietSps.FirstOrDefault(p => p.Id == id);
        }
    }
}
