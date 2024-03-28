using BUS.Services;
using DAL.DomainClass;

namespace PRL
{
    public partial class Form1 : Form
    {
        NhanvienService service;
        private string idWhenClick;
        public Form1()
        {
            InitializeComponent();
            service = new NhanvienService();
            LoadGrid();
            settingComboBox();
            rbtn_Nam.Checked = true;
        }

        private void LoadGrid()
        {
            //B1: đếm cột = số lượng tt của đối tượng
            dtgView.ColumnCount = 5;
            //B2: tên cột
            dtgView.Columns[0].Name = "Mã NV";
            dtgView.Columns[1].Name = "Họ Tên";
            dtgView.Columns[2].Name = "Ngày Sinh";
            dtgView.Columns[3].Name = "Giới Tính";
            dtgView.Columns[4].Name = "Địa Chỉ";
            //B3: clear row
            dtgView.Rows.Clear();
            //B4: Add dữ liệu vào mỗi dòng
            foreach (var nv in service.GetNhanViens())
            {
                dtgView.Rows.Add(nv.MaNv, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.Diachi);
            }
            //đừng quên ném hàm vào ctor để chạy
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNv = txt_MaNV.Text;
            nv.HoTen = txt_HoTen.Text;
            nv.Diachi = cmbx_DChi.Text;
            nv.NgaySinh = DateOnly.Parse(txt_NgSinh.Text);
            if (rbtn_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            MessageBox.Show(service.ThemNV(nv));
            //load lại grid để làm mới
            LoadGrid();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = "";
            txt_MaNV.Text = String.Empty;
            txt_NgSinh.Clear();
            rbtn_Nam.Checked = true;
            cmbx_DChi.SelectedIndex = 0;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(service.XoaNV(idWhenClick));
            LoadGrid();
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            //tìm cell chứa ID trên dòng đã bấm vào
            idWhenClick = dtgView.Rows[rowIndex].Cells[0].Value.ToString();
            BindData();
        }

        public void BindData()
        {
            var nv = service.GetNhanViens().Find(x => x.MaNv == idWhenClick);
            txt_MaNV.Text = nv.MaNv;
            txt_HoTen.Text = nv.HoTen;
            txt_NgSinh.Text = nv.NgaySinh.ToString();
            if (nv.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else
            {
                rbtn_Nu.Checked = true;
            }
            cmbx_DChi.Text = nv.Diachi;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            NhanVien nv = service.GetNhanViens().Find(x => x.MaNv == idWhenClick);
            nv.HoTen = txt_HoTen.Text;
            nv.Diachi = cmbx_DChi.Text;
            nv.NgaySinh = DateOnly.Parse(txt_NgSinh.Text);
            if (rbtn_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            MessageBox.Show(service.SuaNV(nv));
            LoadGrid();
        }

        public void settingComboBox()
        {
            cmbx_DChi.Items.Add("HN");
            cmbx_DChi.Items.Add("DN");
            cmbx_DChi.Items.Add("HP");
            cmbx_DChi.Items.Add("HCM");
            cmbx_DChi.SelectedIndex = 0;
            cmbx_DChi.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
