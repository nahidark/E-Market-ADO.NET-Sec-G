﻿using System;
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
    public partial class Clientform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL_VOSTRO_15\SQLEXPRESS;Initial Catalog=EMarket;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
 
        public Clientform()
        {
            InitializeComponent();
        }
        private void Datagridload()
        {
           
            cmd = new SqlCommand("select * from Client", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvData.DataSource = t;
            dr.Close();
            con.Close();

        }

        private void Clientform_Load(object sender, EventArgs e)
        {
            Datagridload();
        }

       
        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            tbcdcl.Text = dgvData.Rows[i].Cells[0].Value.ToString();
            tbnom.Text = dgvData.Rows[i].Cells[1].Value.ToString();
            tbprenom.Text = dgvData.Rows[i].Cells[2].Value.ToString();
            tbadresse.Text = dgvData.Rows[i].Cells[3].Value.ToString();
            tbtel.Text = dgvData.Rows[i].Cells[4].Value.ToString();
            tbemail.Text = dgvData.Rows[i].Cells[5].Value.ToString();
            tbville.Text = dgvData.Rows[i].Cells[6].Value.ToString();
            


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            { if (tbcdcl.Text == String.Empty || tbnom.Text == String.Empty || tbprenom.Text == String.Empty || tbemail.Text == String.Empty || tbadresse.Text == String.Empty || tbtel.Text == String.Empty || tbville.Text == String.Empty) 
                {
                    MessageBox.Show("Please fill in all information");
                }
                else
                {
                    cmd = new SqlCommand("insert into Client(ClCode,FirstName,LastName,Addre,Phone,Email,City) values (@CodeCl,@Name,@Lname,@address,@tel,@email,@city)", con);
                    cmd.Parameters.AddWithValue("@CodeCl", tbcdcl.Text);
                    cmd.Parameters.AddWithValue("@Name", tbnom.Text);
                    cmd.Parameters.AddWithValue("@Lname", tbprenom.Text);
                    cmd.Parameters.AddWithValue("@address", tbadresse.Text);
                    cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                    cmd.Parameters.AddWithValue("@email", tbemail.Text);
                    cmd.Parameters.AddWithValue("@city", tbville.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload(); 
                }

            }
            catch (Exception) { MessageBox.Show("Please enter correct values");con.Close(); }


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
                cmd = new SqlCommand("delete Client where ClCode=@CodeClient ", con);
                cmd.Parameters.AddWithValue("@CodeClient", tbcdcl.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                con.Close();
                Datagridload();
           
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try {
                if (tbcdcl.Text == String.Empty || tbnom.Text == String.Empty || tbprenom.Text == String.Empty || tbemail.Text == String.Empty || tbadresse.Text == String.Empty || tbtel.Text == String.Empty || tbville.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all information");
                }
                else
                {
                    cmd = new SqlCommand("update Client set FirstName=@Name,LastName=@Lname ,Addre=@address ,Phone=@tel ,Email=@email ,City=@city where ClCode=@CodeClient ", con);
                    cmd.Parameters.AddWithValue("@CodeClient", tbcdcl.Text);
                    cmd.Parameters.AddWithValue("@Name", tbnom.Text);
                    cmd.Parameters.AddWithValue("@Lname", tbprenom.Text);
                    cmd.Parameters.AddWithValue("@address", tbadresse.Text);
                    cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                    cmd.Parameters.AddWithValue("@email", tbemail.Text);
                    cmd.Parameters.AddWithValue("@city", tbville.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }
            }
            catch (Exception) { MessageBox.Show("Please enter correct values");con.Close(); 
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbcdcl_TextChanged(object sender, EventArgs e)
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
