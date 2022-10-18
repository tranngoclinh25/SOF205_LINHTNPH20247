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
            if (_iKhachHangRepository.addKhachHang(obj.KhachHang))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(KhachHangViewModel obj)
        {
            int index = _iKhachHangRepository.getKhachHangsFromDb().FindIndex(p => p.Id == obj.KhachHang.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iKhachHangRepository.updateKhachHang(obj.KhachHang))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(KhachHangViewModel obj)
        {
            int index = _iKhachHangRepository.getKhachHangsFromDb().FindIndex(p => p.Id == obj.KhachHang.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iKhachHangRepository.deleteKhachHang(obj.KhachHang))
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
                        KhachHang = a
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
