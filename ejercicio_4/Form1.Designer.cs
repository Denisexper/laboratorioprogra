namespace ejercicio_4
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
            this.NullReferenceException = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.dia = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NullReferenceException
            // 
            this.NullReferenceException.AutoSize = true;
            this.NullReferenceException.Location = new System.Drawing.Point(364, 36);
            this.NullReferenceException.Name = "NullReferenceException";
            this.NullReferenceException.Size = new System.Drawing.Size(122, 13);
            this.NullReferenceException.TabIndex = 0;
            this.NullReferenceException.Text = "NullReferenceException";
            this.NullReferenceException.Click += new System.EventHandler(this.NullReferenceException_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "numero 1";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(386, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 5;
            this.result.Text = "resultado";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.button1_Click);
            // 
            // dia
            // 
            this.dia.Location = new System.Drawing.Point(317, 95);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(100, 20);
            this.dia.TabIndex = 6;
            // 
            // mes
            // 
            this.mes.Location = new System.Drawing.Point(442, 95);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 20);
            this.mes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "numero 2";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(376, 203);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NullReferenceException);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NullReferenceException;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox dia;
        private System.Windows.Forms.TextBox mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label3;
    }
}

