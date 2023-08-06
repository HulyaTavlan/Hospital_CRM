using Core.Data;
using Core.Objects.Concrates;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Toolbox;

namespace UI.Desktop.Patient
{
    public partial class FindPatient : Form
    {
        public FindPatient()
        {
            InitializeComponent();
        }
        private void FillPatients()
        {
            PatientDataRepository repository = new PatientDataRepository();
            List<PatientEntity> patients = repository.ReadAll();
            grid_patients.DataSource = patients;
        }
        private void FindPatient_Load(object sender, EventArgs e)
        {
            FillPatients();
        }

        private void btn_patientDelete_Click(object sender, EventArgs e)
        {
            if (grid_patients.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "Hasta Kaydı Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    PatientDataRepository repository = new PatientDataRepository();
                    int selected = (int)grid_patients.SelectedRows[0].Cells["Id"].Value;
                    ResponseService response = repository.Delete(selected);
                    if (response.Code == ResponseServiceCode.Success)
                    {
                        MessageBox.Show(response.Message, "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillPatients();
                    }
                    else if (response.Code == ResponseServiceCode.Error)
                    {
                        MessageBox.Show(response.Message, "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_patientUpdate_Click(object sender, EventArgs e)
        {
            if (grid_patients.SelectedRows.Count > 0)
            {
                int selected = (int)grid_patients.SelectedRows[0].Cells["Id"].Value;
                PatientDataRepository repository = new PatientDataRepository();
                showChildForm(new UpdatePatient(repository.ReadOne(selected)));
            }
        }

        private void showChildForm(Form form, bool multiple = false)
        {
            bool control = true;
            if (!multiple)
            {
                FormCollection open_forms = Application.OpenForms;
                foreach (Form f in open_forms)
                {
                    if (f.Name == form.Name)
                    {
                        control = false;
                        break;
                    }
                }
            }
            if (control)
            {
                //this: MainForm sınıfını temsil ediyor.
                form.MdiParent = MainForm.ActiveForm;
                form.Show();
            }
        }
    }
}
