using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apart
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Apartments apartments = new Apartments();

            apartments.Show();
            //this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form2 ap = new Form2();
            ap.Show();
            //this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ImageSlider imageSlider = new ImageSlider();
            imageSlider.Show();
            //this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DeptList deptList = new DeptList();
            deptList.Show();
            //this.Hide();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I made an apartment system app using devexpress. I will share pictures of information about how the system works on Github.");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
