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
    public class SanPhamIRepository : ISanPhamRepository
    {
        private FpolyDBContext _dbContext;

        public SanPhamIRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<SanPham> getSanPhamsFromDb()
        {
            return _dbContext.SanPhams.ToList();
            
        }

        public bool addSanPham(SanPham sanPham)
        {
            if (sanPham == null) return false;
            sanPham.Id = Guid.Empty;
            _dbContext.SanPhams.Add(sanPham);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateSanPham(SanPham sanPham)
        {
            if (sanPham == null) return false;
            var temp = _dbContext.SanPhams.FirstOrDefault(p => p.Id == sanPham.Id);
            temp.Ma = sanPham.Ma;
            temp.Ten = sanPham.Ten;
            _dbContext.SanPhams.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteSanPham(SanPham sanPham)
        {
            if (sanPham == null) return false;
            var temp = _dbContext.SanPhams.FirstOrDefault(p => p.Id == sanPham.Id);
            _dbContext.SanPhams.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public SanPham getSanPham(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.SanPhams.FirstOrDefault(p => p.Id == id);
        }
    }
}
