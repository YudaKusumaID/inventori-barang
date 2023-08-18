namespace Kasir
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtb_jumlah = new TextBox();
            txtb_harga = new TextBox();
            txtb_nama = new TextBox();
            txtb_kode = new TextBox();
            Update = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 150);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 17;
            label4.Text = "JUMLAH:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 110);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 16;
            label3.Text = "HARGA:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 71);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 15;
            label2.Text = "NAMA:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 9;
            label1.Text = "KODE:";
            // 
            // txtb_jumlah
            // 
            txtb_jumlah.Location = new Point(82, 150);
            txtb_jumlah.Name = "txtb_jumlah";
            txtb_jumlah.Size = new Size(63, 23);
            txtb_jumlah.TabIndex = 14;
            // 
            // txtb_harga
            // 
            txtb_harga.Location = new Point(82, 110);
            txtb_harga.Name = "txtb_harga";
            txtb_harga.Size = new Size(116, 23);
            txtb_harga.TabIndex = 13;
            // 
            // txtb_nama
            // 
            txtb_nama.Location = new Point(82, 68);
            txtb_nama.Name = "txtb_nama";
            txtb_nama.Size = new Size(193, 23);
            txtb_nama.TabIndex = 12;
            // 
            // txtb_kode
            // 
            txtb_kode.Location = new Point(82, 30);
            txtb_kode.Name = "txtb_kode";
            txtb_kode.Size = new Size(92, 23);
            txtb_kode.TabIndex = 11;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update.Location = new Point(82, 190);
            Update.Name = "Update";
            Update.Size = new Size(116, 34);
            Update.TabIndex = 10;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += button1_Click;
            // 
            // Close
            // 
            Close.Location = new Point(223, 252);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 18;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 287);
            ControlBox = false;
            Controls.Add(Close);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtb_jumlah);
            Controls.Add(txtb_harga);
            Controls.Add(txtb_nama);
            Controls.Add(txtb_kode);
            Controls.Add(Update);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtb_jumlah;
        private TextBox txtb_harga;
        private TextBox txtb_nama;
        private TextBox txtb_kode;
        private Button Update;
        private Button Close;
    }
}