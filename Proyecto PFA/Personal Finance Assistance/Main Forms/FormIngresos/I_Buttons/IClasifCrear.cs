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
    public partial class IClasifCrear : UserControl
    {
        FormIngresos Ingresos;

        public IClasifCrear(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            LabelError.Visible = false;
            //LabelError.ForeColor = ColorClass.ColorFondo1;
            ButtonCrear.BackColor = ColorClass.ColorBoton;
            TextboxClasif.BackColor = ColorClass.ColorDecorativo;
            ComboboxClasif.BackColor = ColorClass.ColorDecorativo;
            Actualizar_Combobox();
        }

        public void Actualizar_Combobox()
        {
            ComboboxClasif.Items.Clear();
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
            int Alg;
            bool P1, P2;
            if (ComboboxClasif.SelectedItem == null)
            {
                P1 = false;
                LabelError.Text = "Seleccione un rango de fechas";
                LabelError.Visible = true;
            }
            else
            {
                P1 = true;
            }
            if (string.IsNullOrEmpty(TextboxClasif.Text))
            {
                P2 = false;
                LabelError.Text = "Inserte un nombre para la clasificación";
                LabelError.Visible = true;
            }
            else
            {
                P2 = true;
            }
            if ((P1 & P2) == true)
            {
                try
                {
                    Tipo = TextboxClasif.Text;
                    Alg = Convert.ToInt32(ComboboxClasif.SelectedIndex);
                    Fecha = DatetimeAlgorithms.GetNextDate(Alg, DateTime.Today); //Aquí se ejecuta el Algoritmo inteligente con "alg" como parámetro.
                    DBclass.Insert_Tipo_I(Tipo, Fecha, Alg); //Crea la nueva clasificación. Actualiza la DB
                    TextboxClasif.Clear();
                    ComboboxClasif.ResetText();
                    LabelError.Text = "Clasificación de Ingresos creada";
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

        #region BOTÓN
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
        #endregion
    }
}
