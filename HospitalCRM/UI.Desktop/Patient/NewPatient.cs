using Core.Data;
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
using Toolbox;

namespace UI.Desktop.Patient
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        //private bool checkTCKN()
        //{
        //    if (txt_tckno.Text.Length == 11 && !txt_tckno.Text.StartsWith("0"))
        //    {
        //        Int64.TryParse(txt_tckno.Text, out long tckn);

        //        long test_tckn = tckn / 100, tekler = 0, ciftler = 0, s10, s11;
        //        long[] b = new long[9];
        //        for (int i = 8; i >= 0; i--)
        //        {
        //            b[i] = test_tckn % 10; test_tckn /= 10;
        //            if (i % 2 == 0)
        //            {
        //                tekler += b[i];
        //            }
        //            else
        //            {
        //                ciftler += b[i];
        //            }
        //        }
        //        s10 = (tekler * 7 - ciftler) % 10;
        //        s11 = (tekler + ciftler + s10) % 10;
        //        return (s10 * 10 + s11) == tckn % 100;
        //    }
        //    return false;
        //}

        private void txt_tckno_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 96 && e.KeyValue <= 108) || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                //e.Handled: Olayı ele alabilirsin, yani işlem yapılabilir.
                //e.Handled = true;
            }
            else
            {
                //e.SuppressKeyPress: Basılan tuşu baskılar, yazılmasına engel olur.
                e.SuppressKeyPress = true;
            }
        }

        private void txt_tckno_KeyUp(object sender, KeyEventArgs e)
        {
            bool chk = ValidationService.Instance.ValidateTCKN(txt_tckno.Text);
            if (chk)
            {
                txt_tckno.ForeColor = Color.DarkGreen;
                btn_save.Enabled = true;
            }
            else
            {
                txt_tckno.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
        }

        private void txt_email_KeyUp(object sender, KeyEventArgs e)
        {
            if (ValidationService.Instance.ValidateEMail(txt_email.Text))
            {
                txt_tckno.ForeColor = Color.DarkGreen;
                btn_save.Enabled = true;
            }
            else
            {
                txt_tckno.ForeColor = Color.Red;
                btn_save.Enabled = false;
            }
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            //Sözlükten gelen verilerin anahtarlarını string[] (ToArray) olarak çektik.
            string[] cities = Cities.Instance.CityList.Keys.ToArray();
            cb_cities.Items.Clear();
            cb_cities.Items.Add("Seçiniz");
            cb_cities.Items.AddRange(cities);
            cb_cities.SelectedIndex = 0;

            cb_bloodType.SelectedIndex = 0;
        }

        private void cb_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cities.SelectedIndex != 0)
            {
                string key = cb_cities.SelectedItem.ToString();
                string[] districts = Cities.Instance.CityList[key];
                cb_district.Items.Clear();
                cb_district.Items.Add("Seçiniz");
                cb_district.Items.AddRange(districts);
                cb_district.SelectedIndex = 0;
            }
            else
            {
                cb_district.Items.Clear();
                cb_district.Items.Add("Seçiniz");
                cb_district.SelectedIndex = 0;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Yeni Hasta Girişi Penceresi Kapanıyor.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void NewPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Yeni Hasta Girişi Penceresi Kapanıyor.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Control.ControlCollection controls1 = groupBox1.Controls;
            clear_controls(controls1);
            Control.ControlCollection controls2 = groupBox2.Controls;
            clear_controls(controls2);
        }

        private void clear_controls(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                switch (item)
                {
                    case TextBox tb: ((TextBox)item).Clear(); break;
                    case MaskedTextBox mtb: ((MaskedTextBox)item).Clear(); break;
                    case ComboBox cb: ((ComboBox)item).SelectedIndex = 0; break;
                    case CheckBox chk: ((CheckBox)item).Checked = false; break;
                    case RadioButton rb: ((RadioButton)item).Checked = false; break;
                    case DateTimePicker dtp: ((DateTimePicker)item).Value = DateTime.Now; break;
                    default:
                        break;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PatientDataRepository repository = new PatientDataRepository();
            PatientEntity entity = new PatientEntity();
            entity.Firstname = txt_firstname.Text;
            entity.Lastname = txt_lastname.Text;
            long.TryParse(txt_tckno.Text, out long tckno);
            entity.TCKID = tckno;
            entity.DateofBirth = dt_dateOfBirth.Value;
            entity.BloodType = cb_bloodType.SelectedItem.ToString();
            entity.EMailAddress = txt_email.Text;
            entity.PhoneNumber = txt_phone.Text;
            entity.DetailedAddress = txt_address.Text;
            entity.City = cb_cities.SelectedItem.ToString();
            entity.District = cb_district.SelectedItem.ToString();
            entity.Smoke = chk_smoke.Checked;
            entity.Alcohol = chk_drink.Checked;
            entity.Gender = rb_male.Checked ? rb_male.Text : rb_female.Checked ? rb_female.Text : rb_others.Checked ? rb_others.Text : " ";

            /*
            if (rb_male.Checked)
            {
                entity.Gender = rb_male.Text;
            }
            else
            {
                if (rb_female.Checked)
                {
                    entity.Gender = rb_female.Text;
                }
                else
                {
                    if (rb_others.Checked)
                    {
                        entity.Gender = rb_others.Text;
                    }
                    else
                    {
                        entity.Gender = " ";
                    }
                }
            }*/

            ResponseService response = repository.Create(entity);
            switch (response.Code)
            {
                case ResponseServiceCode.Success:
                    MessageBox.Show(response.Message, "Yeni Kayıt Ekle", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case ResponseServiceCode.Information:
                    break;
                case ResponseServiceCode.Warning:
                    break;
                case ResponseServiceCode.Error:
                    MessageBox.Show(response.Message, "Yeni Kayıt Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }
    }
}
