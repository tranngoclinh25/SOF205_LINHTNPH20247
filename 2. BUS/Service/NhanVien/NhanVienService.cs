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
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _iNhanVienRepository;
        private IChucVuRepository _iChucVuRepository;
        private ICuaHangRepository _iCuaHangRepository;
        private List<QLNhanVienViewModel> _nhanViensList;

        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienIRepository();
            _iChucVuRepository = new ChucVuIRepository();
            _iCuaHangRepository = new CuaHangIRepository();
            _nhanViensList = new List<QLNhanVienViewModel>();
            GetAllData();
        }

        public string Add(QLNhanVienViewModel obj)
        {
            var nv = new _1._DAL.DomainClass.NhanVien()
            {
                Id = obj.IdNv,
                Ma = obj.MaNv,
                Ten = obj.TenNv,
                TenDem = obj.TenDemNv,
                Ho = obj.HoNv,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChiNV,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh_FK,
                IdCv = obj.IdCv_FK,
                TrangThai = obj.TrangThai,
            };
            if (_iNhanVienRepository.addNhanVien(nv))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLNhanVienViewModel obj)
        {
            int index = _iNhanVienRepository.getNhanViensFromDb().FindIndex(p => p.Id == obj.IdNv);
            if (index == -1) return "Không tìm thấy";
            var nv = new _1._DAL.DomainClass.NhanVien()
            {
                Id = obj.IdNv,
                Ma = obj.MaNv,
                Ten = obj.TenNv,
                TenDem = obj.TenDemNv,
                Ho = obj.HoNv,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChiNV,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh_FK,
                IdCv = obj.IdCv_FK,
                TrangThai = obj.TrangThai,
            };
            if (_iNhanVienRepository.updateNhanVien(nv))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLNhanVienViewModel obj)
        {
            int index = _iNhanVienRepository.getNhanViensFromDb().FindIndex(p => p.Id == obj.IdNv);
            if (index == -1) return "Không tìm thấy";
            var nv = new _1._DAL.DomainClass.NhanVien()
            {
                Id = obj.IdNv,
                Ma = obj.MaNv,
                Ten = obj.TenNv,
                TenDem = obj.TenDemNv,
                Ho = obj.HoNv,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChiNV,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh_FK,
                IdCv = obj.IdCv_FK,
                TrangThai = obj.TrangThai,
            };
            if (_iNhanVienRepository.deleteNhanVien(nv))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _nhanViensList = (from a in _iNhanVienRepository.getNhanViensFromDb()
                              join b in _iChucVuRepository.getChucVusFromDB() on a.IdCv equals b.Id
                              join c in _iCuaHangRepository.getCuaHangsFromDb() on a.IdCh equals c.Id
                              select new QLNhanVienViewModel()
                              {
                                  IdNv = a.Id,
                                  MaNv = a.Ma,
                                  TenNv = a.Ten,
                                  TenDemNv = a.TenDem,
                                  HoNv = a.Ho,
                                  GioiTinh = a.GioiTinh,
                                  NgaySinh = a.NgaySinh,
                                  Tuoi = DateTime.Now.Year - (a.NgaySinh.Value.Year),
                                  DiaChiNV = a.DiaChi,
                                  Sdt = a.Sdt,
                                  MatKhau = a.MatKhau,
                                  IdCh_FK = a.IdCh,
                                  TenCh = c.Ten,
                                  IdCv_FK = a.IdCv,
                                  TenCv = b.Ma,
                                  TrangThai = a.TrangThai,
                              }).ToList();
        }

        public List<QLNhanVienViewModel> GetAll()
        {
            return _nhanViensList;
        }

        public _1._DAL.DomainClass.NhanVien getByGuid(Guid id)
        {
            return _iNhanVienRepository.getNhanVien(id);
        }
    }
}
