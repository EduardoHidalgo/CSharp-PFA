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
    public partial class EgresoElim : UserControl
    {
        FormIngresos Ingresos;

        public EgresoElim(FormIngresos ingresos)
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
            for (int E = 0; E <= DB_Storer.T5_Egreso.Length - 1; E++) // E - 7
            {
                for (int C = 0; C <= DB_Storer.TABLE_TIPO_E_iterer - 1; C++) //Iterador de clasificaciones
                {
                    string Tipo_E = DB_Storer.T3_Tipo_E[C];
                    int ID_Tipo_E = DB_Storer.T3_ID_tipo_E[C];
                    if (DB_Storer.T5_Tipo_Egreso[E] == ID_Tipo_E)
                    {
                        ComboboxSelecc.Items.Add(DB_Storer.T3_Tipo_E[C] + " - " + DB_Storer.T5_Egreso[E]);
                    }
                }
            }
        }
        public void ButtonMethod()
        {
            int ID_TipoE;
            if (ComboboxSelecc.Text != null)
            {
                try
                {
                    int temp2 = ComboboxSelecc.SelectedIndex;
                    ID_TipoE = DB_Storer.T5_ID_Egreso[temp2];
                    DBclass.Delete_Egreso(ID_TipoE);
                    ComboboxSelecc.ResetText();
                    LabelError.Text = "Gasto Eliminado";
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
                LabelError.Text = "Seleccione un gasto a eliminar";
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
