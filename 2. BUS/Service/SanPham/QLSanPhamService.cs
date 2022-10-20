using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;
using _1._DAL.IRepositories;
using _1._DAL.Repositories;
using _2._BUS.IService.SanPham;
using _2._BUS.ViewModels;

namespace _2._BUS.Service.SanPham
{
    public class QLSanPhamService : IQLSanPhamService
    {
        private IChiTietSpRepository _iChiTietSpRepository;
        private ISanPhamRepository _iSanPhamRepository;
        private IMauSacRepository _iMauSacRepository;
        private INsxRepository _iNsxRepository;
        private IDongSpRepository _iDongSpRepository;
        private List<QLSanPhamViewModel> _sanPhamViewModelsList;

        public QLSanPhamService()
        {
            _iChiTietSpRepository = new ChiTietSpIRepository();
            _iSanPhamRepository = new SanPhamIRepository();
            _iMauSacRepository = new MauSacIRepository();
            _iNsxRepository = new NsxIRepository();
            _iDongSpRepository = new DongSpIRepository();
            _sanPhamViewModelsList = new List<QLSanPhamViewModel>();
            GetAll();
        }
        public string Add(QLSanPhamViewModel obj)
        {
            var sp = new ChiTietSp()
            {
                Id = obj.IdCtSp,
                IdSp = obj.IdSp_FK,
                IdNsx = obj.IdNsx_FK,
                IdMauSac = obj.IdMauSac_FK,
                IdDongSp = obj.IdDongSp_FK,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
        };
            if (obj == null) return "Thêm không thành công";
            if (_iChiTietSpRepository.addChiTietSp(sp))
            {
                GetAll();
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }

        public string Update(QLSanPhamViewModel obj)
        {
            if (obj == null) return "Sửa không thành công";
            var sp = new ChiTietSp()
            {
                Id = obj.IdCtSp,
                IdSp = obj.IdSp_FK,
                IdNsx = obj.IdNsx_FK,
                IdMauSac = obj.IdMauSac_FK,
                IdDongSp = obj.IdDongSp_FK,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            if (_iChiTietSpRepository.updateChiTietSp(sp))
            {
                GetAll();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLSanPhamViewModel obj)
        {
            if (obj == null) return "Xóa không thành công";
            var sp = new ChiTietSp()
            {
                Id = obj.IdCtSp,
                IdSp = obj.IdSp_FK,
                IdNsx = obj.IdNsx_FK,
                IdMauSac = obj.IdMauSac_FK,
                IdDongSp = obj.IdDongSp_FK,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            if (_iChiTietSpRepository.deleteChiTietSp(sp))
            {
                GetAll();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public List<QLSanPhamViewModel> GetAll()
        {

            _sanPhamViewModelsList = (from a in _iChiTietSpRepository.getChiTietSpsFromDB()
                                      join b in _iMauSacRepository.getMauSacsFromDb() on a.IdMauSac equals b.Id
                                      join c in _iSanPhamRepository.getSanPhamsFromDb() on a.IdSp equals c.Id
                                      join d in _iNsxRepository.getNsxesFromDb() on a.IdNsx equals d.Id
                                      join e in _iDongSpRepository.getDongSpsFromDb() on a.IdDongSp equals e.Id
                                      select new QLSanPhamViewModel()
                                      {
                                          IdCtSp = a.Id,
                                          IdSp_FK = a.IdSp,
                                          TenSp = c.Ten,
                                          IdNsx_FK = a.IdNsx,
                                          TenNsx = d.Ten,
                                          IdMauSac_FK = a.IdMauSac,
                                          TenMs = b.Ten,
                                          IdDongSp_FK = a.IdDongSp,
                                          TenDsp = e.Ten,
                                          NamBh = a.NamBh,
                                          MoTa = a.MoTa,
                                          SoLuongTon = a.SoLuongTon,
                                          GiaNhap = a.GiaNhap,
                                          GiaBan = a.GiaBan,
                                      }).ToList();
            return _sanPhamViewModelsList;
        }
        public ChiTietSp getByGuidChiTietSpSanPham(Guid id)
        {
            return _iChiTietSpRepository.getChiTietSp(id);
        }
    }
}
