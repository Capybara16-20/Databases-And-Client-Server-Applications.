using System;
using System.Linq;
using System.Windows.Forms;
using DanceStudioBL;

namespace DanceStudioUI
{
    public partial class AddClientForm : Form
    {
        private const string notEnteredMessage = "Данные не введены.";
        private const string incorrectDateMessage = "Некорректная дата.";

        private readonly BusinessLogic bl;

        public AddClientForm(BusinessLogic bl)
        {
            InitializeComponent();

            this.bl = bl;
        }

        private void btnAddClient_Click(object sender, EventArgs e) => AddClient();

        private void AddClient()
        {
            if (!IsEntered())
            {
                MessageBox.Show(notEnteredMessage);
                return;
            }
            else if (!IsDateCorrect())
            {
                MessageBox.Show(incorrectDateMessage);
                return;
            }

            string surname = tbSurname.Text;
            string name = tbName.Text;
            string patronymic = tbPatronymic.Text;
            DateTime birthDate = dtpBirthDate.Value;
            string phone = tbPhone.Text;
            bl.AddClient(surname, name, patronymic, birthDate, phone);

            Close();
        }

        private bool IsEntered()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;

            return true;
        }

        private bool IsDateCorrect()
        {
            return !(dtpBirthDate.Value > DateTime.Now.AddYears(-3)
                || dtpBirthDate.Value < DateTime.Now.AddYears(-80));
        }
    }
}
