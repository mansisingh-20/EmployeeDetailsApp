namespace EmployeeDetailsApp
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.btnEmpInsert = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpView = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gvEmployee = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpInsert
            // 
            this.btnEmpInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmpInsert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmpInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpInsert.Location = new System.Drawing.Point(24, 615);
            this.btnEmpInsert.Name = "btnEmpInsert";
            this.btnEmpInsert.Size = new System.Drawing.Size(134, 58);
            this.btnEmpInsert.TabIndex = 1;
            this.btnEmpInsert.Text = "Insert";
            this.btnEmpInsert.UseVisualStyleBackColor = false;
            this.btnEmpInsert.Click += new System.EventHandler(this.btnEmpInsert_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmpUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpUpdate.Location = new System.Drawing.Point(265, 615);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(134, 58);
            this.btnEmpUpdate.TabIndex = 2;
            this.btnEmpUpdate.Text = "Modify";
            this.btnEmpUpdate.UseVisualStyleBackColor = false;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmpDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDelete.Location = new System.Drawing.Point(508, 615);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(134, 58);
            this.btnEmpDelete.TabIndex = 3;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = false;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpView
            // 
            this.btnEmpView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmpView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpView.Location = new System.Drawing.Point(755, 615);
            this.btnEmpView.Name = "btnEmpView";
            this.btnEmpView.Size = new System.Drawing.Size(134, 58);
            this.btnEmpView.TabIndex = 4;
            this.btnEmpView.Text = "View";
            this.btnEmpView.UseVisualStyleBackColor = false;
            this.btnEmpView.Click += new System.EventHandler(this.btnEmpView_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(993, 615);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(134, 58);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gvEmployee
            // 
            this.gvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployee.Location = new System.Drawing.Point(24, 205);
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.ReadOnly = true;
            this.gvEmployee.RowHeadersWidth = 62;
            this.gvEmployee.RowTemplate.Height = 28;
            this.gvEmployee.Size = new System.Drawing.Size(1103, 378);
            this.gvEmployee.TabIndex = 6;
            this.gvEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvEmployee_CellMouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::EmployeeDetailsApp.Properties.Resources.kisspng_computer_icons_refresh_free_download_clip_art_one_button_reload_5b282ade52fb22_5051240515293590703399;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(24, 153);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 46);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::EmployeeDetailsApp.Properties.Resources._6_Great_Benefits_of_Using_Employee_Task_Management_Software;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 126);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Details";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 689);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gvEmployee);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEmpView);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnEmpInsert);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1170, 745);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmpInsert;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpView;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView gvEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}