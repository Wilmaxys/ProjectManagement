namespace Gestion_de_projet.Forms
{
    partial class EditTask
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
            this.CBX_TaskType = new System.Windows.Forms.ComboBox();
            this.CBX_Project = new System.Windows.Forms.ComboBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.RTB_DescTaskType = new System.Windows.Forms.RichTextBox();
            this.RTB_DescProject = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RTB_Desc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateStart = new System.Windows.Forms.DateTimePicker();
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PGB_Percent = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.TBX_Percent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBX_TaskType
            // 
            this.CBX_TaskType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBX_TaskType.FormattingEnabled = true;
            this.CBX_TaskType.Location = new System.Drawing.Point(170, 383);
            this.CBX_TaskType.Name = "CBX_TaskType";
            this.CBX_TaskType.Size = new System.Drawing.Size(244, 21);
            this.CBX_TaskType.TabIndex = 0;
            this.CBX_TaskType.SelectedIndexChanged += new System.EventHandler(this.CBX_TaskType_SelectedIndexChanged);
            // 
            // CBX_Project
            // 
            this.CBX_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBX_Project.FormattingEnabled = true;
            this.CBX_Project.Location = new System.Drawing.Point(170, 268);
            this.CBX_Project.Name = "CBX_Project";
            this.CBX_Project.Size = new System.Drawing.Size(244, 21);
            this.CBX_Project.TabIndex = 1;
            this.CBX_Project.SelectedIndexChanged += new System.EventHandler(this.CBX_Project_SelectedIndexChanged);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.Location = new System.Drawing.Point(255, 18);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // RTB_DescTaskType
            // 
            this.RTB_DescTaskType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_DescTaskType.Location = new System.Drawing.Point(170, 413);
            this.RTB_DescTaskType.Name = "RTB_DescTaskType";
            this.RTB_DescTaskType.ReadOnly = true;
            this.RTB_DescTaskType.Size = new System.Drawing.Size(244, 69);
            this.RTB_DescTaskType.TabIndex = 3;
            this.RTB_DescTaskType.Text = "";
            // 
            // RTB_DescProject
            // 
            this.RTB_DescProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_DescProject.Location = new System.Drawing.Point(170, 298);
            this.RTB_DescProject.Name = "RTB_DescProject";
            this.RTB_DescProject.ReadOnly = true;
            this.RTB_DescProject.Size = new System.Drawing.Size(244, 69);
            this.RTB_DescProject.TabIndex = 4;
            this.RTB_DescProject.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_Cancel);
            this.panel1.Controls.Add(this.BTN_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 53);
            this.panel1.TabIndex = 5;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.Location = new System.Drawing.Point(336, 18);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RTB_DescTaskType, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.CBX_Project, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.CBX_TaskType, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.RTB_DescProject, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.RTB_Desc, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.DTP_DateEnd, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DTP_DateStart, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Title, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 494);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(19, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(19, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 75);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description du projet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(19, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type de tâche:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(19, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 75);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description type de tâche:";
            // 
            // RTB_Desc
            // 
            this.RTB_Desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Desc.Location = new System.Drawing.Point(170, 183);
            this.RTB_Desc.Name = "RTB_Desc";
            this.RTB_Desc.Size = new System.Drawing.Size(244, 69);
            this.RTB_Desc.TabIndex = 8;
            this.RTB_Desc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 75);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description:";
            // 
            // DTP_DateEnd
            // 
            this.DTP_DateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_DateEnd.Location = new System.Drawing.Point(170, 103);
            this.DTP_DateEnd.Name = "DTP_DateEnd";
            this.DTP_DateEnd.Size = new System.Drawing.Size(244, 20);
            this.DTP_DateEnd.TabIndex = 11;
            // 
            // DTP_DateStart
            // 
            this.DTP_DateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_DateStart.Location = new System.Drawing.Point(170, 63);
            this.DTP_DateStart.Name = "DTP_DateStart";
            this.DTP_DateStart.Size = new System.Drawing.Size(244, 20);
            this.DTP_DateStart.TabIndex = 12;
            // 
            // TBX_Title
            // 
            this.TBX_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_Title.Location = new System.Drawing.Point(170, 23);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(244, 20);
            this.TBX_Title.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Titre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(19, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date de déut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(19, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date de fin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(19, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pourcentage:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.63934F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.36065F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Controls.Add(this.PGB_Percent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TBX_Percent, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(170, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 24);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // PGB_Percent
            // 
            this.PGB_Percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGB_Percent.Location = new System.Drawing.Point(3, 3);
            this.PGB_Percent.Name = "PGB_Percent";
            this.PGB_Percent.Size = new System.Drawing.Size(155, 18);
            this.PGB_Percent.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(213, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "%";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBX_Percent
            // 
            this.TBX_Percent.Location = new System.Drawing.Point(164, 3);
            this.TBX_Percent.Name = "TBX_Percent";
            this.TBX_Percent.Size = new System.Drawing.Size(43, 20);
            this.TBX_Percent.TabIndex = 13;
            this.TBX_Percent.Text = "0";
            this.TBX_Percent.TextChanged += new System.EventHandler(this.TBX_Percent_TextChanged);
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(606, 666);
            this.Name = "EditTask";
            this.Text = "EditTask";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_TaskType;
        private System.Windows.Forms.ComboBox CBX_Project;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.RichTextBox RTB_DescTaskType;
        private System.Windows.Forms.RichTextBox RTB_DescProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RTB_Desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_DateEnd;
        private System.Windows.Forms.DateTimePicker DTP_DateStart;
        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar PGB_Percent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBX_Percent;
    }
}