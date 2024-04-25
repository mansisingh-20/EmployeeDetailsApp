using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmployeeDetailsApp
{
    public partial class Employee : Form
    {
        private readonly EmployeeDetailsEntities _db;
        public Employee()
        {
            InitializeComponent();
            _db = new EmployeeDetailsEntities();
        }
        SqlConnection con = new SqlConnection("Data Source=L-IN-5CG9513WR9\\SQLEXPRESS;Initial Catalog=EmployeeDetails;Integrated Security=True;Encrypt=False");

        public static DataGridViewRow selectedRow;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Main loginForm = new Main();
                this.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BindData();
            gvEmployee.AllowUserToAddRows = false;
            if(Main.username != "admin")
            {
                btnEmpInsert.Visible = false;
                btnEmpDelete.Visible = false;
                btnEmpUpdate.Visible = false;
                btnEmpExport.Visible = false;
            }
        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from details", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvEmployee.DataSource = dt;
        }

        private void btnEmpInsert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            Modify update = new Modify();
            update.Show();
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    con.Open();
                    string cmd = "DELETE details WHERE id='" + gvEmployee.CurrentRow.Cells["id"].Value.ToString() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Deleted record successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in deleting data" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            View view = new View(); 
            view.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void gvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedRow = gvEmployee.Rows[e.RowIndex];
            }
        }

        private void btnEmpExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "EmployeeDetails";

            for(int i =1; i < gvEmployee.Columns.Count+1; i++)
            {
                worksheet.Cells[1,i] = gvEmployee.Columns[i -1].HeaderText;
            }
            for(int i = 0;i < gvEmployee.Rows.Count; i++)
            {
                for(int j = 0;j < gvEmployee.Columns.Count; j++)
                {
                    worksheet.Cells[i+2,j+1] = gvEmployee.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Employee details";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Exported to excel successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
