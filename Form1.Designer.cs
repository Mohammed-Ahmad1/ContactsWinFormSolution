namespace Clinic_System
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicalRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointments = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.CmsDoctors = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.CmsPatients = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsAppointments = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsPayemnts = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updatePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent.SuspendLayout();
            this.CmsDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.CmsPatients.SuspendLayout();
            this.CmsAppointments.SuspendLayout();
            this.CmsPayemnts.SuspendLayout();
            this.CmsUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.panelContent.Controls.Add(this.btnLogOut);
            this.panelContent.Controls.Add(this.btnUsers);
            this.panelContent.Controls.Add(this.btnDoctors);
            this.panelContent.Controls.Add(this.btnPayments);
            this.panelContent.Controls.Add(this.btnMedicalRecords);
            this.panelContent.Controls.Add(this.btnAppointments);
            this.panelContent.Controls.Add(this.btnPatients);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelContent.Size = new System.Drawing.Size(250, 450);
            this.panelContent.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 8;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLogOut.Location = new System.Drawing.Point(16, 361);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnLogOut.Size = new System.Drawing.Size(200, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 8;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUsers.Location = new System.Drawing.Point(16, 303);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnUsers.Size = new System.Drawing.Size(200, 50);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BorderRadius = 8;
            this.btnDoctors.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDoctors.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnDoctors.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoctors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnDoctors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnDoctors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctors.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDoctors.Location = new System.Drawing.Point(16, 13);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnDoctors.Size = new System.Drawing.Size(200, 50);
            this.btnDoctors.TabIndex = 5;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BorderRadius = 8;
            this.btnPayments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPayments.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPayments.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayments.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPayments.Location = new System.Drawing.Point(16, 245);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnPayments.Size = new System.Drawing.Size(200, 50);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Payments";
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnMedicalRecords
            // 
            this.btnMedicalRecords.BorderRadius = 8;
            this.btnMedicalRecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicalRecords.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnMedicalRecords.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnMedicalRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicalRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicalRecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnMedicalRecords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMedicalRecords.ForeColor = System.Drawing.Color.White;
            this.btnMedicalRecords.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnMedicalRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicalRecords.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMedicalRecords.Location = new System.Drawing.Point(16, 187);
            this.btnMedicalRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicalRecords.Name = "btnMedicalRecords";
            this.btnMedicalRecords.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnMedicalRecords.Size = new System.Drawing.Size(200, 50);
            this.btnMedicalRecords.TabIndex = 3;
            this.btnMedicalRecords.Text = "MedicalRecords";
            this.btnMedicalRecords.Click += new System.EventHandler(this.btnMedicalRecords_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BorderRadius = 8;
            this.btnAppointments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAppointments.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnAppointments.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppointments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnAppointments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAppointments.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAppointments.Location = new System.Drawing.Point(16, 129);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnAppointments.Size = new System.Drawing.Size(200, 50);
            this.btnAppointments.TabIndex = 2;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.BorderRadius = 8;
            this.btnPatients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPatients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPatients.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnPatients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPatients.Location = new System.Drawing.Point(16, 71);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnPatients.Size = new System.Drawing.Size(200, 50);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // CmsDoctors
            // 
            this.CmsDoctors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDoctorToolStripMenuItem,
            this.deleteDoctorToolStripMenuItem});
            this.CmsDoctors.Name = "CmsDoctors";
            this.CmsDoctors.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CmsDoctors.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CmsDoctors.RenderStyle.ColorTable = null;
            this.CmsDoctors.RenderStyle.RoundedEdges = true;
            this.CmsDoctors.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CmsDoctors.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmsDoctors.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CmsDoctors.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CmsDoctors.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CmsDoctors.Size = new System.Drawing.Size(152, 48);
            // 
            // updateDoctorToolStripMenuItem
            // 
            this.updateDoctorToolStripMenuItem.Name = "updateDoctorToolStripMenuItem";
            this.updateDoctorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.updateDoctorToolStripMenuItem.Text = "Update Doctor";
            this.updateDoctorToolStripMenuItem.Click += new System.EventHandler(this.updateDoctorToolStripMenuItem_Click);
            // 
            // deleteDoctorToolStripMenuItem
            // 
            this.deleteDoctorToolStripMenuItem.Name = "deleteDoctorToolStripMenuItem";
            this.deleteDoctorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deleteDoctorToolStripMenuItem.Text = "Delete Doctor";
            this.deleteDoctorToolStripMenuItem.Click += new System.EventHandler(this.deleteDoctorToolStripMenuItem_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.GridColor = System.Drawing.Color.LightSlateGray;
            this.dgvList.Location = new System.Drawing.Point(257, 1);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 35;
            this.dgvList.RowTemplate.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(935, 349);
            this.dgvList.TabIndex = 5;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvList.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.dgvList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvList.ThemeStyle.ReadOnly = true;
            this.dgvList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAdd.Location = new System.Drawing.Point(466, 357);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btnAdd.Size = new System.Drawing.Size(217, 54);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CmsPatients
            // 
            this.CmsPatients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePatientToolStripMenuItem,
            this.updatePatientToolStripMenuItem});
            this.CmsPatients.Name = "CmsPatients";
            this.CmsPatients.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CmsPatients.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CmsPatients.RenderStyle.ColorTable = null;
            this.CmsPatients.RenderStyle.RoundedEdges = true;
            this.CmsPatients.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CmsPatients.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmsPatients.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CmsPatients.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CmsPatients.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CmsPatients.Size = new System.Drawing.Size(153, 48);
            // 
            // deletePatientToolStripMenuItem
            // 
            this.deletePatientToolStripMenuItem.Name = "deletePatientToolStripMenuItem";
            this.deletePatientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deletePatientToolStripMenuItem.Text = "Delete Patient";
            this.deletePatientToolStripMenuItem.Click += new System.EventHandler(this.deletePatientToolStripMenuItem_Click);
            // 
            // updatePatientToolStripMenuItem
            // 
            this.updatePatientToolStripMenuItem.Name = "updatePatientToolStripMenuItem";
            this.updatePatientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updatePatientToolStripMenuItem.Text = "Update Patient";
            this.updatePatientToolStripMenuItem.Click += new System.EventHandler(this.updatePatientToolStripMenuItem_Click);
            // 
            // CmsAppointments
            // 
            this.CmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAppointmentToolStripMenuItem,
            this.deleteAppointmentToolStripMenuItem});
            this.CmsAppointments.Name = "CmsAppointments";
            this.CmsAppointments.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CmsAppointments.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CmsAppointments.RenderStyle.ColorTable = null;
            this.CmsAppointments.RenderStyle.RoundedEdges = true;
            this.CmsAppointments.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CmsAppointments.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmsAppointments.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CmsAppointments.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CmsAppointments.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CmsAppointments.Size = new System.Drawing.Size(187, 48);
            // 
            // updateAppointmentToolStripMenuItem
            // 
            this.updateAppointmentToolStripMenuItem.Name = "updateAppointmentToolStripMenuItem";
            this.updateAppointmentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.updateAppointmentToolStripMenuItem.Text = "Update Appointment";
            this.updateAppointmentToolStripMenuItem.Click += new System.EventHandler(this.updateAppointmentToolStripMenuItem_Click);
            // 
            // deleteAppointmentToolStripMenuItem
            // 
            this.deleteAppointmentToolStripMenuItem.Name = "deleteAppointmentToolStripMenuItem";
            this.deleteAppointmentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteAppointmentToolStripMenuItem.Text = "Delete Appointment";
            this.deleteAppointmentToolStripMenuItem.Click += new System.EventHandler(this.deleteAppointmentToolStripMenuItem_Click);
            // 
            // CmsPayemnts
            // 
            this.CmsPayemnts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePaymentToolStripMenuItem,
            this.deletePaymentToolStripMenuItem});
            this.CmsPayemnts.Name = "CmsPayemnts";
            this.CmsPayemnts.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CmsPayemnts.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CmsPayemnts.RenderStyle.ColorTable = null;
            this.CmsPayemnts.RenderStyle.RoundedEdges = true;
            this.CmsPayemnts.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CmsPayemnts.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmsPayemnts.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CmsPayemnts.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CmsPayemnts.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CmsPayemnts.Size = new System.Drawing.Size(163, 48);
            // 
            // updatePaymentToolStripMenuItem
            // 
            this.updatePaymentToolStripMenuItem.Name = "updatePaymentToolStripMenuItem";
            this.updatePaymentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.updatePaymentToolStripMenuItem.Text = "Update Payment";
            this.updatePaymentToolStripMenuItem.Click += new System.EventHandler(this.updatePaymentToolStripMenuItem_Click);
            // 
            // deletePaymentToolStripMenuItem
            // 
            this.deletePaymentToolStripMenuItem.Name = "deletePaymentToolStripMenuItem";
            this.deletePaymentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deletePaymentToolStripMenuItem.Text = "Delete Payment";
            this.deletePaymentToolStripMenuItem.Click += new System.EventHandler(this.deletePaymentToolStripMenuItem_Click);
            // 
            // CmsUsers
            // 
            this.CmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.CmsUsers.Name = "CmsUsers";
            this.CmsUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CmsUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CmsUsers.RenderStyle.ColorTable = null;
            this.CmsUsers.RenderStyle.RoundedEdges = true;
            this.CmsUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CmsUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmsUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CmsUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CmsUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CmsUsers.Size = new System.Drawing.Size(139, 48);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1193, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panelContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContent.ResumeLayout(false);
            this.CmsDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.CmsPatients.ResumeLayout(false);
            this.CmsAppointments.ResumeLayout(false);
            this.CmsPayemnts.ResumeLayout(false);
            this.CmsUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button btnMedicalRecords;
        private Guna.UI2.WinForms.Guna2Button btnAppointments;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CmsDoctors;
        private System.Windows.Forms.ToolStripMenuItem updateDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDoctorToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CmsPatients;
        private System.Windows.Forms.ToolStripMenuItem deletePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem updateAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAppointmentToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CmsPayemnts;
        private System.Windows.Forms.ToolStripMenuItem updatePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePaymentToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CmsUsers;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}

