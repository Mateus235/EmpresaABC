
namespace mercadoSA
{
    partial class frmCalcu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcu));
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel3 = new System.Windows.Forms.Label();
            this.lblVarivel2 = new System.Windows.Forms.Label();
            this.grbOperacoes = new System.Windows.Forms.GroupBox();
            this.rdoDivisao = new System.Windows.Forms.RadioButton();
            this.rdoMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdoSubtracao = new System.Windows.Forms.RadioButton();
            this.rdoAdicao = new System.Windows.Forms.RadioButton();
            this.btoCalcular = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.grbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.BackColor = System.Drawing.SystemColors.Control;
            this.lblVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel1.Location = new System.Drawing.Point(72, 46);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(67, 18);
            this.lblVariavel1.TabIndex = 0;
            this.lblVariavel1.Text = "Variavel1";
            this.lblVariavel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVariavel3
            // 
            this.lblVariavel3.AutoSize = true;
            this.lblVariavel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVariavel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVariavel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblVariavel3.Location = new System.Drawing.Point(426, 59);
            this.lblVariavel3.Name = "lblVariavel3";
            this.lblVariavel3.Size = new System.Drawing.Size(89, 26);
            this.lblVariavel3.TabIndex = 1;
            this.lblVariavel3.Text = "resultado";
            this.lblVariavel3.Click += new System.EventHandler(this.lblVariavel3_Click);
            // 
            // lblVarivel2
            // 
            this.lblVarivel2.AutoSize = true;
            this.lblVarivel2.BackColor = System.Drawing.SystemColors.Control;
            this.lblVarivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarivel2.Location = new System.Drawing.Point(225, 46);
            this.lblVarivel2.Name = "lblVarivel2";
            this.lblVarivel2.Size = new System.Drawing.Size(67, 18);
            this.lblVarivel2.TabIndex = 2;
            this.lblVarivel2.Text = "Variavel2";
            // 
            // grbOperacoes
            // 
            this.grbOperacoes.BackColor = System.Drawing.SystemColors.Control;
            this.grbOperacoes.Controls.Add(this.rdoDivisao);
            this.grbOperacoes.Controls.Add(this.rdoMultiplicacao);
            this.grbOperacoes.Controls.Add(this.rdoSubtracao);
            this.grbOperacoes.Controls.Add(this.rdoAdicao);
            this.grbOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOperacoes.Location = new System.Drawing.Point(1, 240);
            this.grbOperacoes.Name = "grbOperacoes";
            this.grbOperacoes.Size = new System.Drawing.Size(416, 215);
            this.grbOperacoes.TabIndex = 2;
            this.grbOperacoes.TabStop = false;
            this.grbOperacoes.Text = "operacoes";
            // 
            // rdoDivisao
            // 
            this.rdoDivisao.AutoSize = true;
            this.rdoDivisao.BackColor = System.Drawing.SystemColors.Control;
            this.rdoDivisao.Location = new System.Drawing.Point(260, 161);
            this.rdoDivisao.Name = "rdoDivisao";
            this.rdoDivisao.Size = new System.Drawing.Size(89, 22);
            this.rdoDivisao.TabIndex = 3;
            this.rdoDivisao.TabStop = true;
            this.rdoDivisao.Text = "Divisão(/)";
            this.rdoDivisao.UseVisualStyleBackColor = false;
            // 
            // rdoMultiplicacao
            // 
            this.rdoMultiplicacao.AutoSize = true;
            this.rdoMultiplicacao.BackColor = System.Drawing.SystemColors.Control;
            this.rdoMultiplicacao.Location = new System.Drawing.Point(240, 62);
            this.rdoMultiplicacao.Name = "rdoMultiplicacao";
            this.rdoMultiplicacao.Size = new System.Drawing.Size(128, 22);
            this.rdoMultiplicacao.TabIndex = 2;
            this.rdoMultiplicacao.TabStop = true;
            this.rdoMultiplicacao.Text = "Multiplicação(*)";
            this.rdoMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // rdoSubtracao
            // 
            this.rdoSubtracao.AutoSize = true;
            this.rdoSubtracao.BackColor = System.Drawing.SystemColors.Control;
            this.rdoSubtracao.Location = new System.Drawing.Point(32, 161);
            this.rdoSubtracao.Name = "rdoSubtracao";
            this.rdoSubtracao.Size = new System.Drawing.Size(109, 22);
            this.rdoSubtracao.TabIndex = 1;
            this.rdoSubtracao.TabStop = true;
            this.rdoSubtracao.Text = "Subtração(-)";
            this.rdoSubtracao.UseVisualStyleBackColor = false;
            // 
            // rdoAdicao
            // 
            this.rdoAdicao.AutoSize = true;
            this.rdoAdicao.BackColor = System.Drawing.SystemColors.Control;
            this.rdoAdicao.Location = new System.Drawing.Point(32, 62);
            this.rdoAdicao.Name = "rdoAdicao";
            this.rdoAdicao.Size = new System.Drawing.Size(90, 22);
            this.rdoAdicao.TabIndex = 0;
            this.rdoAdicao.TabStop = true;
            this.rdoAdicao.Text = "Adição(+)";
            this.rdoAdicao.UseVisualStyleBackColor = false;
            // 
            // btoCalcular
            // 
            this.btoCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btoCalcular.Location = new System.Drawing.Point(648, 34);
            this.btoCalcular.Name = "btoCalcular";
            this.btoCalcular.Size = new System.Drawing.Size(99, 45);
            this.btoCalcular.TabIndex = 4;
            this.btoCalcular.Text = "Calcular";
            this.btoCalcular.UseVisualStyleBackColor = false;
            this.btoCalcular.Click += new System.EventHandler(this.btoCalcular_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btoLimpar.Location = new System.Drawing.Point(648, 107);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(99, 40);
            this.btoLimpar.TabIndex = 5;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = false;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btoSair.Location = new System.Drawing.Point(648, 318);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(154, 137);
            this.btoSair.TabIndex = 6;
            this.btoSair.Tag = "";
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = false;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(52, 81);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 7;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(216, 81);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 8;
            // 
            // frmCalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoCalcular);
            this.Controls.Add(this.grbOperacoes);
            this.Controls.Add(this.lblVarivel2);
            this.Controls.Add(this.lblVariavel3);
            this.Controls.Add(this.lblVariavel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalcu";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalcu_Load);
            this.grbOperacoes.ResumeLayout(false);
            this.grbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel3;
        private System.Windows.Forms.Label lblVarivel2;
        private System.Windows.Forms.GroupBox grbOperacoes;
        private System.Windows.Forms.RadioButton rdoDivisao;
        private System.Windows.Forms.RadioButton rdoMultiplicacao;
        private System.Windows.Forms.RadioButton rdoSubtracao;
        private System.Windows.Forms.RadioButton rdoAdicao;
        private System.Windows.Forms.Button btoCalcular;
        private System.Windows.Forms.Button btoLimpar;
        private System.Windows.Forms.Button btoSair;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}