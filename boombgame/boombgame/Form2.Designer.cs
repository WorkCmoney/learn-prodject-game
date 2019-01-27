namespace boombgame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.PictureBox();
            this.lab_score = new System.Windows.Forms.Label();
            this.pic_hp = new System.Windows.Forms.PictureBox();
            this.bee1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boom1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.boom1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.point);
            this.panel1.Controls.Add(this.lab_score);
            this.panel1.Controls.Add(this.pic_hp);
            this.panel1.Controls.Add(this.bee1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Std", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(165)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(130, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "||";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(165)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(736, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // point
            // 
            this.point.Image = ((System.Drawing.Image)(resources.GetObject("point.Image")));
            this.point.Location = new System.Drawing.Point(63, 355);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(23, 26);
            this.point.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.point.TabIndex = 4;
            this.point.TabStop = false;
            // 
            // lab_score
            // 
            this.lab_score.AutoSize = true;
            this.lab_score.Font = new System.Drawing.Font("OCR A Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(165)))), ((int)(((byte)(87)))));
            this.lab_score.Location = new System.Drawing.Point(662, 33);
            this.lab_score.Name = "lab_score";
            this.lab_score.Size = new System.Drawing.Size(40, 35);
            this.lab_score.TabIndex = 3;
            this.lab_score.Text = "0";
            this.lab_score.Click += new System.EventHandler(this.lab_score_Click);
            // 
            // pic_hp
            // 
            this.pic_hp.Image = ((System.Drawing.Image)(resources.GetObject("pic_hp.Image")));
            this.pic_hp.Location = new System.Drawing.Point(23, 21);
            this.pic_hp.Name = "pic_hp";
            this.pic_hp.Size = new System.Drawing.Size(101, 42);
            this.pic_hp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hp.TabIndex = 2;
            this.pic_hp.TabStop = false;
            // 
            // bee1
            // 
            this.bee1.Image = ((System.Drawing.Image)(resources.GetObject("bee1.Image")));
            this.bee1.Location = new System.Drawing.Point(195, 216);
            this.bee1.Name = "bee1";
            this.bee1.Size = new System.Drawing.Size(54, 51);
            this.bee1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bee1.TabIndex = 1;
            this.bee1.TabStop = false;
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(522, 161);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(47, 59);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // boom1
            // 
            this.boom1.Image = ((System.Drawing.Image)(resources.GetObject("boom1.Image")));
            this.boom1.Location = new System.Drawing.Point(373, 194);
            this.boom1.Name = "boom1";
            this.boom1.Size = new System.Drawing.Size(34, 38);
            this.boom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boom1.TabIndex = 8;
            this.boom1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox bee1;
        private System.Windows.Forms.Label lab_score;
        private System.Windows.Forms.PictureBox pic_hp;
        private System.Windows.Forms.PictureBox point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox boom1;
    }
}