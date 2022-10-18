using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IDongSpRepository
    {
        List<DongSp> getDongSpsFromDb();
        bool addDongSp (DongSp dongSp);
        bool updateDongSp (DongSp dongSp);
        bool deleteDongSp (DongSp dongSp);
        DongSp getDongSp(Guid id);
    }
}
