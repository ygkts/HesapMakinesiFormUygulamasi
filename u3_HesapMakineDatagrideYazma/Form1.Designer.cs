namespace u3_HesapMakineDatagrideYazma
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
            this.comboBoxIslemTipi = new System.Windows.Forms.ComboBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIslemTipi
            // 
            this.comboBoxIslemTipi.FormattingEnabled = true;
            this.comboBoxIslemTipi.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "K"});
            this.comboBoxIslemTipi.Location = new System.Drawing.Point(169, 60);
            this.comboBoxIslemTipi.Name = "comboBoxIslemTipi";
            this.comboBoxIslemTipi.Size = new System.Drawing.Size(81, 24);
            this.comboBoxIslemTipi.TabIndex = 0;
            this.comboBoxIslemTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxIslemTipi_SelectedIndexChanged);
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(27, 62);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(100, 22);
            this.txtS1.TabIndex = 1;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(292, 62);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(100, 22);
            this.txtS2.TabIndex = 1;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(562, 60);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 22);
            this.txtSonuc.TabIndex = 1;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(424, 60);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(94, 24);
            this.btnSonuc.TabIndex = 2;
            this.btnSonuc.Text = "=";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 180);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "İşlem Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sayı 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sonuç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geçmiş İşlemler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.comboBoxIslemTipi);
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIslemTipi;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

