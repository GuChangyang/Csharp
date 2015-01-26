using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class frm1 : Form
    {
        int index = 0;
        public frm1()
        {
            InitializeComponent();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            //切换图片在pb里
            ChangeImage();
        }
       
        private void ChangeImage()
        {
            if (index < iLHead.Images.Count)
            {
                ptb1.Image = iLHead.Images[index];
                index++;
            }
            else
            {
                index = 0;
            }
        }

        private void btnStartEnd_Click(object sender, EventArgs e)
        {
            if (tmC.Enabled == false)
                tmC.Start();
            else
                tmC.Stop();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;
                ptb1.Image = iLHead.Images[index];
            }
            else
                ptb1.Image = iLHead.Images[index];

        }

        private void btbRight_Click(object sender, EventArgs e)
        {
            if (index != 16)
            {
                index++;
                ptb1.Image = iLHead.Images[index];
            }
            else
                ptb1.Image = iLHead.Images[index];

        }
    }
}
