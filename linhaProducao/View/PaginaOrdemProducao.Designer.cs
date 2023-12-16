namespace linhaProducao.View
{
    partial class PaginaOrdemProducao
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
            this.listViewOrdemProducao = new System.Windows.Forms.ListView();
            this.btnCadastrarOrdemProducao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOrdemProducao
            // 
            this.listViewOrdemProducao.HideSelection = false;
            this.listViewOrdemProducao.Location = new System.Drawing.Point(3, -1);
            this.listViewOrdemProducao.Name = "listViewOrdemProducao";
            this.listViewOrdemProducao.Size = new System.Drawing.Size(798, 454);
            this.listViewOrdemProducao.TabIndex = 0;
            this.listViewOrdemProducao.UseCompatibleStateImageBehavior = false;
            this.listViewOrdemProducao.SelectedIndexChanged += new System.EventHandler(this.listViewOrdemProducao_SelectedIndexChanged);
            // 
            // btnCadastrarOrdemProducao
            // 
            this.btnCadastrarOrdemProducao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarOrdemProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarOrdemProducao.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarOrdemProducao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarOrdemProducao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOrdemProducao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarOrdemProducao.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarOrdemProducao.Name = "btnCadastrarOrdemProducao";
            this.btnCadastrarOrdemProducao.Size = new System.Drawing.Size(259, 48);
            this.btnCadastrarOrdemProducao.TabIndex = 2;
            this.btnCadastrarOrdemProducao.Text = "Cadastrar ordem produção";
            this.btnCadastrarOrdemProducao.UseVisualStyleBackColor = false;
            this.btnCadastrarOrdemProducao.Click += new System.EventHandler(this.btnCadastrarOrdemProducao_Click);
            // 
            // PaginaOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarOrdemProducao);
            this.Controls.Add(this.listViewOrdemProducao);
            this.Name = "PaginaOrdemProducao";
            this.Text = "PaginaOrdemProducao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrdemProducao;
        private System.Windows.Forms.Button btnCadastrarOrdemProducao;
    }
}