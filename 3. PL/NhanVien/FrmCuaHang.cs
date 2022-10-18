using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1._DAL.DomainClass;
using _2._BUS.IService;
using _2._BUS.IService.NhanVien;
using _2._BUS.Service;
using _2._BUS.Service.NhanVien;
using _2._BUS.ViewModels;

namespace _3._PL.NhanVien
{
    public partial class FrmCuaHang : Form
    {
        private ICuaHangService _iCuaHangService;
        private Guid _id;
        private List<string> lstThanhPho;
        public FrmCuaHang()
        {
            InitializeComponent();
            _iCuaHangService = new CuaHangService();
            List<string> lstThanhPho = new List<string>();
            LoadCuaHang();
            LoadThanhPho();
            LoadQuocGia();
        }
        private void LoadCuaHang()
        {
            int stt = 1;
            dgrid_CuaHang.ColumnCount = 7;
            dgrid_CuaHang.Columns[0].Name = "STT";
            dgrid_CuaHang.Columns[1].Name = "ID";
            dgrid_CuaHang.Columns[2].Name = "Mã Khách Hàng";
            dgrid_CuaHang.Columns[3].Name = "Tên Khách Hàng";
            dgrid_CuaHang.Columns[4].Name = "Địa Chỉ";
            dgrid_CuaHang.Columns[5].Name = "Thành Phố";
            dgrid_CuaHang.Columns[6].Name = "Quốc Gia";
            dgrid_CuaHang.Rows.Clear();
            dgrid_CuaHang.Columns[1].Visible = false;
            foreach (var ch in _iCuaHangService.GetAll())
            {
                dgrid_CuaHang.Rows.Add(stt++, ch.CuaHang.Id, ch.CuaHang.Ma, ch.CuaHang.Ten, ch.CuaHang.DiaChi, ch.CuaHang.ThanhPho, ch.CuaHang.QuocGia);
            }
        }

        private void LoadThanhPho()
        {
            lstThanhPho = new List<string>()
            {
                "An Giang",
                "Bà rịa – Vũng tàu",
                "Bắc Giang",
                "Bắc Kạn",
                "Bạc Liêu",
                "Bắc Ninh",
                "Bến Tre",
                "Bình Định",
                "Bình Dương",
                "Bình Phước",
                "Bình Thuận",
                "Cà Mau",
                "Cần Thơ",
                "Cao Bằng",
                "Đà Nẵng",
                "Đắk Lắk",
                "Đắk Nông",
                "Điện Biên",
                "Đồng Nai",
                "Đồng Tháp",
                "Gia Lai",
                "Hà Giang",
                "Hà Nam",
                "Hà Nội",
                "Hà Tĩnh",
                "Hải Dương",
                "Hải Phòng",
                "Hậu Giang",
                "Hòa Bình",
                "Hưng Yên",
                "Khánh Hòa",
                "Kiên Giang",
                "Kon Tum",
                "Lai Châu",
                "Lâm Đồng",
                "Lạng Sơn",
                "Lào Cai",
                "Long An",
                "Nam Định",
                "Nghệ An",
                "Ninh Bình",
                "Ninh Thuận",
                "Phú Thọ",
                "Phú Yên",
                "Quảng Bình",
                "Quảng Nam",
                "Quảng Ngãi",
                "Quảng Ninh",
                "Quảng Trị",
                "Sóc Trăng",
                "Sơn La",
                "Tây Ninh",
                "Thái Bình",
                "Thái Nguyên",
                "Thanh Hóa",
                "Thừa Thiên Huế",
                "Tiền Giang",
                "Thành phố Hồ Chí Minh",
                "Trà Vinh",
                "Tuyên Quang",
                "Vĩnh Long",
                "Vĩnh Phúc",
                "Yên Bái"
            };
            foreach (var x in lstThanhPho)
            {
                cmb_ThanhPho.Items.Add(x);
            }
            cmb_ThanhPho.SelectedIndex = 0;
        }

        private void LoadQuocGia()
        {
            cmb_QuocGia.Items.Add("Việt Nam");
            cmb_QuocGia.SelectedIndex = 0;
        }

        private void dgrid_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Guid.Parse(dgrid_CuaHang.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iCuaHangService.getByGuid(_id);
            txt_MaCuaHang.Text = temp.Ma;
            txt_TenCuaHang.Text = temp.Ten;
            txt_DiaChi.Text = temp.DiaChi;
            cmb_ThanhPho.Text = temp.ThanhPho;
            cmb_QuocGia.Text = temp.QuocGia;
        }

        private QLNhanVienViewModel getCuaHangControl()
        {
            var ch = new CuaHang()
            {
                Id = Guid.Empty, Ma = txt_MaCuaHang.Text, Ten = txt_TenCuaHang.Text, DiaChi = txt_DiaChi.Text,
                ThanhPho = cmb_ThanhPho.Text, QuocGia = cmb_QuocGia.Text
            };
            return new QLNhanVienViewModel() { CuaHang = ch};
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            MessageBox.Show(_iCuaHangService.Add(getCuaHangControl()));
            LoadCuaHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getCuaHangControl();
            temp.CuaHang.Id = _id;
            MessageBox.Show(_iCuaHangService.Update(temp));
            LoadCuaHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getCuaHangControl();
            temp.CuaHang.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iCuaHangService.Delete(temp));
                LoadCuaHang();
            }
        }
    }
}
