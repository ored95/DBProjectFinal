namespace CompleteAirlinesProject
{
    partial class MainAirlinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAirlinesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userBtn = new System.Windows.Forms.RadioButton();
            this.flightBtn = new System.Windows.Forms.RadioButton();
            this.airportBtn = new System.Windows.Forms.RadioButton();
            this.airlineBtn = new System.Windows.Forms.RadioButton();
            this.airplaneBtn = new System.Windows.Forms.RadioButton();
            this.airlineMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.airlineMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.flightBtn);
            this.panel1.Controls.Add(this.airportBtn);
            this.panel1.Controls.Add(this.airlineBtn);
            this.panel1.Controls.Add(this.airplaneBtn);
            this.panel1.Location = new System.Drawing.Point(24, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 354);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose datatable";
            // 
            // userBtn
            // 
            this.userBtn.AutoSize = true;
            this.userBtn.Location = new System.Drawing.Point(35, 214);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(80, 17);
            this.userBtn.TabIndex = 5;
            this.userBtn.Text = "Passengers";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // flightBtn
            // 
            this.flightBtn.AutoSize = true;
            this.flightBtn.Location = new System.Drawing.Point(35, 176);
            this.flightBtn.Name = "flightBtn";
            this.flightBtn.Size = new System.Drawing.Size(55, 17);
            this.flightBtn.TabIndex = 6;
            this.flightBtn.Text = "Flights";
            this.flightBtn.UseVisualStyleBackColor = true;
            this.flightBtn.Click += new System.EventHandler(this.flightBtn_Click);
            // 
            // airportBtn
            // 
            this.airportBtn.AutoSize = true;
            this.airportBtn.Location = new System.Drawing.Point(35, 138);
            this.airportBtn.Name = "airportBtn";
            this.airportBtn.Size = new System.Drawing.Size(60, 17);
            this.airportBtn.TabIndex = 7;
            this.airportBtn.Text = "Airports";
            this.airportBtn.UseVisualStyleBackColor = true;
            this.airportBtn.Click += new System.EventHandler(this.airportBtn_Click);
            // 
            // airlineBtn
            // 
            this.airlineBtn.AutoSize = true;
            this.airlineBtn.Location = new System.Drawing.Point(37, 103);
            this.airlineBtn.Name = "airlineBtn";
            this.airlineBtn.Size = new System.Drawing.Size(58, 17);
            this.airlineBtn.TabIndex = 8;
            this.airlineBtn.Text = "Airlines";
            this.airlineBtn.UseVisualStyleBackColor = true;
            this.airlineBtn.Click += new System.EventHandler(this.airlineBtn_Click);
            // 
            // airplaneBtn
            // 
            this.airplaneBtn.AutoSize = true;
            this.airplaneBtn.Location = new System.Drawing.Point(37, 65);
            this.airplaneBtn.Name = "airplaneBtn";
            this.airplaneBtn.Size = new System.Drawing.Size(68, 17);
            this.airplaneBtn.TabIndex = 4;
            this.airplaneBtn.Text = "Airplanes";
            this.airplaneBtn.UseVisualStyleBackColor = true;
            this.airplaneBtn.Click += new System.EventHandler(this.airplaneBtn_Click);
            // 
            // airlineMenuStrip
            // 
            this.airlineMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.airlineMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.airlineMenuStrip.Name = "airlineMenuStrip";
            this.airlineMenuStrip.Size = new System.Drawing.Size(879, 24);
            this.airlineMenuStrip.TabIndex = 1;
            this.airlineMenuStrip.Text = "menuStrip";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.editToolStripMenuItem.Text = "Edit..";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byDatabaseToolStripMenuItem,
            this.byTicketsToolStripMenuItem,
            this.forTicketsToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.searchToolStripMenuItem.Text = "Search..";
            // 
            // byDatabaseToolStripMenuItem
            // 
            this.byDatabaseToolStripMenuItem.Name = "byDatabaseToolStripMenuItem";
            this.byDatabaseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.byDatabaseToolStripMenuItem.Text = "By database";
            this.byDatabaseToolStripMenuItem.Click += new System.EventHandler(this.byDatabaseToolStripMenuItem_Click);
            // 
            // byTicketsToolStripMenuItem
            // 
            this.byTicketsToolStripMenuItem.Name = "byTicketsToolStripMenuItem";
            this.byTicketsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.byTicketsToolStripMenuItem.Text = "Flight information";
            this.byTicketsToolStripMenuItem.Click += new System.EventHandler(this.byTicketsToolStripMenuItem_Click);
            // 
            // forTicketsToolStripMenuItem
            // 
            this.forTicketsToolStripMenuItem.Name = "forTicketsToolStripMenuItem";
            this.forTicketsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.forTicketsToolStripMenuItem.Text = "For tickets..";
            this.forTicketsToolStripMenuItem.Click += new System.EventHandler(this.forTicketsToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // MainAirlinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.airlineMenuStrip);
            this.Name = "MainAirlinesForm";
            this.Text = "Airlines Database Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.airlineMenuStrip.ResumeLayout(false);
            this.airlineMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton userBtn;
        private System.Windows.Forms.RadioButton flightBtn;
        private System.Windows.Forms.RadioButton airportBtn;
        private System.Windows.Forms.RadioButton airlineBtn;
        private System.Windows.Forms.RadioButton airplaneBtn;
        private System.Windows.Forms.MenuStrip airlineMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTicketsToolStripMenuItem;

    }
}

