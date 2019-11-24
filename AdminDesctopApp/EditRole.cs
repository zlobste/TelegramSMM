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
    public partial class EditRole : Form
    {
        private readonly string id;
        readonly bool edit;

        public EditRole(string id, string Name , string Discriminator)
            : this()
        {

            edit = true;
            this.id = id;
            nameTextBox.Text = Name;
            discriminatorRichTextBox.Text = Discriminator;

        }



        public EditRole()
        {
            InitializeComponent();
            aspNetRolesTableAdapter.Fill(telesmmDataSet.AspNetRoles);
            edit = false;

        }


        private void button_OK_Click(object sender, EventArgs e)
        {

            if (edit)
            {
               aspNetRolesTableAdapter.UpdateQuery(nameTextBox.Text, discriminatorRichTextBox.Text, id.ToString());
            }
            else
            {
                aspNetRolesTableAdapter.Insert(Guid.NewGuid().ToString() ,nameTextBox.Text, discriminatorRichTextBox.Text);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aspNetRolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aspNetRolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.telesmmDataSet);

        }

        private void EditRole_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetRoles". При необходимости она может быть перемещена или удалена.
            this.aspNetRolesTableAdapter.Fill(this.telesmmDataSet.AspNetRoles);

        }
    }
}
