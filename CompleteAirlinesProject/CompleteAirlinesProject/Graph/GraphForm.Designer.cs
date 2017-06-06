namespace CompleteAirlinesProject.Graph
{
    partial class GraphForm
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
            this.searchToolbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.RadioButton();
            this.priceBtn = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.DataGridView = new ADGV.AdvancedDataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTotal = new System.Windows.Forms.Label();
            this.searchToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchToolbar
            // 
            this.searchToolbar.Controls.Add(this.lbTotal);
            this.searchToolbar.Controls.Add(this.searchBtn);
            this.searchToolbar.Controls.Add(this.priceBtn);
            this.searchToolbar.Controls.Add(this.timeBtn);
            this.searchToolbar.Controls.Add(this.label3);
            this.searchToolbar.Controls.Add(this.destinationBox);
            this.searchToolbar.Controls.Add(this.label2);
            this.searchToolbar.Controls.Add(this.originBox);
            this.searchToolbar.Controls.Add(this.label1);
            this.searchToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchToolbar.Location = new System.Drawing.Point(0, 0);
            this.searchToolbar.Name = "searchToolbar";
            this.searchToolbar.Size = new System.Drawing.Size(899, 33);
            this.searchToolbar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // originBox
            // 
            this.originBox.FormattingEnabled = true;
            this.originBox.Items.AddRange(new object[] {
            "Moscow, Russia",
            "Paris, France",
            "Kerry, Ireland",
            "Amsterdam, Neitherlands",
            "Berlin, Germany",
            "Frankfurt, Germany",
            "Rome, Italy",
            "Saint Petersburg, Russia",
            "Sochi, Russia",
            "Istanbul, Turkey",
            "Helsinki, Finland",
            "Stockholm, Sweden",
            "London, England",
            "Manchester, England",
            "Liverpool, England",
            "Sydney, Australia",
            "Melbourne, Australia",
            "Dubai, India",
            "Hanoi, Vietnam",
            "Ho Chi Minh, Vietnam",
            "HongKong, China",
            "Bangkok, Thailand"});
            this.originBox.Location = new System.Drawing.Point(45, 5);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(164, 21);
            this.originBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Items.AddRange(new object[] {
            "Moscow, Russia",
            "Paris, France",
            "Kerry, Ireland",
            "Amsterdam, Neitherlands",
            "Berlin, Germany",
            "Frankfurt, Germany",
            "Rome, Italy",
            "Saint Petersburg, Russia",
            "Sochi, Russia",
            "Istanbul, Turkey",
            "Helsinki, Finland",
            "Stockholm, Sweden",
            "London, England",
            "Manchester, England",
            "Liverpool, England",
            "Sydney, Australia",
            "Melbourne, Australia",
            "Dubai, India",
            "Hanoi, Vietnam",
            "Ho Chi Minh, Vietnam",
            "HongKong, China",
            "Bangkok, Thailand"});
            this.destinationBox.Location = new System.Drawing.Point(250, 5);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(164, 21);
            this.destinationBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter by";
            // 
            // timeBtn
            // 
            this.timeBtn.AutoSize = true;
            this.timeBtn.Checked = true;
            this.timeBtn.Location = new System.Drawing.Point(502, 9);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(48, 17);
            this.timeBtn.TabIndex = 5;
            this.timeBtn.TabStop = true;
            this.timeBtn.Text = "Time";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.CheckedChanged += new System.EventHandler(this.timeBtn_CheckedChanged);
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.AutoSize = true;
            this.priceBtn.Location = new System.Drawing.Point(556, 9);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(49, 17);
            this.priceBtn.TabIndex = 5;
            this.priceBtn.Text = "Price";
            this.priceBtn.UseVisualStyleBackColor = true;
            this.priceBtn.CheckedChanged += new System.EventHandler(this.priceBtn_CheckedChanged);
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(627, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(163, 27);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AutoGenerateContextFilters = true;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.DateWithTime = false;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 33);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(899, 439);
            this.DataGridView.TabIndex = 2;
            this.DataGridView.TimeFilter = false;
            this.DataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.DataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            // 
            // bindingSource
            // 
            this.bindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource_ListChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(805, 11);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 13);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "Found: 0";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 472);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.searchToolbar);
            this.Name = "GraphForm";
            this.Text = "Ticket Searching";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphForm_FormClosed);
            this.searchToolbar.ResumeLayout(false);
            this.searchToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchToolbar;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RadioButton priceBtn;
        private System.Windows.Forms.RadioButton timeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.Label label1;
        private ADGV.AdvancedDataGridView DataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label lbTotal;
    }
}