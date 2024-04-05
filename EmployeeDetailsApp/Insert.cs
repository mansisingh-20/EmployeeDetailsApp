using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDetailsApp
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=L-IN-5CG9513WR9\\SQLEXPRESS;Initial Catalog=EmployeeDetails;Integrated Security=True;Encrypt=False");

        private void btnNewSubmit_Click(object sender, EventArgs e)
        {
            if (tbNewId.Text != "" && tbNewName.Text != "" && dtDob.Text != "" && cbNewGender.Text != "" && tbNewContact.Text != "" && tbNewEmail.Text != "" && tbNewDepartment.Text != "" && tbNewDesignation.Text != "" && dtDoj.Text != "" && tbNewAddress.Text != "")
            {
                try
                {
                    con.Open();
                    string cmd = "INSERT INTO details (id, fullname, dob, gender, contact, email, department, designation, dateofjoining, address) " +
                        "VALUES ('" + tbNewId.Text + "', '" + tbNewName.Text + "', '" + dtDob.Text + "','" + cbNewGender.Text + "', '" + tbNewContact.Text + "','" + tbNewEmail.Text + "'," +
                        " '" + tbNewDepartment.Text + "', '" + tbNewDesignation.Text + "','" + dtDoj.Text + "', '" + tbNewAddress.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("New employee details inserted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (SqlException ex) when (ex.Number == 245)
                {
                    MessageBox.Show("Please enter integer for Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Employee ID already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in adding data\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter all the details", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNewCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
