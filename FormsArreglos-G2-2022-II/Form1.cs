using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsArreglos_G2_2022_II
{
    public partial class Form1 : Form
    {
        Unidimensional u1;
        Unidimensional u2;
        Multidimensional m1;
        Multidimensional m2;
       
        bool lbOperandos= true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (txtbDisplay.Text.Contains(";"))
            {
                m1 = Multidimensional.Leer(txtbDisplay.Text);
                if (lbOperandos)
                {
                    m2 = m1;
                    lbMatriz1.Text = m1.ToString();
                    lbOperandos = false;
                }
                else
                {
                    lbMatriz2.Text = m1.ToString();
                    lbOperandos = true;
                }

            }
            else
            {

                u1 = Unidimensional.Leer(txtbDisplay.Text);
                if (lbOperandos)
                {
                    u2 = u1;
                    lbMatriz1.Text = u1.ToString();
                    lbOperandos = false;
                }
                else
                {

                    lbMatriz2.Text = u1.ToString();
                    lbOperandos = true;
                }
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            if ( m1 !=null)
            {
                Multidimensional m3 = m2 + m1;
                lbResultado.Text = m3.ToString();

            }
            else
            {
                Unidimensional u3 = u2 + u1;
                lbResultado.Text = u3.ToString();

            }
            
        }
    }
}
