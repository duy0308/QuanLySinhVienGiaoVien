using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.HelperClass
{
    public class winform :  Form
    {
        public Object Obj { get; set; }
        public List<string> TitleCol;
        public DataGridView dt;
        public void Set<T>(List<string> _TitleCol) where T : new()
        {
            Obj = new T();
            TitleCol = _TitleCol;
        }
        public DataGridView CreateGrid<T>(List<T> objT) where T : new()
        {
            dt = new DataGridView();
            try
            {
                PropertyInfo[] pi = objT[0].GetType().GetProperties();
                for (int i = 0; i < pi.GetLength(0); i++)
                {
                    dt.Columns.Add(pi[i].ToString(), TitleCol[i]);
                }
            }
            catch (StackOverflowException ex)
            {
                T obj = new T();
                PropertyInfo[] pi = obj.GetType().GetProperties();
                for (int i = 0; i < TitleCol.Count; i++)
                {
                    dt.Columns.Add(pi[i].ToString(), TitleCol[i]);
                }
                    MessageBox.Show("Không có dữ liệu");
            }
            catch (Exception ex)
            {
                T obj = new T();
                PropertyInfo[] pi = obj.GetType().GetProperties();
                for (int i = 0; i < TitleCol.Count; i++)
                {
                    dt.Columns.Add(pi[i].ToString(), TitleCol[i]);
                }
                MessageBox.Show("Có cột không có tên");
            }
            return dt;
        }
        public winform(): base()
        {

        }
    }
}
