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
    public partial class EditChannel : Form
    {
        
        private readonly int id;
        readonly bool edit;

        public EditChannel(int id,  string Name, string Link, string Type, string UserId, double PostPrice, int CountOfSubscribers)
            : this()
        {
            
            edit = true;
            this.id = id;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = Name;
            linkTextBox.Text = Link;
            switch (Type.ToUpper())
            {
                case "открытый":
                    typeComboBox.SelectedIndex = 0;
                    break;
                case "закрытый":
                    typeComboBox.SelectedIndex = 1;
                    break;
                case "чат":
                    typeComboBox.SelectedIndex = 2;
                    break;
                default:
                    typeComboBox.SelectedIndex = 0;
                    break;
            }

            userIdComboBox.SelectedValue = UserId;
            postPriceNumericUpDown.Value = Convert.ToDecimal(PostPrice);
            countOfSubscribersNumericUpDown.Value = Convert.ToDecimal(CountOfSubscribers);

        }



        public EditChannel()
        {
            InitializeComponent();
            channelsTableAdapter.Fill(telesmmDataSet.Channels);
            edit = false;
        }





        private void EditChannel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUsers". При необходимости она может быть перемещена или удалена.
            this.aspNetUsersTableAdapter.Fill(this.telesmmDataSet.AspNetUsers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Channels". При необходимости она может быть перемещена или удалена.
            this.channelsTableAdapter.Fill(this.telesmmDataSet.Channels);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            string Type = "";
            if (typeComboBox.SelectedIndex == 0)
            {
                Type = "открытый";
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                Type = "закрытый";
            }
            else if (typeComboBox.SelectedIndex == 2)
            {
                Type = "чат";
            }
            if (edit)
            {
                channelsTableAdapter.UpdateQuery(nameTextBox.Text, linkTextBox.Text, Type, userIdComboBox.SelectedValue.ToString(), Convert.ToDouble(postPriceNumericUpDown.Value) , Convert.ToInt32(countOfSubscribersNumericUpDown.Value),  id);
            }
            else
            {
                channelsTableAdapter.ChannelInsertQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, linkTextBox.Text, Type, userIdComboBox.SelectedValue.ToString(), Convert.ToDouble(postPriceNumericUpDown.Value), Convert.ToInt32(countOfSubscribersNumericUpDown.Value));
            }
            Close();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
