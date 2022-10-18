using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _2._BUS.ViewModels
{
    public class QLSanPhamViewModel
    {
        //Chi tiết sản phẩm
        public Guid IdCtSp { get; set; }
        public Guid? IdSp_FK { get; set; }
        public Guid? IdNsx_FK { get; set; }
        public Guid? IdMauSac_FK { get; set; }
        public Guid? IdDongSp_FK { get; set; }
        public int? NamBh { get; set; }
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        //Sản phẩm
        public Guid IdSp { get; set; }
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        //Màu sắc
        public Guid IdMs { get; set; }
        public string MaMs { get; set; }
        public string TenMs { get; set; }
        //Nsx
        public Guid IdNsx { get; set; }
        public string MaNsx { get; set; }
        public string TenNsx { get; set; }
        //Dòng Sp
        public Guid IdDsp { get; set; }
        public string MaDsp { get; set; }
        public string TenDsp { get; set; }
    }
}
