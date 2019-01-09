using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Assistance
{
    public partial class FormOut : Form
    {
        public FormOut()
        {
            InitializeComponent();
            BackColor = ColorClass.ColorFondo1;
            PanelSalir.BackColor = ColorClass.ColorFondo2;
            ButtonOut_Volver.BackColor = ColorClass.ColorBoton;
            ButtonOut_Salir.BackColor = ColorClass.ColorBoton;
        }

        #region Button Volver Events
        private void ButtonF_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
        private void ButtonF_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonOut_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonF_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonOut_Volver.BackColor = ColorClass.ColorBoton;
        }
        private void LabelVolver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
        private void LabelVolver_MouseEnter(object sender, EventArgs e)
        {
            ButtonOut_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelVolver_MouseLeave(object sender, EventArgs e)
        {
            ButtonOut_Volver.BackColor = ColorClass.ColorBoton;
        }
        #endregion
        #region Button Salir Events
        private void ButtonF_Salir_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonF_Salir_MouseEnter(object sender, EventArgs e)
        {
            ButtonOut_Salir.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonF_Salir_MouseLeave(object sender, EventArgs e)
        {
            ButtonOut_Salir.BackColor = ColorClass.ColorBoton;
        }
        private void LabelSalir_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void LabelSalir_MouseEnter(object sender, EventArgs e)
        {
            ButtonOut_Salir.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelSalir_MouseLeave(object sender, EventArgs e)
        {
            ButtonOut_Salir.BackColor = ColorClass.ColorBoton;
        } 
        #endregion
    }
}
