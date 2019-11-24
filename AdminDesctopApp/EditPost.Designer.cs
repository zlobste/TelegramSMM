namespace AdminDesctopApp
{
    partial class EditPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label textLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label additionalInformationLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label isDeletedLabel;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.postsTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.PostsTableAdapter();
            this.aspNetUsersTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetUsersTableAdapter();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.isDeletedCheckBox = new System.Windows.Forms.CheckBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.userIdTextBox = new System.Windows.Forms.ComboBox();
            this.aspNetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.additionalInformationTextBox = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            titleLabel = new System.Windows.Forms.Label();
            textLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            additionalInformationLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            isDeletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(72, 36);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(72, 93);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(39, 17);
            textLabel.TabIndex = 4;
            textLabel.Text = "Text:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(73, 258);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(38, 17);
            linkLabel.TabIndex = 6;
            linkLabel.Text = "Link:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(569, 36);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(50, 17);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "Image:";
            // 
            // additionalInformationLabel
            // 
            additionalInformationLabel.AutoSize = true;
            additionalInformationLabel.Location = new System.Drawing.Point(73, 323);
            additionalInformationLabel.Name = "additionalInformationLabel";
            additionalInformationLabel.Size = new System.Drawing.Size(148, 17);
            additionalInformationLabel.TabIndex = 10;
            additionalInformationLabel.Text = "Additional Information:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(569, 323);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(57, 17);
            userIdLabel.TabIndex = 12;
            userIdLabel.Text = "User Id:";
            // 
            // isDeletedLabel
            // 
            isDeletedLabel.AutoSize = true;
            isDeletedLabel.Location = new System.Drawing.Point(569, 387);
            isDeletedLabel.Name = "isDeletedLabel";
            isDeletedLabel.Size = new System.Drawing.Size(75, 17);
            isDeletedLabel.TabIndex = 14;
            isDeletedLabel.Text = "Is Deleted:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.telesmmDataSet;
            this.bindingSource1.Position = 0;
            // 
            // telesmmDataSet
            // 
            this.telesmmDataSet.DataSetName = "telesmmDataSet";
            this.telesmmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // aspNetUsersTableAdapter
            // 
            this.aspNetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(75, 56);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(475, 22);
            this.titleTextBox.TabIndex = 3;
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(76, 281);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(475, 22);
            this.linkTextBox.TabIndex = 7;
            // 
            // isDeletedCheckBox
            // 
            this.isDeletedCheckBox.Location = new System.Drawing.Point(572, 415);
            this.isDeletedCheckBox.Name = "isDeletedCheckBox";
            this.isDeletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDeletedCheckBox.TabIndex = 15;
            this.isDeletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(572, 476);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(321, 33);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(75, 476);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(475, 33);
            this.button_OK.TabIndex = 16;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataSource = this.aspNetUsersBindingSource;
            this.userIdTextBox.DisplayMember = "Email";
            this.userIdTextBox.FormattingEnabled = true;
            this.userIdTextBox.Location = new System.Drawing.Point(572, 343);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(321, 24);
            this.userIdTextBox.TabIndex = 18;
            this.userIdTextBox.ValueMember = "Id";
            // 
            // aspNetUsersBindingSource
            // 
            this.aspNetUsersBindingSource.DataMember = "AspNetUsers";
            this.aspNetUsersBindingSource.DataSource = this.bindingSource1;
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(75, 113);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(475, 130);
            this.textTextBox.TabIndex = 19;
            this.textTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(572, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // additionalInformationTextBox
            // 
            this.additionalInformationTextBox.Location = new System.Drawing.Point(75, 343);
            this.additionalInformationTextBox.Name = "additionalInformationTextBox";
            this.additionalInformationTextBox.Size = new System.Drawing.Size(475, 96);
            this.additionalInformationTextBox.TabIndex = 21;
            this.additionalInformationTextBox.Text = "";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(572, 249);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(321, 54);
            this.openButton.TabIndex = 22;
            this.openButton.Text = "Add image";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.telesmmDataSet;
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 548);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.additionalInformationTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(textLabel);
            this.Controls.Add(linkLabel);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(additionalInformationLabel);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(isDeletedLabel);
            this.Controls.Add(this.isDeletedCheckBox);
            this.Name = "EditPost";
            this.Text = "EditPost";
            this.Load += new System.EventHandler(this.EditPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.CheckBox isDeletedCheckBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private telesmmDataSetTableAdapters.AspNetUsersTableAdapter aspNetUsersTableAdapter;
        private System.Windows.Forms.ComboBox userIdTextBox;
        private System.Windows.Forms.BindingSource aspNetUsersBindingSource;
        private System.Windows.Forms.RichTextBox textTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox additionalInformationTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.BindingSource postsBindingSource;
    }
}