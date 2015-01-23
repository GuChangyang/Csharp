namespace Close
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInfor = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lbeShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfor
            // 
            this.lblInfor.Location = new System.Drawing.Point(190, 70);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(218, 23);
            this.lblInfor.TabIndex = 0;
            this.lblInfor.Text = "您希望你的计算机做什么？";
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "关机",
            "待机",
            "睡眠"});
            this.cmbSelect.Location = new System.Drawing.Point(193, 96);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(249, 21);
            this.cmbSelect.TabIndex = 1;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // lbeShow
            // 
            this.lbeShow.Location = new System.Drawing.Point(190, 130);
            this.lbeShow.Name = "lbeShow";
            this.lbeShow.Size = new System.Drawing.Size(218, 23);
            this.lbeShow.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "帮助";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.lbeShow);
            this.Controls.Add(this.lblInfor);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "关闭Windows";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lbeShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

