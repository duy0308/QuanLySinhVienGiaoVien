using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Common
{
    public class DataGridViewImageButtonUpdateCell : DataGridViewImageButtonCell
    {
        public override void LoadImages()
        {
            string a = Application.StartupPath;
            string b = Application.LocalUserAppDataPath;
            string c = Application.UserAppDataPath;
            string d = Application.CommonAppDataPath;

            _buttonImageNormal = Image.FromFile(Application.StartupPath + @"\garbage.png");
            _buttonImageDisabled = Image.FromFile(Application.StartupPath + @"\garbage.png");
            _buttonImageHot = Image.FromFile(Application.StartupPath + @"\garbage.png");

        }
    }
}
