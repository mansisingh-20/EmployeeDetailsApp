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

namespace EmployeeDetailsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked==true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != "" && tbPassword.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=L-IN-5CG9513WR9\\SQLEXPRESS;Initial Catalog=EmployeeDetails;Integrated Security=True;Encrypt=False");
                    SqlCommand cmd = new SqlCommand("select * from login where username = @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Welcome to Employee Management System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                        cbShowPassword.Checked = false;
                        Employee main = new Employee();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill both fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text) == true)
            {
                tbUsername.Focus();
                errorProvider1.SetError(this.tbUsername, "Please Enter Username");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text) == true)
            {
                tbPassword.Focus();
                errorProvider2.SetError(this.tbPassword, "Please Enter Password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
        }
    }
}
