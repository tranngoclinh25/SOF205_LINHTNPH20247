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
    public class MauSacIRepository : IMauSacRepository
    {
        private FpolyDBContext _dbContext;

        public MauSacIRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<MauSac> getMauSacsFromDb()
        {
            return _dbContext.MauSacs.ToList();
        }

        public bool addMauSac(MauSac mauSac)
        {
            if (mauSac == null) return false;
            mauSac.Id = Guid.Empty;
            _dbContext.MauSacs.Add(mauSac);
            _dbContext.SaveChanges();
            return true;
        }

        public bool updateMauSac(MauSac mauSac)
        {
            if (mauSac == null) return false;
            var temp = _dbContext.MauSacs.FirstOrDefault(p => p.Id == mauSac.Id);
            temp.Ma = mauSac.Ma;
            temp.Ten = mauSac.Ten;
            _dbContext.MauSacs.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool deleteMauSac(MauSac mauSac)
        {
            if (mauSac == null) return false;
            var temp = _dbContext.MauSacs.FirstOrDefault(p => p.Id == mauSac.Id);
            _dbContext.MauSacs.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public MauSac getMauSac(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.MauSacs.FirstOrDefault(p => p.Id == id);
        }
    }
}
