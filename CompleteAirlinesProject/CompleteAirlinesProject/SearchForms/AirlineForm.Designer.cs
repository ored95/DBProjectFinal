namespace CompleteAirlinesProject.SearchForms
{
    partial class AirlineForm
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
            this.airlinesDataSet = new CompleteAirlinesProject.AirlinesDataSet();
            this.airlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesTableAdapter = new CompleteAirlinesProject.AirlinesDataSetTableAdapters.AirlinesTableAdapter();
            this.airlineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbTotal);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 408);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(405, 22);
            this.panel.TabIndex = 3;
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
            this.airlineIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.airlinesBindingSource;
            this.DataGridView.DateWithTime = false;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(405, 430);
            this.DataGridView.TabIndex = 2;
            this.DataGridView.TimeFilter = false;
            this.DataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.DataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "AirlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airlinesBindingSource
            // 
            this.airlinesBindingSource.DataMember = "Airlines";
            this.airlinesBindingSource.DataSource = this.airlinesDataSet;
            this.airlinesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.airlinesBindingSource_ListChanged);
            // 
            // airlinesTableAdapter
            // 
            this.airlinesTableAdapter.ClearBeforeFill = true;
            // 
            // airlineIDDataGridViewTextBoxColumn
            // 
            this.airlineIDDataGridViewTextBoxColumn.DataPropertyName = "AirlineID";
            this.airlineIDDataGridViewTextBoxColumn.HeaderText = "AirlineID";
            this.airlineIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.airlineIDDataGridViewTextBoxColumn.Name = "airlineIDDataGridViewTextBoxColumn";
            this.airlineIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.airlineIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // AirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 430);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DataGridView);
            this.Name = "AirlineForm";
            this.Text = "AirlineForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirplaneForm_FormClosed);
            this.Load += new System.EventHandler(this.AirlineForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbTotal;
        private ADGV.AdvancedDataGridView DataGridView;
        private AirlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource airlinesBindingSource;
        private AirlinesDataSetTableAdapters.AirlinesTableAdapter airlinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;

    }
}