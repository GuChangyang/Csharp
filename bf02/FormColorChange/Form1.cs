using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormColorChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
