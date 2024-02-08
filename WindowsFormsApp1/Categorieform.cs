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
    public partial class Categorieform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL_VOSTRO_15\SQLEXPRESS;Initial Catalog=EMarket;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Categorieform()
        {
            InitializeComponent();
        }
        private void Datagridload()
        {

            cmd = new SqlCommand("select * from Categories",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvData.DataSource = t;
            dr.Close();
            con.Close();

        }
        private void Categorieform_Load(object sender, EventArgs e)
        {
            Datagridload();
        }




        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbcdca.Text == String.Empty || tblibelle.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all information");
                }
                else
                {
                    cmd = new SqlCommand("insert into Categories(CatCode,Lable) values (@CodeCat,@Libelle)", con);
                    cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
                    cmd.Parameters.AddWithValue("@Libelle", tblibelle.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }

            }
            catch (Exception) { MessageBox.Show("Please enter correct values"); con.Close(); }


        }



        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            tbcdca.Text = dgvData.Rows[i].Cells[0].Value.ToString();
            tblibelle.Text = dgvData.Rows[i].Cells[1].Value.ToString();
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbcdca.Text == String.Empty || tblibelle.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all information");
                }
                else
                {
                    cmd = new SqlCommand("update Categories set Lable=@Libelle where  CatCode=@CodeCat ", con);
                    cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
                    cmd.Parameters.AddWithValue("@Libelle", tblibelle.Text);
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

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {

            cmd = new SqlCommand("delete Categories where CatCode=@CodeCat ", con);
            cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            Datagridload();
        }

       
        
    }
}


