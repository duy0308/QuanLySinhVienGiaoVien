using QLNS.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_GV
{
    public partial class frmMain : Form
    {
        DanhMuc.HocSinh.DanhSachHocSinh dshs;
        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private void addNewTab(string strTabName, UserControl ucContent)
        {
            foreach (TabPage tabpage in tabControl.TabPages)
            {
                if (tabpage.Text == strTabName)
                {
                    tabControl.SelectedTab = tabpage;
                    return;
                }
            }
            SupperTabControl newTabPanel = new SupperTabControl();
            TabPage newTabPage = new TabPage();
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = strTabName;
            newTabPanel.Size = new System.Drawing.Size(tabControl.Width, tabControl.Height);
            newTabPanel.TabIndex = 2;
            newTabPanel.Tag = newTabPage;

            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22324);
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(ucContent);

            tabControl.TabPages.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;
        }
        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dshs = new DanhMuc.HocSinh.DanhSachHocSinh();
            addNewTab("Danh sách bộ phận", dshs);

        }
    }
}
