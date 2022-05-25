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
    public partial class Garaze : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        public Garaze()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Garaze_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT id, naziv, adresa, cena_po_satu, ukupno_mesta FROM garaza", Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
