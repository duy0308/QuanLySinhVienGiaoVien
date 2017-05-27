using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLNS.Common
{
    public class DataGridViewImageButtonSaveCell : DataGridViewImageButtonCell
    {
        public override void LoadImages()
        {
            _buttonImageNormal = Image.FromFile(Application.StartupPath + @"\edit.png");
            _buttonImageDisabled = Image.FromFile(Application.StartupPath + @"\edit.png");
            _buttonImageHot = Image.FromFile(Application.StartupPath + @"\edit.png");

        }
    }
}