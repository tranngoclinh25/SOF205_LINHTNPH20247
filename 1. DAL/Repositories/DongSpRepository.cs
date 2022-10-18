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
    public class DongSpIRepository : IDongSpRepository
    {
        private FpolyDBContext _dbContext;

        public DongSpIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<DongSp> getDongSpsFromDb()
        {
            return _dbContext.DongSps.ToList();
        }

        public bool addDongSp(DongSp dongSp)
        {
            if (dongSp == null) return false;
            dongSp.Id = Guid.Empty;
            _dbContext.DongSps.Add(dongSp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateDongSp(DongSp dongSp)
        {
            if(dongSp == null) return false;
            var temp = _dbContext.DongSps.FirstOrDefault(p => p.Id == dongSp.Id);
            temp.Ma = dongSp.Ma;
            temp.Ten = dongSp.Ten;
            _dbContext.DongSps.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteDongSp(DongSp dongSp)
        {
            if (dongSp == null) return false;
            var temp = _dbContext.DongSps.FirstOrDefault(p => p.Id == dongSp.Id);
            _dbContext.DongSps.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public DongSp getDongSp(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.DongSps.FirstOrDefault(p => p.Id == id);
        }
    }
}
