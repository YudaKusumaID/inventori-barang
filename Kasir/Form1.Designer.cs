namespace Kasir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dgv1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            UPDATE = new DataGridViewButtonColumn();
            DELETE = new DataGridViewButtonColumn();
            txtb_kode = new TextBox();
            txtb_nama = new TextBox();
            txtb_harga = new TextBox();
            txtb_jumlah = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(104, 210);
            button1.Name = "button1";
            button1.Size = new Size(116, 34);
            button1.TabIndex = 0;
            button1.Text = "Tambahkan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, UPDATE, DELETE });
            dgv1.Location = new Point(25, 270);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersVisible = false;
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(746, 333);
            dgv1.TabIndex = 1;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "kode_barang";
            Column1.HeaderText = "KODE BARANG";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "nama_barang";
            Column2.HeaderText = "NAMA BARANG";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "harga_barang";
            Column3.HeaderText = "HARGA BARANG";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "jumlah_barang";
            Column4.HeaderText = "JUMLAH BARANG";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // UPDATE
            // 
            UPDATE.HeaderText = "UPDATE";
            UPDATE.Name = "UPDATE";
            UPDATE.ReadOnly = true;
            UPDATE.Resizable = DataGridViewTriState.True;
            UPDATE.SortMode = DataGridViewColumnSortMode.Automatic;
            UPDATE.Text = "UPDATE";
            UPDATE.UseColumnTextForButtonValue = true;
            // 
            // DELETE
            // 
            DELETE.HeaderText = "DELETE";
            DELETE.Name = "DELETE";
            DELETE.ReadOnly = true;
            DELETE.Text = "DELETE";
            DELETE.UseColumnTextForButtonValue = true;
            // 
            // txtb_kode
            // 
            txtb_kode.Location = new Point(104, 50);
            txtb_kode.Name = "txtb_kode";
            txtb_kode.Size = new Size(92, 23);
            txtb_kode.TabIndex = 2;
            // 
            // txtb_nama
            // 
            txtb_nama.Location = new Point(104, 88);
            txtb_nama.Name = "txtb_nama";
            txtb_nama.Size = new Size(193, 23);
            txtb_nama.TabIndex = 3;
            // 
            // txtb_harga
            // 
            txtb_harga.Location = new Point(104, 130);
            txtb_harga.Name = "txtb_harga";
            txtb_harga.Size = new Size(116, 23);
            txtb_harga.TabIndex = 4;
            // 
            // txtb_jumlah
            // 
            txtb_jumlah.Location = new Point(104, 170);
            txtb_jumlah.Name = "txtb_jumlah";
            txtb_jumlah.Size = new Size(63, 23);
            txtb_jumlah.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 0;
            label1.Text = "KODE:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 91);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 6;
            label2.Text = "NAMA:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 130);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 7;
            label3.Text = "HARGA:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 170);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 8;
            label4.Text = "JUMLAH:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtb_jumlah);
            Controls.Add(txtb_harga);
            Controls.Add(txtb_nama);
            Controls.Add(txtb_kode);
            Controls.Add(dgv1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Inventori Barang";
            Activated += Form1_Activated_1;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgv1;
        private TextBox txtb_kode;
        private TextBox txtb_nama;
        private TextBox txtb_harga;
        private TextBox txtb_jumlah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn UPDATE;
        private DataGridViewButtonColumn DELETE;
    }
}