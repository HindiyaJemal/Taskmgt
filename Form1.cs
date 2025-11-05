using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hamilton");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string title = txtTitle.Text;
            MessageBox.Show(title + " " + id);
            txtDescription.Text = "Button Add Clicked";
            txtID.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Kira");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hind");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kane");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spurs");
        }
    }
}