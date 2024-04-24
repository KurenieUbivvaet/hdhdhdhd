namespace Technoservice
{
    partial class EnterForm
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
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            RegBtn = new Button();
            PasHideBtn = new Button();
            EnterBtn = new Button();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(77, 34);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(100, 23);
            LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(77, 72);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 1;
            // 
            // RegBtn
            // 
            RegBtn.Location = new Point(77, 135);
            RegBtn.Name = "RegBtn";
            RegBtn.Size = new Size(100, 23);
            RegBtn.TabIndex = 2;
            RegBtn.Text = "Регистрация";
            RegBtn.UseVisualStyleBackColor = true;
            RegBtn.Click += RegBtn_Click;
            // 
            // PasHideBtn
            // 
            PasHideBtn.Location = new Point(183, 71);
            PasHideBtn.Name = "PasHideBtn";
            PasHideBtn.Size = new Size(24, 23);
            PasHideBtn.TabIndex = 3;
            PasHideBtn.Text = "X";
            PasHideBtn.UseVisualStyleBackColor = true;
            PasHideBtn.Click += PasHideBtn_Click;
            // 
            // EnterBtn
            // 
            EnterBtn.Location = new Point(77, 106);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(100, 23);
            EnterBtn.TabIndex = 4;
            EnterBtn.Text = "Вход";
            EnterBtn.UseVisualStyleBackColor = true;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 275);
            Controls.Add(EnterBtn);
            Controls.Add(PasHideBtn);
            Controls.Add(RegBtn);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Name = "EnterForm";
            Text = "EnterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button RegBtn;
        private Button PasHideBtn;
        private Button EnterBtn;
    }
}