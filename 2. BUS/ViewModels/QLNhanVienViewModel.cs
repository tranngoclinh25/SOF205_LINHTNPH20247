using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _2._BUS.ViewModels
{
    public class QLNhanVienViewModel
    {
        public NhanVien NhanVien { get; set; }
        public ChucVu ChucVu { get; set; }
        public CuaHang CuaHang { get; set; }
    }
}
