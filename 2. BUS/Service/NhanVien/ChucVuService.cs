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
    public class ChucVuService : IChucVuService
    {
        private IChucVuRepository _iChucVuRepository;
        private List<QLNhanVienViewModel> _chucVusList;

        public ChucVuService()
        {
            _iChucVuRepository = new ChucVuIRepository();
            _chucVusList = new List<QLNhanVienViewModel>();
            GetAllData();
        }

        public string Add(QLNhanVienViewModel obj)
        {
            if (_iChucVuRepository.addChucVu(obj.ChucVu))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLNhanVienViewModel obj)
        {
            int index = _iChucVuRepository.getChucVusFromDB().FindIndex(p => p.Id == obj.ChucVu.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iChucVuRepository.updateChucVu(obj.ChucVu))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLNhanVienViewModel obj)
        {
            int index = _iChucVuRepository.getChucVusFromDB().FindIndex(p => p.Id == obj.ChucVu.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iChucVuRepository.deleteChucVu(obj.ChucVu))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _chucVusList = (from a in _iChucVuRepository.getChucVusFromDB()
                    select new QLNhanVienViewModel()
                    {
                        ChucVu = a
                    }).ToList();
        }

        public List<QLNhanVienViewModel> GetAll()
        {
            return _chucVusList;
        }

        public ChucVu getByGuid(Guid id)
        {
            return _iChucVuRepository.getChucVu(id);
        }
    }
}
