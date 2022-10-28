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
        //Nhân viên
        public Guid IdNv { get; set; }
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string TenDemNv { get; set; }
        public string HoNv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int Tuoi { get; set; }
        public string DiaChiNV { get; set; }
        public string Sdt { get; set; }
        public string MatKhau { get; set; }
        public Guid? IdCh_FK { get; set; }
        public Guid? IdCv_FK { get; set; }
        public int? TrangThai { get; set; }
        //Chức vụ
        public Guid IdCv { get; set; }
        public string MaCv { get; set; }
        public string TenCv { get; set; }
        //Cửa hàng
        public Guid IdCh { get; set; }
        public string MaCh { get; set; }
        public string TenCh { get; set; }
        public string DiaChiCH { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
    }
}
