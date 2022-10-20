using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _2._BUS.ViewModels
{
    public class QLHoaDonViewModel
    {
        //Không làm bán hàng nên ko sửa
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public HoaDon HoaDon { get; set; }
        public NhanVien NhanVien { get; set; }
        public ChiTietSp ChiTietSp { get; set; }
    }
}
