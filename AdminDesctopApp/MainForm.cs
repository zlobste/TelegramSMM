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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Themes". При необходимости она может быть перемещена или удалена.
            this.themesTableAdapter.Fill(this.telesmmDataSet.Themes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.ThemeChannels". При необходимости она может быть перемещена или удалена.
            this.themeChannelsTableAdapter.Fill(this.telesmmDataSet.ThemeChannels);
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
            themesTableAdapter.Update(telesmmDataSet);
            themeChannelsTableAdapter.Update(telesmmDataSet);

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

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = themesBindingSource;
            dataGridView1.DataSource = themesBindingSource;
            label1.Text = "Themes";
        }

        private void themeChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = themeChannelsBindingSource;
            dataGridView1.DataSource = themeChannelsBindingSource;
            label1.Text = "ThemeChannel";
        }

        private void editQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new EditQuery();
            qe.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private bool edit = true;
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            if (dataGridView1.DataSource == themesBindingSource)
            {
                var edt = new EditTheme();
                edt.ShowDialog();
                themesTableAdapter.Fill(telesmmDataSet.Themes);

            }
            else if (dataGridView1.DataSource == postsBindingSource)
            {
                var edt = new EditPost();
                edt.ShowDialog();
                postsTableAdapter.Fill(telesmmDataSet.Posts);
            }
            else if (dataGridView1.DataSource == channelsBindingSource)
            {
                var edt = new EditChannel();
                edt.ShowDialog();
                channelsTableAdapter.Fill(telesmmDataSet.Channels);
            }
            else if (dataGridView1.DataSource == ordersBindingSource)
            {
                var edt = new EditOrder();
                edt.ShowDialog();
                ordersTableAdapter.Fill(telesmmDataSet.Orders);
            }
            else if (dataGridView1.DataSource == aspNetRolesBindingSource)
            {
                var edt = new EditRole();
                edt.ShowDialog();
                aspNetRolesTableAdapter.Fill(telesmmDataSet.AspNetRoles);
            }
            else if (dataGridView1.DataSource == aspNetUsersBindingSource)
            {
                var edt = new EditUser();
                edt.ShowDialog();
                aspNetUsersTableAdapter.Fill(telesmmDataSet.AspNetUsers);
            }
            else if (dataGridView1.DataSource == themeChannelsBindingSource)
            {
                var edt = new EditChannelTheme();
                edt.ShowDialog();
                themeChannelsTableAdapter.Fill(telesmmDataSet.ThemeChannels);
            }
            else if (dataGridView1.DataSource == aspNetUserRolesBindingSource)
            {
                var edt = new EditUserRole();
                edt.ShowDialog();
                aspNetUserRolesTableAdapter.Fill(telesmmDataSet.AspNetUserRoles);
            }

            telesmmDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            if (dataGridView1.DataSource == themesBindingSource)
            {
                var st = new telesmmDataSet.ThemesDataTable();
              
                themesTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditTheme(
                    Convert.ToInt32(row[0]),
                    row[1].ToString()
                );
                edt.ShowDialog();
                themesTableAdapter.Fill(telesmmDataSet.Themes);
            }
            else if (dataGridView1.DataSource == postsBindingSource)
            {
                var st = new telesmmDataSet.PostsDataTable();
                postsTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditPost(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    Convert.ToBoolean(row[7]));

                edt.ShowDialog();
                postsTableAdapter.Fill(telesmmDataSet.Posts);
            }
            else if (dataGridView1.DataSource == channelsBindingSource)
            {
                var st = new telesmmDataSet.ChannelsDataTable();
                channelsTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditChannel(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    Convert.ToDouble(row[5]),
                    Convert.ToInt32(row[6])
                );

                edt.ShowDialog();
                channelsTableAdapter.Fill(telesmmDataSet.Channels);
            }
            else if (dataGridView1.DataSource == ordersBindingSource)
            {
                var st = new telesmmDataSet.OrdersDataTable();
                ordersTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditOrder(
                    Convert.ToInt32(row[0]),
                    Convert.ToDateTime(row[1]),
                    Convert.ToInt32(row[2]),
                    Convert.ToInt32(row[3]),
                    Convert.ToDateTime(row[4])

                );
                edt.ShowDialog();
                ordersTableAdapter.Fill(telesmmDataSet.Orders);
            }
            else if (dataGridView1.DataSource == aspNetRolesBindingSource)
            {
                var st = new telesmmDataSet.AspNetRolesDataTable();
                aspNetRolesTableAdapter.FillBy(st, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditRole(
                    row[0].ToString(), 
                    row[1].ToString(),
                row[2].ToString()
                );
                edt.ShowDialog();
                aspNetRolesTableAdapter.Fill(telesmmDataSet.AspNetRoles);
            }
            else if (dataGridView1.DataSource == aspNetUsersBindingSource)
            {
                var st = new telesmmDataSet.AspNetUsersDataTable();
                aspNetUsersTableAdapter.FillBy(st, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditUser(
                    row[0].ToString(),
                    row[3].ToString(),
                   Convert.ToDouble( row[2]),
                    row[4].ToString(),
                    row[1].ToString(),
                    Convert.ToBoolean(row[6])
                );
                edt.ShowDialog();
                aspNetUsersTableAdapter.Fill(telesmmDataSet.AspNetUsers);
            }
            else if (dataGridView1.DataSource == themeChannelsBindingSource)
            {
                var st = new telesmmDataSet.ThemeChannelsDataTable();
                themeChannelsTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) , Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditChannelTheme(
                    Convert.ToInt32(row[0]),
                            Convert.ToInt32(row[1])

                );
                edt.ShowDialog();
                themeChannelsTableAdapter.Fill(telesmmDataSet.ThemeChannels);
            }
            else if (dataGridView1.DataSource == aspNetUserRolesBindingSource)
            {
                var st = new telesmmDataSet.AspNetUserRolesDataTable();
                aspNetUserRolesTableAdapter.FillBy(st, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditUserRole(
                    row[0].ToString(),
                    row[1].ToString()

                );
                edt.ShowDialog();
                aspNetUserRolesTableAdapter.Fill(telesmmDataSet.AspNetUserRoles);
            }

            telesmmDataSet.AcceptChanges();
        }

        


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;

            if (dataGridView1.DataSource == themesBindingSource)
            {
                themesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                themesTableAdapter.Fill(telesmmDataSet.Themes);

            }
            else if (dataGridView1.DataSource == postsBindingSource)
            {
                postsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                postsTableAdapter.Fill(telesmmDataSet.Posts);

            }
            else if (dataGridView1.DataSource ==channelsBindingSource)
            {
                channelsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                channelsTableAdapter.Fill(telesmmDataSet.Channels);
            }
            else if (dataGridView1.DataSource == ordersBindingSource)
            {
                ordersTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                ordersTableAdapter.Fill(telesmmDataSet.Orders);

            }
            else if (dataGridView1.DataSource == aspNetRolesBindingSource)
            {
                aspNetRolesTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                aspNetRolesTableAdapter.Fill(telesmmDataSet.AspNetRoles);
            }
            else if (dataGridView1.DataSource == aspNetUsersBindingSource)
            {
                aspNetUsersTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                aspNetUsersTableAdapter.Fill(telesmmDataSet.AspNetUsers);
            }
            else if (dataGridView1.DataSource == themeChannelsBindingSource)
            {
                themeChannelsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) , Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                themeChannelsTableAdapter.Fill(telesmmDataSet.ThemeChannels);
            }
            else if (dataGridView1.DataSource == aspNetUserRolesBindingSource)
            {
                aspNetUserRolesTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                aspNetUserRolesTableAdapter.Fill(telesmmDataSet.AspNetUserRoles);
            }
        }
    }
}
