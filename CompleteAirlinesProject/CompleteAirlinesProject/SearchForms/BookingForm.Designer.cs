namespace CompleteAirlinesProject.SearchForms
{
    partial class BookingForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.DataGridView = new ADGV.AdvancedDataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passGenderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesDataSet = new CompleteAirlinesProject.AirlinesDataSet();
            this.bookingsTableAdapter = new CompleteAirlinesProject.AirlinesDataSetTableAdapters.BookingsTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbTotal);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 357);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(633, 22);
            this.panel.TabIndex = 9;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(12, 6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 0;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.AutoGenerateContextFilters = true;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.flightIDDataGridViewTextBoxColumn,
            this.passportNumberDataGridViewTextBoxColumn,
            this.passNameDataGridViewTextBoxColumn,
            this.passAgeDataGridViewTextBoxColumn,
            this.passGenderDataGridViewCheckBoxColumn,
            this.createDateDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.bookingsBindingSource;
            this.DataGridView.DateWithTime = false;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(633, 379);
            this.DataGridView.TabIndex = 8;
            this.DataGridView.TimeFilter = false;
            this.DataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.DataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            this.flightIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            this.passportNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // passNameDataGridViewTextBoxColumn
            // 
            this.passNameDataGridViewTextBoxColumn.DataPropertyName = "PassName";
            this.passNameDataGridViewTextBoxColumn.HeaderText = "PassName";
            this.passNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.passNameDataGridViewTextBoxColumn.Name = "passNameDataGridViewTextBoxColumn";
            this.passNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.passNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // passAgeDataGridViewTextBoxColumn
            // 
            this.passAgeDataGridViewTextBoxColumn.DataPropertyName = "PassAge";
            this.passAgeDataGridViewTextBoxColumn.HeaderText = "PassAge";
            this.passAgeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.passAgeDataGridViewTextBoxColumn.Name = "passAgeDataGridViewTextBoxColumn";
            this.passAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.passAgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // passGenderDataGridViewCheckBoxColumn
            // 
            this.passGenderDataGridViewCheckBoxColumn.DataPropertyName = "PassGender";
            this.passGenderDataGridViewCheckBoxColumn.HeaderText = "PassGender";
            this.passGenderDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.passGenderDataGridViewCheckBoxColumn.Name = "passGenderDataGridViewCheckBoxColumn";
            this.passGenderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.passGenderDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.airlinesDataSet;
            this.bookingsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bookingsBindingSource_ListChanged);
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "AirlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 379);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DataGridView);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirplaneForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbTotal;
        private ADGV.AdvancedDataGridView DataGridView;
        private AirlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private AirlinesDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn passGenderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
    }
}