namespace taller5._2
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de numeros que quiere";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(303, 40);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(162, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(325, 66);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(140, 23);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Text = "enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 238);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 334);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

