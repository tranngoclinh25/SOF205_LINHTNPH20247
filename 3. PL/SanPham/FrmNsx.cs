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

namespace _3._PL
{
    public partial class FrmNsx : Form
    {
        private INsxService _iNsxService;
        private Guid _id;
        public FrmNsx()
        {
            InitializeComponent();
            _iNsxService = new NsxService();
            LoadNsx();
        }

        private void LoadNsx()
        {
            int stt = 1;
            dgrid_NSX.ColumnCount = 4;
            dgrid_NSX.Columns[0].Name = "STT";
            dgrid_NSX.Columns[1].Name = "ID";
            dgrid_NSX.Columns[2].Name = "Mã NSX";
            dgrid_NSX.Columns[3].Name = "Tên NSX";
            dgrid_NSX.Rows.Clear();
            dgrid_NSX.Columns[1].Visible = false;
            foreach (var nsx in _iNsxService.GetAll())
            {
                dgrid_NSX.Rows.Add(stt++, nsx.IdNsx, nsx.MaNsx, nsx.TenNsx);
            }
        }

        private void dgrid_NSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            _id = Guid.Parse(dgrid_NSX.Rows[indexrow].Cells[1].Value.ToString());
            var temp = _iNsxService.getByGuid(_id);
            txt_MaNSX.Text = temp.Ma;
            txt_TenNSX.Text = temp.Ten;
        }

        private QLSanPhamViewModel getNsxControl()
        {
            return new QLSanPhamViewModel()
            {
                IdNsx = Guid.Empty,
                MaNsx = txt_MaNSX.Text,
                TenNsx = txt_TenNSX.Text
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iNsxService.Add(getNsxControl()));
            LoadNsx();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getNsxControl();
            temp.IdNsx = _id;
            MessageBox.Show(_iNsxService.Update(temp));
            LoadNsx();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getNsxControl();
            temp.IdNsx = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iNsxService.Delete(temp));
                LoadNsx();
            }
        }
    }
}
