using Actions;
using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class Main : Form
    {
        BusinessLogic bl = new BusinessLogic();

        public Main()
        {
            InitializeComponent();
            EmployeesGridRenew();
            DealGridRenew();
            PaymentsGridRenew();
        }

        public void EmployeesGridRenew()
        {

            employeesGrid.Rows.Clear();
            for (int i = 0; i < bl.GetEmployeesList().Count; i++)
            {
                employeesGrid.Rows.Add();
                employeesGrid[0, i].Value = bl.GetEmployeesList()[i].FullName;
                for (int j = 0; j < bl.GetSpecialitiesList().Count; j++)
                {
                    if (bl.GetEmployeesList()[i].Specialty == bl.GetSpecialitiesList()[j].ID)
                    {
                        employeesGrid[1, i].Value = bl.GetSpecialitiesList()[j].Name;
                        break;
                    }
                }
                for (int j = 0; j < bl.GetExperiencesList().Count; j++)
                {
                    if (bl.GetEmployeesList()[i].Experience == bl.GetExperiencesList()[j].ID)
                    {
                        employeesGrid[2, i].Value = bl.GetExperiencesList()[j].Name;
                        break;
                    }
                }
                employeesGrid[3, i].Value = bl.GetEmployeesList()[i].Salary.ToString() + " рублей";
                if (bl.GetEmployeesList()[i].Statistics.HasValue)
                {
                    employeesGrid[4, i].Value = String.Format("{0:0.###}", bl.GetEmployeesList()[i].Statistics);
                }
                else
                {
                    employeesGrid[4, i].Value = "Отсутствует";
                }
                if (bl.GetEmployeesList()[i].RankingPlace.HasValue)
                {
                    employeesGrid[5, i].Value = bl.GetEmployeesList()[i].RankingPlace;
                }
                else
                {
                    employeesGrid[5, i].Value = "Отсутствует";
                }
            }
        }

        public void DealGridRenew()
        {
            dealGrid.Rows.Clear();
            for (int i = 0; i < bl.GetDealsList().Count; i++)
            {
                dealGrid.Rows.Add();
                for (int j = 0; j < bl.GetCustomersList().Count; j++)
                {
                    if (bl.GetDealsList()[i].Customer == bl.GetCustomersList()[j].ID)
                    {
                        dealGrid[0, i].Value = bl.GetCustomersList()[j].FullName;
                        break;
                    }
                }
                for (int j = 0; j < bl.GetEmployeesList().Count; j++)
                {
                    if (bl.GetDealsList()[i].Employee == bl.GetEmployeesList()[j].ID)
                    {
                        dealGrid[1, i].Value = bl.GetEmployeesList()[j].FullName;
                        break;
                    }
                }
                for (int j = 0; j < bl.GetHopelessnessLevelsList().Count; j++)
                {
                    if (bl.GetDealsList()[i].HopelessnessLevel == bl.GetHopelessnessLevelsList()[j].ID)
                    {
                        dealGrid[2, i].Value = bl.GetHopelessnessLevelsList()[j].Name;
                        break;
                    }
                }
                for (int j = 0; j < bl.GetAgreementTypesList().Count; j++)
                {
                    if (bl.GetDealsList()[i].AgreementType == bl.GetAgreementTypesList()[j].ID)
                    {
                        dealGrid[3, i].Value = bl.GetAgreementTypesList()[j].Name;
                        break;
                    }
                }
                if (bl.GetDealsList()[i].Stage.HasValue)
                {
                    for (int j = 0; j < bl.GetStagesList().Count; j++)
                    {
                        if (bl.GetDealsList()[i].Stage == bl.GetStagesList()[j].ID)
                        {
                            dealGrid[4, i].Value = bl.GetStagesList()[j].Step;
                            break;
                        }
                    }
                }
                else
                {
                    dealGrid[4, i].Value = "Отсутствует";
                }
                if (bl.GetDealsList()[i].Status.HasValue)
                {
                    for (int j = 0; j < bl.GetEndingStatusesList().Count; j++)
                    {
                        if (bl.GetDealsList()[i].Status == bl.GetEndingStatusesList()[j].ID)
                        {
                            dealGrid[5, i].Value = bl.GetEndingStatusesList()[j].Status;
                            break;
                        }
                    }
                }
                else
                {
                    dealGrid[5, i].Value = "Отсутствует";
                }
            }
        }

        public void PaymentsGridRenew()
        {

            if (paymentsGrid.Rows.Count > 1)
            {
                paymentsGrid.Rows.Clear();
            }

            for (int i = 0; i < bl.GetPaymentsList().Count; i++)
            {
                paymentsGrid.Rows.Add();
                paymentsGrid[0, i].Value = "№" + bl.GetPaymentsList()[i].Deal.ToString();
                foreach (var paymentType in bl.GetPaymentTypesList())
                {
                    if (paymentType.ID == bl.GetPaymentsList()[i].PaymentType)
                    {
                        paymentsGrid[1, i].Value = paymentType.Name;
                        break;
                    }
                }
                paymentsGrid[2, i].Value = bl.GetPaymentsList()[i].Sum;

                paymentsGrid[3, i].Value = bl.GetPaymentsList()[i].Status;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(bl);
            addEmployeeForm.ShowDialog();
            EmployeesGridRenew();
        }

        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (employeesGrid.SelectedRows.Count > 0)
            {
                if (employeesGrid.SelectedRows.Count < 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Удалить сотрудника?", "Удаление сотрудника", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var employee in bl.GetEmployeesList())
                        {
                            if (employeesGrid.CurrentRow.Cells[0].Value.ToString() == employee.FullName)
                            {
                                id = employee.ID;
                                break;
                            }
                        }
                        bool canDelete = true;
                        for (int i = 0; i < bl.GetDealsList().Count; i++)
                        {
                            if (bl.GetDealsList()[i].Employee == id)
                            {
                                MessageBox.Show("Невозможно удалить сотрудника, имеющего дела!");
                                canDelete = false;
                                break;
                            }
                        }
                        if (canDelete)
                        {
                            bl.DeleteEmployee(id);
                            EmployeesGridRenew();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выбрано более одного сотрудника!");
                }
            }
            else
            {
                MessageBox.Show("Сотрудник не выбран!");
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeesGrid.SelectedRows.Count > 0)
            {
                if (employeesGrid.SelectedRows.Count < 2)
                {
                    foreach (var employee in bl.GetEmployeesList())
                    {
                        if (employeesGrid.CurrentRow.Cells[0].Value.ToString() == employee.FullName)
                        {
                            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(bl, employee.ID, employee.FullName);
                            editEmployeeForm.ShowDialog();
                            break;
                        }
                    }
                    EmployeesGridRenew();
                }
                else
                {
                    MessageBox.Show("Выбрано более одного сотрудника!");
                }
            }
            else
            {
                MessageBox.Show("Сотрудник не выбран!");
            }

        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDealForm adddealForm = new AddDealForm(bl);
            adddealForm.ShowDialog();
            DealGridRenew();
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dealGrid.SelectedRows.Count > 0)
            {
                if (dealGrid.SelectedRows.Count < 2)
                {
                    int id = bl.GetDealsList()[dealGrid.CurrentRow.Index].ID;
                    EditDealForm editDealForm = new EditDealForm(bl, id);
                    editDealForm.ShowDialog();
                    DealGridRenew();
                    PaymentsGridRenew();
                }
                else
                {
                    MessageBox.Show("Выбрано более одного сотрудника!");
                }
            }
            else
            {
                MessageBox.Show("Сотрудник не выбран!");
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dealGrid.SelectedRows.Count > 0)
            {
                if (dealGrid.SelectedRows.Count < 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Удалить дело?", "Удаление дела", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        id = bl.GetDealsList()[dealGrid.CurrentRow.Index].ID;
                        bl.DeleteDeal(id);
                        DealGridRenew();
                        PaymentsGridRenew();
                    }
                }
                else
                {
                    MessageBox.Show("Выбрано более одного сотрудника!");
                }
            }
            else
            {
                MessageBox.Show("Сотрудник не выбран!");
            }
        }

        private void изменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (paymentsGrid.SelectedRows.Count > 0)
            {
                if (paymentsGrid.SelectedRows.Count < 2)
                {
                    int deal = bl.GetPaymentsList()[paymentsGrid.CurrentRow.Index].Deal;
                    int paymentType = bl.GetPaymentsList()[paymentsGrid.CurrentRow.Index].PaymentType;
                    bl.EditPayment(deal, paymentType);
                    PaymentsGridRenew();
                }
                else
                {
                    MessageBox.Show("Выбрано более одной оплаты!");
                }
            }
            else
            {
                MessageBox.Show("Оплата не выбрана!");
            }
        }
    }
}