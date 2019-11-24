namespace AdminDesctopApp
{
    partial class EditChannel
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label postPriceLabel;
            System.Windows.Forms.Label countOfSubscribersLabel;
            System.Windows.Forms.Label idLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.channelsTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.ChannelsTableAdapter();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.aspNetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspNetUsersTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetUsersTableAdapter();
            this.countOfSubscribersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.telesmmDataSet1 = new AdminDesctopApp.telesmmDataSet();
            this.telesmmDataSet2 = new AdminDesctopApp.telesmmDataSet();
            this.postPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            postPriceLabel = new System.Windows.Forms.Label();
            countOfSubscribersLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfSubscribersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(39, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(39, 79);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(38, 17);
            linkLabel.TabIndex = 5;
            linkLabel.Text = "Link:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(39, 107);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(44, 17);
            typeLabel.TabIndex = 7;
            typeLabel.Text = "Type:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(39, 135);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(46, 17);
            userIdLabel.TabIndex = 9;
            userIdLabel.Text = "User :";
            // 
            // postPriceLabel
            // 
            postPriceLabel.AutoSize = true;
            postPriceLabel.Location = new System.Drawing.Point(39, 163);
            postPriceLabel.Name = "postPriceLabel";
            postPriceLabel.Size = new System.Drawing.Size(76, 17);
            postPriceLabel.TabIndex = 11;
            postPriceLabel.Text = "Post Price:";
            // 
            // countOfSubscribersLabel
            // 
            countOfSubscribersLabel.AutoSize = true;
            countOfSubscribersLabel.Location = new System.Drawing.Point(39, 191);
            countOfSubscribersLabel.Name = "countOfSubscribersLabel";
            countOfSubscribersLabel.Size = new System.Drawing.Size(147, 17);
            countOfSubscribersLabel.TabIndex = 13;
            countOfSubscribersLabel.Text = "Count Of Subscribers:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(39, 23);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(79, 17);
            idLabel.TabIndex = 21;
            idLabel.Text = "Channel Id:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(192, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(192, 76);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(185, 22);
            this.linkTextBox.TabIndex = 6;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(213, 258);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(164, 33);
            this.button_Cancel.TabIndex = 16;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(42, 258);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(165, 33);
            this.button_OK.TabIndex = 15;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
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
            // channelsTableAdapter
            // 
            this.channelsTableAdapter.ClearBeforeFill = true;
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DataSource = this.aspNetUsersBindingSource;
            this.userIdComboBox.DisplayMember = "Email";
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(192, 130);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(185, 24);
            this.userIdComboBox.TabIndex = 17;
            this.userIdComboBox.ValueMember = "Id";
            // 
            // aspNetUsersBindingSource
            // 
            this.aspNetUsersBindingSource.DataMember = "AspNetUsers";
            this.aspNetUsersBindingSource.DataSource = this.bindingSource1;
            // 
            // aspNetUsersTableAdapter
            // 
            this.aspNetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // countOfSubscribersNumericUpDown
            // 
            this.countOfSubscribersNumericUpDown.Location = new System.Drawing.Point(192, 186);
            this.countOfSubscribersNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.countOfSubscribersNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.countOfSubscribersNumericUpDown.Name = "countOfSubscribersNumericUpDown";
            this.countOfSubscribersNumericUpDown.Size = new System.Drawing.Size(185, 22);
            this.countOfSubscribersNumericUpDown.TabIndex = 18;
            this.countOfSubscribersNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "открытый",
            "закрытый",
            "чат"});
            this.typeComboBox.Location = new System.Drawing.Point(192, 104);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(185, 24);
            this.typeComboBox.TabIndex = 19;
            // 
            // telesmmDataSet1
            // 
            this.telesmmDataSet1.DataSetName = "telesmmDataSet";
            this.telesmmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telesmmDataSet2
            // 
            this.telesmmDataSet2.DataSetName = "telesmmDataSet";
            this.telesmmDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postPriceNumericUpDown
            // 
            this.postPriceNumericUpDown.Location = new System.Drawing.Point(192, 158);
            this.postPriceNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.postPriceNumericUpDown.Name = "postPriceNumericUpDown";
            this.postPriceNumericUpDown.Size = new System.Drawing.Size(185, 22);
            this.postPriceNumericUpDown.TabIndex = 20;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(192, 18);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(185, 22);
            this.idTextBox.TabIndex = 22;
            // 
            // EditChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 356);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.postPriceNumericUpDown);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.countOfSubscribersNumericUpDown);
            this.Controls.Add(this.userIdComboBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(linkLabel);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(postPriceLabel);
            this.Controls.Add(countOfSubscribersLabel);
            this.Name = "EditChannel";
            this.Text = "EditChannel";
            this.Load += new System.EventHandler(this.EditChannel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfSubscribersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.ChannelsTableAdapter channelsTableAdapter;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private System.Windows.Forms.BindingSource aspNetUsersBindingSource;
        private telesmmDataSetTableAdapters.AspNetUsersTableAdapter aspNetUsersTableAdapter;
        private System.Windows.Forms.NumericUpDown countOfSubscribersNumericUpDown;
        private System.Windows.Forms.ComboBox typeComboBox;
        private telesmmDataSet telesmmDataSet1;
        private telesmmDataSet telesmmDataSet2;
        private System.Windows.Forms.NumericUpDown postPriceNumericUpDown;
        private System.Windows.Forms.TextBox idTextBox;
    }
}