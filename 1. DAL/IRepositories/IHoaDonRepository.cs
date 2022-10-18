using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        List<HoaDon> getHoaDonsFromDb();
        bool addHoaDon (HoaDon hoaDon);
        bool updateHoaDon (HoaDon hoaDon);

        bool deleteHoaDon (HoaDon hoaDon);
        HoaDon getHoaDon(Guid id);
    }
}
