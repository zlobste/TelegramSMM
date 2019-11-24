namespace AdminDesctopApp
{
    partial class EditOrder
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
            System.Windows.Forms.Label publicationDateLabel;
            System.Windows.Forms.Label channelIdLabel;
            System.Windows.Forms.Label postIdLabel;
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.publicationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aspNetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telesmmDataSet = new AdminDesctopApp.telesmmDataSet();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.OrdersTableAdapter();
            this.channelComboBox = new System.Windows.Forms.ComboBox();
            this.channelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.PostsTableAdapter();
            this.channelsTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.ChannelsTableAdapter();
            this.aspNetUsersTableAdapter = new AdminDesctopApp.telesmmDataSetTableAdapters.AspNetUsersTableAdapter();
            this.postDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            publicationDateLabel = new System.Windows.Forms.Label();
            channelIdLabel = new System.Windows.Forms.Label();
            postIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Location = new System.Drawing.Point(71, 74);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new System.Drawing.Size(115, 17);
            publicationDateLabel.TabIndex = 21;
            publicationDateLabel.Text = "Publication Date:";
            // 
            // channelIdLabel
            // 
            channelIdLabel.AutoSize = true;
            channelIdLabel.Location = new System.Drawing.Point(71, 106);
            channelIdLabel.Name = "channelIdLabel";
            channelIdLabel.Size = new System.Drawing.Size(68, 17);
            channelIdLabel.TabIndex = 23;
            channelIdLabel.Text = "Channel :";
            // 
            // postIdLabel
            // 
            postIdLabel.AutoSize = true;
            postIdLabel.Location = new System.Drawing.Point(71, 133);
            postIdLabel.Name = "postIdLabel";
            postIdLabel.Size = new System.Drawing.Size(44, 17);
            postIdLabel.TabIndex = 27;
            postIdLabel.Text = "Post :";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(237, 206);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(164, 33);
            this.button_Cancel.TabIndex = 18;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(66, 206);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(165, 33);
            this.button_OK.TabIndex = 17;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // publicationDateDateTimePicker
            // 
            this.publicationDateDateTimePicker.Location = new System.Drawing.Point(192, 70);
            this.publicationDateDateTimePicker.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.publicationDateDateTimePicker.Name = "publicationDateDateTimePicker";
            this.publicationDateDateTimePicker.Size = new System.Drawing.Size(209, 22);
            this.publicationDateDateTimePicker.TabIndex = 22;
            // 
            // aspNetUsersBindingSource
            // 
            this.aspNetUsersBindingSource.DataMember = "AspNetUsers";
            this.aspNetUsersBindingSource.DataSource = this.bindingSource1;
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
            // postComboBox
            // 
            this.postComboBox.DataSource = this.postsBindingSource;
            this.postComboBox.DisplayMember = "Title";
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Location = new System.Drawing.Point(192, 132);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(209, 24);
            this.postComboBox.TabIndex = 33;
            this.postComboBox.ValueMember = "Id";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.bindingSource1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // channelComboBox
            // 
            this.channelComboBox.DataSource = this.channelsBindingSource;
            this.channelComboBox.DisplayMember = "Link";
            this.channelComboBox.FormattingEnabled = true;
            this.channelComboBox.Location = new System.Drawing.Point(192, 99);
            this.channelComboBox.Name = "channelComboBox";
            this.channelComboBox.Size = new System.Drawing.Size(209, 24);
            this.channelComboBox.TabIndex = 34;
            this.channelComboBox.ValueMember = "Id";
            // 
            // channelsBindingSource
            // 
            this.channelsBindingSource.DataMember = "Channels";
            this.channelsBindingSource.DataSource = this.bindingSource1;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // channelsTableAdapter
            // 
            this.channelsTableAdapter.ClearBeforeFill = true;
            // 
            // aspNetUsersTableAdapter
            // 
            this.aspNetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // postDateLabel
            // 
            this.postDateLabel.AutoSize = true;
            this.postDateLabel.Location = new System.Drawing.Point(189, 166);
            this.postDateLabel.Name = "postDateLabel";
            this.postDateLabel.Size = new System.Drawing.Size(46, 17);
            this.postDateLabel.TabIndex = 35;
            this.postDateLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date Post:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postDateLabel);
            this.Controls.Add(this.channelComboBox);
            this.Controls.Add(this.postComboBox);
            this.Controls.Add(publicationDateLabel);
            this.Controls.Add(this.publicationDateDateTimePicker);
            this.Controls.Add(channelIdLabel);
            this.Controls.Add(postIdLabel);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telesmmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.DateTimePicker publicationDateDateTimePicker;
        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private telesmmDataSet telesmmDataSet;
        private telesmmDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ComboBox channelComboBox;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private telesmmDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.BindingSource channelsBindingSource;
        private telesmmDataSetTableAdapters.ChannelsTableAdapter channelsTableAdapter;
        private System.Windows.Forms.BindingSource aspNetUsersBindingSource;
        private telesmmDataSetTableAdapters.AspNetUsersTableAdapter aspNetUsersTableAdapter;
        private System.Windows.Forms.Label postDateLabel;
        private System.Windows.Forms.Label label1;
    }
}