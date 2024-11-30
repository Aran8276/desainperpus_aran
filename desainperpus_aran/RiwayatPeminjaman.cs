using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desainperpus_aran
{
    public partial class RiwayatPeminjaman : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;

        public RiwayatPeminjaman()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = @"
        SELECT 
        	[siswa].[nis],
        	[buku].[id_buku],
        	[user].[id_user],
        	[peminjaman_buku].[id_peminjaman_buku],
        	[peminjaman].[id_peminjaman],
            [user].[nama],
            [buku].[judul_buku],
            [peminjaman_buku].[jml_pinjam],
            [peminjaman].[tgl_pinjam],
            CASE 
                WHEN [pengembalian].[tgl_kembali] IS NULL THEN '-' 
                ELSE CONVERT(VARCHAR, [peminjaman].[durasi_pinjam]) 
            END AS durasi_pinjam,
            CASE 
                WHEN [pengembalian].[tgl_kembali] IS NULL THEN '-' 
                ELSE CONVERT(VARCHAR, [peminjaman].[tgl_kembali]) 
            END AS tgl_kembali,
            CASE 
                WHEN [pengembalian].[denda] IS NULL THEN '-' 
                ELSE CONVERT(VARCHAR, [peminjaman].[denda]) 
            END AS denda
        FROM 
            [peminjaman]
        JOIN 
            [peminjaman_buku] ON [peminjaman].[id_peminjaman] = [peminjaman_buku].[id_peminjaman]
        JOIN 
            [user] ON [peminjaman].[id_user] = [user].[id_user]
        JOIN 
            [buku] ON [peminjaman_buku].[id_buku] = [buku].[id_buku]
        JOIN
        	[siswa] ON [user].[id_user] = [siswa].[id_user]
        LEFT JOIN 
            [pengembalian] ON [peminjaman].[id_peminjaman] = [pengembalian].[id_peminjaman]
        WHERE [peminjaman].[id_user] = " + Convert.ToInt32(Model.id);

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                // 0 = nis
                // 1 = id_buku
                // 2 = id_user
                // 3 = id_peminjaman_buku
                // 4 = id_peminjaman
                // 5 = nama
                // 6 = judul_buku
                // 7 = jml_pinjam
                // 8 = tgl_pinjam
                // 9 = durasi_pinjam
                // 10 = tgl_kembali
                // 11 = denda

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "Peminjam";
                dataGridView1.Columns[6].HeaderText = "Judul Buku";
                dataGridView1.Columns[7].HeaderText = "Jumlah Pinjam";
                dataGridView1.Columns[8].HeaderText = "Tanggal Pinjam";
                dataGridView1.Columns[9].HeaderText = "Durasi Pinjam";
                dataGridView1.Columns[10].HeaderText = "Tanggal Kembali";
                dataGridView1.Columns[11].HeaderText = "Denda";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
