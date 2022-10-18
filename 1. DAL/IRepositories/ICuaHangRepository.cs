using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface ICuaHangRepository
    {
        List<CuaHang> getCuaHangsFromDb();
        bool addCuaHang (CuaHang cuaHang);
        bool updateCuaHang (CuaHang cuaHang);
        bool deleteCuaHang (CuaHang cuaHang);
        CuaHang getCuaHang(Guid id);
    }
}
