
namespace Desktop_Notifier
{
    partial class Form2
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topStrip = new Guna.UI2.WinForms.Guna2Panel();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.topStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.topStrip.Margin = new System.Windows.Forms.Padding(2);
            this.topStrip.Name = "topStrip";
            this.topStrip.ShadowDecoration.Parent = this.topStrip;
            this.topStrip.Size = new System.Drawing.Size(769, 30);
            this.topStrip.TabIndex = 6;
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
            this.minimizeBtn.Location = new System.Drawing.Point(697, 2);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.ShadowDecoration.Parent = this.minimizeBtn;
            this.minimizeBtn.Size = new System.Drawing.Size(34, 26);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "-";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(8, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(83, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Desktop Notifier";
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
            this.exitBtn.Location = new System.Drawing.Point(735, 2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(34, 26);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel topStrip;
        private Guna.UI2.WinForms.Guna2Button minimizeBtn;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
    }
}