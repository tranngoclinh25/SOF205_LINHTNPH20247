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
    public class MauSacService : IMauSacService
    {
        private IMauSacRepository _iMauSacRepository;
        private List<QLSanPhamViewModel> _mauSacList;

        public MauSacService()
        {
            _iMauSacRepository = new MauSacIRepository();
            _mauSacList = new List<QLSanPhamViewModel>();
            GetAllData();
        }
        public string Add(QLSanPhamViewModel obj)
        {
            if (_iMauSacRepository.addMauSac(obj.MauSac))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLSanPhamViewModel obj)
        {
            int index = _iMauSacRepository.getMauSacsFromDb().FindIndex(p => p.Id == obj.MauSac.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iMauSacRepository.updateMauSac(obj.MauSac))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLSanPhamViewModel obj)
        {
            int index = _iMauSacRepository.getMauSacsFromDb().FindIndex(p => p.Id == obj.MauSac.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iMauSacRepository.deleteMauSac(obj.MauSac))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _mauSacList = (from a in _iMauSacRepository.getMauSacsFromDb()
                    select new QLSanPhamViewModel()
                    {
                        MauSac = a
                    }).ToList();
        }

        public List<QLSanPhamViewModel> GetAll()
        {
            return _mauSacList;
        }

        public MauSac getByGuid(Guid id)
        {
            return _iMauSacRepository.getMauSac(id);
        }
    }
}
