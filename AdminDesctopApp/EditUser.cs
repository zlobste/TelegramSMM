using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDesctopApp
{
    public partial class EditUser : Form
    {
        private readonly string id;
        readonly bool edit;
        private string PasswordHash;


        public EditUser (string id, string Email, double Balance , string Password, string TelegramAccount, bool EmailConfirmed)
            : this()
        {

            edit = true;
            this.id = id;
            emailTextBox.Text = Email;
            telegramAccountTextBox.Text = TelegramAccount;
            balanceNumericUpDown.Value = Convert.ToDecimal(Balance);
            passwordHashTextBox.Text = Password;
            PasswordHash = Password;
            EmailConfirmedCheckBox.Checked = EmailConfirmed;
            
            EmailConfirmedCheckBox.Visible = true;
        }



        public EditUser()
        {
            InitializeComponent();
            aspNetUsersTableAdapter.Fill(telesmmDataSet.AspNetUsers);
            edit = false;
            EmailConfirmedCheckBox.Visible = false;

        }




        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUsers". При необходимости она может быть перемещена или удалена.
            this.aspNetUsersTableAdapter.Fill(this.telesmmDataSet.AspNetUsers);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {

                if (PasswordHash != passwordHashTextBox.Text.GetHashCode().ToString())
                {
                    PasswordHash = passwordHashTextBox.Text.GetHashCode().ToString();
                }
                
                aspNetUsersTableAdapter.UpdateQuery( telegramAccountTextBox.Text, Convert.ToDouble(balanceNumericUpDown.Text), emailTextBox.Text , PasswordHash, emailTextBox.Text, EmailConfirmedCheckBox.Checked, id);
            }
            else
            {
                aspNetUsersTableAdapter.InsertQuery(Guid.NewGuid().ToString(), telegramAccountTextBox.Text, Convert.ToDouble(balanceNumericUpDown.Text), emailTextBox.Text, passwordHashTextBox.Text.GetHashCode().ToString(), emailTextBox.Text , false);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
