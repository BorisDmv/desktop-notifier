
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.changeTextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topStrip = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(951, 617);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(180, 45);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // changeTextBtn
            // 
            this.changeTextBtn.CheckedState.Parent = this.changeTextBtn;
            this.changeTextBtn.CustomImages.Parent = this.changeTextBtn;
            this.changeTextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeTextBtn.ForeColor = System.Drawing.Color.White;
            this.changeTextBtn.HoverState.Parent = this.changeTextBtn;
            this.changeTextBtn.Location = new System.Drawing.Point(459, 395);
            this.changeTextBtn.Name = "changeTextBtn";
            this.changeTextBtn.ShadowDecoration.Parent = this.changeTextBtn;
            this.changeTextBtn.Size = new System.Drawing.Size(285, 58);
            this.changeTextBtn.TabIndex = 1;
            this.changeTextBtn.Text = "Change Text";
            this.changeTextBtn.Click += new System.EventHandler(this.changeTextBtn_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(504, 328);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(197, 40);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "Main Panel";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 0;
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(18, 617);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(45, 20);
            this.clockLabel.TabIndex = 4;
            this.clockLabel.Text = "clock";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topStrip
            // 
            this.topStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topStrip.Location = new System.Drawing.Point(0, 0);
            this.topStrip.Name = "topStrip";
            this.topStrip.ShadowDecoration.Parent = this.topStrip;
            this.topStrip.Size = new System.Drawing.Size(1153, 46);
            this.topStrip.TabIndex = 5;
            this.topStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topStrip_MouseDown);
            this.topStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topStrip_MouseMove);
            this.topStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topStrip_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 674);
            this.Controls.Add(this.topStrip);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.changeTextBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button changeTextBtn;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel topStrip;
    }
}

