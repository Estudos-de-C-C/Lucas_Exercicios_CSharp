
namespace Execricio_01_TEDS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_compra = new System.Windows.Forms.TextBox();
            this.valor_parcela = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor da compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite em quantas vezes deseja pagar:";
            // 
            // valor_compra
            // 
            this.valor_compra.Location = new System.Drawing.Point(211, 93);
            this.valor_compra.Name = "valor_compra";
            this.valor_compra.Size = new System.Drawing.Size(334, 23);
            this.valor_compra.TabIndex = 3;
            this.valor_compra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // valor_parcela
            // 
            this.valor_parcela.Location = new System.Drawing.Point(211, 181);
            this.valor_parcela.Name = "valor_parcela";
            this.valor_parcela.Size = new System.Drawing.Size(334, 23);
            this.valor_parcela.TabIndex = 4;
            this.valor_parcela.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor que deverá ser pago:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(365, 331);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(13, 15);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "0";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valor_parcela);
            this.Controls.Add(this.valor_compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor_compra;
        private System.Windows.Forms.TextBox valor_parcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultado;
    }
}

