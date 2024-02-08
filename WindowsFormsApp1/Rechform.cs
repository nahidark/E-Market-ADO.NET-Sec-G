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

    public partial class Rechform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL_VOSTRO_15\SQLEXPRESS;Initial Catalog=EMarket;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Rechform()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dgvData.DataSource = dt;
            Activer();
            if(comboBox1.Text == "Client")
            {
                lab1.Text = "Code Client";
                lab2.Text = "FirstName";
                lab3.Text = "LastName";
                lab4.Text = "Address";
                lab5.Text = "Phone";
                lab6.Text = "Email";
                lab7.Text = "City";
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Categories")
            {
                lab1.Text = "Catagory Code";
                lab2.Text = "Label";
                tb3.Enabled = false;
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Detail")
            {
                lab1.Text = "Order Num";
                lab2.Text = "Article Code";
                lab3.Text = "Order Count";
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Bill")
            {
                lab1.Text = "Bill Number";
                lab2.Text = "Bill Amount";
                lab3.Text = "Order Number";
                lab8.Text = "Bill Date";
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Ordered")
            {
                lab1.Text = "Order Number";
                lab2.Text = "Code Client";
                lab8.Text = "Ordered Date";
                tb3.Enabled = false;
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Article")
            {
                lab1.Text = "Article Code";
                lab2.Text = "Designation";
                lab3.Text = "Unit Price";
                lab4.Text = "Stock Quantity";
                lab5.Text = "Catagory Code";
                tb6.Enabled = false;
                tb7.Enabled = false;
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
        }

        private void Activer()
        {
            lab1.Text = "";
            lab2.Text = "";
            lab3.Text = "";
            lab4.Text = "";
            lab5.Text = "";
            lab6.Text = "";
            lab7.Text = "";
            lab8.Text = "";
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            tb4.Enabled = true;
            tb5.Enabled = true;
            tb6.Enabled = true;
            tb7.Enabled = true;
            cbdt.Enabled = true;
        }

        private void Rechform_Load(object sender, EventArgs e)
        {

        }
        
        private void rechmulti_Click(object sender, EventArgs e)
        {if (comboBox1.Text == String.Empty) { MessageBox.Show("Please choose a table"); }
            else
            {
                DataTable dt = new DataTable();
                dgvData.DataSource = dt;
                string req = "";
                if (comboBox1.Text == "Client")
                {
                    req = "select * from Client where ClCode like '" + tb1.Text + "%' and FirstName like '" + tb2.Text + "%' and LastName like '" + tb3.Text + "%' and Addre like '" + tb4.Text + "%' and Phone like '" + tb5.Text + "%' and Email like '" + tb6.Text + "%' and City like '" + tb7.Text + "%'";
                }
                if (comboBox1.Text == "Categories")
                {
                    req = "select * from Categorie where CatCode like '" + tb1.Text + "%' and Lable like '" + tb2.Text + "%'";
                }
                if (comboBox1.Text == "Detail")
                {
                    req = "select * from Detail where OrdNum like '" + tb1.Text + "%' and ArtCode like '" + tb2.Text + "%'and OrdCount like '" + tb3.Text + "%'";
                }
                if (comboBox1.Text == "Ordered")
                {
                    if (dt8.Enabled == true)
                    {
                        req = "select * from Ordered where OrdNum like '" + tb1.Text + "%' and OrdDate =@Date and CodeCl like '" + tb2.Text + "%'";
                    }
                    else
                    {
                        req = "select * from Ordered where OrdNum like '" + tb1.Text + "%' and CodeCl like '" + tb2.Text + "%'";
                    }
                }
                if (comboBox1.Text == "Bill")
                {
                    if (dt8.Enabled == true)
                    {
                        req = "select * from Bill where BillNum like '" + tb1.Text + "%' and BillDate =@Date and BillAmnt like '" + tb2.Text + "%'and OrdNum like '" + tb3.Text + "%'";
                    }
                    else
                    {
                        req = "select * from Bill where BillNum like '" + tb1.Text + "%' and BillAmnt like '" + tb2.Text + "%'and OrdNum like '" + tb3.Text + "%'";
                    }
                }
                if (comboBox1.Text == "Article")
                {
                    req = "select * from Article where ArtCode like '" + tb1.Text + "%' and Designation like '" + tb2.Text + "%'and PU like '" + tb3.Text + "%'and QStock like '" + tb4.Text + "%'and CatCode like '" + tb5.Text + "%'";
                }
                cmd = new SqlCommand(req, con);
                cmd.Parameters.AddWithValue("@Date", dt8.Value.Date);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dgvData.DataSource = t;
                dr.Close();
                con.Close();
            }
            

        }

        private void cbdt_CheckedChanged(object sender, EventArgs e)
        {
            if(cbdt.Checked == true)
            {
                dt8.Enabled = true;
            }
            if (cbdt.Checked == false)
            {
                dt8.Enabled = false;
            }
        }
    }
}
