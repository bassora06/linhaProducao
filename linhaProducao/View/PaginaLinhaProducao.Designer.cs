namespace linhaProducao.View
{
    partial class PaginaLinhaProducao
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
            this.listViewLinhaProducao = new System.Windows.Forms.ListView();
            this.btnCadastrarLinhaProducao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLinhaProducao
            // 
            this.listViewLinhaProducao.HideSelection = false;
            this.listViewLinhaProducao.Location = new System.Drawing.Point(-4, -1);
            this.listViewLinhaProducao.Name = "listViewLinhaProducao";
            this.listViewLinhaProducao.Size = new System.Drawing.Size(807, 454);
            this.listViewLinhaProducao.TabIndex = 0;
            this.listViewLinhaProducao.UseCompatibleStateImageBehavior = false;
            this.listViewLinhaProducao.SelectedIndexChanged += new System.EventHandler(this.listViewLinhaProducao_SelectedIndexChanged);
            // 
            // btnCadastrarLinhaProducao
            // 
            this.btnCadastrarLinhaProducao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarLinhaProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarLinhaProducao.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarLinhaProducao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarLinhaProducao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLinhaProducao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarLinhaProducao.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarLinhaProducao.Name = "btnCadastrarLinhaProducao";
            this.btnCadastrarLinhaProducao.Size = new System.Drawing.Size(265, 48);
            this.btnCadastrarLinhaProducao.TabIndex = 2;
            this.btnCadastrarLinhaProducao.Text = "Cadastrar linha de produção";
            this.btnCadastrarLinhaProducao.UseVisualStyleBackColor = false;
            this.btnCadastrarLinhaProducao.Click += new System.EventHandler(this.btnCadastrarLinhaProducao_Click);
            // 
            // PaginaLinhaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarLinhaProducao);
            this.Controls.Add(this.listViewLinhaProducao);
            this.Name = "PaginaLinhaProducao";
            this.Text = "PaginaLinhaProducao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLinhaProducao;
        private System.Windows.Forms.Button btnCadastrarLinhaProducao;
    }
}