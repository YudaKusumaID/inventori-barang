using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kasir
{
    public partial class Form2 : Form
    {
        private int kodeBarang;

        //KONEKSI
        MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; uid = root; pwd = 1234; database = Kasir");


        




        public Form2(int kodeBarang, string namaBarang, int hargaBarang, int jumlahBarang)
        {
            InitializeComponent();
            this.kodeBarang = kodeBarang;

            txtb_kode.ReadOnly = true;
            txtb_kode.Text = kodeBarang.ToString();
            txtb_nama.Text = namaBarang;
            txtb_harga.Text = hargaBarang.ToString();
            txtb_jumlah.Text = jumlahBarang.ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TOMBOL UPDATE
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!int.TryParse(txtb_kode.Text, out _) || !int.TryParse(txtb_harga.Text, out _) || !int.TryParse(txtb_jumlah.Text, out _))
            {
                MessageBox.Show("Kode, harga, dan jumlah barang harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                conn.Open();
                string nama_barang = txtb_nama.Text;
                int harga_barang = Convert.ToInt32(txtb_harga.Text);
                int jumlah_barang = Convert.ToInt32(txtb_jumlah.Text);
                string updateQuery = "UPDATE barang SET nama_barang = @nama, harga_barang = @harga, jumlah_barang = @jumlah WHERE kode_barang = @kode";
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama_barang);
                    cmd.Parameters.AddWithValue("@harga", harga_barang);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah_barang);
                    cmd.Parameters.AddWithValue("@kode", kodeBarang);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil di-update.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal meng-update data.");
                    }
                }
            }

        }
    }
}
