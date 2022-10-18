using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IChucVuRepository
    {
        List<ChucVu> getChucVusFromDB();
        bool addChucVu(ChucVu chucVu);
        bool updateChucVu(ChucVu chucVu);
        bool deleteChucVu(ChucVu chucVu);
        ChucVu getChucVu(Guid id);
    }
}
