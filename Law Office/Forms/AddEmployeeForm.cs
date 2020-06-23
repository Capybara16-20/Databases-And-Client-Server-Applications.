using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Actions;

namespace Forms
{
    public partial class AddEmployeeForm : Form
    {
        BusinessLogic bl = new BusinessLogic();

        public AddEmployeeForm(BusinessLogic bl)
        {
            InitializeComponent();
            this.bl = bl;
            comboBoxSpeciality.Items.Clear();
            comboBoxExperience.Items.Clear();
            foreach (var s in bl.GetSpecialitiesList())
            {
                comboBoxSpeciality.Items.Add(s.Name.ToString());
            }
            foreach (var exp in bl.GetExperiencesList())
            {
                comboBoxExperience.Items.Add(exp.Name.ToString());
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            string fullName = string.Empty;
            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string patronomyc = textBoxPatronymic.Text;
            int speciality = 0;
            string strSpeciality = string.Empty;
            if (comboBoxSpeciality.SelectedIndex > -1)
            {
                strSpeciality = comboBoxSpeciality.SelectedItem.ToString();
            }
            int experience = 0;
            string strExperience = string.Empty;
            if (comboBoxSpeciality.SelectedIndex > -1)
            {
                strExperience = comboBoxExperience.SelectedItem.ToString();
            }
            if ((surname != string.Empty) && (name != string.Empty) && (patronomyc != string.Empty)
                && (strSpeciality != string.Empty) && (strExperience != string.Empty))
            {
                fullName = surname + " " + name + " " + patronomyc;
                foreach (var s in bl.GetSpecialitiesList())
                {
                    if (s.Name == strSpeciality)
                    {
                        speciality = s.ID;
                        break;
                    }
                }
                foreach (var exp in bl.GetExperiencesList())
                {
                    if (exp.Name == strExperience)
                    {
                        experience = exp.ID;
                        break;
                    }
                }
                bl.AddEmployee(fullName, speciality, experience);
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные не введены!");
            }
        }

        private void textBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBoxSurname.Text)) && (Regex.IsMatch(textBoxSurname.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                textBoxSurname.Focus();
                errorProvider.SetError(textBoxSurname, "Некорректный формат фамилии!");
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBoxName.Text)) && (Regex.IsMatch(textBoxName.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                textBoxName.Focus();
                errorProvider.SetError(textBoxName, "Некорректный формат имени!");
            }
        }

        private void textBoxPatronymic_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBoxPatronymic.Text)) && (Regex.IsMatch(textBoxPatronymic.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                textBoxPatronymic.Focus();
                errorProvider.SetError(textBoxPatronymic, "Некорректный формат отчества!");
            }
        }

        private void comboBoxSpeciality_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSpeciality.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxSpeciality.Focus();
                errorProvider.SetError(comboBoxSpeciality, "Специальность не выбрана!");
            }
        }

        private void comboBoxExperience_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxExperience.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxExperience.Focus();
                errorProvider.SetError(comboBoxExperience, "Стаж не выбран!");
            }
        }
    }
}
