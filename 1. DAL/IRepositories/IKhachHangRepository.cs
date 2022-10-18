using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        List<KhachHang> getKhachHangsFromDb();
        bool addKhachHang (KhachHang khachHang);
        bool updateKhachHang (KhachHang khachHang);
        bool deleteKhachHang (KhachHang khachHang);
        KhachHang getKhachHang(Guid id);
    }
}
