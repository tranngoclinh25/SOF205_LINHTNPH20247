using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        List<SanPham> getSanPhamsFromDb();
        bool addSanPham (SanPham sanPham);
        bool updateSanPham (SanPham sanPham);
        bool deleteSanPham (SanPham sanPham);
        SanPham getSanPham (Guid id);

    }
}
