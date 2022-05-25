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
    public partial class Promet : Form
    {
        DataTable tabela;
        DataTable garaze;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        private void ucitaj()
        {
            adapter = new SqlDataAdapter("SELECT * FROM promet", Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void popuni_cmb_garaza()
        {
            garaze = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM garaza", Konekcija.Connect());
            adapter.Fill(garaze);
            cmb_garaza.DataSource = garaze;
            cmb_garaza.DisplayMember = "naziv";
            cmb_garaza.ValueMember = "id";
        }

        public Promet()
        {
            InitializeComponent();
        }

        private void Promet_Load(object sender, EventArgs e)
        {
            popuni_cmb_garaza();
            ucitaj();

            dataGridView1.Columns["id"].ReadOnly = true;
            dataGridView1.Columns["datum_i_vreme"].ReadOnly = true;
            dataGridView1.Columns["garaza"].ReadOnly = true;
            dataGridView1.Columns["tablice"].ReadOnly = true;
            dataGridView1.Columns["ulaz_izlaz"].ReadOnly = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            lbl_err.Text = "";
            string str = "INSERT INTO promet(datum_i_vreme, garaza, tablice, ulaz_izlaz) VALUES(";
            str = str + "'" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + " ";

            int sat = Convert.ToInt32(txt_sati.Text);
            int minuti = Convert.ToInt32(txt_minuti.Text);

            if (sat>=0 && sat<=23 && minuti>=0 && minuti<=59)
            {
                str = str + txt_sati.Text + ":" + txt_minuti.Text + "', '";
            }
            else
            {
                lbl_err.Text = "Greska pri unosu vremena";
            }
            str = str + cmb_garaza.SelectedValue.ToString() + "', '";
            if (txt_tablica.Text != "")
            {
                str = str + txt_tablica.Text + "', '";
            }
            else
            {
                lbl_err.Text = "Unesite tablice";
            }
            if (cmb_ui.SelectedIndex==0)
            {
                str = str + "u";
                string str1 = "UPDATE garaza SET zauzeto_mesta = zauzeto_mesta + 1 WHERE id =" + cmb_garaza.SelectedValue.ToString();
                SqlConnection veza = Konekcija.Connect();
                SqlCommand naredba = new SqlCommand(str1, veza);
                veza.Open();
                naredba.ExecuteNonQuery();
                veza.Close();
            }
            else
            {
                if (cmb_ui.SelectedIndex == 1)
                {
                    str = str + "i";
                    string str1 = "UPDATE garaza SET zauzeto_mesta = zauzeto_mesta - 1 WHERE id =" + cmb_garaza.SelectedValue.ToString();
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand naredba = new SqlCommand(str1, veza);
                    veza.Open();
                    naredba.ExecuteNonQuery();
                    veza.Close();
                }
                else
                {
                    lbl_err.Text = "Izaberite Ulaz/Izlaz";
                }
            }
            str = str + "')";
            if (lbl_err.Text=="")
            {
                SqlConnection veza = Konekcija.Connect();
                SqlCommand naredba = new SqlCommand(str, veza);
                veza.Open();
                naredba.ExecuteNonQuery();
                veza.Close();
                ucitaj();
            }
        }
    }
}
