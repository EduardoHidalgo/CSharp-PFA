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
    public partial class IClasifElim : UserControl
    {
        FormIngresos Ingresos;

        public IClasifElim(FormIngresos ingresos)
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
            for (int I = 0; I <= DB_Storer.T2_Tipo_I.Length - 1; I++)
            {
                ComboboxClasif.Items.Add(DB_Storer.T2_Tipo_I[I]);
            }
        }
        public void ButtonMethod()
        {
            int ID_TipoI;
            if (ComboboxClasif.SelectedItem != null)
            {
                try
                {
                    int temp2 = ComboboxClasif.SelectedIndex;
                    ID_TipoI = DB_Storer.T2_ID_tipo_I[temp2];
                    DBclass.Delete_Tipo_I(ID_TipoI);
                    LabelError.Text = "Ingreso eliminado";
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
                LabelError.Text = "Seleccione un ingreso de la lista a eliminar";
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
