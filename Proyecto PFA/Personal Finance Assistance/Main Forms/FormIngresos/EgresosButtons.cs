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
    public partial class EgresosButtons : UserControl
    {
        FormIngresos Ingresos;
        public EgresosButtons(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            MethodMain();
        }
        FormIngresos Egresos;
        EClasifCrear Control1;
        EClasifModif Control2;
        EClasifElim Control3;
        EgresoCrear Control4;
        EgresoModif Control5;
        EgresoElim Control6;

        private void MethodMain()
        {
            ButtonCrearC.BackColor = ColorClass.ColorBoton;
            ButtonModifC.BackColor = ColorClass.ColorBoton;
            ButtonElimC.BackColor = ColorClass.ColorBoton;
            ButtonCrearE.BackColor = ColorClass.ColorBoton;
            ButtonModifE.BackColor = ColorClass.ColorBoton;
            ButtonElimE.BackColor = ColorClass.ColorBoton;
        }

        #region CREAR CLASIFICACIÓN
        private void ButtonCrearC_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control1 = new EClasifCrear(Ingresos);
            Egresos.PanelControls.Controls.Add(Control1);
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
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control1 = new EClasifCrear(Ingresos);
            Egresos.PanelControls.Controls.Add(Control1);
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
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control2 = new EClasifModif(Ingresos);
            Egresos.PanelControls.Controls.Add(Control2);
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
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control2 = new EClasifModif(Ingresos);
            Egresos.PanelControls.Controls.Add(Control2);
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
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control3 = new EClasifElim(Ingresos);
            Egresos.PanelControls.Controls.Add(Control3);
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
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control3 = new EClasifElim(Ingresos);
            Egresos.PanelControls.Controls.Add(Control3);
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

        #region CREAR EGRESO
        private void ButtonCrearE_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control4 = new EgresoCrear(Ingresos);
            Egresos.PanelControls.Controls.Add(Control4);
        }
        private void ButtonCrearE_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrearE.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonCrearE_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrearE.BackColor = ColorClass.ColorBoton;
        }
        private void LabelCrearE_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control4 = new EgresoCrear(Ingresos);
            Egresos.PanelControls.Controls.Add(Control4);
        }
        private void LabelCrearE_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrearE.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelCrearE_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrearE.BackColor = ColorClass.ColorBoton;
        } 
        #endregion

        #region MODIFICAR EGRESO
        private void ButtonModifE_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control5 = new EgresoModif(Ingresos);
            Egresos.PanelControls.Controls.Add(Control5);
        }
        private void ButtonModifE_MouseEnter(object sender, EventArgs e)
        {
            ButtonModifE.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonModifE_MouseLeave(object sender, EventArgs e)
        {
            ButtonModifE.BackColor = ColorClass.ColorBoton;
        }
        private void LabelModifE_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control5 = new EgresoModif(Ingresos);
            Egresos.PanelControls.Controls.Add(Control5);
        }
        private void LabelModifE_MouseEnter(object sender, EventArgs e)
        {
            ButtonModifE.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelModifE_MouseLeave(object sender, EventArgs e)
        {
            ButtonModifE.BackColor = ColorClass.ColorBoton;
        } 
        #endregion

        #region ELIMINAR EGRESO
        private void ButtonElimE_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control6 = new EgresoElim(Ingresos);
            Egresos.PanelControls.Controls.Add(Control6);
        }
        private void ButtonElimE_MouseEnter(object sender, EventArgs e)
        {
            ButtonElimE.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonElimE_MouseLeave(object sender, EventArgs e)
        {
            ButtonElimE.BackColor = ColorClass.ColorBoton;
        }
        private void LabelElimE_MouseClick(object sender, MouseEventArgs e)
        {
            Egresos = (FormIngresos)this.ParentForm;
            Egresos.PanelControls.Controls.Clear();
            Control6 = new EgresoElim(Ingresos);
            Egresos.PanelControls.Controls.Add(Control6);
        }
        private void LabelElimE_MouseEnter(object sender, EventArgs e)
        {
            ButtonElimE.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelElimE_MouseLeave(object sender, EventArgs e)
        {
            ButtonElimE.BackColor = ColorClass.ColorBoton;
        }
        #endregion
    }
}
