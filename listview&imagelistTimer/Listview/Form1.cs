﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQQ.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQQ.View = View.SmallIcon;
        }

        private void 详细视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQQ.View = View.Details;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQQ.View = View.List;
        }

        private void 抬头ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQQ.View = View.Tile;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
