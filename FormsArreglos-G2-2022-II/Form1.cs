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
        Multidimensional m3;
       
        bool lbOperandos= true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtbDisplay.Text == "")
                {
                    string error = "Debe de ingresar una matriz";
                    throw new ApplicationException(error);
                }

                #region Leer operandos
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
                #endregion
            }
            catch(ApplicationException error   )
            {
                MessageBox.Show(error.Message);
            }




        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Suma

                if (m1 != null)
                {
                    if(m2.M != m1.M || m1.N != m2.N  )
                    {
                        string error = "Las matrices deben ser conformables";
                        throw new ApplicationException(error);
                    }


                    m3 = m2 + m1;
                    lbResultado.Text = m3.ToString();

                }
                else
                {
                    if (u1.N != u2.N)
                    {
                        string error = "Las matrices deben ser conformables";
                        throw new ApplicationException(error);
                    }


                    Unidimensional u3 = u2 + u1;
                    lbResultado.Text = u3.ToString();                    

                }
                #endregion
            }
            catch(ApplicationException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            m3 = m2 * m1;
            lbResultado.Text = m3.ToString();

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            if( rdbRadianes.Checked)
            {
                m3 = m3 % rdbRadianes.Checked;
                lbResultado.Text = m3.ToString();
            }
            else
            {
                m3 = m3 % rdbRadianes.Checked;
                lbResultado.Text = m3.ToString();
            }
        }
    }
}
