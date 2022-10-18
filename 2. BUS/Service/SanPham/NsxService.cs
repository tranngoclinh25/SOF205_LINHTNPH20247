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
            var nsx = new Nsx()
            {
                Id = obj.IdNsx,
                Ma = obj.MaNsx,
                Ten = obj.TenNsx
            };
            if (_iNsxRepository.addNsx(nsx))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLSanPhamViewModel obj)
        {
            int index = _iNsxRepository.getNsxesFromDb().FindIndex(p => p.Id == obj.IdNsx);
            if (index == -1) return "Không tìm thấy";
            var nsx = new Nsx()
            {
                Id = obj.IdNsx,
                Ma = obj.MaNsx,
                Ten = obj.TenNsx
            };
            if (_iNsxRepository.updateNsx(nsx))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLSanPhamViewModel obj)
        {
            int index = _iNsxRepository.getNsxesFromDb().FindIndex(p => p.Id == obj.IdNsx);
            if (index == -1) return "Không tìm thấy";
            var nsx = new Nsx()
            {
                Id = obj.IdNsx,
                Ma = obj.MaNsx,
                Ten = obj.TenNsx
            };
            if (_iNsxRepository.deleteNsx(nsx))
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
                        IdNsx = a.Id,
                        MaNsx = a.Ma,
                        TenNsx = a.Ten
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
