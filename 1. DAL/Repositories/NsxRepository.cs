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
    public class NsxIRepository : INsxRepository
    {
        private FpolyDBContext _dbContext;

        public NsxIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<Nsx> getNsxesFromDb()
        {
            return _dbContext.Nsxes.ToList();
        }

        public bool addNsx(Nsx nsx)
        {
            if (nsx == null) return false;
            nsx.Id = Guid.Empty;
            _dbContext.Nsxes.Add(nsx);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateNsx(Nsx nsx)
        {
            if (nsx == null) return false;
            var temp = _dbContext.Nsxes.FirstOrDefault(p => p.Id == nsx.Id);
            temp.Ma = nsx.Ma;
            temp.Ten = nsx.Ten;
            _dbContext.Nsxes.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteNsx(Nsx nsx)
        {
            if (nsx == null) return false;
            var temp = _dbContext.Nsxes.FirstOrDefault(p => p.Id == nsx.Id);
            _dbContext.Nsxes.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public Nsx getNsx(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Nsxes.FirstOrDefault(p => p.Id == id);
        }
    }
}
