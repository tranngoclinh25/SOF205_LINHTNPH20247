using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _2._BUS.ViewModels;

namespace _2._BUS.IService.SanPham
{
    public interface IQLSanPhamService
    {
        string Add(QLSanPhamViewModel obj);
        string Update(QLSanPhamViewModel obj);
        string Delete(QLSanPhamViewModel obj);
        void GetAllData();
        List<QLSanPhamViewModel> GetAll();
        List<QLSanPhamViewModel> GetAll(string input);
        ChiTietSp getByGuidChiTietSpSanPham(Guid id);
    }
}
