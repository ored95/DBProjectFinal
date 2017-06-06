namespace CompleteAirlinesProject.EditForms
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
            this.panelEditor = new System.Windows.Forms.Panel();
            this.edtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.edtTitle = new System.Windows.Forms.TextBox();
            this.edtRating = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditor
            // 
            this.panelEditor.Controls.Add(this.edtID);
            this.panelEditor.Controls.Add(this.label1);
            this.panelEditor.Controls.Add(this.updateBtn);
            this.panelEditor.Controls.Add(this.label2);
            this.panelEditor.Controls.Add(this.deleteBtn);
            this.panelEditor.Controls.Add(this.label5);
            this.panelEditor.Controls.Add(this.insertBtn);
            this.panelEditor.Controls.Add(this.edtTitle);
            this.panelEditor.Controls.Add(this.edtRating);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEditor.Location = new System.Drawing.Point(0, 0);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(191, 370);
            this.panelEditor.TabIndex = 27;
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(71, 12);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(98, 20);
            this.edtID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(19, 246);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(150, 40);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(19, 197);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 40);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rating";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(19, 151);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(150, 40);
            this.insertBtn.TabIndex = 21;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // edtTitle
            // 
            this.edtTitle.Location = new System.Drawing.Point(71, 55);
            this.edtTitle.Name = "edtTitle";
            this.edtTitle.Size = new System.Drawing.Size(98, 20);
            this.edtTitle.TabIndex = 17;
            // 
            // edtRating
            // 
            this.edtRating.Location = new System.Drawing.Point(71, 98);
            this.edtRating.Name = "edtRating";
            this.edtRating.Size = new System.Drawing.Size(98, 20);
            this.edtRating.TabIndex = 16;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(191, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(553, 370);
            this.DataGridView.TabIndex = 28;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // AirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 370);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panelEditor);
            this.Name = "AirlineForm";
            this.Text = "AirlineForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirlineForm_FormClosed);
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox edtTitle;
        private System.Windows.Forms.TextBox edtRating;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}