using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _1._DAL.IRepositories;
using _1._DAL.Repositories;
using _2._BUS.IService.NhanVien;
using _2._BUS.ViewModels;

namespace _2._BUS.Service.NhanVien
{
    public class CuaHangService : ICuaHangService
    {
        private ICuaHangRepository _iCuaHangRepository;
        private List<QLNhanVienViewModel> _cuaHangsList;

        public CuaHangService()
        {
            _iCuaHangRepository = new CuaHangIRepository();
            _cuaHangsList = new List<QLNhanVienViewModel>();
            GetAllData();
        }

        public string Add(QLNhanVienViewModel obj)
        {
            var ch = new CuaHang()
            {
                Id = obj.IdCh,
                Ma = obj.MaCh,
                Ten = obj.TenCh,
                DiaChi = obj.DiaChiCH,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            if (_iCuaHangRepository.addCuaHang(ch))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLNhanVienViewModel obj)
        {
            int index = _iCuaHangRepository.getCuaHangsFromDb().FindIndex(p => p.Id == obj.IdCh);
            if (index == -1) return "Không tìm thấy";
            var ch = new CuaHang()
            {
                Id = obj.IdCh,
                Ma = obj.MaCh,
                Ten = obj.TenCh,
                DiaChi = obj.DiaChiCH,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            if (_iCuaHangRepository.updateCuaHang(ch))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLNhanVienViewModel obj)
        {
            int index = _iCuaHangRepository.getCuaHangsFromDb().FindIndex(p => p.Id == obj.IdCh);
            if (index == -1) return "Không tìm thấy";
            var ch = new CuaHang()
            {
                Id = obj.IdCh,
                Ma = obj.MaCh,
                Ten = obj.TenCh,
                DiaChi = obj.DiaChiCH,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            if (_iCuaHangRepository.deleteCuaHang(ch))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _cuaHangsList = (from a in _iCuaHangRepository.getCuaHangsFromDb()
                select new QLNhanVienViewModel()
                {
                    IdCh = a.Id,
                    MaCh = a.Ma,
                    TenCh = a.Ten,
                    DiaChiCH = a.DiaChi,
                    ThanhPho = a.ThanhPho,
                    QuocGia = a.QuocGia,
                }).ToList();
        }

        public List<QLNhanVienViewModel> GetAll()
        {
            return _cuaHangsList;
        }

        public CuaHang getByGuid(Guid id)
        {
            return _iCuaHangRepository.getCuaHang(id);
        }
    }
}
