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
using System.Xml;

namespace desainperpus_aran
{
    public partial class PengembalianBuku : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string unselctedLabel = "Pilih--";
        public int id_buku;
        public int id_peminjaman;
        public int id_peminjaman_buku;
        public int id_user;
        public Dictionary<string, string> siswaDictionary = new Dictionary<string, string>();
        public Dictionary<string, string> bukuDictionary = new Dictionary<string, string>();

        public PengembalianBuku()
        {
            InitializeComponent();
            showData();
            ambilPeminjaman();
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
                INNER JOIN 
                    [pengembalian] ON [peminjaman].[id_peminjaman] = [pengembalian].[id_peminjaman]
                ";

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

        public void insertData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT [stok] FROM [buku] WHERE [id_buku] = @id_buku";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_buku", id_buku);
                reader = command.ExecuteReader();
                reader.Read();
                int stokTersedia = Convert.ToInt32(reader["stok"]);

                connection.Close();
                connection.Open();

                sql = "SELECT [jml_pinjam] FROM [peminjaman_buku] WHERE [id_peminjaman] = @id_peminjaman";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                reader = command.ExecuteReader();
                reader.Read();
                int jumlahPinjam = Convert.ToInt32(reader["jml_pinjam"]);

                connection.Close();
                connection.Open();


                sql = @"
                SELECT [peminjaman].[tgl_pinjam], [peminjaman].[tgl_kembali],
                DATEDIFF(day, [peminjaman].[tgl_pinjam], GETDATE()) AS offset
                FROM [peminjaman]
                WHERE [peminjaman].[id_peminjaman] = @id_peminjaman";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                reader = command.ExecuteReader();
                reader.Read();
                int offset = Convert.ToInt32(reader["offset"]);
                DateTime batasPengumpulan = Convert.ToDateTime(reader["tgl_kembali"]);

                connection.Close();
                connection.Open();

                sql = @"
                INSERT INTO [pengembalian]
                (
                id_peminjaman,
                id_buku,
                tgl_kembali,
                denda)
                
                VALUES
                (
                @id_peminjaman, 
                @id_buku, 
                DATEADD(DAY, @offset_hari, GETDATE()), 
                CASE 
                    WHEN DATEDIFF(DAY, @batas_pengumpulan, GETDATE()) < 0 THEN 0
                    ELSE DATEDIFF(DAY, @batas_pengumpulan, GETDATE()) * 1000
                END
                )";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                command.Parameters.AddWithValue("@id_buku", id_buku);
                command.Parameters.AddWithValue("@offset_hari", offset);
                command.Parameters.AddWithValue("@batas_pengumpulan", batasPengumpulan);
                command.ExecuteNonQuery();

                connection.Close();
                connection.Open();

                sql = @"
                UPDATE [peminjaman] SET
                tgl_kembali = DATEADD(DAY, @offset, GETDATE()), 
                durasi_pinjam = @offset,
                denda = CASE 
                            WHEN DATEDIFF(DAY, @batas_pengumpulan, GETDATE()) < 0 THEN 0
                            ELSE DATEDIFF(DAY, @batas_pengumpulan, GETDATE()) * 1000
                        END
                WHERE [id_peminjaman] = @id_peminjaman;
                
                UPDATE [buku] SET
                [stok] = @stok
                WHERE [id_buku] = @id_buku";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@batas_pengumpulan", batasPengumpulan);
                command.Parameters.AddWithValue("@stok", stokTersedia + jumlahPinjam);
                command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                command.Parameters.AddWithValue("@id_buku", id_buku);
                command.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dimasukan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Silahkan pilih data terlebihdahulu", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            }
            finally
            {
                connection.Close();
                showData();
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connection.Close();
                    connection.Open();

                    string sql = "SELECT [stok] FROM [buku] WHERE [id_buku] = @id_buku";
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id_buku", id_buku);
                    reader = command.ExecuteReader();
                    reader.Read();
                    int stokTersedia = Convert.ToInt32(reader["stok"]);

                    connection.Close();
                    connection.Open();

                    sql = "SELECT [jml_pinjam] FROM [peminjaman_buku] WHERE [id_peminjaman] = @id_peminjaman";
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                    reader = command.ExecuteReader();
                    reader.Read();
                    int jumlahPinjam = Convert.ToInt32(reader["jml_pinjam"]);

                    connection.Close();
                    connection.Open();

                    sql =
                    @"
                    UPDATE [peminjaman] SET
                    tgl_kembali = GETDATE(), 
                    durasi_pinjam = 0,
                    denda = 0
                    WHERE [id_peminjaman] = @id_peminjaman;
                    
                    UPDATE [buku] SET
                    [stok] = @stok
                    WHERE [id_buku] = @id_buku

                    DELETE FROM [pengembalian] WHERE [id_peminjaman] = @id_peminjaman
                    ";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@stok", stokTersedia - jumlahPinjam);
                    command.Parameters.AddWithValue("@id_buku", id_buku);
                    command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);


                    try
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Hapus berhasil", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Gagal hapus",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        showData();
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih data terlebihdahulu", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ambilPeminjaman()
        {
            try
            {
                idPeminjaman.Items.Clear();
                connection.Close();
                connection.Open();

                string sql = @"
                SELECT [peminjaman].[id_peminjaman], [user].[nama], [buku].[judul_buku]
                FROM [peminjaman_buku]
                JOIN [peminjaman] ON [peminjaman_buku].[id_peminjaman] = [peminjaman].[id_peminjaman]
                JOIN [user] ON [peminjaman].[id_user] = [user].[id_user]
                JOIN [buku] ON [peminjaman_buku].[id_buku] = [buku].[id_buku];
                ";

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string idPeminjamanText = reader["id_peminjaman"].ToString();
                    string nama = reader["nama"].ToString();
                    string judulBuku = reader["judul_buku"].ToString();
                    idPeminjaman.Items.Add(idPeminjamanText + " - " + nama + " (" + judulBuku + ")");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idPeminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idPeminjaman.SelectedItem != null)
            {
                // Extract the id_peminjaman from the selected item
                string selectedItem = idPeminjaman.SelectedItem.ToString();
                string idPeminjamanText = selectedItem.Split(' ')[0]; // Assuming id_peminjaman is the first part before the first space

                id_peminjaman = Convert.ToInt32(idPeminjamanText);

                connection.Close();
                connection.Open();

                string sql = @"
                SELECT [peminjaman].[id_peminjaman] ,[buku].[id_buku], [user].[id_user]
                FROM peminjaman
                JOIN [peminjaman_buku] ON [peminjaman].[id_peminjaman] = [peminjaman_buku].[id_peminjaman]
                JOIN [user] ON [peminjaman].[id_user] = [user].[id_user]
                JOIN [buku] ON [buku].[id_buku] = [peminjaman_buku].[id_buku]
                AND [peminjaman].[id_peminjaman] = " + id_peminjaman;

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                reader.Read();
                id_peminjaman = Convert.ToInt32(reader["id_peminjaman"]);
                id_buku = Convert.ToInt32(reader["id_buku"]);
                id_user = Convert.ToInt32(reader["id_user"]);




                connection.Close();

            }
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Method ini digunakan utk mengisi inputan sesuai kolum yg kita klik nanti

            dataGridView1.CurrentRow.Selected = true;

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

            id_buku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            id_peminjaman_buku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            id_peminjaman = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            id_user = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

            idBuku.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            judulBuku.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            nisSiswa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            namaSiswa.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            jumlahBuku.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            //nis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }
    }
}
