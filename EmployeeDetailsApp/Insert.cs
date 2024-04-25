using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
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
            string email = tbNewEmail.Text;
            string phoneNumber = tbNewContact.Text;

            if (tbNewId.Text != "" && tbNewName.Text != "" && dtDob.Text != "" && cbNewGender.Text != "" && tbNewContact.Text != "" && tbNewEmail.Text != "" && tbNewDepartment.Text != "" && tbNewDesignation.Text != "" && dtDoj.Text != "" && tbNewAddress.Text != "")
            {
                try
                {
                    con.Open();

                    if (!IsValidPhoneNumber(phoneNumber))
                    {
                        MessageBox.Show("Invalid phone number\nPlease enter with country code\nExample: +91-9876543210", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (!IsValidEmail(email))
                    {
                        MessageBox.Show("Invalid email address\nPlease enter proper email id\nExample: someone@example.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    //string dateonly = dtDoj.Value.Date.ToString("yyyy - MM - dd");
                    DateTime dateofJoining = dtDoj.Value.Date;
                    string dateofJoiningString = dateofJoining.ToString("yyyy-MM-dd");

                    string cmd = "INSERT INTO details (id, fullname, dob, gender, contact, email, department, designation, dateofjoining, address) " +
                                "VALUES ('" + tbNewId.Text + "', '" + tbNewName.Text + "', '" + dtDob.Text + "','" + cbNewGender.Text + "', '" + tbNewContact.Text + "','" + tbNewEmail.Text + "'," +
                                " '" + tbNewDepartment.Text + "', '" + tbNewDesignation.Text + "','" + dateofJoiningString + "', '" + tbNewAddress.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("New employee details inserted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (SqlException ex) when (ex.Number == 245)
                {
                    MessageBox.Show("Please enter an integer for Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Employee ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {

            string pattern = @"^\+[1-9]\d{1,3}-\d{9,14}$"; // Assumes phone number has 10 digits
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private void btnNewCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbNewContact_Enter(object sender, EventArgs e)
        {
            if (tbNewContact.Text == "+91-9876543210")
            {
                tbNewContact.Text = "";
                tbNewContact.ForeColor = Color.Black;
            }
        }

        private void tbNewContact_Leave(object sender, EventArgs e)
        {
            if (tbNewContact.Text == "")
            {
                tbNewContact.Text = "+91-9876543210";
                tbNewContact.ForeColor = Color.Silver;
            }
        }

        private void tbNewEmail_Enter(object sender, EventArgs e)
        {
            if (tbNewEmail.Text == "someone@example.com")
            {
                tbNewEmail.Text = "";
                tbNewEmail.ForeColor = Color.Black;
            }
        }

        private void tbNewEmail_Leave(object sender, EventArgs e)
        {
            if (tbNewEmail.Text == "")
            {
                tbNewEmail.Text = "someone@example.com";
                tbNewEmail.ForeColor = Color.Silver;
            }
        }
    }
}
