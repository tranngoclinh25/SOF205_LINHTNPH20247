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
    public class NsxService : INsxService
    {
        private INsxRepository _iNsxRepository;
        private List<QLSanPhamViewModel> _nsxList;

        public NsxService()
        {
            _iNsxRepository = new NsxIRepository();
            _nsxList = new List<QLSanPhamViewModel>();
            GetAllData();
        }

        public string Add(QLSanPhamViewModel obj)
        {
            if (_iNsxRepository.addNsx(obj.Nsx))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLSanPhamViewModel obj)
        {
            int index = _iNsxRepository.getNsxesFromDb().FindIndex(p => p.Id == obj.Nsx.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iNsxRepository.updateNsx(obj.Nsx))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLSanPhamViewModel obj)
        {
            int index = _iNsxRepository.getNsxesFromDb().FindIndex(p => p.Id == obj.Nsx.Id);
            if (index == -1) return "Không tìm thấy";
            if (_iNsxRepository.deleteNsx(obj.Nsx))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }

        public void GetAllData()
        {
            _nsxList = (from a in _iNsxRepository.getNsxesFromDb()
                    select new QLSanPhamViewModel()
                    {
                        Nsx = a
                    }).ToList();
        }


        public List<QLSanPhamViewModel> GetAll()
        {
            return _nsxList;
        }

        public Nsx getByGuid(Guid id)
        {
            return _iNsxRepository.getNsx(id);
        }
    }
}
