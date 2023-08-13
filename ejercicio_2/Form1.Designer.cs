namespace Ejercici0_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.Button();
            this.frase = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "frase";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(362, 122);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(75, 23);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "comprobar";
            this.inputTextBox.UseVisualStyleBackColor = true;
            this.inputTextBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // frase
            // 
            this.frase.Location = new System.Drawing.Point(353, 81);
            this.frase.Name = "frase";
            this.frase.Size = new System.Drawing.Size(100, 20);
            this.frase.TabIndex = 2;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(288, 172);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(216, 20);
            this.resultado.TabIndex = 3;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.frase);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inputTextBox;
        private System.Windows.Forms.TextBox frase;
        private System.Windows.Forms.TextBox resultado;
    }
}

