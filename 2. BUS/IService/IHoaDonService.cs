using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _2._BUS.ViewModels;

namespace _2._BUS.IService
{
    public interface IHoaDonService
    {
        string Add(QLHoaDonViewModel obj);
        string Update(QLHoaDonViewModel obj);
        string Delete(QLHoaDonViewModel obj);
        List<QLHoaDonViewModel> GetAll();
        HoaDon getByGuid(Guid id);

    }
}
