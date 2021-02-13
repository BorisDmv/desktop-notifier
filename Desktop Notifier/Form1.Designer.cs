
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.changeTextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleText = new System.Windows.Forms.Label();
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
            this.changeTextBtn.Location = new System.Drawing.Point(459, 396);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 674);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.changeTextBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button changeTextBtn;
        private System.Windows.Forms.Label titleText;
    }
}

