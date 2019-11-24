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
    public partial class EditTheme : Form
    {
       
        public EditTheme()
        {
            InitializeComponent();
            themesTableAdapter.Fill(telesmmDataSet.Themes);
            edit = false;
        }

        public EditTheme(int id,string Name)
            : this()
        {
            themesTableAdapter.Fill(telesmmDataSet.Themes);
            edit = true;
            this.id = id; 
            nameTextBox.Text = Name;
        }
       
        private readonly int id;
        
        readonly bool edit;


        private void EditTheme_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Themes". При необходимости она может быть перемещена или удалена.
            this.themesTableAdapter.Fill(this.telesmmDataSet.Themes);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                themesTableAdapter.UpdateQuery(nameTextBox.Text, id);
            }
            else
            {
                themesTableAdapter.Insert(nameTextBox.Text);

            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
