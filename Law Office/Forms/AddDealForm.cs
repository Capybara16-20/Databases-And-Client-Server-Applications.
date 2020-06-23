using System;
using System.ComponentModel;
using System.Windows.Forms;
using Actions;

namespace Forms
{
    public partial class AddDealForm : Form
    {
        BusinessLogic bl = new BusinessLogic();

        public AddDealForm(BusinessLogic bl)
        {
            InitializeComponent();
            this.bl = bl;
            comboBoxCustomer.Items.Clear();
            comboBoxEmployee.Items.Clear();
            comboBoxLevel.Items.Clear();
            comboBoxAgreement.Items.Clear();
            foreach (var customer in bl.GetCustomersList())
            {
                comboBoxCustomer.Items.Add(customer.FullName);
            }
            foreach (var employee in bl.GetEmployeesList())
            {
                comboBoxEmployee.Items.Add(employee.FullName);
            }
            foreach (var level in bl.GetHopelessnessLevelsList())
            {
                comboBoxLevel.Items.Add(level.Name);
            }
            foreach (var type in bl.GetAgreementTypesList())
            {
                comboBoxAgreement.Items.Add(type.Name);
            }
        }

        private void comboBoxCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxCustomer.Focus();
                errorProvider.SetError(comboBoxCustomer, "Клиент не выбран!");
            }
        }

        private void comboBoxEmployee_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxEmployee.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxEmployee.Focus();
                errorProvider.SetError(comboBoxEmployee, "Сотрудник не выбран!");
            }
        }

        private void comboBoxLevel_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxLevel.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxLevel.Focus();
                errorProvider.SetError(comboBoxLevel, "Уровень безнадёжности не выбран!");
            }
        }

        private void comboBoxAgreement_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxAgreement.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxAgreement.Focus();
                errorProvider.SetError(comboBoxAgreement, "Вид соглашения не выбран!");
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            int customer = 0;
            string strCustomer = string.Empty;
            if (comboBoxCustomer.SelectedIndex > -1)
            {
                strCustomer = comboBoxCustomer.SelectedItem.ToString();
            }
            int employee = 0;
            string strEmployee = string.Empty;
            if (comboBoxEmployee.SelectedIndex > -1)
            {
                strEmployee = comboBoxEmployee.SelectedItem.ToString();
            }
            int level = 0;
            string strLevel = string.Empty;
            if (comboBoxLevel.SelectedIndex > -1)
            {
                strLevel = comboBoxLevel.SelectedItem.ToString();
            }
            int type = 0;
            string strType = string.Empty;
            if (comboBoxAgreement.SelectedIndex > -1)
            {
                strType = comboBoxAgreement.SelectedItem.ToString();
            }
            if ((strCustomer != string.Empty) && (strEmployee != string.Empty) && (strLevel != string.Empty) && (strType != string.Empty))
            {
                foreach (var c in bl.GetCustomersList())
                {
                    if (c.FullName == strCustomer)
                    {
                        customer = c.ID;
                        break;
                    }
                }
                foreach (var emp in bl.GetEmployeesList())
                {
                    if (emp.FullName == strEmployee)
                    {
                        employee = emp.ID;
                        break;
                    }
                }
                foreach (var l in bl.GetHopelessnessLevelsList())
                {
                    if (l.Name == strLevel)
                    {
                        level = l.ID;
                        break;
                    }
                }
                foreach (var t in bl.GetAgreementTypesList())
                {
                    if (t.Name == strType)
                    {
                        type = t.ID;
                        break;
                    }
                }
                bl.AddDeal(customer, employee, level, type);
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные не введены!");
            }
        }
    }
}
