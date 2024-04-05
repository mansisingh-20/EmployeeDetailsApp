using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDetailsApp
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=L-IN-5CG9513WR9\\SQLEXPRESS;Initial Catalog=EmployeeDetails;Integrated Security=True;Encrypt=False");


        private void Modify_Load(object sender, EventArgs e)
        {
            try
            {
                tbModifyId.Text = Employee.selectedRow.Cells[0].Value.ToString();
                tbModifyName.Text = Employee.selectedRow.Cells[1].Value.ToString();
                dtModifyDob.Text = Employee.selectedRow.Cells[2].Value.ToString();
                cbModifyGender.Text = Employee.selectedRow.Cells[3].Value.ToString();
                tbModifyContact.Text = Employee.selectedRow.Cells[4].Value.ToString();
                tbModifyEmail.Text = Employee.selectedRow.Cells[5].Value.ToString();
                tbModifyDepartment.Text = Employee.selectedRow.Cells[6].Value.ToString();
                tbModifyDesignation.Text = Employee.selectedRow.Cells[7].Value.ToString();
                dtModifyDoj.Text = Employee.selectedRow.Cells[8].Value.ToString();
                tbModifyAddress.Text = Employee.selectedRow.Cells[9].Value.ToString();
            }
            catch (NullReferenceException)
            {
                DialogResult check = MessageBox.Show("Please select a record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (check == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            if (tbModifyId.Text != "" && tbModifyName.Text != "" && dtModifyDob.Text != "" && cbModifyGender.Text != "" && tbModifyContact.Text != "" && tbModifyEmail.Text != "" && tbModifyDepartment.Text != "" && tbModifyDesignation.Text != "" && dtModifyDoj.Text != "" && tbModifyAddress.Text != "")
            {

                try
                {
                    con.Open();
                    string cmd = "UPDATE details " +
                        "SET id = '" + tbModifyId.Text + "', fullname = '" + tbModifyName.Text + "', dob = '" + dtModifyDob.Text + "', gender = '" + cbModifyGender.Text + "', contact = '" + tbModifyContact.Text + "'," +
                        " email = '" + tbModifyEmail.Text + "', department = '" + tbModifyDepartment.Text + "', designation = '" + tbModifyDesignation.Text + "', dateofjoining = '" + dtModifyDoj.Text + "', address = '" + tbModifyAddress.Text + "' " +
                        "WHERE id = '" + Employee.selectedRow.Cells[0].Value.ToString() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Modified successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Error in modifying data\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
