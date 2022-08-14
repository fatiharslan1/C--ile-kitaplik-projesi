using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kitaplık_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-5R80TPD\\;Initial Catalog=kitaplikproje;Integrated Security=True");

        baglantisinif bgl = new baglantisinif();

        void listele()
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kitaplar", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            
            conn.Close();
            listele();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string durum = " ";
        

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            //baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_kitaplar (kitapad,yazar,sayfa,tur,durum) values (@p1,@p2,@p3,@p4,@p5)", conn);
            komut.Parameters.AddWithValue("@p1", txtkitap.Text);
            komut.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut.Parameters.AddWithValue("@p3", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p4", cmbtur.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            conn.Close();
            //baglantı.Close();
            MessageBox.Show("Kayıt yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
          

        }

        private void rdbkullanılmıs_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdbsıfır_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtkitap.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbtur.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if(dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdbsıfır.Checked = true;
            }
            else
            {
               
                rdbkullanılmıs.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            //baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_kitaplar where kitapid = @p1", conn);
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            conn.Close();
           // baglantı.Close();
            MessageBox.Show("Kitap silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
           // baglantı.Open();
            SqlCommand komut = new SqlCommand("update  tbl_kitaplar set kitapad=@p1,yazar=@p2,sayfa=@p3,tur=@p4,durum=@p5 where kitapid=@p6 ", conn);
            komut.Parameters.AddWithValue("@p1", txtkitap.Text);
            komut.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut.Parameters.AddWithValue("@p3", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p4", cmbtur.Text);
            if(rdbkullanılmıs.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if(rdbsıfır.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", txtid.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            //baglantı.Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK , MessageBoxIcon.Information);
            listele();
            
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            // baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_kitaplar where kitapad=@p1", conn);
            komut.Parameters.AddWithValue("@p1", txtkitapbul.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           // baglantı.Close();
           conn.Close();

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_kitaplar where kitapad like '%" + txtkitapbul.Text + "%'", conn);
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

       

       
    }
}
