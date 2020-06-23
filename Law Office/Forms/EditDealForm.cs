using System;
using System.ComponentModel;
using System.Windows.Forms;
using Actions;

namespace Forms
{
    public partial class EditDealForm : Form
    {
        BusinessLogic bl = new BusinessLogic();
        int id;
        int? stage;
        int? status;

        public EditDealForm(BusinessLogic bl, int id)
        {
            InitializeComponent();
            this.bl = bl;
            this.id = id;
            foreach (var stage in bl.GetStagesList())
            {
                comboBoxStage.Items.Add(stage.Step);
            }
            comboBoxStage.Items.Add("Отсутствует");
            foreach (var status in bl.GetEndingStatusesList())
            {
                comboBoxStatus.Items.Add(status.Status);
            }
            comboBoxStatus.Items.Add("Отсутствует");
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxStage.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxStage.Focus();
                errorProvider.SetError(comboBoxStage, "Стадия дела не выбрана!");
            }
        }

        private void comboBoxStatus_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxStatus.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxStatus.Focus();
                errorProvider.SetError(comboBoxStatus, "Статус завершения не выбран не выбран!");
            }
        }

        private void buttonEditDeal_Click(object sender, EventArgs e)
        {
            string strStage = string.Empty;
            string strStatus = string.Empty;
            if ((comboBoxStage.SelectedIndex > -1) && (comboBoxStatus.SelectedIndex > -1))
            {
                strStage = comboBoxStage.SelectedItem.ToString();
                strStatus = comboBoxStatus.SelectedItem.ToString();
                if ((strStage == "Отсутствует") && (strStatus == "Отсутствует"))
                {
                    MessageBox.Show("У дела не может одновременно отсутствовать стадия и статус завершения!");
                }
                else if ((strStage != "Отсутствует") && (strStatus != "Отсутствует"))
                {
                    MessageBox.Show("Дела не может одновременно иметь стадию и статус завершения!");
                }
                else
                {
                    if (strStage == "Отсутствует")
                    {
                        stage = null;
                    }
                    else
                    {
                        for (int i = 0; i < bl.GetStagesList().Count; i++)
                        {

                            if (bl.GetStagesList()[i].Step == strStage)
                            {
                                stage = bl.GetStagesList()[i].ID;
                                break;
                            }
                        }
                    }
                    if (strStatus == "Отсутствует")
                    {
                        status = null;
                    }
                    else
                    {
                        for (int i = 0; i < bl.GetEndingStatusesList().Count; i++)
                        {
                            if (bl.GetEndingStatusesList()[i].Status == strStatus)
                            {
                                status = bl.GetEndingStatusesList()[i].ID;
                                break;
                            }
                        }
                    }
                    bl.EditDeal(id, stage, status);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Данные не введены!");
            }
        }
    }
}
