namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_hasil = new System.Windows.Forms.TextBox();
            this.btnTambarh = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_kali = new System.Windows.Forms.Button();
            this.btn_bagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nilai B";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(72, 17);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 26);
            this.txt_a.TabIndex = 2;
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.Location = new System.Drawing.Point(72, 61);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 26);
            this.txt_b.TabIndex = 3;
            // 
            // txt_hasil
            // 
            this.txt_hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasil.Location = new System.Drawing.Point(72, 101);
            this.txt_hasil.Name = "txt_hasil";
            this.txt_hasil.Size = new System.Drawing.Size(100, 26);
            this.txt_hasil.TabIndex = 4;
            // 
            // btnTambarh
            // 
            this.btnTambarh.Location = new System.Drawing.Point(189, 13);
            this.btnTambarh.Name = "btnTambarh";
            this.btnTambarh.Size = new System.Drawing.Size(75, 23);
            this.btnTambarh.TabIndex = 5;
            this.btnTambarh.Text = "+";
            this.btnTambarh.UseVisualStyleBackColor = true;
            this.btnTambarh.Click += new System.EventHandler(this.btnTambarh_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Location = new System.Drawing.Point(188, 46);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(75, 23);
            this.btn_kurang.TabIndex = 6;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_kali
            // 
            this.btn_kali.Location = new System.Drawing.Point(189, 75);
            this.btn_kali.Name = "btn_kali";
            this.btn_kali.Size = new System.Drawing.Size(75, 23);
            this.btn_kali.TabIndex = 7;
            this.btn_kali.Text = "x";
            this.btn_kali.UseVisualStyleBackColor = true;
            this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
            // 
            // btn_bagi
            // 
            this.btn_bagi.Location = new System.Drawing.Point(188, 104);
            this.btn_bagi.Name = "btn_bagi";
            this.btn_bagi.Size = new System.Drawing.Size(75, 23);
            this.btn_bagi.TabIndex = 8;
            this.btn_bagi.Text = "/";
            this.btn_bagi.UseVisualStyleBackColor = true;
            this.btn_bagi.Click += new System.EventHandler(this.btn_bagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 153);
            this.Controls.Add(this.btn_bagi);
            this.Controls.Add(this.btn_kali);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btnTambarh);
            this.Controls.Add(this.txt_hasil);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_hasil;
        private System.Windows.Forms.Button btnTambarh;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_kali;
        private System.Windows.Forms.Button btn_bagi;
    }
}

