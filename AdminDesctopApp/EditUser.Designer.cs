namespace AdminDesctopApp
{
    partial class EditUser
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
            System.Windows.Forms.Label telegramAccountLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordHashLabel;
            this.telegramAccountTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordHashTextBox = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.balanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.aspNetUsersTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetUsersTableAdapter();
            this.EmailConfirmedCheckBox = new System.Windows.Forms.CheckBox();
            telegramAccountLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordHashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // telegramAccountLabel
            // 
            telegramAccountLabel.AutoSize = true;
            telegramAccountLabel.Location = new System.Drawing.Point(57, 116);
            telegramAccountLabel.Name = "telegramAccountLabel";
            telegramAccountLabel.Size = new System.Drawing.Size(127, 17);
            telegramAccountLabel.TabIndex = 3;
            telegramAccountLabel.Text = "Telegram Account:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(57, 60);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(63, 17);
            balanceLabel.TabIndex = 5;
            balanceLabel.Text = "Balance:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(57, 30);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Location = new System.Drawing.Point(57, 88);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(77, 17);
            passwordHashLabel.TabIndex = 11;
            passwordHashLabel.Text = "Password :";
            // 
            // telegramAccountTextBox
            // 
            this.telegramAccountTextBox.Location = new System.Drawing.Point(251, 116);
            this.telegramAccountTextBox.Name = "telegramAccountTextBox";
            this.telegramAccountTextBox.Size = new System.Drawing.Size(269, 22);
            this.telegramAccountTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(251, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(269, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // passwordHashTextBox
            // 
            this.passwordHashTextBox.Location = new System.Drawing.Point(251, 88);
            this.passwordHashTextBox.Name = "passwordHashTextBox";
            this.passwordHashTextBox.Size = new System.Drawing.Size(269, 22);
            this.passwordHashTextBox.TabIndex = 12;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(416, 197);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(104, 33);
            this.button_Cancel.TabIndex = 30;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(58, 197);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(352, 33);
            this.button_OK.TabIndex = 29;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // balanceNumericUpDown
            // 
            this.balanceNumericUpDown.Location = new System.Drawing.Point(251, 60);
            this.balanceNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.balanceNumericUpDown.Name = "balanceNumericUpDown";
            this.balanceNumericUpDown.Size = new System.Drawing.Size(269, 22);
            this.balanceNumericUpDown.TabIndex = 31;
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
            // aspNetUsersTableAdapter
            // 
            this.aspNetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // EmailConfirmedCheckBox
            // 
            this.EmailConfirmedCheckBox.AutoSize = true;
            this.EmailConfirmedCheckBox.Location = new System.Drawing.Point(251, 144);
            this.EmailConfirmedCheckBox.Name = "EmailConfirmedCheckBox";
            this.EmailConfirmedCheckBox.Size = new System.Drawing.Size(128, 21);
            this.EmailConfirmedCheckBox.TabIndex = 32;
            this.EmailConfirmedCheckBox.Text = "EmailConfirmed";
            this.EmailConfirmedCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 287);
            this.Controls.Add(this.EmailConfirmedCheckBox);
            this.Controls.Add(this.balanceNumericUpDown);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(telegramAccountLabel);
            this.Controls.Add(this.telegramAccountTextBox);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(passwordHashLabel);
            this.Controls.Add(this.passwordHashTextBox);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox telegramAccountTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordHashTextBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.NumericUpDown balanceNumericUpDown;
        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.AspNetUsersTableAdapter aspNetUsersTableAdapter;
        private System.Windows.Forms.CheckBox EmailConfirmedCheckBox;
    }
}