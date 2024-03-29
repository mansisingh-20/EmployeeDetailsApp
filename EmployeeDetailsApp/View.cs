using System;
using System.Windows.Forms;

namespace EmployeeDetailsApp
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                labelId.Text = Employee.selectedRow.Cells[0].Value.ToString();
                labelName.Text = Employee.selectedRow.Cells[1].Value.ToString();
                labelDob.Text = Employee.selectedRow.Cells[2].Value.ToString();
                labelGender.Text = Employee.selectedRow.Cells[3].Value.ToString();
                labelContact.Text = Employee.selectedRow.Cells[4].Value.ToString();
                labelEmail.Text = Employee.selectedRow.Cells[5].Value.ToString();
                labelDepartment.Text = Employee.selectedRow.Cells[6].Value.ToString();
                labelDesignation.Text = Employee.selectedRow.Cells[7].Value.ToString();
                labelDoj.Text = Employee.selectedRow.Cells[8].Value.ToString();
                labelAddress.Text = Employee.selectedRow.Cells[9].Value.ToString();
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
    }
}
