using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnfilm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click", "Film");
        }
    }
}
