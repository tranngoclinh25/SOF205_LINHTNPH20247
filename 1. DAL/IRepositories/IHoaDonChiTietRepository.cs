using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IHoaDonChiTietRepository
    {
        List<HoaDonChiTiet> getHoaDonChiTietsFromDb();
        bool addHoaDonChiTiet (HoaDonChiTiet hoaDonChiTiet);
        bool updateHoaDonChiTiet (HoaDonChiTiet hoaDonChiTiet);
        bool deleteHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
    }
}
