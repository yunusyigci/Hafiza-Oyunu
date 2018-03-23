namespace hafıza_oyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bir_oyuncu = new System.Windows.Forms.Label();
            this.iki_oyuncu = new System.Windows.Forms.Label();
            this.sıra1 = new System.Windows.Forms.Label();
            this.sıra2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.süre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(776, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Oyun";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1140, 566);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(54, 36);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1080, 566);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(51, 36);
            this.listBox2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(893, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birinci Oyuncunun Puanı:    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(893, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "İkinci Oyuncunun Puanı :    ";
            // 
            // bir_oyuncu
            // 
            this.bir_oyuncu.AutoSize = true;
            this.bir_oyuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bir_oyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bir_oyuncu.ForeColor = System.Drawing.Color.Black;
            this.bir_oyuncu.Location = new System.Drawing.Point(1130, 116);
            this.bir_oyuncu.Name = "bir_oyuncu";
            this.bir_oyuncu.Size = new System.Drawing.Size(36, 39);
            this.bir_oyuncu.TabIndex = 4;
            this.bir_oyuncu.Text = "0";
            // 
            // iki_oyuncu
            // 
            this.iki_oyuncu.AutoSize = true;
            this.iki_oyuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iki_oyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iki_oyuncu.ForeColor = System.Drawing.Color.Black;
            this.iki_oyuncu.Location = new System.Drawing.Point(1130, 66);
            this.iki_oyuncu.Name = "iki_oyuncu";
            this.iki_oyuncu.Size = new System.Drawing.Size(36, 39);
            this.iki_oyuncu.TabIndex = 4;
            this.iki_oyuncu.Text = "0";
            // 
            // sıra1
            // 
            this.sıra1.AutoSize = true;
            this.sıra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sıra1.Cursor = System.Windows.Forms.Cursors.No;
            this.sıra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sıra1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sıra1.Location = new System.Drawing.Point(752, 74);
            this.sıra1.Name = "sıra1";
            this.sıra1.Size = new System.Drawing.Size(0, 25);
            this.sıra1.TabIndex = 5;
            // 
            // sıra2
            // 
            this.sıra2.AutoSize = true;
            this.sıra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sıra2.Cursor = System.Windows.Forms.Cursors.No;
            this.sıra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sıra2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sıra2.Location = new System.Drawing.Point(752, 127);
            this.sıra2.Name = "sıra2";
            this.sıra2.Size = new System.Drawing.Size(0, 25);
            this.sıra2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(958, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kala Süre : ";
            // 
            // süre
            // 
            this.süre.AutoSize = true;
            this.süre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.süre.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.süre.ForeColor = System.Drawing.Color.Black;
            this.süre.Location = new System.Drawing.Point(1079, 256);
            this.süre.Name = "süre";
            this.süre.Size = new System.Drawing.Size(87, 95);
            this.süre.TabIndex = 6;
            this.süre.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 595);
            this.Controls.Add(this.süre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sıra2);
            this.Controls.Add(this.sıra1);
            this.Controls.Add(this.iki_oyuncu);
            this.Controls.Add(this.bir_oyuncu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bir_oyuncu;
        private System.Windows.Forms.Label iki_oyuncu;
        private System.Windows.Forms.Label sıra1;
        private System.Windows.Forms.Label sıra2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label süre;
        private System.Windows.Forms.Button button1;
    }
}

