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
    public partial class EgresoModif : UserControl
    {
        FormIngresos Ingresos;

        public EgresoModif(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            LabelError.Visible = false;
            //LabelError.ForeColor = ColorClass.ColorFondo1;
            ButtonCrear.BackColor = ColorClass.ColorBoton;
            TextboxCrear.BackColor = ColorClass.ColorDecorativo;
            ComboboxClasif.BackColor = ColorClass.ColorDecorativo;
            ComboboxSelecc.BackColor = ColorClass.ColorDecorativo;
            Actualizar_Combobox();
        }

        public void Actualizar_Combobox()
        {
            ComboboxClasif.Items.Clear();
            ComboboxSelecc.Items.Clear();
            for (int E = 0; E <= DB_Storer.T3_Tipo_E.Length - 1; E++) // E - 5
            {
                ComboboxClasif.Items.Add(DB_Storer.T3_Tipo_E[E]);
            }
            for (int E = 0; E <= DB_Storer.T5_Egreso.Length - 1; E++) // E - 6
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
            DateTime Fecha;
            double Monto;
            int ID;
            int ID_TipoE;
            bool P1, P2, P3, P4;
            if (ComboboxSelecc.SelectedItem == null)
            {
                P1 = false;
                LabelError.Text = "Seleccione un gasto a modificar";
                LabelError.Visible = true;
            }
            else
            {
                P1 = true;
            }
            if (ComboboxClasif.SelectedItem == null)
            {
                P2 = false;
                LabelError.Text = "Seleccione una clasificación nueva del gasto";
                LabelError.Visible = true;
            }
            else
            {
                P2 = true;
            }
            if (string.IsNullOrEmpty(DateTimeCrear.Text))
            {
                P3 = false;
                LabelError.Text = "Inserte una fecha nueva del gasto";
                LabelError.Visible = true;
            }
            else
            {
                P3 = true;
            }
            if (string.IsNullOrEmpty(TextboxCrear.Text))
            {
                P4 = false;
                LabelError.Text = "Inserte un monto nuevo del gasto";
                LabelError.Visible = true;
            }
            else
            {
                P4 = true;
            }
            if ((P1 & P2 & P3 & P4) == true)
            {
                try
                {
                    ID = DB_Storer.T5_ID_Egreso[ComboboxSelecc.SelectedIndex];
                    string temp = ComboboxClasif.Text;
                    int temp2 = Array.IndexOf(DB_Storer.T3_Tipo_E, temp);
                    ID_TipoE = DB_Storer.T3_ID_tipo_E[temp2];
                    Monto = Convert.ToDouble(TextboxCrear.Text);
                    Fecha = DateTime.Today;
                    DBclass.Modifier_Egreso(ID, ID_TipoE, Monto, Fecha);
                    TextboxCrear.Clear();
                    ComboboxClasif.ResetText();
                    ComboboxSelecc.ResetText();
                    DateTimeCrear.ResetText();
                    LabelError.Text = "Gasto Modificado";
                    LabelError.Visible = true;
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
                LabelError.Text = "Rellene todos los campos correctamente";
                LabelError.Visible = true;
            }
        }

        private void ButtonCrear_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void ButtonCrear_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrear.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonCrear_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrear.BackColor = ColorClass.ColorBoton;
        }
        private void LabelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void LabelButton_MouseEnter(object sender, EventArgs e)
        {
            ButtonCrear.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ButtonCrear.BackColor = ColorClass.ColorBoton;
        }
    }
}
