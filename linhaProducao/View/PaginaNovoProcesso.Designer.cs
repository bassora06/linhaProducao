﻿namespace linhaProducao.View
{
    partial class PaginaNovoProcesso
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
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Location = new System.Drawing.Point(18, 136);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(175, 44);
            this.btnCancelarCliente.TabIndex = 12;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(230, 136);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(175, 44);
            this.btnSalvarCliente.TabIndex = 11;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextBoxNome);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 88);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nome";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNome.Location = new System.Drawing.Point(6, 28);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(375, 47);
            this.TextBoxNome.TabIndex = 0;
            // 
            // PaginaNovoProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 205);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnSalvarCliente);
            this.Name = "PaginaNovoProcesso";
            this.Text = "PaginaNovoProcesso";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TextBoxNome;
    }
}