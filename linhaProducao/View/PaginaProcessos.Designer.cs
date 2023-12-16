namespace linhaProducao.View
{
    partial class PaginaProcessos
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
            this.listViewProcessos = new System.Windows.Forms.ListView();
            this.btnCadastrarProcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProcessos
            // 
            this.listViewProcessos.HideSelection = false;
            this.listViewProcessos.Location = new System.Drawing.Point(1, -1);
            this.listViewProcessos.Name = "listViewProcessos";
            this.listViewProcessos.Size = new System.Drawing.Size(802, 454);
            this.listViewProcessos.TabIndex = 0;
            this.listViewProcessos.UseCompatibleStateImageBehavior = false;
            this.listViewProcessos.SelectedIndexChanged += new System.EventHandler(this.listViewProcessos_SelectedIndexChanged);
            // 
            // btnCadastrarProcesso
            // 
            this.btnCadastrarProcesso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarProcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarProcesso.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarProcesso.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProcesso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarProcesso.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarProcesso.Name = "btnCadastrarProcesso";
            this.btnCadastrarProcesso.Size = new System.Drawing.Size(210, 48);
            this.btnCadastrarProcesso.TabIndex = 2;
            this.btnCadastrarProcesso.Text = "Cadastrar processo";
            this.btnCadastrarProcesso.UseVisualStyleBackColor = false;
            this.btnCadastrarProcesso.Click += new System.EventHandler(this.btnCadastrarProcesso_Click);
            // 
            // PaginaProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarProcesso);
            this.Controls.Add(this.listViewProcessos);
            this.Name = "PaginaProcessos";
            this.Text = "PaginaProcessos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProcessos;
        private System.Windows.Forms.Button btnCadastrarProcesso;
    }
}