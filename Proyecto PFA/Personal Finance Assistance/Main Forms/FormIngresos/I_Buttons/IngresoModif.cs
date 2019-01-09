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
    public partial class IngresoModif : UserControl
    {
        FormIngresos Ingresos;

        public IngresoModif(FormIngresos ingresos)
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
            for (int I = 0; I <= DB_Storer.T2_Tipo_I.Length - 1; I++) // I - 5
            {
                ComboboxClasif.Items.Add(DB_Storer.T2_Tipo_I[I]);
            }
            for (int I = 0; I <= DB_Storer.T4_Ingreso.Length - 1; I++) // I - 6
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
            DateTime Fecha;
            double Monto;
            int ID;
            int ID_TipoI;
            bool P1, P2, P3, P4;
            if (ComboboxSelecc.SelectedItem == null)
            {
                P1 = false;
                LabelError.Text = "Seleccione un ingreso a modificar";
                LabelError.Visible = true;
            }
            else
            {
                P1 = true;
            }
            if (ComboboxClasif.SelectedItem == null)
            {
                P2 = false;
                LabelError.Text = "Seleccione una clasificación nueva del ingreso";
                LabelError.Visible = true;
            }
            else
            {
                P2 = true;
            }
            if (string.IsNullOrEmpty(DateTimeCrear.Text))
            {
                P3 = false;
                LabelError.Text = "Inserte una fecha nueva del ingreso";
                LabelError.Visible = true;
            }
            else
            {
                P3 = true;
            }
            if (string.IsNullOrEmpty(TextboxCrear.Text))
            {
                P4 = false;
                LabelError.Text = "Inserte un monto nuevo del ingreso";
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
                    ID = DB_Storer.T4_ID_Ingreso[ComboboxSelecc.SelectedIndex];
                    string temp = ComboboxClasif.Text;
                    int temp2 = Array.IndexOf(DB_Storer.T2_Tipo_I, temp);
                    ID_TipoI = DB_Storer.T2_ID_tipo_I[temp2];
                    Monto = Convert.ToDouble(TextboxCrear.Text);
                    Fecha = Convert.ToDateTime(DateTimeCrear.Text);
                    DBclass.Modifier_Ingreso(ID, ID_TipoI, Monto, Fecha);
                    TextboxCrear.Clear();
                    ComboboxClasif.ResetText();
                    ComboboxSelecc.ResetText();
                    DateTimeCrear.ResetText();
                    LabelError.Text = "Ingreso Modificado";
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
