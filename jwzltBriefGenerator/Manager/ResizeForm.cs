using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jwzltBriefGenerator.Manager
{
    public partial class ResizeForm : Form
    {
        public string username = "操作者";
        public string filename = "";
        public int department;
        public string departmentName;
        DataTable dt;

        public ResizeForm()
        {
            InitializeComponent();
        }
    }
}
