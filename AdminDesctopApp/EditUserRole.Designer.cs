namespace AdminDesctopApp
{
    partial class EditUserRole
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label roleIdLabel;
            this.roleIdComboBox = new System.Windows.Forms.ComboBox();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.aspNetUserRolesTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetUserRolesTableAdapter();
            this.aspNetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspNetUsersTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetUsersTableAdapter();
            this.aspNetRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspNetRolesTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetRolesTableAdapter();
            userIdLabel = new System.Windows.Forms.Label();
            roleIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roleIdComboBox
            // 
            this.roleIdComboBox.DataSource = this.aspNetRolesBindingSource;
            this.roleIdComboBox.DisplayMember = "Name";
            this.roleIdComboBox.FormattingEnabled = true;
            this.roleIdComboBox.Location = new System.Drawing.Point(147, 73);
            this.roleIdComboBox.Name = "roleIdComboBox";
            this.roleIdComboBox.Size = new System.Drawing.Size(154, 24);
            this.roleIdComboBox.TabIndex = 40;
            this.roleIdComboBox.ValueMember = "Id";
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DataSource = this.aspNetUsersBindingSource;
            this.userIdComboBox.DisplayMember = "Email";
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(147, 43);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(154, 24);
            this.userIdComboBox.TabIndex = 39;
            this.userIdComboBox.ValueMember = "Id";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(190, 117);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 33);
            this.button_Cancel.TabIndex = 38;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(56, 117);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(111, 33);
            this.button_OK.TabIndex = 37;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(53, 48);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(42, 17);
            userIdLabel.TabIndex = 35;
            userIdLabel.Text = "User:";
            // 
            // roleIdLabel
            // 
            roleIdLabel.AutoSize = true;
            roleIdLabel.Location = new System.Drawing.Point(53, 76);
            roleIdLabel.Name = "roleIdLabel";
            roleIdLabel.Size = new System.Drawing.Size(41, 17);
            roleIdLabel.TabIndex = 36;
            roleIdLabel.Text = "Role:";
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
            // aspNetUserRolesTableAdapter
            // 
            this.aspNetUserRolesTableAdapter.ClearBeforeFill = true;
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
            // aspNetRolesBindingSource
            // 
            this.aspNetRolesBindingSource.DataMember = "AspNetRoles";
            this.aspNetRolesBindingSource.DataSource = this.bindingSource1;
            // 
            // aspNetRolesTableAdapter
            // 
            this.aspNetRolesTableAdapter.ClearBeforeFill = true;
            // 
            // EditUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 206);
            this.Controls.Add(this.roleIdComboBox);
            this.Controls.Add(this.userIdComboBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(roleIdLabel);
            this.Name = "EditUserRole";
            this.Text = "EditUserRole";
            this.Load += new System.EventHandler(this.EditUserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetRolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roleIdComboBox;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.AspNetUserRolesTableAdapter aspNetUserRolesTableAdapter;
        private System.Windows.Forms.BindingSource aspNetUsersBindingSource;
        private telesmmDataSetTableAdapters.AspNetUsersTableAdapter aspNetUsersTableAdapter;
        private System.Windows.Forms.BindingSource aspNetRolesBindingSource;
        private telesmmDataSetTableAdapters.AspNetRolesTableAdapter aspNetRolesTableAdapter;
    }
}