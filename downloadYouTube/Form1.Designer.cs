namespace downloadYouTube
{
    partial class FrmPrincipal
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
            this.txtLinkYoutube = new System.Windows.Forms.TextBox();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLinkYoutube
            // 
            this.txtLinkYoutube.Location = new System.Drawing.Point(19, 61);
            this.txtLinkYoutube.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLinkYoutube.Name = "txtLinkYoutube";
            this.txtLinkYoutube.Size = new System.Drawing.Size(610, 22);
            this.txtLinkYoutube.TabIndex = 0;
            // 
            // btnBaixar
            // 
            this.btnBaixar.BackColor = System.Drawing.Color.Teal;
            this.btnBaixar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnBaixar.Location = new System.Drawing.Point(194, 160);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(225, 28);
            this.btnBaixar.TabIndex = 1;
            this.btnBaixar.Text = "BAIXAR";
            this.btnBaixar.UseVisualStyleBackColor = false;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link do vídeo (YouTube)";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.txtLinkYoutube);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WILL - SOLUÇÃO DE DOWNLOAD";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinkYoutube;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Label label1;
    }
}

