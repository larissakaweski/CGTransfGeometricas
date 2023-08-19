
namespace CGTransfGeometricas
{
    partial class tela
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
            this.painel = new System.Windows.Forms.Panel();
            this.numericUpDownTransY = new System.Windows.Forms.NumericUpDown();
            this.btTransladar = new System.Windows.Forms.Button();
            this.numericUpDownTransX = new System.Windows.Forms.NumericUpDown();
            this.btRotacionar = new System.Windows.Forms.Button();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.transformacoes = new System.Windows.Forms.Label();
            this.Infos = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.btApagar = new System.Windows.Forms.Button();
            this.btCor = new System.Windows.Forms.Button();
            this.btDesenhar = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            this.btEscala = new System.Windows.Forms.Button();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.btEspelhar = new System.Windows.Forms.Button();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.painel.Controls.Add(this.btEspelhar);
            this.painel.Controls.Add(this.btEscala);
            this.painel.Controls.Add(this.numericUpDownScale);
            this.painel.Controls.Add(this.numericUpDownTransY);
            this.painel.Controls.Add(this.btTransladar);
            this.painel.Controls.Add(this.numericUpDownTransX);
            this.painel.Controls.Add(this.btRotacionar);
            this.painel.Controls.Add(this.numericUpDownAngle);
            this.painel.Controls.Add(this.transformacoes);
            this.painel.Controls.Add(this.Infos);
            this.painel.Controls.Add(this.txtY);
            this.painel.Controls.Add(this.lbY);
            this.painel.Controls.Add(this.btApagar);
            this.painel.Controls.Add(this.btCor);
            this.painel.Controls.Add(this.btDesenhar);
            this.painel.Controls.Add(this.txtX);
            this.painel.Controls.Add(this.lbX);
            this.painel.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel.Location = new System.Drawing.Point(608, 0);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(257, 450);
            this.painel.TabIndex = 0;
            // 
            // numericUpDownTransY
            // 
            this.numericUpDownTransY.Location = new System.Drawing.Point(198, 351);
            this.numericUpDownTransY.Name = "numericUpDownTransY";
            this.numericUpDownTransY.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTransY.TabIndex = 19;
            this.numericUpDownTransY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTransY.ThousandsSeparator = true;
            // 
            // btTransladar
            // 
            this.btTransladar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransladar.Location = new System.Drawing.Point(27, 348);
            this.btTransladar.Name = "btTransladar";
            this.btTransladar.Size = new System.Drawing.Size(98, 23);
            this.btTransladar.TabIndex = 18;
            this.btTransladar.Text = "Transladar";
            this.btTransladar.UseVisualStyleBackColor = true;
            this.btTransladar.Click += new System.EventHandler(this.btTransladar_Click);
            // 
            // numericUpDownTransX
            // 
            this.numericUpDownTransX.Location = new System.Drawing.Point(135, 351);
            this.numericUpDownTransX.Name = "numericUpDownTransX";
            this.numericUpDownTransX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownTransX.TabIndex = 17;
            this.numericUpDownTransX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTransX.ThousandsSeparator = true;
            // 
            // btRotacionar
            // 
            this.btRotacionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRotacionar.Location = new System.Drawing.Point(27, 319);
            this.btRotacionar.Name = "btRotacionar";
            this.btRotacionar.Size = new System.Drawing.Size(98, 23);
            this.btRotacionar.TabIndex = 16;
            this.btRotacionar.Text = "Rotacionar";
            this.btRotacionar.UseVisualStyleBackColor = true;
            this.btRotacionar.Click += new System.EventHandler(this.btRotacionar_Click);
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(152, 322);
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownAngle.TabIndex = 14;
            this.numericUpDownAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAngle.ThousandsSeparator = true;
            // 
            // transformacoes
            // 
            this.transformacoes.AutoSize = true;
            this.transformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformacoes.Location = new System.Drawing.Point(28, 278);
            this.transformacoes.Name = "transformacoes";
            this.transformacoes.Size = new System.Drawing.Size(202, 29);
            this.transformacoes.TabIndex = 13;
            this.transformacoes.Text = "Transformações";
            // 
            // Infos
            // 
            this.Infos.AutoSize = true;
            this.Infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infos.Location = new System.Drawing.Point(60, 9);
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(156, 29);
            this.Infos.TabIndex = 12;
            this.Infos.Text = "Informações";
            // 
            // txtY
            // 
            this.txtY.BackColor = System.Drawing.SystemColors.Menu;
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(140, 75);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(80, 35);
            this.txtY.TabIndex = 11;
            this.txtY.Text = "0";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY.Location = new System.Drawing.Point(167, 47);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(28, 25);
            this.lbY.TabIndex = 9;
            this.lbY.Text = "Y";
            // 
            // btApagar
            // 
            this.btApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagar.Location = new System.Drawing.Point(65, 221);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(138, 36);
            this.btApagar.TabIndex = 8;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btCor
            // 
            this.btCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCor.Location = new System.Drawing.Point(65, 179);
            this.btCor.Name = "btCor";
            this.btCor.Size = new System.Drawing.Size(138, 36);
            this.btCor.TabIndex = 7;
            this.btCor.Text = "Cor";
            this.btCor.UseVisualStyleBackColor = true;
            this.btCor.Click += new System.EventHandler(this.btCor_Click);
            // 
            // btDesenhar
            // 
            this.btDesenhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesenhar.Location = new System.Drawing.Point(65, 137);
            this.btDesenhar.Name = "btDesenhar";
            this.btDesenhar.Size = new System.Drawing.Size(138, 36);
            this.btDesenhar.TabIndex = 6;
            this.btDesenhar.Text = "Desenhar";
            this.btDesenhar.UseVisualStyleBackColor = true;
            this.btDesenhar.Click += new System.EventHandler(this.btDesenhar_Click);
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.SystemColors.Menu;
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(33, 75);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(82, 35);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(60, 47);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 25);
            this.lbX.TabIndex = 2;
            this.lbX.Text = "X";
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(608, 450);
            this.imagem.TabIndex = 1;
            this.imagem.TabStop = false;
            this.imagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagem_MouseMove);
            // 
            // btEscala
            // 
            this.btEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEscala.Location = new System.Drawing.Point(27, 374);
            this.btEscala.Name = "btEscala";
            this.btEscala.Size = new System.Drawing.Size(98, 23);
            this.btEscala.TabIndex = 21;
            this.btEscala.Text = "Escalar";
            this.btEscala.UseVisualStyleBackColor = true;
            this.btEscala.Click += new System.EventHandler(this.btEscala_Click);
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.Location = new System.Drawing.Point(152, 377);
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownScale.TabIndex = 20;
            this.numericUpDownScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownScale.ThousandsSeparator = true;
            // 
            // btEspelhar
            // 
            this.btEspelhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEspelhar.Location = new System.Drawing.Point(27, 403);
            this.btEspelhar.Name = "btEspelhar";
            this.btEspelhar.Size = new System.Drawing.Size(98, 23);
            this.btEspelhar.TabIndex = 22;
            this.btEspelhar.Text = "Espelhar";
            this.btEspelhar.UseVisualStyleBackColor = true;
            this.btEspelhar.Click += new System.EventHandler(this.btEspelhar_Click);
            // 
            // tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.painel);
            this.Name = "tela";
            this.Text = "Roteiro 1 – Ambientação e Transformações";
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btCor;
        private System.Windows.Forms.Button btDesenhar;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.ColorDialog cdlg;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label transformacoes;
        private System.Windows.Forms.Label Infos;
        private System.Windows.Forms.Button btRotacionar;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.NumericUpDown numericUpDownTransY;
        private System.Windows.Forms.Button btTransladar;
        private System.Windows.Forms.NumericUpDown numericUpDownTransX;
        private System.Windows.Forms.Button btEscala;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Button btEspelhar;
    }
}

