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
using _2._BUS.Service;
using _2._BUS.ViewModels;

namespace _3._PL
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangService _iKhachHangService;
        private List<string> lstThanhPho;
        private Guid _id;
        public FrmKhachHang()
        {
            InitializeComponent();
            _iKhachHangService = new KhachHangService();
            List<string> lstThanhPho = new List<string>();
            LoadKhachHang();
            LoadThanhPho();
            LoadQuocGia();
        }
        private void LoadKhachHang()
        {
            int stt = 1;
            dgrid_KhachHang.ColumnCount = 9;
            dgrid_KhachHang.Columns[0].Name = "STT";
            dgrid_KhachHang.Columns[1].Name = "ID";
            dgrid_KhachHang.Columns[2].Name = "Tên NV";
            dgrid_KhachHang.Columns[3].Name = "Ngày Sinh";
            dgrid_KhachHang.Columns[4].Name = "Địa Chỉ";
            dgrid_KhachHang.Columns[5].Name = "SDT";
            dgrid_KhachHang.Columns[6].Name = "Mật Khẩu";
            dgrid_KhachHang.Columns[7].Name = "Thành Phố";
            dgrid_KhachHang.Columns[8].Name = "Quốc Gia";
            dgrid_KhachHang.Rows.Clear();
            dgrid_KhachHang.Columns[1].Visible = false;
            foreach (var x in _iKhachHangService.GetAll())
            {
                dgrid_KhachHang.Rows.Add(stt++, x.Id, $"{x.Ho} {x.TenDem} {x.Ten}", x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.ThanhPho, x.QuocGia);
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
            _id = Guid.Parse(dgrid_KhachHang.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iKhachHangService.getByGuid(_id);
            txt_MaKH.Text = temp.Ma;
            txt_TenKH.Text = temp.Ten;
            txt_TenDemKH.Text = temp.TenDem;
            txt_HoKH.Text = temp.Ho;
            DT_NgaySinh.Value = (DateTime)temp.NgaySinh;
            txt_DiaChi.Text = temp.DiaChi;
            txt_SDT.Text = temp.Sdt;
            txt_Pass.Text = temp.MatKhau;
            cmb_ThanhPho.Text = temp.ThanhPho;
            cmb_QuocGia.Text = temp.QuocGia;
        }
        private KhachHangViewModel getNhanVienControl()
        {
            return new KhachHangViewModel()
            {
                Id = Guid.Empty, Ma = txt_MaKH.Text, Ten = txt_TenKH.Text, TenDem = txt_TenDemKH.Text, Ho = txt_HoKH.Text, NgaySinh = DT_NgaySinh.Value, DiaChi = txt_DiaChi.Text, Sdt = txt_SDT.Text, MatKhau = txt_Pass.Text, ThanhPho = cmb_ThanhPho.Text, QuocGia = cmb_QuocGia.Text
            };
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iKhachHangService.Add(getNhanVienControl()));
            LoadKhachHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getNhanVienControl();
            temp.Id = _id;
            MessageBox.Show(_iKhachHangService.Update(temp));
            LoadKhachHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getNhanVienControl();
            temp.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iKhachHangService.Delete(temp));
                LoadKhachHang();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = null;
            txt_TenKH.Text = null;
            txt_TenDemKH.Text = null;
            txt_HoKH.Text = null;
            DT_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = null;
            txt_SDT.Text = null;
            txt_Pass.Text = null;
            cmb_ThanhPho.SelectedIndex = 0;
            cmb_QuocGia.SelectedIndex = 0;
        }
    }
}
