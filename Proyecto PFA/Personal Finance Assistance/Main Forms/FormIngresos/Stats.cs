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
    public partial class Stats : UserControl
    {
        FormIngresos Ingresos;
        public Stats(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            InitializeComponent();
            ComboboxStats.BackColor = ColorClass.ColorDecorativo;
            ComboboxStats.Items.Add("Datos estadísticos");
            ComboboxStats.Text = "Selecciona una sección estadística";
        }

        GráficaIngresos GraficaIngresos;
        GráficaEgresos GraficaEgresos;
        DatosEstadísticos DatosEstadisticos;

        private void ComboboxStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelStats.Controls.Clear();

            /*
            if (ComboboxStats.SelectedIndex == 0)
            {
                GraficaIngresos = new GráficaIngresos();
                PanelStats.Controls.Add(GraficaIngresos);
            }
            if (ComboboxStats.SelectedIndex == 1)
            {
                GraficaEgresos = new GráficaEgresos();
                PanelStats.Controls.Add(GraficaEgresos);
            }
            */
            if (ComboboxStats.SelectedIndex == 0)
            {
                DatosEstadisticos = new DatosEstadísticos(Ingresos);
                PanelStats.Controls.Add(DatosEstadisticos);
            }
        }
    }
}
