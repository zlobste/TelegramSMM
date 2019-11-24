using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDesctopApp
{
    public partial class EditPost : Form
    {

        private string ImagePath;
        private readonly int id;
        readonly bool edit;

        public EditPost(int id, string Title , string Text , string Link , string Image , string AdditionaInformation , string UserId , bool IsDeleted )
            : this()
        {
            postsTableAdapter.Fill(telesmmDataSet.Posts);
            edit = true;
            this.id = id;
            titleTextBox.Text = Title;
            textTextBox.Text = Text;
            linkTextBox.Text = Link;
            pictureBox1.Image = System.Drawing.Image.FromFile(Path.GetFullPath("/Images"+Image));
           
            
            additionalInformationTextBox.Text = AdditionaInformation;
            userIdTextBox.SelectedValue = UserId;
            isDeletedCheckBox.Checked = IsDeleted;
            ImagePath = Path.GetFullPath("/Images" + Image);
           

        }

        

        public EditPost()
        {
            InitializeComponent();
            postsTableAdapter.Fill(telesmmDataSet.Posts);
            edit = false;
        }

        private void EditPost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.AspNetUsers". При необходимости она может быть перемещена или удалена.
            this.aspNetUsersTableAdapter.Fill(this.telesmmDataSet.AspNetUsers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telesmmDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.telesmmDataSet.Posts);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("/Images");



            if (edit)
            {
                if (ImagePath == pictureBox1.ImageLocation)
                {
                    postsTableAdapter.UpdateQuery(titleTextBox.Text, textTextBox.Text, linkTextBox.Text, ImagePath, additionalInformationTextBox.Text, userIdTextBox.SelectedValue.ToString(), isDeletedCheckBox.Checked, id);

                }
                else
                {
                    string image_name = Guid.NewGuid().ToString();
                    if (pictureBox1.Image != null)
                    {
                        try
                        {

                            pictureBox1.Image.Save(path + image_name + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        catch
                        {
                            MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    postsTableAdapter.UpdateQuery(titleTextBox.Text, textTextBox.Text, linkTextBox.Text,    image_name + ".jpeg", additionalInformationTextBox.Text, userIdTextBox.SelectedValue.ToString(), isDeletedCheckBox.Checked, id);

                }
            }
            else
            {
                string image_name = Guid.NewGuid().ToString();
                if (pictureBox1.Image != null) 
                {
                    try
                    {
                       
                        pictureBox1.Image.Save(path + image_name + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                postsTableAdapter.Insert(titleTextBox.Text, textTextBox.Text, linkTextBox.Text,   image_name +".jpeg", additionalInformationTextBox.Text, userIdTextBox.SelectedValue.ToString(), isDeletedCheckBox.Checked);

            }
            Close();
        }
    

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd =  new OpenFileDialog();
            
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный фaйл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
