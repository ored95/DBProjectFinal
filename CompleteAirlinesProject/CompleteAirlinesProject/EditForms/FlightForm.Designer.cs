namespace CompleteAirlinesProject.EditForms
{
    partial class FlightForm
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.edtOrigin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtFlightID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtFreeSeats = new System.Windows.Forms.TextBox();
            this.edtDepartureTime = new System.Windows.Forms.TextBox();
            this.edtCreateDate = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.edtArrivalTime = new System.Windows.Forms.TextBox();
            this.edtPrice = new System.Windows.Forms.TextBox();
            this.edtAirplaneID = new System.Windows.Forms.TextBox();
            this.edtDestination = new System.Windows.Forms.TextBox();
            this.edtFlightNumber = new System.Windows.Forms.TextBox();
            this.edtAirlineID = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panelEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(213, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(655, 550);
            this.DataGridView.TabIndex = 30;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // panelEditor
            // 
            this.panelEditor.Controls.Add(this.edtOrigin);
            this.panelEditor.Controls.Add(this.label8);
            this.panelEditor.Controls.Add(this.edtFlightID);
            this.panelEditor.Controls.Add(this.label1);
            this.panelEditor.Controls.Add(this.label11);
            this.panelEditor.Controls.Add(this.label7);
            this.panelEditor.Controls.Add(this.updateBtn);
            this.panelEditor.Controls.Add(this.label2);
            this.panelEditor.Controls.Add(this.label10);
            this.panelEditor.Controls.Add(this.label6);
            this.panelEditor.Controls.Add(this.deleteBtn);
            this.panelEditor.Controls.Add(this.label9);
            this.panelEditor.Controls.Add(this.label4);
            this.panelEditor.Controls.Add(this.label3);
            this.panelEditor.Controls.Add(this.label5);
            this.panelEditor.Controls.Add(this.edtFreeSeats);
            this.panelEditor.Controls.Add(this.edtDepartureTime);
            this.panelEditor.Controls.Add(this.edtCreateDate);
            this.panelEditor.Controls.Add(this.checkBtn);
            this.panelEditor.Controls.Add(this.insertBtn);
            this.panelEditor.Controls.Add(this.edtArrivalTime);
            this.panelEditor.Controls.Add(this.edtPrice);
            this.panelEditor.Controls.Add(this.edtAirplaneID);
            this.panelEditor.Controls.Add(this.edtDestination);
            this.panelEditor.Controls.Add(this.edtFlightNumber);
            this.panelEditor.Controls.Add(this.edtAirlineID);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEditor.Location = new System.Drawing.Point(0, 0);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(213, 550);
            this.panelEditor.TabIndex = 29;
            // 
            // edtOrigin
            // 
            this.edtOrigin.Location = new System.Drawing.Point(93, 139);
            this.edtOrigin.Name = "edtOrigin";
            this.edtOrigin.Size = new System.Drawing.Size(114, 20);
            this.edtOrigin.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Origin";
            // 
            // edtFlightID
            // 
            this.edtFlightID.Location = new System.Drawing.Point(93, 12);
            this.edtFlightID.Name = "edtFlightID";
            this.edtFlightID.Size = new System.Drawing.Size(114, 20);
            this.edtFlightID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "FlightID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "FreeSeats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Departure Time";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 506);
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
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "AirplaneID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CreateDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Arrival Time";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 460);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(189, 40);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "FlightNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "AirlineID";
            // 
            // edtFreeSeats
            // 
            this.edtFreeSeats.Location = new System.Drawing.Point(93, 264);
            this.edtFreeSeats.Name = "edtFreeSeats";
            this.edtFreeSeats.Size = new System.Drawing.Size(114, 20);
            this.edtFreeSeats.TabIndex = 17;
            // 
            // edtDepartureTime
            // 
            this.edtDepartureTime.Location = new System.Drawing.Point(93, 171);
            this.edtDepartureTime.Name = "edtDepartureTime";
            this.edtDepartureTime.Size = new System.Drawing.Size(114, 20);
            this.edtDepartureTime.TabIndex = 17;
            // 
            // edtCreateDate
            // 
            this.edtCreateDate.Location = new System.Drawing.Point(93, 326);
            this.edtCreateDate.Name = "edtCreateDate";
            this.edtCreateDate.Size = new System.Drawing.Size(114, 20);
            this.edtCreateDate.TabIndex = 16;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(12, 414);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(189, 40);
            this.insertBtn.TabIndex = 21;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // edtArrivalTime
            // 
            this.edtArrivalTime.Location = new System.Drawing.Point(93, 234);
            this.edtArrivalTime.Name = "edtArrivalTime";
            this.edtArrivalTime.Size = new System.Drawing.Size(114, 20);
            this.edtArrivalTime.TabIndex = 16;
            // 
            // edtPrice
            // 
            this.edtPrice.Location = new System.Drawing.Point(93, 295);
            this.edtPrice.Name = "edtPrice";
            this.edtPrice.Size = new System.Drawing.Size(114, 20);
            this.edtPrice.TabIndex = 16;
            // 
            // edtAirplaneID
            // 
            this.edtAirplaneID.Location = new System.Drawing.Point(93, 43);
            this.edtAirplaneID.Name = "edtAirplaneID";
            this.edtAirplaneID.Size = new System.Drawing.Size(114, 20);
            this.edtAirplaneID.TabIndex = 17;
            // 
            // edtDestination
            // 
            this.edtDestination.Location = new System.Drawing.Point(93, 203);
            this.edtDestination.Name = "edtDestination";
            this.edtDestination.Size = new System.Drawing.Size(114, 20);
            this.edtDestination.TabIndex = 16;
            // 
            // edtFlightNumber
            // 
            this.edtFlightNumber.Location = new System.Drawing.Point(93, 107);
            this.edtFlightNumber.Name = "edtFlightNumber";
            this.edtFlightNumber.Size = new System.Drawing.Size(114, 20);
            this.edtFlightNumber.TabIndex = 16;
            // 
            // edtAirlineID
            // 
            this.edtAirlineID.Location = new System.Drawing.Point(93, 75);
            this.edtAirlineID.Name = "edtAirlineID";
            this.edtAirlineID.Size = new System.Drawing.Size(114, 20);
            this.edtAirlineID.TabIndex = 16;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(12, 368);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(189, 40);
            this.checkBtn.TabIndex = 21;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 550);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panelEditor);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FlightForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.TextBox edtOrigin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtFlightID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtDepartureTime;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox edtArrivalTime;
        private System.Windows.Forms.TextBox edtAirplaneID;
        private System.Windows.Forms.TextBox edtDestination;
        private System.Windows.Forms.TextBox edtFlightNumber;
        private System.Windows.Forms.TextBox edtAirlineID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtFreeSeats;
        private System.Windows.Forms.TextBox edtCreateDate;
        private System.Windows.Forms.TextBox edtPrice;
        private System.Windows.Forms.Button checkBtn;
    }
}