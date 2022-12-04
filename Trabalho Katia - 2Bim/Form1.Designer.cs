namespace Trabalho_Katia___2Bim
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
            this.btnForncedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnAlimenticios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForncedores
            // 
            this.btnForncedores.BackColor = System.Drawing.SystemColors.Info;
            this.btnForncedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForncedores.Location = new System.Drawing.Point(125, 191);
            this.btnForncedores.Name = "btnForncedores";
            this.btnForncedores.Size = new System.Drawing.Size(161, 57);
            this.btnForncedores.TabIndex = 0;
            this.btnForncedores.Text = "Forncedores";
            this.btnForncedores.UseVisualStyleBackColor = false;
            this.btnForncedores.Click += new System.EventHandler(this.btnForncedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(320, 191);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(161, 57);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnAlimenticios
            // 
            this.btnAlimenticios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAlimenticios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimenticios.Location = new System.Drawing.Point(524, 191);
            this.btnAlimenticios.Name = "btnAlimenticios";
            this.btnAlimenticios.Size = new System.Drawing.Size(161, 57);
            this.btnAlimenticios.TabIndex = 2;
            this.btnAlimenticios.Text = "Alimentícios";
            this.btnAlimenticios.UseVisualStyleBackColor = false;
            this.btnAlimenticios.Click += new System.EventHandler(this.btnAlimenticios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlimenticios);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnForncedores);
            this.Name = "Form1";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForncedores;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnAlimenticios;
    }
}

