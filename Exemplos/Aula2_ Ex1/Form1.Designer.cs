
namespace Aula2__Ex1
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
            this.botao = new System.Windows.Forms.Button();
            this.labela = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(319, 271);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(163, 32);
            this.botao.TabIndex = 0;
            this.botao.Text = "botao";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            this.botao.Enter += new System.EventHandler(this.botao_Enter);
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(371, 168);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(39, 13);
            this.labela.TabIndex = 1;
            this.labela.Text = "abelha";
            this.labela.Click += new System.EventHandler(this.label1_Click);
            this.labela.DoubleClick += new System.EventHandler(this.labela_DoubleClick);
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(9, 18);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(781, 384);
            this.foto.TabIndex = 2;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            this.foto.MouseEnter += new System.EventHandler(this.foto_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.PictureBox foto;
    }
}

