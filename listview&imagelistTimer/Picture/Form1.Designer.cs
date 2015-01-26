namespace Picture
{
    partial class frm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.iLHead = new System.Windows.Forms.ImageList(this.components);
            this.btnLeft = new System.Windows.Forms.Button();
            this.btbRight = new System.Windows.Forms.Button();
            this.btnStartEnd = new System.Windows.Forms.Button();
            this.tmC = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb1
            // 
            this.ptb1.Location = new System.Drawing.Point(66, 46);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(303, 151);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = false;
            // 
            // iLHead
            // 
            this.iLHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLHead.ImageStream")));
            this.iLHead.TransparentColor = System.Drawing.Color.Transparent;
            this.iLHead.Images.SetKeyName(0, "01.jpg");
            this.iLHead.Images.SetKeyName(1, "02.jpg");
            this.iLHead.Images.SetKeyName(2, "03.jpg");
            this.iLHead.Images.SetKeyName(3, "04.jpg");
            this.iLHead.Images.SetKeyName(4, "05.jpg");
            this.iLHead.Images.SetKeyName(5, "06.jpg");
            this.iLHead.Images.SetKeyName(6, "07.jpg");
            this.iLHead.Images.SetKeyName(7, "08.jpg");
            this.iLHead.Images.SetKeyName(8, "09.jpg");
            this.iLHead.Images.SetKeyName(9, "10.jpg");
            this.iLHead.Images.SetKeyName(10, "11.jpg");
            this.iLHead.Images.SetKeyName(11, "12.jpg");
            this.iLHead.Images.SetKeyName(12, "13.jpg");
            this.iLHead.Images.SetKeyName(13, "14.jpg");
            this.iLHead.Images.SetKeyName(14, "15.jpg");
            this.iLHead.Images.SetKeyName(15, "16.jpg");
            this.iLHead.Images.SetKeyName(16, "17.jpg");
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(76, 271);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<<<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btbRight
            // 
            this.btbRight.Location = new System.Drawing.Point(180, 271);
            this.btbRight.Name = "btbRight";
            this.btbRight.Size = new System.Drawing.Size(75, 23);
            this.btbRight.TabIndex = 1;
            this.btbRight.Text = ">>>>";
            this.btbRight.UseVisualStyleBackColor = true;
            this.btbRight.Click += new System.EventHandler(this.btbRight_Click);
            // 
            // btnStartEnd
            // 
            this.btnStartEnd.Location = new System.Drawing.Point(294, 271);
            this.btnStartEnd.Name = "btnStartEnd";
            this.btnStartEnd.Size = new System.Drawing.Size(75, 23);
            this.btnStartEnd.TabIndex = 1;
            this.btnStartEnd.Text = "开始或停止";
            this.btnStartEnd.UseVisualStyleBackColor = true;
            this.btnStartEnd.Click += new System.EventHandler(this.btnStartEnd_Click);
            // 
            // tmC
            // 
            this.tmC.Interval = 1000;
            this.tmC.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 351);
            this.Controls.Add(this.btnStartEnd);
            this.Controls.Add(this.btbRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.ptb1);
            this.MaximizeBox = false;
            this.Name = "frm1";
            this.Text = "我的图片浏览器";
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.ImageList iLHead;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btbRight;
        private System.Windows.Forms.Button btnStartEnd;
        private System.Windows.Forms.Timer tmC;
    }
}

