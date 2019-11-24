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
    public partial class EditOrder : Form
    {
        
        private readonly int id;
        readonly bool edit;

        public EditOrder(int id, DateTime PublicationDate , int ChannelId ,int PostId , DateTime DatePost)
            : this()
        {

            edit = true;
            this.id = id;
            publicationDateDateTimePicker.Value = PublicationDate;
            channelComboBox.SelectedValue = ChannelId;
            
            postComboBox.SelectedValue = PostId;

            postDateLabel.Visible = true;
            label1.Visible = true;
            postDateLabel.Text = DatePost.ToString();


        }



        public EditOrder()
        {
            InitializeComponent();
            ordersTableAdapter.Fill(telesmmDataSet.Orders);
            edit = false;

            postDateLabel.Visible = false;
            label1.Visible = false;

        }

        private void button_OK_Click(object sender, EventArgs e)
        {


            if (edit)
            {
                ordersTableAdapter.UpdateQuery(publicationDateDateTimePicker.Value, Convert.ToInt32(channelComboBox.SelectedValue), Convert.ToInt32(postComboBox.SelectedValue),Convert.ToDateTime(postDateLabel.Text) , id);
            }
            else
            {
                ordersTableAdapter.Insert(publicationDateDateTimePicker.Value, Convert.ToInt32(channelComboBox.SelectedValue), Convert.ToInt32(postComboBox.SelectedValue), DateTime.Now);
            }
            Close();



        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUsers". При необходимости она может быть перемещена или удалена.
            this.aspNetUsersTableAdapter.Fill(this.telesmmDataSet.AspNetUsers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Channels". При необходимости она может быть перемещена или удалена.
            this.channelsTableAdapter.Fill(this.telesmmDataSet.Channels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.telesmmDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.telesmmDataSet.Orders);

        }
    }
}
