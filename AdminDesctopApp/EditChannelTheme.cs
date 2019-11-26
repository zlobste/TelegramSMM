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
    public partial class EditChannelTheme : Form
    {
        
        readonly bool edit;
       


        public EditChannelTheme( int Theme_Id, int Channel_Id)
            : this()
        {
            edit = true;
            channelIdComboBox.SelectedValue = Channel_Id;
            themeIdComboBox.SelectedValue = Theme_Id;
        }



        public EditChannelTheme()
        {
            InitializeComponent();
            themeChannelsTableAdapter.Fill(telesmmDataSet.ThemeChannels);
            edit = false;

        }




        private void EditChannelTheme_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Channels". При необходимости она может быть перемещена или удалена.
            this.channelsTableAdapter.Fill(this.telesmmDataSet.Channels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Themes". При необходимости она может быть перемещена или удалена.
            this.themesTableAdapter.Fill(this.telesmmDataSet.Themes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.ThemeChannels". При необходимости она может быть перемещена или удалена.
            this.themeChannelsTableAdapter.Fill(this.telesmmDataSet.ThemeChannels);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {

                themeChannelsTableAdapter.UpdateQuery(Convert.ToInt32(themeIdComboBox.SelectedValue), Convert.ToInt32(channelIdComboBox.SelectedValue));
            }
            else
            {
                themeChannelsTableAdapter.Insert(Convert.ToInt32(themeIdComboBox.SelectedValue), Convert.ToInt32(channelIdComboBox.SelectedValue));
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
