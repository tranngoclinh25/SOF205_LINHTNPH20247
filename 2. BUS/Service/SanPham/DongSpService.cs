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
    public class DongSpService : IDongSpService
    {
        private IDongSpRepository _iDongSpRepository;
        private List<QLSanPhamViewModel> _dongSpList;

        public DongSpService()
        {
            _iDongSpRepository = new DongSpIRepository();
            _dongSpList = new List<QLSanPhamViewModel>();
            GetAllData();
        }

        public string Add(QLSanPhamViewModel obj)
        {
            var dsp = new DongSp()
            {
                Id = obj.IdDsp,
                Ma = obj.MaDsp,
                Ten = obj.TenDsp
            };
            if (_iDongSpRepository.addDongSp(dsp))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLSanPhamViewModel obj)
        {
            int index = _iDongSpRepository.getDongSpsFromDb().FindIndex(p => p.Id == obj.IdDsp);
            if (index == -1) return "Không tìm thấy";
            var dsp = new DongSp()
            {
                Id = obj.IdDsp,
                Ma = obj.MaDsp,
                Ten = obj.TenDsp
            };
            if (_iDongSpRepository.updateDongSp(dsp))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }
        public string Delete(QLSanPhamViewModel obj)
        {
            int index = _iDongSpRepository.getDongSpsFromDb().FindIndex(p => p.Id == obj.IdDsp);
            if (index == -1) return "Không tìm thấy";
            var dsp = new DongSp()
            {
                Id = obj.IdDsp,
                Ma = obj.MaDsp,
                Ten = obj.TenDsp
            };
            if (_iDongSpRepository.deleteDongSp(dsp))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _dongSpList = (from a in _iDongSpRepository.getDongSpsFromDb()
                    select new QLSanPhamViewModel()
                    {
                        IdDsp = a.Id,
                        MaDsp = a.Ma,
                        TenDsp = a.Ten
                    }).ToList();
        }

        public List<QLSanPhamViewModel> GetAll()
        {
            return _dongSpList;
        }

        public DongSp getByGuid(Guid id)
        {
            return _iDongSpRepository.getDongSp(id);
        }
    }
}
