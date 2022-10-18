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
    public class ChucVuIRepository : IChucVuRepository
    {
        private FpolyDBContext _dbContext;

        public ChucVuIRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<ChucVu> getChucVusFromDB()
        {
            return _dbContext.ChucVus.ToList();
        }

        public bool addChucVu(ChucVu chucVu)
        {
            if (chucVu == null) return false;
            chucVu.Id = Guid.Empty;
            _dbContext.ChucVus.Add(chucVu);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateChucVu(ChucVu chucVu)
        {
            if(chucVu == null) return false;
            var temp = _dbContext.ChucVus.FirstOrDefault(p => p.Id == chucVu.Id);
            temp.Ma = chucVu.Ma;
            temp.Ten = chucVu.Ten;
            _dbContext.ChucVus.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteChucVu(ChucVu chucVu)
        {
            if (chucVu == null) return false;
            var temp = _dbContext.ChucVus.FirstOrDefault(p => p.Id == chucVu.Id);
            _dbContext.ChucVus.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public ChucVu getChucVu(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChucVus.FirstOrDefault(p => p.Id == id);
        }
    }
}
