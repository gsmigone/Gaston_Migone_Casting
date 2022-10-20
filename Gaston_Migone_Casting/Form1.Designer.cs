namespace Gaston_Migone_Casting
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
            this.btnImp = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnMet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(151, 62);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(158, 23);
            this.btnImp.TabIndex = 0;
            this.btnImp.Text = "Ejemplo Casting Implícito";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(151, 103);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(158, 23);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Ejemplo Casting Explícito";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnMet
            // 
            this.btnMet.Location = new System.Drawing.Point(151, 146);
            this.btnMet.Name = "btnMet";
            this.btnMet.Size = new System.Drawing.Size(158, 23);
            this.btnMet.TabIndex = 2;
            this.btnMet.Text = "Ejemplo Métodos de Casteo";
            this.btnMet.UseVisualStyleBackColor = true;
            this.btnMet.Click += new System.EventHandler(this.btnMet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 265);
            this.Controls.Add(this.btnMet);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnImp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnMet;
    }
}

