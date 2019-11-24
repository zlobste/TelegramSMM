namespace AdminDesctopApp
{
    partial class EditRole
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
            System.Windows.Forms.Label discriminatorLabel;
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.discriminatorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.aspNetRolesTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetRolesTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            discriminatorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(49, 48);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // discriminatorLabel
            // 
            discriminatorLabel.AutoSize = true;
            discriminatorLabel.Location = new System.Drawing.Point(49, 76);
            discriminatorLabel.Name = "discriminatorLabel";
            discriminatorLabel.Size = new System.Drawing.Size(94, 17);
            discriminatorLabel.TabIndex = 25;
            discriminatorLabel.Text = "Discriminator:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(254, 205);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(164, 33);
            this.button_Cancel.TabIndex = 20;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(52, 205);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(165, 33);
            this.button_OK.TabIndex = 19;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(149, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(269, 22);
            this.nameTextBox.TabIndex = 24;
            // 
            // discriminatorRichTextBox
            // 
            this.discriminatorRichTextBox.Location = new System.Drawing.Point(149, 76);
            this.discriminatorRichTextBox.Name = "discriminatorRichTextBox";
            this.discriminatorRichTextBox.Size = new System.Drawing.Size(269, 96);
            this.discriminatorRichTextBox.TabIndex = 26;
            this.discriminatorRichTextBox.Text = "";
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
            // aspNetRolesTableAdapter
            // 
            this.aspNetRolesTableAdapter.ClearBeforeFill = true;
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 290);
            this.Controls.Add(this.discriminatorRichTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(discriminatorLabel);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "EditRole";
            this.Text = "EditRole";
            this.Load += new System.EventHandler(this.EditRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox discriminatorRichTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.AspNetRolesTableAdapter aspNetRolesTableAdapter;
    }
}