namespace AdminDesctopApp
{
    partial class EditChannelTheme
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
            System.Windows.Forms.Label theme_IdLabel;
            System.Windows.Forms.Label channel_IdLabel;
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.themeChannelsTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.ThemeChannelsTableAdapter();
            this.themeIdComboBox = new System.Windows.Forms.ComboBox();
            this.channelIdComboBox = new System.Windows.Forms.ComboBox();
            this.themesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themesTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.ThemesTableAdapter();
            this.channelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.channelsTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.ChannelsTableAdapter();
            theme_IdLabel = new System.Windows.Forms.Label();
            channel_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // theme_IdLabel
            // 
            theme_IdLabel.AutoSize = true;
            theme_IdLabel.Location = new System.Drawing.Point(73, 57);
            theme_IdLabel.Name = "theme_IdLabel";
            theme_IdLabel.Size = new System.Drawing.Size(56, 17);
            theme_IdLabel.TabIndex = 1;
            theme_IdLabel.Text = "Theme:";
            // 
            // channel_IdLabel
            // 
            channel_IdLabel.AutoSize = true;
            channel_IdLabel.Location = new System.Drawing.Point(73, 85);
            channel_IdLabel.Name = "channel_IdLabel";
            channel_IdLabel.Size = new System.Drawing.Size(64, 17);
            channel_IdLabel.TabIndex = 3;
            channel_IdLabel.Text = "Channel:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(210, 126);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 33);
            this.button_Cancel.TabIndex = 32;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(76, 126);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(111, 33);
            this.button_OK.TabIndex = 31;
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
            // themeChannelsTableAdapter
            // 
            this.themeChannelsTableAdapter.ClearBeforeFill = true;
            // 
            // themeIdComboBox
            // 
            this.themeIdComboBox.DataSource = this.themesBindingSource;
            this.themeIdComboBox.DisplayMember = "Name";
            this.themeIdComboBox.FormattingEnabled = true;
            this.themeIdComboBox.Location = new System.Drawing.Point(167, 52);
            this.themeIdComboBox.Name = "themeIdComboBox";
            this.themeIdComboBox.Size = new System.Drawing.Size(154, 24);
            this.themeIdComboBox.TabIndex = 33;
            this.themeIdComboBox.ValueMember = "Id";
            // 
            // channelIdComboBox
            // 
            this.channelIdComboBox.DataSource = this.channelsBindingSource;
            this.channelIdComboBox.DisplayMember = "Link";
            this.channelIdComboBox.FormattingEnabled = true;
            this.channelIdComboBox.Location = new System.Drawing.Point(167, 82);
            this.channelIdComboBox.Name = "channelIdComboBox";
            this.channelIdComboBox.Size = new System.Drawing.Size(154, 24);
            this.channelIdComboBox.TabIndex = 34;
            this.channelIdComboBox.ValueMember = "Id";
            // 
            // themesBindingSource
            // 
            this.themesBindingSource.DataMember = "Themes";
            this.themesBindingSource.DataSource = this.bindingSource1;
            // 
            // themesTableAdapter
            // 
            this.themesTableAdapter.ClearBeforeFill = true;
            // 
            // channelsBindingSource
            // 
            this.channelsBindingSource.DataMember = "Channels";
            this.channelsBindingSource.DataSource = this.bindingSource1;
            // 
            // channelsTableAdapter
            // 
            this.channelsTableAdapter.ClearBeforeFill = true;
            // 
            // EditChannelTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 209);
            this.Controls.Add(this.channelIdComboBox);
            this.Controls.Add(this.themeIdComboBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(theme_IdLabel);
            this.Controls.Add(channel_IdLabel);
            this.Name = "EditChannelTheme";
            this.Text = "EditChannelTheme";
            this.Load += new System.EventHandler(this.EditChannelTheme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.ThemeChannelsTableAdapter themeChannelsTableAdapter;
        private System.Windows.Forms.ComboBox themeIdComboBox;
        private System.Windows.Forms.ComboBox channelIdComboBox;
        private System.Windows.Forms.BindingSource themesBindingSource;
        private telesmmDataSetTableAdapters.ThemesTableAdapter themesTableAdapter;
        private System.Windows.Forms.BindingSource channelsBindingSource;
        private telesmmDataSetTableAdapters.ChannelsTableAdapter channelsTableAdapter;
    }
}