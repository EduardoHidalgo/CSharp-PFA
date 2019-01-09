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
    public partial class IClasifModif : UserControl
    {
        FormIngresos Ingresos;

        public IClasifModif(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            LabelError.Visible = false;
            //LabelError.ForeColor = ColorClass.ColorFondo1;
            ButtonModificar.BackColor = ColorClass.ColorBoton;
            TextboxClasif.BackColor = ColorClass.ColorDecorativo;
            ComboboxSelecc.BackColor = ColorClass.ColorDecorativo;
            ComboboxClasif.BackColor = ColorClass.ColorDecorativo;
            Actualizar_Combobox();
        }

        public void Actualizar_Combobox()
        {
            ComboboxSelecc.Items.Clear();
            ComboboxClasif.Items.Clear();
            for (int I = 0; I <= DB_Storer.T2_Tipo_I.Length - 1; I++)
            {
                ComboboxSelecc.Items.Add(DB_Storer.T2_Tipo_I[I]);
            }
            DB_Storer.Expected_Date_Instances();
            for (int I = 0; I <= 10; I++)
            {
                ComboboxClasif.Items.Add(DB_Storer.Expected_Date[I]);
            }
        }
        public void ButtonMethod()
        {
            string Tipo;
            DateTime Fecha;
            int ID_TipoI;
            int Alg;
            bool P1, P2, P3;
            if (string.IsNullOrEmpty(TextboxClasif.Text))
            {
                P1 = false;
                LabelError.Text = "Inserte un nuevo nombre para la clasificación";
                LabelError.Visible = true;
            }
            else
            {
                P1 = true;
            }
            if (ComboboxSelecc.SelectedItem == null)
            {
                P2 = false;
                LabelError.Text = "Seleccione una clasificación a modificar";
                LabelError.Visible = true;
            }
            else
            {
                P2 = true;
            }
            if (ComboboxClasif.SelectedItem == null)
            {
                P3 = false;
                LabelError.Text = "Inserte una fecha nueva";
                LabelError.Visible = true;
            }
            else
            {
                P3 = true;
            }
            if ((P1 & P2 & P3) == true)
            {
                try
                {
                    Tipo = TextboxClasif.Text;
                    string temp = ComboboxSelecc.Text;
                    int temp2 = Array.IndexOf(DB_Storer.T2_Tipo_I, temp);
                    ID_TipoI = DB_Storer.T2_ID_tipo_I[temp2];
                    Alg = Convert.ToInt32(ComboboxClasif.SelectedIndex);
                    Fecha = DatetimeAlgorithms.GetNextDate(Alg, DateTime.Today);
                    DBclass.Modifier_Tipo_I(ID_TipoI, Tipo, Fecha, Alg);
                    TextboxClasif.Clear();
                    ComboboxClasif.ResetText();
                    ComboboxSelecc.ResetText();
                    LabelError.Text = "Clasificación modificada";
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

        private void ButtonModificar_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void ButtonModificar_MouseEnter(object sender, EventArgs e)
        {
            ButtonModificar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonModificar_MouseLeave(object sender, EventArgs e)
        {
            ButtonModificar.BackColor = ColorClass.ColorBoton;
        }
        private void LabelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonMethod();
        }
        private void LabelButton_MouseEnter(object sender, EventArgs e)
        {
            ButtonModificar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ButtonModificar.BackColor = ColorClass.ColorBoton;
        }
    }
}
