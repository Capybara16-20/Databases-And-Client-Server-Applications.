using System;
using System.Linq;
using System.Windows.Forms;
using DanceStudioBL;

namespace DanceStudioUI
{
    public partial class EditClientForm : Form
    {
        private const string notEnteredMessage = "Данные не введены.";
        private const string incorrectDateMessage = "Некорректная дата.";

        private readonly BusinessLogic bl;
        private readonly int id;
        private string surname;
        private string name;
        private string patronymic;
        private readonly DateTime birthDate;
        private readonly string phone;

        public EditClientForm(BusinessLogic bl, int id, string fullName, DateTime birthDate, string phone)
        {
            InitializeComponent();

            this.bl = bl;
            this.id = id;
            GetFullNameParts(fullName);
            this.birthDate = birthDate;
            this.phone = phone;

            tbSurname.Text = surname;
            tbName.Text = name;
            tbPatronymic.Text = patronymic;
            dtpBirthDate.Value = birthDate;
            tbPhone.Text = phone;
        }

        private void btnEditClient_Click(object sender, EventArgs e) => EditClient();

        private void EditClient()
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
            string fullName = GetFullName(surname, name, patronymic);
            bl.EditClient(id, fullName, birthDate, phone);

            Close();
        }

        private void GetFullNameParts(string fullName)
        {
            const int surnameIndex = 0;
            const int nameIndex = 1;
            const int patronymicIndex = 2;

            string[] fullNameParts = fullName.Split(' ');
            surname = fullNameParts[surnameIndex];
            name = fullNameParts[nameIndex];
            patronymic = fullNameParts[patronymicIndex];
        }

        private static string GetFullName(string surname, string name, string patronymic)
        {
            return string.Format("{0} {1} {2}", surname, name, patronymic);
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
