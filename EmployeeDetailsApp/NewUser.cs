using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDetailsApp
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=L-IN-5CG9513WR9\\SQLEXPRESS;Initial Catalog=EmployeeDetails;Integrated Security=True;Encrypt=False");

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            if (tbUserUsername.Text != "" && tbUserPassword.Text != "" && tbUserRePassword.Text != "")
            {
                if(tbUserPassword.Text == tbUserRePassword.Text)
                {
                    try
                    {
                        con.Open();
                        string cmd = "INSERT INTO login (username, password) VALUES ('" + tbUserUsername.Text + "', '" + tbUserPassword.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("New user is successfully registered", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Username already exist. Please enter different username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in registering" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password mismatch. Please enter same passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter all the details", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUserPw_Click(object sender, EventArgs e)
        {
            if(tbUserPassword.UseSystemPasswordChar == true)
            {
                tbUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbUserPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnUserRePw_Click(object sender, EventArgs e)
        {
            if (tbUserRePassword.UseSystemPasswordChar == true)
            {
                tbUserRePassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbUserRePassword.UseSystemPasswordChar = true;
            }
        }
    }
}
