namespace indirim_satiş
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnOdencek = new System.Windows.Forms.Button();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb40);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb30);
            this.groupBox1.Controls.Add(this.rb0);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Seçin";
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb0.Location = new System.Drawing.Point(7, 38);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(102, 20);
            this.rb0.TabIndex = 0;
            this.rb0.TabStop = true;
            this.rb0.Text = "İndirim Yok";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb30.Location = new System.Drawing.Point(7, 93);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(104, 20);
            this.rb30.TabIndex = 1;
            this.rb30.TabStop = true;
            this.rb30.Text = "%30 İndirim";
            this.rb30.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb5.Location = new System.Drawing.Point(7, 64);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(96, 20);
            this.rb5.TabIndex = 2;
            this.rb5.TabStop = true;
            this.rb5.Text = "%5 İndirim";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb40.Location = new System.Drawing.Point(9, 119);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(104, 20);
            this.rb40.TabIndex = 3;
            this.rb40.TabStop = true;
            this.rb40.Text = "%40 İndirim";
            this.rb40.UseVisualStyleBackColor = true;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(222, 52);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(77, 16);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyat Girin";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(315, 49);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // btnOdencek
            // 
            this.btnOdencek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdencek.Location = new System.Drawing.Point(315, 85);
            this.btnOdencek.Name = "btnOdencek";
            this.btnOdencek.Size = new System.Drawing.Size(100, 40);
            this.btnOdencek.TabIndex = 3;
            this.btnOdencek.Text = "Ödenecek Tutar";
            this.btnOdencek.UseVisualStyleBackColor = true;
            this.btnOdencek.Click += new System.EventHandler(this.btnOdencek_Click);
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecek.Location = new System.Drawing.Point(312, 135);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(78, 16);
            this.lblOdenecek.TabIndex = 4;
            this.lblOdenecek.Text = "Ödenecek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 339);
            this.Controls.Add(this.lblOdenecek);
            this.Controls.Add(this.btnOdencek);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnOdencek;
        private System.Windows.Forms.Label lblOdenecek;
    }
}

