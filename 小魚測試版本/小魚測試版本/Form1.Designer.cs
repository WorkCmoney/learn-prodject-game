namespace 小魚測試版本
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play_box = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tail = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControl21 = new 小魚測試版本.UserControl2();
            this.introduction1 = new 小魚測試版本.Introduction();
            this.sorce1 = new 小魚測試版本.sorce();
            ((System.ComponentModel.ISupportInitialize)(this.play_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // play_box
            // 
            this.play_box.BackColor = System.Drawing.Color.Transparent;
            this.play_box.Image = ((System.Drawing.Image)(resources.GetObject("play_box.Image")));
            this.play_box.Location = new System.Drawing.Point(100, 215);
            this.play_box.Name = "play_box";
            this.play_box.Size = new System.Drawing.Size(108, 56);
            this.play_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_box.TabIndex = 0;
            this.play_box.TabStop = false;
            this.play_box.Click += new System.EventHandler(this.play);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(456, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.how_play);
            // 
            // tail
            // 
            this.tail.BackColor = System.Drawing.Color.Transparent;
            this.tail.Image = ((System.Drawing.Image)(resources.GetObject("tail.Image")));
            this.tail.Location = new System.Drawing.Point(133, 59);
            this.tail.Name = "tail";
            this.tail.Size = new System.Drawing.Size(561, 84);
            this.tail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tail.TabIndex = 2;
            this.tail.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(632, 215);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.exit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControl21
            // 
            this.userControl21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl21.BackgroundImage")));
            this.userControl21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl21.Location = new System.Drawing.Point(3, 2);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(833, 478);
            this.userControl21.TabIndex = 5;
            // 
            // introduction1
            // 
            this.introduction1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.introduction1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.introduction1.Location = new System.Drawing.Point(0, 0);
            this.introduction1.Name = "introduction1";
            this.introduction1.Size = new System.Drawing.Size(833, 478);
            this.introduction1.TabIndex = 6;
            // 
            // sorce1
            // 
            this.sorce1.BackColor = System.Drawing.Color.Transparent;
            this.sorce1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sorce1.BackgroundImage")));
            this.sorce1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sorce1.Location = new System.Drawing.Point(0, 0);
            this.sorce1.Name = "sorce1";
            this.sorce1.Size = new System.Drawing.Size(840, 480);
            this.sorce1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 478);
            this.Controls.Add(this.sorce1);
            this.Controls.Add(this.introduction1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.play_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.play_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox play_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox tail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private UserControl2 userControl21;
        private Introduction introduction1;
        private sorce sorce1;
    }
}

