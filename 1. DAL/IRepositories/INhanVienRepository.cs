using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface INhanVienRepository
    {
        List<NhanVien> getNhanViensFromDb();
        bool addNhanVien (NhanVien nhanVien);
        bool updateNhanVien (NhanVien nhanVien);
        bool deleteNhanVien (NhanVien nhanVien);
        NhanVien getNhanVien(Guid id);
    }
}
