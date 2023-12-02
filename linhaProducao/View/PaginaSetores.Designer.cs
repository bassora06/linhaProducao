namespace linhaProducao.View
{
    partial class PaginaSetores
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
            this.listViewSetores = new System.Windows.Forms.ListView();
            this.btnCadastrarSetor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSetores
            // 
            this.listViewSetores.HideSelection = false;
            this.listViewSetores.Location = new System.Drawing.Point(1, -2);
            this.listViewSetores.Name = "listViewSetores";
            this.listViewSetores.Size = new System.Drawing.Size(803, 454);
            this.listViewSetores.TabIndex = 0;
            this.listViewSetores.UseCompatibleStateImageBehavior = false;
            this.listViewSetores.SelectedIndexChanged += new System.EventHandler(this.listViewSetores_SelectedIndexChanged);
            // 
            // btnCadastrarSetor
            // 
            this.btnCadastrarSetor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarSetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarSetor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarSetor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarSetor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSetor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarSetor.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarSetor.Name = "btnCadastrarSetor";
            this.btnCadastrarSetor.Size = new System.Drawing.Size(210, 48);
            this.btnCadastrarSetor.TabIndex = 2;
            this.btnCadastrarSetor.Text = "Cadastrar setor";
            this.btnCadastrarSetor.UseVisualStyleBackColor = false;
            // 
            // PaginaSetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarSetor);
            this.Controls.Add(this.listViewSetores);
            this.Name = "PaginaSetores";
            this.Text = "PaginaSetores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSetores;
        private System.Windows.Forms.Button btnCadastrarSetor;
    }
}