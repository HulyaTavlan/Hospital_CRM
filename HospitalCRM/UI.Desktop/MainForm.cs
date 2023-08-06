using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Patient;

namespace UI.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getNewPatientForm_Click(object sender, EventArgs e)
        {
            NewPatient newPatientForm = new NewPatient();
            showChildForm(newPatientForm);
            /*
            FormCollection open_forms = Application.OpenForms;
            bool control = true;
            foreach (Form f in open_forms)
            {
                if (f.Name == newPatientForm.Name)
                {
                    control = false;
                    break;
                }
            }
            if (control)
            {
                newPatientForm.MdiParent = this;
                newPatientForm.Show();
            }
            */
        }

        private void getFindPatientForm_Click(object sender, EventArgs e)
        {
            showChildForm(new FindPatient());
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
                form.MdiParent = this;
                form.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult: Herhangi bir iletişim penceresinden gelen cevabı işler.
            DialogResult result = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
