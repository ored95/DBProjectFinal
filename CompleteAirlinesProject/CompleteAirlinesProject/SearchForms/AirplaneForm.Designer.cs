namespace CompleteAirlinesProject.SearchForms
{
    partial class AirplaneForm
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
            this.DataGridView = new ADGV.AdvancedDataGridView();
            this.airlinesDataSet = new CompleteAirlinesProject.AirlinesDataSet();
            this.airplanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplanesTableAdapter = new CompleteAirlinesProject.AirlinesDataSetTableAdapters.AirplanesTableAdapter();
            this.airplaneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airplaneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.AutoGenerateContextFilters = true;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airplaneIDDataGridViewTextBoxColumn,
            this.airplaneTypeDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.airplanesBindingSource;
            this.DataGridView.DateWithTime = false;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(422, 413);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.TimeFilter = false;
            this.DataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.DataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "AirlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplanesBindingSource
            // 
            this.airplanesBindingSource.DataMember = "Airplanes";
            this.airplanesBindingSource.DataSource = this.airlinesDataSet;
            this.airplanesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.airplanesBindingSource_ListChanged);
            // 
            // airplanesTableAdapter
            // 
            this.airplanesTableAdapter.ClearBeforeFill = true;
            // 
            // airplaneIDDataGridViewTextBoxColumn
            // 
            this.airplaneIDDataGridViewTextBoxColumn.DataPropertyName = "AirplaneID";
            this.airplaneIDDataGridViewTextBoxColumn.HeaderText = "AirplaneID";
            this.airplaneIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.airplaneIDDataGridViewTextBoxColumn.Name = "airplaneIDDataGridViewTextBoxColumn";
            this.airplaneIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.airplaneIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // airplaneTypeDataGridViewTextBoxColumn
            // 
            this.airplaneTypeDataGridViewTextBoxColumn.DataPropertyName = "AirplaneType";
            this.airplaneTypeDataGridViewTextBoxColumn.HeaderText = "AirplaneType";
            this.airplaneTypeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.airplaneTypeDataGridViewTextBoxColumn.Name = "airplaneTypeDataGridViewTextBoxColumn";
            this.airplaneTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.airplaneTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            this.numberOfSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfSeatsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbTotal);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 391);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(422, 22);
            this.panel.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(12, 6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 0;
            // 
            // AirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 413);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DataGridView);
            this.Name = "AirplaneForm";
            this.Text = "AirplaneForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirplaneForm_FormClosed);
            this.Load += new System.EventHandler(this.AirplaneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView DataGridView;
        private AirlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource airplanesBindingSource;
        private AirlinesDataSetTableAdapters.AirplanesTableAdapter airplanesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn airplaneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airplaneTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbTotal;
    }
}