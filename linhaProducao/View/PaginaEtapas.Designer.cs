namespace linhaProducao.View
{
    partial class PaginaEtapas
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
            this.listViewEtapas = new System.Windows.Forms.ListView();
            this.btnCadastrarEtapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEtapas
            // 
            this.listViewEtapas.HideSelection = false;
            this.listViewEtapas.Location = new System.Drawing.Point(1, 0);
            this.listViewEtapas.Name = "listViewEtapas";
            this.listViewEtapas.Size = new System.Drawing.Size(801, 453);
            this.listViewEtapas.TabIndex = 0;
            this.listViewEtapas.UseCompatibleStateImageBehavior = false;
            this.listViewEtapas.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnCadastrarEtapa
            // 
            this.btnCadastrarEtapa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarEtapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarEtapa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarEtapa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEtapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarEtapa.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarEtapa.Name = "btnCadastrarEtapa";
            this.btnCadastrarEtapa.Size = new System.Drawing.Size(210, 48);
            this.btnCadastrarEtapa.TabIndex = 2;
            this.btnCadastrarEtapa.Text = "Cadastrar etapa";
            this.btnCadastrarEtapa.UseVisualStyleBackColor = false;
            this.btnCadastrarEtapa.Click += new System.EventHandler(this.btnCadastrarEtapa_Click);
            // 
            // PaginaEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarEtapa);
            this.Controls.Add(this.listViewEtapas);
            this.Name = "PaginaEtapas";
            this.Text = "PaginaEtapas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEtapas;
        private System.Windows.Forms.Button btnCadastrarEtapa;
    }
}