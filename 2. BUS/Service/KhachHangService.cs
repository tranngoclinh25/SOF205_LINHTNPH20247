using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _1._DAL.IRepositories;
using _1._DAL.Repositories;
using _2._BUS.IService;
using _2._BUS.ViewModels;

namespace _2._BUS.Service
{
    public class KhachHangService:IKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepository;
        private List<KhachHangViewModel> _khachHangList;

        public KhachHangService()
        {
            _iKhachHangRepository = new KhachHangIRepository();
            _khachHangList = new List<KhachHangViewModel>();
            GetAllData();
        }

        public string Add(KhachHangViewModel obj)
        {
            var kh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau,
            };
            if (_iKhachHangRepository.addKhachHang(kh))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(KhachHangViewModel obj)
        {
            int index = _iKhachHangRepository.getKhachHangsFromDb().FindIndex(p => p.Id == obj.Id);
            if (index == -1) return "Không tìm thấy";
            var kh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau,
            };
            if (_iKhachHangRepository.updateKhachHang(kh))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(KhachHangViewModel obj)
        {
            int index = _iKhachHangRepository.getKhachHangsFromDb().FindIndex(p => p.Id == obj.Id);
            if (index == -1) return "Không tìm thấy";
            var kh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau,
            };
            if (_iKhachHangRepository.deleteKhachHang(kh))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _khachHangList = (from a in _iKhachHangRepository.getKhachHangsFromDb()
                    select new KhachHangViewModel()
                    {
                        Id = a.Id,
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TenDem = a.TenDem,
                        Ho = a.Ho,
                        NgaySinh = a.NgaySinh,
                        Sdt = a.Sdt,
                        DiaChi = a.DiaChi,
                        ThanhPho = a.ThanhPho,
                        QuocGia = a.QuocGia,
                        MatKhau = a.MatKhau,
                    }).ToList();
        }

        public List<KhachHangViewModel> GetAll()
        {
            return _khachHangList;
        }

        public KhachHang getByGuid(Guid id)
        {
            return _iKhachHangRepository.getKhachHang(id);
        }
    }
}
