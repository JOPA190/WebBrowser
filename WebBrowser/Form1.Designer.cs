using System;

namespace WebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Avançar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(58, 8);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(474, 20);
            this.txt_URL.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(797, 417);
            this.webBrowser1.TabIndex = 2;
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.BackColor = System.Drawing.Color.Lime;
            this.btn_Abrir.Location = new System.Drawing.Point(538, 7);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(79, 20);
            this.btn_Abrir.TabIndex = 3;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = false;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.Red;
            this.btn_Voltar.Location = new System.Drawing.Point(635, 7);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(79, 20);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Avançar
            // 
            this.btn_Avançar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Avançar.Location = new System.Drawing.Point(720, 7);
            this.btn_Avançar.Name = "btn_Avançar";
            this.btn_Avançar.Size = new System.Drawing.Size(79, 20);
            this.btn_Avançar.TabIndex = 5;
            this.btn_Avançar.Text = "Avançar";
            this.btn_Avançar.UseVisualStyleBackColor = false;
            this.btn_Avançar.Click += new System.EventHandler(this.btn_Avançar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Avançar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Navegador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private readonly EventHandler label1_Click;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Avançar;
    }
}

