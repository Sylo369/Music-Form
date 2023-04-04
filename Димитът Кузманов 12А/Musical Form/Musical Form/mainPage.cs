using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musical_Form
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            var rockForm = new rockForm();
            rockForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void popButton_Click(object sender, EventArgs e)
        {
            var popForm = new popForm();
            popForm.Show();
            
        }

        private void jazzButton_Click(object sender, EventArgs e)
        {
            var jazzForm = new jazzForm();
            jazzForm.Show();
        }

        private void hiphopButton_Click(object sender, EventArgs e)
        {
            var hiphopForm = new hiphopForm();
            hiphopForm.Show();
        }

        private void metalButton_Click(object sender, EventArgs e)
        {
            var metalForm = new metalForm();
            metalForm.Show();
        }
    }
}
