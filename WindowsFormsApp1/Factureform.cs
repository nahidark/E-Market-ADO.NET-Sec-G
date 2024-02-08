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

namespace WindowsFormsApp1
{
    // BILL
    public partial class Factureform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL_VOSTRO_15\SQLEXPRESS;Initial Catalog=EMarket;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Factureform()
        {
            InitializeComponent();
        }
        private void Datagridload()
        {

            cmd = new SqlCommand("select * from Bill", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvData.DataSource = t;
            dr.Close();
            con.Close();

        }
        private void Factureform_Load(object sender, EventArgs e)
        {
            Datagridload();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnc.Text == String.Empty || tbcdfa.Text == String.Empty || tbmo.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all information");
                }
                else
                {
                    cmd = new SqlCommand("insert into Bill(BillNum,BillDate,BillAmnt,OrdNum) values (@CodeFac,@Datef,@MF,@Numco)", con);
                    cmd.Parameters.AddWithValue("@CodeFac", tbcdfa.Text);
                    cmd.Parameters.AddWithValue("@Datef", dtpf.Value);
                    cmd.Parameters.AddWithValue("@MF", tbmo.Text);
                    cmd.Parameters.AddWithValue("@Numco", tbnc.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }

            }
            catch (Exception) {
                MessageBox.Show("Please enter correct values");
                     con.Close();
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            tbcdfa.Text = dgvData.Rows[i].Cells[0].Value.ToString();
            dtpf.Value = DateTime.Parse(dgvData.Rows[i].Cells[1].Value.ToString());
            tbmo.Text = dgvData.Rows[i].Cells[2].Value.ToString();
            tbnc.Text = dgvData.Rows[i].Cells[3].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnc.Text == String.Empty || tbcdfa.Text == String.Empty || tbmo.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all information");
                }
                else
                {
                    cmd = new SqlCommand("update Bill set BillDate=@Datef ,MontantFact=@MF ,OrdNum=@Numco where  BillNum=@CodeFac ", con);
                    cmd.Parameters.AddWithValue("@CodeFac", tbcdfa.Text);
                    cmd.Parameters.AddWithValue("@Datef", dtpf.Value);
                    cmd.Parameters.AddWithValue("@MF", tbmo.Text);
                    cmd.Parameters.AddWithValue("@Numco", tbnc.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }
            }
            
            catch (Exception) { MessageBox.Show("Please enter correct values"); con.Close();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete Bill where BillNum=@CodeFac ", con);
            cmd.Parameters.AddWithValue("@CodeFac", tbcdfa.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            Datagridload();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
