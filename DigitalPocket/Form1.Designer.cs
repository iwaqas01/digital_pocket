namespace DigitalPocket
{
    partial class Form1
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
            this.calendarView1 = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmonthlytrans = new System.Windows.Forms.Label();
            this.lbldate = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblexpense = new System.Windows.Forms.Label();
            this.lblincome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblddebit = new System.Windows.Forms.Label();
            this.lblcredit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.InContentContextMenu = new DevComponents.DotNetBar.ButtonItem();
            this.InContentAddAppContextItem = new DevComponents.DotNetBar.ButtonItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblincme = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarView1
            // 
            // 
            // 
            // 
            this.calendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView1.ContainerControlProcessDialogKey = true;
            this.calendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarView1.Location = new System.Drawing.Point(0, 0);
            this.calendarView1.MultiUserTabHeight = 19;
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month;
            this.calendarView1.Size = new System.Drawing.Size(797, 534);
            this.calendarView1.TabIndex = 0;
            this.calendarView1.Text = "calendarView1";
            this.calendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView1.TimeIndicator.Tag = null;
            this.calendarView1.TimeSlotDuration = 30;
            this.calendarView1.YearViewLinkView = DevComponents.DotNetBar.Schedule.eCalendarView.Month;
            this.calendarView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.calendarView1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 534);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblincme);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblmonthlytrans);
            this.panel3.Controls.Add(this.lbldate);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Controls.Add(this.lblddebit);
            this.panel3.Controls.Add(this.lblcredit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 370);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Monthly Transfer";
            // 
            // lblmonthlytrans
            // 
            this.lblmonthlytrans.AutoSize = true;
            this.lblmonthlytrans.Location = new System.Drawing.Point(105, 95);
            this.lblmonthlytrans.Name = "lblmonthlytrans";
            this.lblmonthlytrans.Size = new System.Drawing.Size(13, 13);
            this.lblmonthlytrans.TabIndex = 17;
            this.lblmonthlytrans.Text = "0";
            // 
            // lbldate
            // 
            // 
            // 
            // 
            this.lbldate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbldate.Location = new System.Drawing.Point(58, 170);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(76, 29);
            this.lbldate.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTransfer);
            this.panel4.Controls.Add(this.lblexpense);
            this.panel4.Controls.Add(this.lblincome);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 165);
            this.panel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Transfer";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(84, 77);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(13, 13);
            this.lblTransfer.TabIndex = 20;
            this.lblTransfer.Text = "0";
            // 
            // lblexpense
            // 
            this.lblexpense.AutoSize = true;
            this.lblexpense.Location = new System.Drawing.Point(84, 49);
            this.lblexpense.Name = "lblexpense";
            this.lblexpense.Size = new System.Drawing.Size(13, 13);
            this.lblexpense.TabIndex = 19;
            this.lblexpense.Text = "0";
            // 
            // lblincome
            // 
            this.lblincome.AutoSize = true;
            this.lblincome.Location = new System.Drawing.Point(84, 20);
            this.lblincome.Name = "lblincome";
            this.lblincome.Size = new System.Drawing.Size(13, 13);
            this.lblincome.TabIndex = 18;
            this.lblincome.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Income";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(58, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 29);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "User Statistics Monthly";
            // 
            // lblddebit
            // 
            this.lblddebit.AutoSize = true;
            this.lblddebit.Location = new System.Drawing.Point(106, 38);
            this.lblddebit.Name = "lblddebit";
            this.lblddebit.Size = new System.Drawing.Size(13, 13);
            this.lblddebit.TabIndex = 15;
            this.lblddebit.Text = "0";
            // 
            // lblcredit
            // 
            this.lblcredit.AutoSize = true;
            this.lblcredit.Location = new System.Drawing.Point(105, 67);
            this.lblcredit.Name = "lblcredit";
            this.lblcredit.Size = new System.Drawing.Size(13, 13);
            this.lblcredit.TabIndex = 14;
            this.lblcredit.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monthly Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Monthly Expense";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contextMenuBar1);
            this.panel2.Controls.Add(this.calendarView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 534);
            this.panel2.TabIndex = 2;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.InContentContextMenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(146, 212);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(504, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 10;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // InContentContextMenu
            // 
            this.InContentContextMenu.AutoExpandOnClick = true;
            this.InContentContextMenu.Name = "InContentContextMenu";
            this.InContentContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.InContentAddAppContextItem});
            this.InContentContextMenu.Text = "InContent";
            // 
            // InContentAddAppContextItem
            // 
            this.InContentAddAppContextItem.Name = "InContentAddAppContextItem";
            this.InContentAddAppContextItem.Text = "Add Appointment";
            this.InContentAddAppContextItem.Click += new System.EventHandler(this.InContentAddAppContextItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Income";
            // 
            // lblincme
            // 
            this.lblincme.AutoSize = true;
            this.lblincme.Location = new System.Drawing.Point(105, 122);
            this.lblincme.Name = "lblincme";
            this.lblincme.Size = new System.Drawing.Size(13, 13);
            this.lblincme.TabIndex = 19;
            this.lblincme.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DigitalPocket.Properties.Resources.wallet_banner_728x236;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Schedule.CalendarView calendarView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem InContentContextMenu;
        private DevComponents.DotNetBar.ButtonItem InContentAddAppContextItem;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.LabelX lbldate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblexpense;
        private System.Windows.Forms.Label lblincome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label lblcredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblddebit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmonthlytrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblincme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

