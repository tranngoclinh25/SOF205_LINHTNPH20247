using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _2._BUS.ViewModels;

namespace _2._BUS.IService
{
    public interface IKhachHangService
    {
        string Add(KhachHangViewModel obj);
        string Update(KhachHangViewModel obj);
        string Delete(KhachHangViewModel obj);
        void GetAllData();
        List<KhachHangViewModel> GetAll();
        KhachHang getByGuid(Guid id);
    }
}
