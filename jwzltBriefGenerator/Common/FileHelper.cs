using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jwzltBriefGenerator
{
    class FileHelper
    {
        public static string OpenFileDialog(string title = "请选择文件", string filter = "所有文件(*.*)|*.*", bool multiselect = false)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = multiselect;//该值确定是否可以选择多个文件
            dialog.Title = title;
            dialog.Filter = filter;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public static string SaveFileDialog(string filter = "xlsx|*.xlsx", string title = "保存到")
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = title;
            sfd.Filter = filter;
            sfd.ShowDialog();
            return sfd.FileName;
        }
    }
}
