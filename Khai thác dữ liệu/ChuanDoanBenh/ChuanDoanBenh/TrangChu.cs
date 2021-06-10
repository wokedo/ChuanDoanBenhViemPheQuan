using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanBenh
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            DuLieu dl = new DuLieu();
            dl.Show();
        }

    }
}
