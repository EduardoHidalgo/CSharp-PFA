using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Assistance
{
    public partial class IngresosButtons : UserControl
    {
        public IngresosButtons(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            MethodMain();
        }

        FormIngresos Ingresos;
        IClasifCrear Control1;
        IClasifModif Control2;
        IClasifElim Control3;
        IngresoCrear Control4;
        IngresoModif Control5;
        IngresoElim Control6;

        private void MethodMain()
        {
            ButtonCrearC.BackColor = ColorClass.ColorBoton;
            ButtonModifC.BackColor = ColorClass.ColorBoton;
            ButtonElimC.BackColor = ColorClass.ColorBoton;
            ButtonCrearI.BackColor = ColorClass.ColorBoton;
            ButtonModifI.BackColor = ColorClass.ColorBoton;
            ButtonElimI.BackColor = ColorClass.ColorBoton;
        }

        #region CREAR CLASIFICACIÓN
        private void ButtonCrearC_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control1 = new IClasifCrear(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control1);
        }
        private void ButtonCrearC_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrearC.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonCrearC_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrearC.BackColor = ColorClass.ColorBoton;
        }
        private void LabelCrearC_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control1 = new IClasifCrear(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control1);
        }
        private void LabelCrearC_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrearC.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelCrearC_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrearC.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region MODIFICAR CLASIFICACIÓN
        private void ButtonModifC_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control2 = new IClasifModif(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control2);
        }
        private void ButtonModifC_MouseEnter(object sender, EventArgs e)
        {
            ButtonModifC.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonModifC_MouseLeave(object sender, EventArgs e)
        {
            ButtonModifC.BackColor = ColorClass.ColorBoton;
        }
        private void LabelModifC_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control2 = new IClasifModif(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control2);
        }
        private void LabelModifC_MouseEnter(object sender, EventArgs e)
        {
            ButtonModifC.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelModifC_MouseLeave(object sender, EventArgs e)
        {
            ButtonModifC.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region ELIMINAR CLASIFICACIÓN
        private void ButtonElimC_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control3 = new IClasifElim(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control3);
        }
        private void ButtonElimC_MouseEnter(object sender, EventArgs e)
        {
            ButtonElimC.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonElimC_MouseLeave(object sender, EventArgs e)
        {
            ButtonElimC.BackColor = ColorClass.ColorBoton;
        }
        private void LabelElimC_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control3 = new IClasifElim(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control3);
        }
        private void LabelElimC_MouseEnter(object sender, EventArgs e)
        {
            ButtonElimC.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelElimC_MouseLeave(object sender, EventArgs e)
        {
            ButtonElimC.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region CREAR INGRESO
        private void ButtonCrearI_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control4 = new IngresoCrear(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control4);
        }
        private void ButtonCrearI_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrearI.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonCrearI_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrearI.BackColor = ColorClass.ColorBoton;
        }
        private void LabelCrearI_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control4 = new IngresoCrear(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control4);
        }
        private void LabelCrearI_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrearI.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelCrearI_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrearI.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region MODIFICAR INGRESO
        private void ButtonModifI_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control5 = new IngresoModif(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control5);
        }
        private void ButtonModifI_MouseEnter(object sender, EventArgs e)
        {
            ButtonModifI.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonModifI_MouseLeave(object sender, EventArgs e)
        {
            ButtonModifI.BackColor = ColorClass.ColorBoton;
        }
        private void LabelModifI_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control5 = new IngresoModif(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control5);
        }
        private void LabelModifI_MouseEnter(object sender, EventArgs e)
        {
            ButtonModifI.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelModifI_MouseLeave(object sender, EventArgs e)
        {
            ButtonModifI.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region ELIMINAR INGRESO
        private void ButtonElimI_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control6 = new IngresoElim(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control6);
        }
        private void ButtonElimI_MouseEnter(object sender, EventArgs e)
        {
            ButtonElimI.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonElimI_MouseLeave(object sender, EventArgs e)
        {
            ButtonElimI.BackColor = ColorClass.ColorBoton;
        }
        private void LabelElimI_MouseClick(object sender, MouseEventArgs e)
        {
            Ingresos = (FormIngresos)this.ParentForm;
            Ingresos.PanelControls.Controls.Clear();
            Control6 = new IngresoElim(Ingresos);
            Ingresos.PanelControls.Controls.Add(Control6);
        }
        private void LabelElimI_MouseEnter(object sender, EventArgs e)
        {
            ButtonElimI.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelElimI_MouseLeave(object sender, EventArgs e)
        {
            ButtonElimI.BackColor = ColorClass.ColorBoton;
        }
        #endregion

    }
}
