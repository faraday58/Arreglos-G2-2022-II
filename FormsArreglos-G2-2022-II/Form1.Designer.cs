
namespace FormsArreglos_G2_2022_II
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtbMat1 = new System.Windows.Forms.TextBox();
            this.txtbMat2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(229, 273);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(250, 129);
            this.btnSumar.TabIndex = 1;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // txtbMat1
            // 
            this.txtbMat1.Location = new System.Drawing.Point(120, 145);
            this.txtbMat1.Name = "txtbMat1";
            this.txtbMat1.Size = new System.Drawing.Size(154, 38);
            this.txtbMat1.TabIndex = 2;
            // 
            // txtbMat2
            // 
            this.txtbMat2.Location = new System.Drawing.Point(452, 148);
            this.txtbMat2.Name = "txtbMat2";
            this.txtbMat2.Size = new System.Drawing.Size(143, 38);
            this.txtbMat2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(827, 134);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(54, 64);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "0 0\r\n0 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 459);
            this.Controls.Add(this.txtbMat2);
            this.Controls.Add(this.txtbMat1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtbMat1;
        private System.Windows.Forms.TextBox txtbMat2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
    }
}

