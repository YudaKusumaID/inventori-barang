using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Kasir
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource;

        //string koneksi = "server = 127.0.0.1; uid = root; pwd = 1234; database = Kasir";
        MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; uid = root; pwd = 1234; database = Kasir");

        public Form1()
        {
            InitializeComponent();
            conn.Open();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //PENGECEKAN INPUTAN
            if (string.IsNullOrWhiteSpace(txtb_kode.Text) ||
                string.IsNullOrWhiteSpace(txtb_nama.Text) ||
                string.IsNullOrWhiteSpace(txtb_harga.Text) ||
                string.IsNullOrWhiteSpace(txtb_jumlah.Text))
            {
                MessageBox.Show("Semua Kolom Harus di Isi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //CEK KODE BARANG
            else if (IsKodeBarangExist(txtb_kode.Text))
            {
                MessageBox.Show("Kode Barang sudah ada dalam database!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (!int.TryParse(txtb_kode.Text, out _) || !int.TryParse(txtb_harga.Text, out _) || !int.TryParse(txtb_jumlah.Text, out _))
            {
                MessageBox.Show("Kode, harga, dan jumlah barang harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //SEMUA INPUTAN VALID
            else
            {
                string masukData = "INSERT INTO barang (kode_barang, nama_barang, harga_barang, jumlah_barang) VALUES ('" + txtb_kode.Text + "', '" + txtb_nama.Text + "', '" + txtb_harga.Text + "', '" + txtb_jumlah.Text + "')";
                MySqlCommand cmd = new MySqlCommand(masukData, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA BERHASIL DI MASUKKAN", "Sukses");
                    LoadData();
                }

                else
                {
                    MessageBox.Show("DATA GAGAL DI MASUKKAN");
                }
            }
        }

        //FUNGSI CEK KODE BARANG
        private bool IsKodeBarangExist(string kodeBarang)
        {
            string query = "SELECT COUNT(*) FROM barang WHERE kode_barang = @kode";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@kode", kodeBarang);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        //FUNGSI LOAD DATA
        public void LoadData()
        {
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM barang", conn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dgv1.DataSource = dt;
            dgv1.AllowUserToAddRows = false;
            dgv1.RowHeadersVisible = false;
        }

        //TABEL
        public void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Columns[e.ColumnIndex].HeaderText == "DELETE")
            {
                int selectedRowIndex = e.RowIndex;
                string kodeBarang = dgv1.Rows[selectedRowIndex].Cells["Column1"].Value.ToString();

                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //AKSi MENGHAPUS
                    string deleteQuery = "DELETE FROM barang WHERE kode_barang = @kode";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", kodeBarang);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus.", "Sukses");
                            LoadData(); //MUAT ULANG TABEL
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data.");
                        }
                    }
                }
            }

            else if (dgv1.Columns[e.ColumnIndex].HeaderText == "UPDATE")
            {
                int kodeBarang = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["Column1"].Value);
                string namaBarang = dgv1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                int hargaBarang = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["Column3"].Value);
                int jumlahBarang = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["Column4"].Value);

                Form2 form2 = new Form2(kodeBarang, namaBarang, hargaBarang, jumlahBarang);
                form2.ShowDialog();
            }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            LoadData();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void Form1_Activated_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}