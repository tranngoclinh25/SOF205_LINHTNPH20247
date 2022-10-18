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
    public class CuaHangIRepository : ICuaHangRepository
    {
        private FpolyDBContext _dbContext;

        public CuaHangIRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<CuaHang> getCuaHangsFromDb()
        {
            return _dbContext.CuaHangs.ToList();
        }

        public bool addCuaHang(CuaHang cuaHang)
        {
            if (cuaHang == null) return false;
            cuaHang.Id = Guid.Empty;
            _dbContext.CuaHangs.Add(cuaHang);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateCuaHang(CuaHang cuaHang)
        {
            if(cuaHang == null) return false;
            var temp = _dbContext.CuaHangs.FirstOrDefault(p => p.Id == cuaHang.Id);
            temp.Ma = cuaHang.Ma;
            temp.Ten = cuaHang.Ten;
            temp.DiaChi = cuaHang.DiaChi;
            temp.ThanhPho = cuaHang.ThanhPho;
            temp.QuocGia = cuaHang.QuocGia;
            _dbContext.CuaHangs.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteCuaHang(CuaHang cuaHang)
        {
            if (cuaHang == null) return false;
            var temp = _dbContext.CuaHangs.FirstOrDefault(p => p.Id == cuaHang.Id);
            _dbContext.CuaHangs.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public CuaHang getCuaHang(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.CuaHangs.FirstOrDefault(p => p.Id == id);
        }
    }
}
