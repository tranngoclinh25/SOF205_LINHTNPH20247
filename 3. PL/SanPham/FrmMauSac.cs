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
using _2._BUS.IService.SanPham;
using _2._BUS.Service;
using _2._BUS.Service.SanPham;
using _2._BUS.ViewModels;

namespace _3._PL.SanPham
{
    public partial class FrmMauSac : Form
    {
        private IMauSacService _iMauSacService;
        private Guid _id;
        public FrmMauSac()
        {
            InitializeComponent();
            _iMauSacService = new MauSacService();
            LoadMauSac();
        }

        private void LoadMauSac()
        {
            int stt = 1;
            dgrid_MauSac.ColumnCount = 4;
            dgrid_MauSac.Columns[0].Name = "STT";
            dgrid_MauSac.Columns[1].Name = "ID";
            dgrid_MauSac.Columns[2].Name = "Mã Dòng SP";
            dgrid_MauSac.Columns[3].Name = "Tên Dòng SP";
            dgrid_MauSac.Rows.Clear();
            dgrid_MauSac.Columns[1].Visible = false;
            foreach (var ms in _iMauSacService.GetAll())
            {
                dgrid_MauSac.Rows.Add(stt++, ms.IdMs, ms.MaMs, ms.TenMs);
            }
        }

        private void dgrid_MauSac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Guid.Parse(dgrid_MauSac.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iMauSacService.getByGuid(_id);
            txt_MaMS.Text = temp.Ma;
            txt_TenMS.Text = temp.Ten;
        }

        private QLSanPhamViewModel getMauSacControl()
        {
            return new QLSanPhamViewModel()
            {
                IdMs = Guid.Empty,
                MaMs = txt_MaMS.Text,
                TenMs = txt_TenMS.Text
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iMauSacService.Add(getMauSacControl()));
            LoadMauSac();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getMauSacControl();
            temp.IdMs = _id;
            MessageBox.Show(_iMauSacService.Update(temp));
            LoadMauSac();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getMauSacControl();
            temp.IdMs = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iMauSacService.Delete(temp));
                LoadMauSac();
            }
        }
    }
}
