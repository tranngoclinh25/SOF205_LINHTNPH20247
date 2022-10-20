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
using _2._BUS.IService.NhanVien;
using _2._BUS.Service.NhanVien;
using _2._BUS.ViewModels;

namespace _3._PL.NhanVien
{
    public partial class FrmChucVu : Form
    {
        private IChucVuService _iChucVuService;
        private Guid _id;
        public FrmChucVu()
        {
            InitializeComponent();
            _iChucVuService = new ChucVuService();
            LoadChucVu();
        }
        private void LoadChucVu()
        {
            int stt = 1;
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = "STT";
            dgrid_ChucVu.Columns[1].Name = "ID";
            dgrid_ChucVu.Columns[2].Name = "Mã Chức Vụ";
            dgrid_ChucVu.Columns[3].Name = "Tên Chức Vụ";
            dgrid_ChucVu.Rows.Clear();
            dgrid_ChucVu.Columns[1].Visible = false;
            foreach (var cv in _iChucVuService.GetAll())
            {
                dgrid_ChucVu.Rows.Add(stt++, cv.IdCv, cv.MaCv, cv.TenCv);
            }
        }
        private void dgrid_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Guid.Parse(dgrid_ChucVu.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iChucVuService.getByGuid(_id);
            txt_MaChucVu.Text = temp.Ma;
            txt_TenChucVu.Text = temp.Ten;
        }
        private QLNhanVienViewModel getDongSpControl()
        {
            return new QLNhanVienViewModel()
            {
                IdCv = Guid.Empty,
                MaCv = txt_MaChucVu.Text,
                TenCv = txt_TenChucVu.Text,
            };
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iChucVuService.Add(getDongSpControl()));
            LoadChucVu();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getDongSpControl();
            temp.IdCv = _id;
            MessageBox.Show(_iChucVuService.Update(temp));
            LoadChucVu();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getDongSpControl();
            temp.IdCv = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iChucVuService.Delete(temp));
                LoadChucVu();
            }
        }
    }
}
