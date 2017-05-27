using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.HelperClass
{
    class SupperTabControl : TabControl
    {
        private Point _lastClickPos;
        private ContextMenuStrip _CMS;
        public SupperTabControl()
        {
            _CMS = GetCMS();
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

        private ContextMenuStrip GetCMS()
        {
            ContextMenuStrip CMS = new ContextMenuStrip();
            CMS.Items.Add("Close", null, new EventHandler(Item_Clicked));
            return CMS;
        }
        private void Item_Clicked(Object sender, EventArgs e)
        {
            for (int i = 0; i < this.TabCount; i++)
            {
                Rectangle rec = this.GetTabRect(i);
                if (rec.Contains(this.PointToClient(_lastClickPos)))
                {
                    this.TabPages.RemoveAt(i);
                }
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                _lastClickPos = Cursor.Position;
                _CMS.Show(Cursor.Position);
            }
        }
    }
}
