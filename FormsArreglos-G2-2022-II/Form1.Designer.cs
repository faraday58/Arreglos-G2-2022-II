
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtbDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbMatriz1 = new System.Windows.Forms.Label();
            this.lbMatriz2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.rdbRadianes = new System.Windows.Forms.RadioButton();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(302, 489);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(93, 57);
            this.btnSumar.TabIndex = 1;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtbDisplay
            // 
            this.txtbDisplay.Location = new System.Drawing.Point(105, 136);
            this.txtbDisplay.Name = "txtbDisplay";
            this.txtbDisplay.Size = new System.Drawing.Size(463, 35);
            this.txtbDisplay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            // 
            // lbResultado
            // 
            this.lbResultado.Location = new System.Drawing.Point(794, 210);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(184, 87);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "0 0\r\n0 0";
            // 
            // lbMatriz1
            // 
            this.lbMatriz1.Location = new System.Drawing.Point(100, 225);
            this.lbMatriz1.Name = "lbMatriz1";
            this.lbMatriz1.Size = new System.Drawing.Size(200, 109);
            this.lbMatriz1.TabIndex = 0;
            this.lbMatriz1.Text = "0 0";
            // 
            // lbMatriz2
            // 
            this.lbMatriz2.Location = new System.Drawing.Point(460, 225);
            this.lbMatriz2.Name = "lbMatriz2";
            this.lbMatriz2.Size = new System.Drawing.Size(200, 109);
            this.lbMatriz2.TabIndex = 0;
            this.lbMatriz2.Text = "0 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Matriz 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matriz 2";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(83, 489);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 57);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(768, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 29);
            this.label.TabIndex = 0;
            this.label.Text = "Resultado";
            // 
            // rdbRadianes
            // 
            this.rdbRadianes.AutoSize = true;
            this.rdbRadianes.Location = new System.Drawing.Point(105, 62);
            this.rdbRadianes.Name = "rdbRadianes";
            this.rdbRadianes.Size = new System.Drawing.Size(146, 33);
            this.rdbRadianes.TabIndex = 3;
            this.rdbRadianes.TabStop = true;
            this.rdbRadianes.Text = "Radianes";
            this.rdbRadianes.UseVisualStyleBackColor = true;
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Location = new System.Drawing.Point(302, 62);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(89, 33);
            this.rdbDeg.TabIndex = 3;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "Deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(630, 489);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(93, 57);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Location = new System.Drawing.Point(83, 391);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(93, 57);
            this.btnSeno.TabIndex = 1;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1150, 709);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.rdbRadianes);
            this.Controls.Add(this.txtbDisplay);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMatriz2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMatriz1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtbDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbMatriz1;
        private System.Windows.Forms.Label lbMatriz2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton rdbRadianes;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSeno;
    }
}

