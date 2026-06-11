using System;
using System.Data;
using Clinic_Business_Layer;
using Clinic_Business;


using System.Windows.Forms;
using Clinic_System.Doctors;
using Clinic_System.Patients;
using Clinic_System.Appointments;
using Clinic_System.Payments;
using Clinic_System.Login;
using Clinic_System.Users;
namespace Clinic_System
{
    public partial class Form1 : Form
    {
        public enum enMode { AddNew, Update }
        enMode Mode = enMode.AddNew;

        private string currentView = "";

        private int _DoctorID = -1;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
            Mode = enMode.Update;
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            currentView = "Doctors";
            btnAdd.Visible = true;
            dgvList.ContextMenuStrip = CmsDoctors;
            DataTable dtDoctors = clsDoctorsBusiness.GetAllDoctors();
            dgvList.DataSource = dtDoctors;
            dgvList.Refresh();

            btnAdd.Text = "Add Doctor";
        }

        private void _Refresh()
        {
            switch(currentView)
            {
                case "Doctors":
                    DataTable dtDoctors = clsDoctorsBusiness.GetAllDoctors();
                    dgvList.DataSource = dtDoctors;
                    break;


                case "Patients":
                    DataTable dtPatients = clsPatientBusiness.GetAllPatients();
                    dgvList.DataSource = dtPatients;
                    break;


                case "Appointments":
                    DataTable dtAppointments = clsAppointments.GetAllAppointments();
                    dgvList.DataSource = dtAppointments;
                    break;

                case "Payments":
                    DataTable dtPayments = clsPaymentBusiness.GetAllPayments();
                    dgvList.DataSource = dtPayments;
                    break;


                case "Users":
                    DataTable dtUsers = clsUsersBusiness.GetAllUsers();
                    dgvList.DataSource = dtUsers;
                    break;
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            currentView = "Patients";
            dgvList.ContextMenuStrip = CmsPatients;
            dgvList.DataSource = clsPatientBusiness.GetAllPatients();
            btnAdd.Text = "Add Patient";
        }



        private void btnAppointments_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            currentView = "Appointments";
            dgvList.ContextMenuStrip = CmsAppointments;

            dgvList.DataSource = clsAppointments.GetAllAppointments();
            btnAdd.Text = "Add Appointment";
        }

        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            currentView = "Medical Record";
            btnAdd.Text = "Add Medical Record";
            MessageBox.Show("Not Implemented");
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            currentView = "Payments";
            dgvList.ContextMenuStrip = CmsPayemnts;
            dgvList.DataSource = clsPaymentBusiness.GetAllPayments();

            btnAdd.Text = "Add Payment";

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            frmAddEditDoctors form = new frmAddEditDoctors();
            form.Show();

            form.OnDoctorSaved += () =>
            {
                _Refresh(); // refresh the DataGridView
            };
            _Refresh();
        }

        private void updateDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            frmAddEditDoctors form = new frmAddEditDoctors(DoctorID);
            form.ShowDialog();
            _Refresh();


        }

        private void deleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            if (MessageBox.Show($"Are you want to delete a doctor with id :{DoctorID} ?", "Delete a Doctor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsDoctorsBusiness.DeleteDoctor(DoctorID))
                {
                    MessageBox.Show($"Doctor With ID :{DoctorID} Deleted Successfully");
                    _Refresh();
                }
                else
                    MessageBox.Show($"Failed To Delete a Doctor With ID :{DoctorID}");
            }
            else
                MessageBox.Show($"Delete a doctor operation was cancelled");
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvList.ClearSelection();
                dgvList.Rows[e.RowIndex].Selected = true;
                CmsDoctors.Show(Cursor.Position);
            }
        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            if (MessageBox.Show($"Are you want to delete a doctor with id :{PatientID} ?", "Delete a Patient",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPatientBusiness.DeletePatient(PatientID))
                {
                    MessageBox.Show($"Patient With ID :{PatientID} Deleted Successfully");
                    _Refresh();
                }
                else
                    MessageBox.Show($"Failed To Delete a Patient With ID :{PatientID}");
            }
            else
                MessageBox.Show($"Delete a Patient operation was cancelled");
            _Refresh();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            frmAddEditPatient form = new frmAddEditPatient(PatientID);
            form.ShowDialog();
            _Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentView == "Doctors")
            {
                frmAddEditDoctors form = new frmAddEditDoctors();
                form.Show();

                form.OnDoctorSaved += () =>
                {
                    _Refresh(); // refresh the DataGridView
                };

            }
            else if (currentView == "Patients")
            {
                frmAddEditPatient form = new frmAddEditPatient();
                form.Show();

                form.OnPatientSaved += () =>
                {
                    _Refresh(); // refresh the DataGridView
                };
            }

            else if (currentView == "Appointments")
            {
                frmAddEditAppointment form = new frmAddEditAppointment();
                form.Show();

                form.OnAppointmentSaved += () =>
                {
                    _Refresh(); // refresh the DataGridView
                };
            }

            else if (currentView == "Users")
            {
                frmAddEditUser form = new frmAddEditUser(); 
                form.Show();

                form.OnUserSaved += () =>
                {
                    _Refresh(); // refresh the DataGridView
                };
            }

            else if (currentView == "Payments")
            {
                frmAddEditPayment form = new frmAddEditPayment();
                form.Show();

                form.OnPaymentSaved += () =>
                {
                    _Refresh(); // refresh the DataGridView
                };
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
        }

        private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            frmAddEditAppointment form = new frmAddEditAppointment(AppointmentID);
            form.ShowDialog();

            _Refresh();
        }

        private void deleteAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            if (MessageBox.Show($"Are you want to delete an appointment with id :{AppointmentID} ?",
                 "Delete appointment",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsAppointments.DeleteAppointment(AppointmentID))
                {
                    MessageBox.Show($"Appointment With ID :{AppointmentID} Deleted Successfully");
                    _Refresh();
                }
                else
                    MessageBox.Show($"Failed To Delete Appointment With ID :{AppointmentID}");
            }
            else
                MessageBox.Show($"Delete appointment operation was cancelled");
            _Refresh();
        }

        private void updatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaymentID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            frmAddEditPayment form = new frmAddEditPayment(PaymentID);
            form.ShowDialog();
            _Refresh();
        }

        private void deletePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null) return;
            int PaymentID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);
            var msg = MessageBox.Show($"Are you sure you want to delete the payment with ID: {PaymentID}?",
                                      "Delete Payment",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                if (clsPaymentBusiness.DeletePayment(PaymentID))
                {
                    MessageBox.Show($"Payment with ID: {PaymentID} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Refresh(); 
                }
                else
                    MessageBox.Show($"Failed to delete payment with ID: {PaymentID}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Delete operation was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            frmAddEditUser form = new frmAddEditUser(UserID);
            form.ShowDialog();
            _Refresh();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);

            if (MessageBox.Show($"Are you want to delete an User with id :{UserID} ?",
                 "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsersBusiness.DeleteUser(UserID))
                {
                    MessageBox.Show($"User With ID :{UserID} Deleted Successfully");
                    _Refresh();
                }
                else
                    MessageBox.Show($"Failed To Delete User With ID :{UserID}");
            }
            else
                MessageBox.Show($"Delete User operation was cancelled");
            _Refresh();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            currentView = "Users";
            dgvList.ContextMenuStrip = CmsUsers;
            dgvList.DataSource = clsUsersBusiness.GetAllUsers();
            btnAdd.Text = "Add Users";
        }
    }
}