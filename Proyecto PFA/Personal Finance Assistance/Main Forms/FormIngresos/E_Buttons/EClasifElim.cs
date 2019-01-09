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
    public partial class EClasifElim : UserControl
    {
        FormIngresos Ingresos;

        public EClasifElim(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            LabelError.Visible = false;
            //LabelError.ForeColor = ColorClass.ColorFondo1;
            ButtonEliminar.BackColor = ColorClass.ColorBoton;
            ComboboxClasif.BackColor = ColorClass.ColorDecorativo;
            Actualizar_Combobox();
        }

        public void Actualizar_Combobox()
        {
            ComboboxClasif.Items.Clear();
            for (int I = 0; I <= DB_Storer.T3_Tipo_E.Length - 1; I++)
            {
                ComboboxClasif.Items.Add(DB_Storer.T3_Tipo_E[I]);
            }
        }
        public void ButtonMethod()
        {
            int ID_TipoE;
            if (ComboboxClasif.SelectedItem != null)
            {
                try
                {
                    int temp2 = ComboboxClasif.SelectedIndex;
                    ID_TipoE = DB_Storer.T3_ID_tipo_E[temp2];
                    DBclass.Delete_Tipo_E(ID_TipoE);
                    LabelError.Text = "Egreso eliminado";
                    LabelError.Visible = true;
                    ComboboxClasif.ResetText();
                    Ingresos = (FormIngresos)this.ParentForm;
                    Ingresos.Actualizar_Treeview();
                    Actualizar_Combobox();
                    Ingresos.Actualizar_Stats();
                }
                catch
                {
                    LabelError.Text = "Error, Comuníquese con soporte";
                    LabelError.Visible = true;
                }
            }
            else
            {
                LabelError.Text = "Seleccione un egreso de la lista a eliminar";
                LabelError.Visible = true;
            }
        }


        private void ButtonEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void ButtonEliminar_MouseEnter(object sender, EventArgs e)
        {
            ButtonEliminar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonEliminar_MouseLeave(object sender, EventArgs e)
        {
            ButtonEliminar.BackColor = ColorClass.ColorBoton;
        }
        private void LabelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void LabelButton_MouseEnter(object sender, EventArgs e)
        {
            ButtonEliminar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ButtonEliminar.BackColor = ColorClass.ColorBoton;
        }
    }
}
