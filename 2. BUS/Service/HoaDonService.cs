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
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _iHoaDonRepository;
        private IChiTietSpRepository _iChiTietSpRepository;
        private INhanVienRepository _iNhanVienRepository;
        private IHoaDonChiTietRepository _iHoaDonChiTietRepository;
        private List<QLHoaDonViewModel> _qlHoaDonViewModelsList;

        public HoaDonService()
        {
            _iChiTietSpRepository = new ChiTietSpIRepository();
            _iHoaDonRepository = new HoaDonIRepository();
            _iHoaDonChiTietRepository = new HoaDonChiTietIRepository();
            _iNhanVienRepository = new NhanVienIRepository();
            _qlHoaDonViewModelsList = new List<QLHoaDonViewModel>();
            GetAll();
        }
        public string Add(QLHoaDonViewModel obj)
        {
            if (obj == null) return "Thêm không thành công";
            if (_iHoaDonRepository.addHoaDon(obj.HoaDon))
            {
                GetAll();
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }

        public string Update(QLHoaDonViewModel obj)
        {
            if (obj == null) return "Sửa không thành công";
            if (_iHoaDonRepository.updateHoaDon(obj.HoaDon))
            {
                GetAll();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLHoaDonViewModel obj)
        {
            if (obj == null) return "Xóa không thành công";
            if (_iHoaDonRepository.deleteHoaDon(obj.HoaDon))
            {
                GetAll();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public List<QLHoaDonViewModel> GetAll()
        {
            _qlHoaDonViewModelsList = (from a in _iHoaDonChiTietRepository.getHoaDonChiTietsFromDb()
                join b in _iChiTietSpRepository.getChiTietSpsFromDB() on a.IdChiTietSp equals b.Id
                join c in _iHoaDonRepository.getHoaDonsFromDb() on a.IdHoaDon equals c.Id
                join d in _iNhanVienRepository.getNhanViensFromDb() on c.IdNv equals d.Id
                select new QLHoaDonViewModel()
                {
                    HoaDonChiTiet = a,
                    ChiTietSp = b,
                    HoaDon = c,
                    NhanVien = d
                }).ToList();
            return _qlHoaDonViewModelsList;
        }

        public HoaDon getByGuid(Guid id)
        {
            return _iHoaDonRepository.getHoaDon(id);
        }
    }
}
