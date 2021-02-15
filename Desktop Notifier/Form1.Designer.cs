
using System;

namespace Desktop_Notifier
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nameInsertBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.deadLineInsertBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addTaskButton = new Guna.UI2.WinForms.Guna2Button();
            this.topStrip = new Guna.UI2.WinForms.Guna2Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableTasks)).BeginInit();
            this.topStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(1103, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(51, 40);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clockLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockLabel.Location = new System.Drawing.Point(12, 560);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(69, 29);
            this.clockLabel.TabIndex = 4;
            this.clockLabel.Text = "clock";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableTasks
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tableTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tableTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableTasks.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableTasks.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableTasks.EnableHeadersVisualStyles = false;
            this.tableTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableTasks.Location = new System.Drawing.Point(12, 58);
            this.tableTasks.Name = "tableTasks";
            this.tableTasks.RowHeadersVisible = false;
            this.tableTasks.RowHeadersWidth = 62;
            this.tableTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableTasks.Size = new System.Drawing.Size(1130, 457);
            this.tableTasks.TabIndex = 6;
            this.tableTasks.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableTasks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tableTasks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableTasks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableTasks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableTasks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableTasks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableTasks.ThemeStyle.HeaderStyle.Height = 21;
            this.tableTasks.ThemeStyle.ReadOnly = false;
            this.tableTasks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableTasks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableTasks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableTasks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableTasks.ThemeStyle.RowsStyle.Height = 22;
            this.tableTasks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableTasks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // nameInsertBox
            // 
            this.nameInsertBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInsertBox.DefaultText = "";
            this.nameInsertBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameInsertBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameInsertBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInsertBox.DisabledState.Parent = this.nameInsertBox;
            this.nameInsertBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInsertBox.FillColor = System.Drawing.Color.DimGray;
            this.nameInsertBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInsertBox.FocusedState.Parent = this.nameInsertBox;
            this.nameInsertBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameInsertBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInsertBox.HoverState.Parent = this.nameInsertBox;
            this.nameInsertBox.Location = new System.Drawing.Point(544, 527);
            this.nameInsertBox.Name = "nameInsertBox";
            this.nameInsertBox.PasswordChar = '\0';
            this.nameInsertBox.PlaceholderText = "Task Name";
            this.nameInsertBox.SelectedText = "";
            this.nameInsertBox.ShadowDecoration.Parent = this.nameInsertBox;
            this.nameInsertBox.Size = new System.Drawing.Size(196, 62);
            this.nameInsertBox.TabIndex = 7;
            // 
            // deadLineInsertBox
            // 
            this.deadLineInsertBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deadLineInsertBox.DefaultText = "";
            this.deadLineInsertBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.deadLineInsertBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.deadLineInsertBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deadLineInsertBox.DisabledState.Parent = this.deadLineInsertBox;
            this.deadLineInsertBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deadLineInsertBox.FillColor = System.Drawing.Color.DimGray;
            this.deadLineInsertBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deadLineInsertBox.FocusedState.Parent = this.deadLineInsertBox;
            this.deadLineInsertBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deadLineInsertBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deadLineInsertBox.HoverState.Parent = this.deadLineInsertBox;
            this.deadLineInsertBox.Location = new System.Drawing.Point(746, 527);
            this.deadLineInsertBox.Name = "deadLineInsertBox";
            this.deadLineInsertBox.PasswordChar = '\0';
            this.deadLineInsertBox.PlaceholderText = "Deadline";
            this.deadLineInsertBox.SelectedText = "";
            this.deadLineInsertBox.ShadowDecoration.Parent = this.deadLineInsertBox;
            this.deadLineInsertBox.Size = new System.Drawing.Size(196, 62);
            this.deadLineInsertBox.TabIndex = 8;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTaskButton.CheckedState.Parent = this.addTaskButton;
            this.addTaskButton.CustomImages.Parent = this.addTaskButton;
            this.addTaskButton.FillColor = System.Drawing.Color.SlateBlue;
            this.addTaskButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.HoverState.Parent = this.addTaskButton;
            this.addTaskButton.Location = new System.Drawing.Point(948, 527);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.ShadowDecoration.Parent = this.addTaskButton;
            this.addTaskButton.Size = new System.Drawing.Size(194, 62);
            this.addTaskButton.TabIndex = 10;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // topStrip
            // 
            this.topStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topStrip.BackColor = System.Drawing.Color.SlateBlue;
            this.topStrip.Controls.Add(this.minimizeBtn);
            this.topStrip.Controls.Add(this.titleLabel);
            this.topStrip.Controls.Add(this.exitBtn);
            this.topStrip.Location = new System.Drawing.Point(0, 0);
            this.topStrip.Name = "topStrip";
            this.topStrip.ShadowDecoration.Parent = this.topStrip;
            this.topStrip.Size = new System.Drawing.Size(1154, 46);
            this.topStrip.TabIndex = 5;
            this.topStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topStrip_MouseDown);
            this.topStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topStrip_MouseMove);
            this.topStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topStrip_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(12, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(123, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Desktop Notifier";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.minimizeBtn.CheckedState.Parent = this.minimizeBtn;
            this.minimizeBtn.CustomImages.Parent = this.minimizeBtn;
            this.minimizeBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.HoverState.Parent = this.minimizeBtn;
            this.minimizeBtn.Location = new System.Drawing.Point(1046, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.ShadowDecoration.Parent = this.minimizeBtn;
            this.minimizeBtn.Size = new System.Drawing.Size(51, 40);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1154, 604);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.deadLineInsertBox);
            this.Controls.Add(this.nameInsertBox);
            this.Controls.Add(this.tableTasks);
            this.Controls.Add(this.topStrip);
            this.Controls.Add(this.clockLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableTasks)).EndInit();
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer1;

        private Guna.UI2.WinForms.Guna2DataGridView tableTasks;
        private Guna.UI2.WinForms.Guna2Button addTaskButton;
        private Guna.UI2.WinForms.Guna2TextBox deadLineInsertBox;
        private Guna.UI2.WinForms.Guna2TextBox nameInsertBox;

        private Guna.UI2.WinForms.Guna2Panel topStrip;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2Button minimizeBtn;

    }
}

