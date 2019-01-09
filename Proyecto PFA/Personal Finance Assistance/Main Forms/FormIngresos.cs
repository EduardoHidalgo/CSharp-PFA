using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Assistance
{
    public partial class FormIngresos : Form
    {
        IngresosButtons IngresosButtons;
        EgresosButtons EgresosButtons;
        FormIngresos Ingresos;

        public FormIngresos()
        {
            Ingresos = this;
            InitializeComponent();
            MethodMain();
            ButtonMetas.Visible = false;
            ButtonMetas.Enabled = false;
        }

        DatosEstadísticos DatosEstadisticos;


        //INSTANCIAS PARA PANEL ESTADÍSTICO
        Stats Stats;
        Metas Metas;

        public DatosEstadísticos SetDatosEstadisticos
        {
            get
            {
                return DatosEstadisticos;
            }

            set
            {
                DatosEstadisticos = value;
            }
        }

        private void MethodMain()
        {
            this.BackColor = ColorClass.ColorFondo2;
            TreeviewLista.BackColor = ColorClass.ColorDecorativo;
            ButtonIngresos.BackColor = ColorClass.ColorBoton;
            ButtonEgresos.BackColor = ColorClass.ColorBoton;
            TreeviewLista.LineColor = ColorClass.ColorBoton;
            TreeviewLista.ForeColor = ColorClass.ColorBoton;
            ButtonStats.BackColor = ColorClass.ColorBoton;
            ButtonMetas.BackColor = ColorClass.ColorBoton;    
            
            DBclass.Create_Tipo_I();
            DBclass.Create_Ingresos();
            DBclass.Create_Tipo_E();
            DBclass.Create_Egresos();
            DBclass.Upload_Tipo_I();
            DBclass.Upload_Ingresos();
            DBclass.Upload_Tipo_E();
            DBclass.Upload_Egresos();

            Actualizar_Treeview();
        }
        public void Actualizar_Treeview() //Actualiza la lista de ingresos y egresos
        {
            TreeviewLista.Nodes.Clear();
            TreeviewLista.Nodes.Add("Ingresos");
            TreeviewLista.Nodes.Add("Gastos");
            for (int C = 0; C <= DB_Storer.TABLE_TIPO_I_iterer - 1; C++) //Iterador de clasificaciones
            {
                string Tipo_I = DB_Storer.T2_Tipo_I[C];
                int ID_Tipo_I = DB_Storer.T2_ID_tipo_I[C];
                TreeviewLista.Nodes[0].Nodes.Add(Tipo_I);
                for (int N = 0; N <= DB_Storer.TABLE_INGRESOS_iterer - 1; N++)
                {
                    if (DB_Storer.T4_Tipo_Ingreso[N] == ID_Tipo_I)
                    {
                        string Ingreso = String.Format("{0:dd/MM/yy}", DB_Storer.T4_Date_Ingreso[N]) + " " + Convert.ToString(DB_Storer.T4_Ingreso[N]);
                        TreeviewLista.Nodes[0].Nodes[C].Nodes.Add(Ingreso);
                    }
                }
            }
            for (int C = 0; C <= DB_Storer.TABLE_TIPO_E_iterer - 1; C++) //Iterador de clasificaciones
            {
                string Tipo_E = DB_Storer.T3_Tipo_E[C];
                int ID_Tipo_E = DB_Storer.T3_ID_tipo_E[C];
                TreeviewLista.Nodes[1].Nodes.Add(Tipo_E);
                for (int N = 0; N <= DB_Storer.TABLE_EGRESOS_iterer - 1; N++)
                {
                    if (DB_Storer.T5_Tipo_Egreso[N] == ID_Tipo_E)
                    {
                        string Egreso = String.Format("{0:dd/MM/yy}", DB_Storer.T5_Date_Egreso[N]) + " " + Convert.ToString(DB_Storer.T5_Egreso[N]);
                        TreeviewLista.Nodes[1].Nodes[C].Nodes.Add(Egreso);
                    }
                }
            }
            foreach (TreeNode tn in TreeviewLista.Nodes) //Despliega el primer nivel de nodos por pura vanidad
            {
                tn.Expand();
            }
        }
        public void Actualizar_Stats()
        {
            if (SetDatosEstadisticos != null)
            DatosEstadisticos.ActualizarComboboxs();
        }

        private void ButtonIngresos_MouseClick(object sender, MouseEventArgs e)
        {
            PanelControls.Controls.Clear();
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Left", 1196 , 5);
            PanelButtons.Controls.Clear();
            IngresosButtons = new IngresosButtons(Ingresos);
            PanelButtons.Controls.Add(IngresosButtons);
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Right", 1196, 5);
        }
        private void ButtonIngresos_MouseEnter(object sender, EventArgs e)
        {
            ButtonIngresos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonIngresos_MouseLeave(object sender, EventArgs e)
        {
            ButtonIngresos.BackColor = ColorClass.ColorBoton;
        }
        private void LabelIngresos_MouseClick(object sender, MouseEventArgs e)
        {
            PanelControls.Controls.Clear();
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Left", 1196, 5);
            PanelButtons.Controls.Clear();
            IngresosButtons = new IngresosButtons(Ingresos);
            PanelButtons.Controls.Add(IngresosButtons);
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Right", 1196, 5);
        }
        private void LabelIngresos_MouseEnter(object sender, EventArgs e)
        {
            ButtonIngresos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelIngresos_MouseLeave(object sender, EventArgs e)
        {
            ButtonIngresos.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonEgresos_MouseClick(object sender, MouseEventArgs e)
        {
            PanelControls.Controls.Clear();
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Left", 1196, 5);
            PanelButtons.Controls.Clear();
            EgresosButtons = new EgresosButtons(Ingresos);
            PanelButtons.Controls.Add(EgresosButtons);
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Right", 1196, 5);
        }
        private void ButtonEgresos_MouseEnter(object sender, EventArgs e)
        {
            ButtonEgresos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonEgresos_MouseLeave(object sender, EventArgs e)
        {
            ButtonEgresos.BackColor = ColorClass.ColorBoton;
        }
        private void LabelEgresos_MouseClick(object sender, MouseEventArgs e)
        {
            PanelControls.Controls.Clear();
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Left", 1196, 5);
            PanelButtons.Controls.Clear();
            EgresosButtons = new EgresosButtons(Ingresos);
            PanelButtons.Controls.Add(EgresosButtons);
            FormMethods.DesplazamientoHorizontalSinCentrar(PanelButtons, "Right", 1196, 5);
        }
        private void LabelEgresos_MouseEnter(object sender, EventArgs e)
        {
            ButtonEgresos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelEgresos_MouseLeave(object sender, EventArgs e)
        {
            ButtonEgresos.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonMetas_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStats.Controls.Clear();
            Metas = new Metas();
            PanelStats.Controls.Add(Metas);
        }
        private void ButtonMetas_MouseEnter(object sender, EventArgs e)
        {
            ButtonMetas.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonMetas_MouseLeave(object sender, EventArgs e)
        {
            ButtonMetas.BackColor = ColorClass.ColorBoton;
        }
        private void LabelMetas_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStats.Controls.Clear();
            Metas = new Metas();
            PanelStats.Controls.Add(Metas);
        }
        private void LabelMetas_MouseEnter(object sender, EventArgs e)
        {
            ButtonMetas.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelMetas_MouseLeave(object sender, EventArgs e)
        {
            ButtonMetas.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonStats_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStats.Controls.Clear();
            Stats = new Stats(Ingresos);
            PanelStats.Controls.Add(Stats);
        }
        private void ButtonStats_MouseEnter(object sender, EventArgs e)
        {
            ButtonStats.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonStats_MouseLeave(object sender, EventArgs e)
        {
            ButtonStats.BackColor = ColorClass.ColorBoton;
        }
        private void LabelStats_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStats.Controls.Clear();
            Stats = new Stats(Ingresos);
            PanelStats.Controls.Add(Stats);
        }
        private void LabelStats_MouseEnter(object sender, EventArgs e)
        {
            ButtonStats.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelStats_MouseLeave(object sender, EventArgs e)
        {
            ButtonStats.BackColor = ColorClass.ColorBoton;
        }
    }
}
