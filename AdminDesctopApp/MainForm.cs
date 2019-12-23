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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.telesmmDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.telesmmDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Channels". При необходимости она может быть перемещена или удалена.
            this.channelsTableAdapter.Fill(this.telesmmDataSet.Channels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUsers". При необходимости она может быть перемещена или удалена.
            this.aspNetUsersTableAdapter.Fill(this.telesmmDataSet.AspNetUsers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUserRoles". При необходимости она может быть перемещена или удалена.
            this.aspNetUserRolesTableAdapter.Fill(this.telesmmDataSet.AspNetUserRoles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetRoles". При необходимости она может быть перемещена или удалена.
            this.aspNetRolesTableAdapter.Fill(this.telesmmDataSet.AspNetRoles);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aspNetUsersTableAdapter.Update(telesmmDataSet);
            aspNetRolesTableAdapter.Update(telesmmDataSet);
            aspNetUserRolesTableAdapter.Update(telesmmDataSet);
            channelsTableAdapter.Update(telesmmDataSet);
            ordersTableAdapter.Update(telesmmDataSet);
            postsTableAdapter.Update(telesmmDataSet);
            

        }

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = aspNetUsersBindingSource;
            dataGridView1.DataSource = aspNetUsersBindingSource;
            label1.Text = "Users";
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = aspNetRolesBindingSource;
            dataGridView1.DataSource = aspNetRolesBindingSource;
            label1.Text = "Roles";
        }

        private void userRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = aspNetUserRolesBindingSource;
            dataGridView1.DataSource = aspNetUserRolesBindingSource;
            label1.Text = "UserRoles";
        }

        private void channelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = channelsBindingSource;
            dataGridView1.DataSource = channelsBindingSource;
            label1.Text = "Channels";
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = ordersBindingSource;
            dataGridView1.DataSource = ordersBindingSource;
            label1.Text = "Orders";
        }

        private void postsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = postsBindingSource;
            dataGridView1.DataSource = postsBindingSource;
            label1.Text = "Posts";
        }

     
        private void editQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new EditQuery();
            qe.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
