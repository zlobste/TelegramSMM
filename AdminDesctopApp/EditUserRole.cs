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
    public partial class EditUserRole : Form
    {

        readonly bool edit;



        public EditUserRole(string UserId , string RoleId )
            : this()
        {
            edit = true;
            userIdComboBox.SelectedValue = UserId;
            roleIdComboBox.SelectedValue = RoleId;
        }



        public EditUserRole()
        {
            InitializeComponent();
            aspNetUserRolesTableAdapter.Fill(telesmmDataSet.AspNetUserRoles);
            edit = false;

        }



        private void EditUserRole_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetRoles". При необходимости она может быть перемещена или удалена.
            this.aspNetRolesTableAdapter.Fill(this.telesmmDataSet.AspNetRoles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUsers". При необходимости она может быть перемещена или удалена.
            this.aspNetUsersTableAdapter.Fill(this.telesmmDataSet.AspNetUsers);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {

                aspNetUserRolesTableAdapter.UpdateQuery(userIdComboBox.SelectedValue.ToString(), roleIdComboBox.SelectedValue.ToString());
            }
            else
            {
                aspNetUserRolesTableAdapter.Insert(userIdComboBox.SelectedValue.ToString(), roleIdComboBox.SelectedValue.ToString());
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
