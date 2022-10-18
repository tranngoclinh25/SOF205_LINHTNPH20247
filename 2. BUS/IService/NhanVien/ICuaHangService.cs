using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _2._BUS.ViewModels;

namespace _2._BUS.IService.NhanVien
{
    public interface ICuaHangService
    {
        string Add(QLNhanVienViewModel obj);
        string Update(QLNhanVienViewModel obj);
        string Delete(QLNhanVienViewModel obj);
        void GetAllData();
        List<QLNhanVienViewModel> GetAll();
        CuaHang getByGuid(Guid id);
    }
}
