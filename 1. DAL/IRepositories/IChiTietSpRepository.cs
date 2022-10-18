using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IChiTietSpRepository
    {
        List<ChiTietSp> getChiTietSpsFromDB();
        bool addChiTietSp(ChiTietSp chiTietSp);
        bool updateChiTietSp(ChiTietSp chiTietSp);
        bool deleteChiTietSp(ChiTietSp chiTietSp);
        ChiTietSp getChiTietSp(Guid id);
    }
}
