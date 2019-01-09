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
    public partial class IngresoElim : UserControl
    {
        FormIngresos Ingresos;

        public IngresoElim(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            LabelError.Visible = false;
            //LabelError.ForeColor = ColorClass.ColorFondo1;
            ButtonEliminar.BackColor = ColorClass.ColorBoton;
            ComboboxSelecc.BackColor = ColorClass.ColorDecorativo;
            Actualizar_Combobox();
        }

        public void Actualizar_Combobox()
        {
            ComboboxSelecc.Items.Clear();
            for (int I = 0; I <= DB_Storer.T4_Ingreso.Length - 1; I++) // I - 7
            {
                for (int C = 0; C <= DB_Storer.TABLE_TIPO_I_iterer - 1; C++) //Iterador de clasificaciones
                {
                    string Tipo_I = DB_Storer.T2_Tipo_I[C];
                    int ID_Tipo_I = DB_Storer.T2_ID_tipo_I[C];
                    if (DB_Storer.T4_Tipo_Ingreso[I] == ID_Tipo_I)
                    {
                        ComboboxSelecc.Items.Add(DB_Storer.T2_Tipo_I[C] + " - " + DB_Storer.T4_Ingreso[I]);
                    }
                }
            }
        }
        public void ButtonMethod()
        {
            int ID_TipoI;
            if (ComboboxSelecc.Text != null)
            {
                try
                {
                    int temp2 = ComboboxSelecc.SelectedIndex;
                    ID_TipoI = DB_Storer.T4_ID_Ingreso[temp2];
                    DBclass.Delete_Ingreso(ID_TipoI);
                    ComboboxSelecc.ResetText();
                    LabelError.Text = "Ingreso Eliminado";
                    LabelError.Visible = true;
                    Actualizar_Combobox();
                    Ingresos = (FormIngresos)this.ParentForm;
                    Ingresos.Actualizar_Treeview();
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
                LabelError.Text = "Seleccione un ingreso a eliminar";
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
        private void LabelEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void LabelEliminar_MouseEnter(object sender, EventArgs e)
        {
            ButtonEliminar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelEliminar_MouseLeave(object sender, EventArgs e)
        {
            ButtonEliminar.BackColor = ColorClass.ColorBoton;
        }
    }
}
