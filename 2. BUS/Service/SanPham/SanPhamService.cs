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
    public class SanPhamService : ISanPhamService
    {
        private ISanPhamRepository _iSanPhamRepository;
        private List<QLSanPhamViewModel> _SanPhamList;

        public SanPhamService()
        {
            _iSanPhamRepository = new SanPhamIRepository();
            _SanPhamList = new List<QLSanPhamViewModel>();
            GetAllData();
        }


        public string Add(QLSanPhamViewModel obj)
        {
            var sp = new _1._DAL.DomainClass.SanPham()
            {
                Id = obj.IdSp,
                Ma = obj.MaSp,
                Ten = obj.TenSp
            };
            if (_iSanPhamRepository.addSanPham(sp))
            {
                GetAllData();
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string Update(QLSanPhamViewModel obj)
        {
            int index = _iSanPhamRepository.getSanPhamsFromDb().FindIndex(p => p.Id == obj.IdSp);
            if (index == -1) return "Không tìm thấy";
            var sp = new _1._DAL.DomainClass.SanPham()
            {
                Id = obj.IdSp,
                Ma = obj.MaSp,
                Ten = obj.TenSp
            };
            if (_iSanPhamRepository.updateSanPham(sp))
            {
                GetAllData();
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }

        public string Delete(QLSanPhamViewModel obj)
        {
            int index = _iSanPhamRepository.getSanPhamsFromDb().FindIndex(p => p.Id == obj.IdSp);
            if (index == -1) return "Không tìm thấy";
            var sp = new _1._DAL.DomainClass.SanPham()
            {
                Id = obj.IdSp,
                Ma = obj.MaSp,
                Ten = obj.TenSp
            };
            if (_iSanPhamRepository.deleteSanPham(sp))
            {
                GetAllData();
                return "Xóa thành công";
            }
            return "Xóa không thành công";

        }
        public void GetAllData()
        {
            _SanPhamList = (from a in _iSanPhamRepository.getSanPhamsFromDb()
                            select new QLSanPhamViewModel()
                            {
                                IdSp = a.Id,
                                MaSp = a.Ma,
                                TenSp = a.Ten
                            }).ToList();
        }

        public List<QLSanPhamViewModel> GetAll()
        {
            return _SanPhamList;
        }

        public _1._DAL.DomainClass.SanPham getByGuid(Guid id)
        {
            return _iSanPhamRepository.getSanPham(id);
        }
    }
}
