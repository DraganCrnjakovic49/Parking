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

namespace Parking
{
    public partial class Stanje : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;

        private void ucitaj()
        {
            adapter = new SqlDataAdapter("SELECT naziv, zauzeto_mesta FROM garaza", Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["naziv"].ReadOnly = true;
            dataGridView1.Columns["zauzeto_mesta"].ReadOnly = true;
        }
        public Stanje()
        {
            InitializeComponent();
        }

        private void Stanje_Load(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            ucitaj();
        }
    }
}
