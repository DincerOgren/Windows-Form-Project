namespace Projeee
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obosaltButton = new System.Windows.Forms.Button();
            this.opBar = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.organikButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kbosaltButton = new System.Windows.Forms.Button();
            this.kpBar = new System.Windows.Forms.ProgressBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.kagıtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbosaltButton = new System.Windows.Forms.Button();
            this.cpBar = new System.Windows.Forms.ProgressBar();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.camButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mbosaltButton = new System.Windows.Forms.Button();
            this.mpBar = new System.Windows.Forms.ProgressBar();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.metalButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelblel = new System.Windows.Forms.Label();
            this.puanLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.obosaltButton);
            this.groupBox1.Controls.Add(this.opBar);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.organikButton);
            this.groupBox1.Location = new System.Drawing.Point(340, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // obosaltButton
            // 
            this.obosaltButton.Enabled = false;
            this.obosaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.obosaltButton.Location = new System.Drawing.Point(18, 260);
            this.obosaltButton.Name = "obosaltButton";
            this.obosaltButton.Size = new System.Drawing.Size(146, 34);
            this.obosaltButton.TabIndex = 3;
            this.obosaltButton.Text = "BOŞALT";
            this.obosaltButton.UseVisualStyleBackColor = true;
            this.obosaltButton.Click += new System.EventHandler(this.obosaltButton_Click);
            // 
            // opBar
            // 
            this.opBar.Location = new System.Drawing.Point(18, 233);
            this.opBar.Maximum = 700;
            this.opBar.Name = "opBar";
            this.opBar.Size = new System.Drawing.Size(146, 23);
            this.opBar.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(146, 180);
            this.listBox1.TabIndex = 1;
            // 
            // organikButton
            // 
            this.organikButton.Enabled = false;
            this.organikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikButton.Location = new System.Drawing.Point(18, 12);
            this.organikButton.Name = "organikButton";
            this.organikButton.Size = new System.Drawing.Size(146, 34);
            this.organikButton.TabIndex = 0;
            this.organikButton.Text = "ORGANİK ATIK";
            this.organikButton.UseVisualStyleBackColor = true;
            this.organikButton.Click += new System.EventHandler(this.organikButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox2.Controls.Add(this.kbosaltButton);
            this.groupBox2.Controls.Add(this.kpBar);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.kagıtButton);
            this.groupBox2.Location = new System.Drawing.Point(527, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 301);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // kbosaltButton
            // 
            this.kbosaltButton.Enabled = false;
            this.kbosaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kbosaltButton.Location = new System.Drawing.Point(18, 261);
            this.kbosaltButton.Name = "kbosaltButton";
            this.kbosaltButton.Size = new System.Drawing.Size(146, 34);
            this.kbosaltButton.TabIndex = 3;
            this.kbosaltButton.Text = "BOŞALT";
            this.kbosaltButton.UseVisualStyleBackColor = true;
            this.kbosaltButton.Click += new System.EventHandler(this.kbosaltButton_Click);
            // 
            // kpBar
            // 
            this.kpBar.Location = new System.Drawing.Point(18, 233);
            this.kpBar.Maximum = 1200;
            this.kpBar.Name = "kpBar";
            this.kpBar.Size = new System.Drawing.Size(146, 23);
            this.kpBar.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(18, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(146, 180);
            this.listBox2.TabIndex = 1;
            // 
            // kagıtButton
            // 
            this.kagıtButton.Enabled = false;
            this.kagıtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagıtButton.Location = new System.Drawing.Point(18, 12);
            this.kagıtButton.Name = "kagıtButton";
            this.kagıtButton.Size = new System.Drawing.Size(146, 34);
            this.kagıtButton.TabIndex = 0;
            this.kagıtButton.Text = "KAĞIT ATIK";
            this.kagıtButton.UseVisualStyleBackColor = true;
            this.kagıtButton.Click += new System.EventHandler(this.kagıtButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(340, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox3.Controls.Add(this.cbosaltButton);
            this.groupBox3.Controls.Add(this.cpBar);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.camButton);
            this.groupBox3.Location = new System.Drawing.Point(340, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 300);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // cbosaltButton
            // 
            this.cbosaltButton.Enabled = false;
            this.cbosaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbosaltButton.Location = new System.Drawing.Point(18, 260);
            this.cbosaltButton.Name = "cbosaltButton";
            this.cbosaltButton.Size = new System.Drawing.Size(146, 34);
            this.cbosaltButton.TabIndex = 3;
            this.cbosaltButton.Text = "BOŞALT";
            this.cbosaltButton.UseVisualStyleBackColor = true;
            this.cbosaltButton.Click += new System.EventHandler(this.cbosaltButton_Click);
            // 
            // cpBar
            // 
            this.cpBar.Location = new System.Drawing.Point(18, 233);
            this.cpBar.Maximum = 2200;
            this.cpBar.Name = "cpBar";
            this.cpBar.Size = new System.Drawing.Size(146, 23);
            this.cpBar.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(18, 49);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(146, 180);
            this.listBox3.TabIndex = 1;
            // 
            // camButton
            // 
            this.camButton.Enabled = false;
            this.camButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camButton.Location = new System.Drawing.Point(18, 12);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(146, 34);
            this.camButton.TabIndex = 0;
            this.camButton.Text = "CAM";
            this.camButton.UseVisualStyleBackColor = true;
            this.camButton.Click += new System.EventHandler(this.camButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox4.Controls.Add(this.mbosaltButton);
            this.groupBox4.Controls.Add(this.mpBar);
            this.groupBox4.Controls.Add(this.listBox4);
            this.groupBox4.Controls.Add(this.metalButton);
            this.groupBox4.Location = new System.Drawing.Point(527, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 300);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // mbosaltButton
            // 
            this.mbosaltButton.Enabled = false;
            this.mbosaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mbosaltButton.Location = new System.Drawing.Point(18, 260);
            this.mbosaltButton.Name = "mbosaltButton";
            this.mbosaltButton.Size = new System.Drawing.Size(146, 34);
            this.mbosaltButton.TabIndex = 3;
            this.mbosaltButton.Text = "BOŞALT";
            this.mbosaltButton.UseVisualStyleBackColor = true;
            this.mbosaltButton.Click += new System.EventHandler(this.mbosaltButton_Click);
            // 
            // mpBar
            // 
            this.mpBar.Location = new System.Drawing.Point(18, 233);
            this.mpBar.Maximum = 2300;
            this.mpBar.Name = "mpBar";
            this.mpBar.Size = new System.Drawing.Size(146, 23);
            this.mpBar.TabIndex = 2;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(18, 49);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(146, 180);
            this.listBox4.TabIndex = 1;
            // 
            // metalButton
            // 
            this.metalButton.Enabled = false;
            this.metalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalButton.Location = new System.Drawing.Point(18, 12);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(146, 34);
            this.metalButton.TabIndex = 0;
            this.metalButton.Text = "METAL";
            this.metalButton.UseVisualStyleBackColor = true;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 235);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Location = new System.Drawing.Point(30, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.labelblel);
            this.groupBox6.Controls.Add(this.puanLabel);
            this.groupBox6.Controls.Add(this.sureLabel);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Controls.Add(this.button9);
            this.groupBox6.Location = new System.Drawing.Point(12, 253);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 412);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(71, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "PUAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelblel
            // 
            this.labelblel.BackColor = System.Drawing.Color.Peru;
            this.labelblel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelblel.Location = new System.Drawing.Point(71, 107);
            this.labelblel.Name = "labelblel";
            this.labelblel.Size = new System.Drawing.Size(167, 33);
            this.labelblel.TabIndex = 4;
            this.labelblel.Text = "SÜRE";
            this.labelblel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puanLabel
            // 
            this.puanLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.puanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.Location = new System.Drawing.Point(71, 257);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(167, 66);
            this.puanLabel.TabIndex = 3;
            this.puanLabel.Text = "0";
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sureLabel
            // 
            this.sureLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.Location = new System.Drawing.Point(71, 140);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(167, 66);
            this.sureLabel.TabIndex = 2;
            this.sureLabel.Text = "60";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(43, 339);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 48);
            this.button10.TabIndex = 1;
            this.button10.Text = "ÇIKIŞ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(43, 33);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 67);
            this.button9.TabIndex = 0;
            this.button9.Text = "YENİ OYUN";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(722, 680);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obosaltButton;
        private System.Windows.Forms.ProgressBar opBar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button organikButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kbosaltButton;
        private System.Windows.Forms.ProgressBar kpBar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button kagıtButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cbosaltButton;
        private System.Windows.Forms.ProgressBar cpBar;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button camButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button mbosaltButton;
        private System.Windows.Forms.ProgressBar mpBar;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelblel;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

