namespace processImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagemBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemBox
            // 
            this.imagemBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemBox.Image")));
            this.imagemBox.Location = new System.Drawing.Point(12, 12);
            this.imagemBox.Name = "imagemBox";
            this.imagemBox.Size = new System.Drawing.Size(712, 487);
            this.imagemBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemBox.TabIndex = 0;
            this.imagemBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "CONTAR PIXEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagemBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemBox;
        private System.Windows.Forms.Button button1;
    }
}

