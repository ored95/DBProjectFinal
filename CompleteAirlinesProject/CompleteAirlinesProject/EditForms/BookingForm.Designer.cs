namespace CompleteAirlinesProject.EditForms
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
            this.edtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtBookingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.insertBtn = new System.Windows.Forms.Button();
            this.edtFlightID = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtPassportNumber = new System.Windows.Forms.TextBox();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.edtGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edtCreateDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panelEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtAge
            // 
            this.edtAge.Location = new System.Drawing.Point(93, 139);
            this.edtAge.Name = "edtAge";
            this.edtAge.Size = new System.Drawing.Size(114, 20);
            this.edtAge.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Age";
            // 
            // edtBookingID
            // 
            this.edtBookingID.Location = new System.Drawing.Point(93, 12);
            this.edtBookingID.Name = "edtBookingID";
            this.edtBookingID.Size = new System.Drawing.Size(114, 20);
            this.edtBookingID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "BookingID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gender";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(18, 381);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(189, 40);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "FlightID";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(18, 335);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(189, 40);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PassportNumber";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(18, 243);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(189, 40);
            this.checkBtn.TabIndex = 21;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(218, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(613, 427);
            this.DataGridView.TabIndex = 32;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(18, 289);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(189, 40);
            this.insertBtn.TabIndex = 21;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // edtFlightID
            // 
            this.edtFlightID.Location = new System.Drawing.Point(93, 43);
            this.edtFlightID.Name = "edtFlightID";
            this.edtFlightID.Size = new System.Drawing.Size(114, 20);
            this.edtFlightID.TabIndex = 17;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(93, 107);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(114, 20);
            this.edtName.TabIndex = 16;
            // 
            // edtPassportNumber
            // 
            this.edtPassportNumber.Location = new System.Drawing.Point(103, 75);
            this.edtPassportNumber.Name = "edtPassportNumber";
            this.edtPassportNumber.Size = new System.Drawing.Size(104, 20);
            this.edtPassportNumber.TabIndex = 16;
            // 
            // panelEditor
            // 
            this.panelEditor.Controls.Add(this.edtGender);
            this.panelEditor.Controls.Add(this.label10);
            this.panelEditor.Controls.Add(this.edtCreateDate);
            this.panelEditor.Controls.Add(this.edtAge);
            this.panelEditor.Controls.Add(this.label8);
            this.panelEditor.Controls.Add(this.edtBookingID);
            this.panelEditor.Controls.Add(this.label1);
            this.panelEditor.Controls.Add(this.label7);
            this.panelEditor.Controls.Add(this.updateBtn);
            this.panelEditor.Controls.Add(this.label2);
            this.panelEditor.Controls.Add(this.deleteBtn);
            this.panelEditor.Controls.Add(this.label3);
            this.panelEditor.Controls.Add(this.label5);
            this.panelEditor.Controls.Add(this.checkBtn);
            this.panelEditor.Controls.Add(this.insertBtn);
            this.panelEditor.Controls.Add(this.edtFlightID);
            this.panelEditor.Controls.Add(this.edtName);
            this.panelEditor.Controls.Add(this.edtPassportNumber);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEditor.Location = new System.Drawing.Point(0, 0);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(218, 427);
            this.panelEditor.TabIndex = 31;
            // 
            // edtGender
            // 
            this.edtGender.FormattingEnabled = true;
            this.edtGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.edtGender.Location = new System.Drawing.Point(93, 171);
            this.edtGender.Name = "edtGender";
            this.edtGender.Size = new System.Drawing.Size(114, 21);
            this.edtGender.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CreateDate";
            // 
            // edtCreateDate
            // 
            this.edtCreateDate.Location = new System.Drawing.Point(93, 203);
            this.edtCreateDate.Name = "edtCreateDate";
            this.edtCreateDate.Size = new System.Drawing.Size(114, 20);
            this.edtCreateDate.TabIndex = 23;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 427);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panelEditor);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox edtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtBookingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox edtFlightID;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtPassportNumber;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.ComboBox edtGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtCreateDate;
    }
}