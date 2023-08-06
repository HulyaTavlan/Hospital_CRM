using Core.Objects.Concrates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Patient
{
    public partial class UpdatePatient : Form
    {
        private PatientEntity patient;
        public UpdatePatient(PatientEntity patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {
            txt_tckno.Text = patient.TCKID.ToString();
            txt_firstname.Text = patient.Firstname;
            txt_lastname.Text = patient.Lastname;
            txt_email.Text = patient.EMailAddress;
        }
    }
}
