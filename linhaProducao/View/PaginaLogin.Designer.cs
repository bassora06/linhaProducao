namespace linhaProducao
{
    partial class PaginaLogin
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
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.Location = new System.Drawing.Point(12, 97);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(378, 56);
            this.TextBoxEmail.TabIndex = 0;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSenha.Location = new System.Drawing.Point(12, 159);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '•';
            this.TextBoxSenha.Size = new System.Drawing.Size(378, 56);
            this.TextBoxSenha.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(12, 230);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(378, 46);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Logar";
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Todos os direitos reservados ©2023";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PaginaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxEmail);
            this.Name = "PaginaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label2;
    }
}