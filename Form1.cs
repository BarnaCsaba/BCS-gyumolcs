using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCS_gyumolcs
{
    public partial class Form1 : Form
    {
        string connectionString = "server=127.0.0.1;database=gyümölcs;uid=root;pwd=;";
        public Form1()
        {
            InitializeComponent();
        }
        private void Lekerdezes(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            gomb.Visible=false;
        }

        private void gomb_Click(object sender, EventArgs e)
        {
            Lekerdezes("SELECT * FROM adatok");

        }

        private void btnMagyar_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT TNév, Ár FROM adatok WHERE Magyar = 1";
            Lekerdezes(query);
        }

        private void btnOlcso_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT TNév, ÉrkIdő FROM adatok WHERE Ár <= 200";
            Lekerdezes(query);
        }

        private void btnMennyiseg_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT TNév, Mennyiség FROM adatok WHERE Mennyiség BETWEEN 8 AND 15";
            Lekerdezes(query);
        }

        private void btnLejart_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT TNév FROM adatok WHERE DATE_ADD(ÉrkIdő, INTERVAL Szavatosság DAY) < NOW()";
            Lekerdezes(query);
        }

        private void btnBevetel_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT TNév, Ár * Mennyiség AS Osszertek FROM adatok";
            Lekerdezes(query);
        }
    }
}
