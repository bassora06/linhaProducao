namespace linhaProducao.View
{
    partial class PaginaProdutos
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
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(1, -1);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(800, 452);
            this.listViewProdutos.TabIndex = 0;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(210, 48);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            // 
            // PaginaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.listViewProdutos);
            this.Name = "PaginaProdutos";
            this.Text = "PaginaProdutos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}