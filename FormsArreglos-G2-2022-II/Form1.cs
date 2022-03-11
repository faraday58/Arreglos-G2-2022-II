using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsArreglos_G2_2022_II
{
    public partial class Form1 : Form
    {
        Unidimensional u1;
        bool lbOperandos= true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            u1 = Unidimensional.Leer(txtbDisplay.Text);
            if (lbOperandos )
            {
                lbMatriz1.Text = u1.ToString();
                lbOperandos = false;
            }else
            {
                lbMatriz2.Text = u1.ToString();
                lbOperandos = true;
            }           
            
        }
    }
}
