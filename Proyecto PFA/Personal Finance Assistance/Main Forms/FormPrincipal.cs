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
    public partial class FormPrincipal : Form
    {
        private FormPrincipal Principal;

        public FormPrincipal()
        {
            InitializeComponent();
            DBclass.Create_Config();
            DBclass.Upload_Config();
            ColorClass.SelectColor(DB_Storer.T6_Theme[0]);
            ColorMethod();
            LenguajeMethod();
            FormInicio Inicio = new FormInicio();
            Inicio.MdiParent = this;
            Inicio.Dock = DockStyle.Fill;
            Inicio.Show();
            Principal = this;
        }

        Form ActiveChild;

        public void ColorMethod()
        {
            BackColor = ColorClass.ColorFondo2;
            ButtonInicio.BackColor = ColorClass.ColorBoton;
            ButtonIngresos.BackColor = ColorClass.ColorBoton;
            ButtonConsumo.BackColor = ColorClass.ColorBoton;
            ButtonAhorro.BackColor = ColorClass.ColorBoton;
            ButtonCréditos.BackColor = ColorClass.ColorBoton;
            ButtonSeguros.BackColor = ColorClass.ColorBoton;
            ButtonConfig.BackColor = ColorClass.ColorBoton;
            ButtonSalir.BackColor = ColorClass.ColorBoton;
            PanelMenu.BackColor = ColorClass.ColorBotonCursado;
        }
        public void LenguajeMethod()
        {
            if (DB_Storer.T6_Lenguage[0] == 0) //ESPAÑOL
            {
                LabelInicio.Text = "INICIO";
                LabelIngresos.Text = "INGRESOS Y EGRESOS";
                LabelConsumo.Text = "CONSUMO\nINTELIGENTE";
                LabelAhorro.Text = "AHORRO";
                LabelSeguros.Text = "CRÉDITOS";
                LabelCréditos.Text = "SEGUROS";
                LabelConfig.Text = "CONFIGURACIÓN";
                LabelSalir.Text = "SALIR";
            }
            else if(DB_Storer.T6_Lenguage[0] == 1) //INGLES
            {
                LabelInicio.Text = "LOBBY";
                LabelIngresos.Text = "INCOME AND\nEXPENDITURES";
                LabelConsumo.Text = "INTELLIGENT\nCONSUMPTION";
                LabelAhorro.Text = "SAVINGS";
                LabelSeguros.Text = "INSURANCE";
                LabelCréditos.Text = "CREDIT";
                LabelConfig.Text = "CONFIGURATION";
                LabelSalir.Text = "EXIT";
            }
            FormMethods.CentrarTextos(LabelInicio, ButtonInicio);
            FormMethods.CentrarTextos(LabelIngresos, ButtonIngresos);
            FormMethods.CentrarTextos(LabelConsumo, ButtonConsumo);
            FormMethods.CentrarTextos(LabelAhorro, ButtonAhorro);
            FormMethods.CentrarTextos(LabelSeguros, ButtonSeguros);
            FormMethods.CentrarTextos(LabelCréditos, ButtonCréditos);
            FormMethods.CentrarTextos(LabelConfig, ButtonConfig);
            FormMethods.CentrarTextos(LabelSalir, ButtonSalir);
        }

        #region INICIO events
        private void ButtonInicio_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormInicio Inicio = new FormInicio();
            Inicio.MdiParent = this;
            Inicio.Dock = DockStyle.Fill;
            Inicio.Show();
        }
        private void ButtonInicio_MouseEnter(object sender, EventArgs e)
        {
            ButtonInicio.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonInicio_MouseLeave(object sender, EventArgs e)
        {
            ButtonInicio.BackColor = ColorClass.ColorBoton;
        }
        private void LabelInicio_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormInicio Inicio = new FormInicio();
            Inicio.MdiParent = this;
            Inicio.Dock = DockStyle.Fill;
            Inicio.Show();
        }
        private void LabelInicio_MouseEnter(object sender, EventArgs e)
        {
            ButtonInicio.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelInicio_MouseLeave(object sender, EventArgs e)
        {
            ButtonInicio.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region INGRESOS events
        private void ButtonIngresos_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormIngresos Ingresos = new FormIngresos();
            Ingresos.MdiParent = this;
            Ingresos.Dock = DockStyle.Fill;
            Ingresos.Show();
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
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormIngresos Ingresos = new FormIngresos();
            Ingresos = new FormIngresos();
            Ingresos.MdiParent = this;
            Ingresos.Dock = DockStyle.Fill;
            Ingresos.Show();
        }
        private void LabelIngresos_MouseEnter(object sender, EventArgs e)
        {
            ButtonIngresos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelIngresos_MouseLeave(object sender, EventArgs e)
        {
            ButtonIngresos.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region CONSUMO events
        private void ButtonConsumo_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormConsumo Consumo = new FormConsumo();
            Consumo.MdiParent = this;
            Consumo.Dock = DockStyle.Fill;
            Consumo.Show();
        }
        private void ButtonConsumo_MouseEnter(object sender, EventArgs e)
        {
            ButtonConsumo.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonConsumo_MouseLeave(object sender, EventArgs e)
        {
            ButtonConsumo.BackColor = ColorClass.ColorBoton;
        }
        private void LabelConsumo_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormConsumo Consumo = new FormConsumo();
            Consumo.MdiParent = this;
            Consumo.Dock = DockStyle.Fill;
            Consumo.Show();
        }
        private void LabelConsumo_MouseEnter(object sender, EventArgs e)
        {
            ButtonConsumo.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelConsumo_MouseLeave(object sender, EventArgs e)
        {
            ButtonConsumo.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region AHORRO events
        private void ButtonAhorro_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormAhorro Ahorro = new FormAhorro();
            Ahorro.MdiParent = this;
            Ahorro.Dock = DockStyle.Fill;
            Ahorro.Show();
        }
        private void ButtonAhorro_MouseEnter(object sender, EventArgs e)
        {
            ButtonAhorro.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonAhorro_MouseLeave(object sender, EventArgs e)
        {
            ButtonAhorro.BackColor = ColorClass.ColorBoton;
        }
        private void LabelAhorro_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormAhorro Ahorro = new FormAhorro();
            Ahorro.MdiParent = this;
            Ahorro.Dock = DockStyle.Fill;
            Ahorro.Show();
        }
        private void LabelAhorro_MouseEnter(object sender, EventArgs e)
        {
            ButtonAhorro.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelAhorro_MouseLeave(object sender, EventArgs e)
        {
            ButtonAhorro.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region CRÉDITOS events
        private void ButtonCréditos_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormCredito Credito = new FormCredito();
            Credito.MdiParent = this;
            Credito.Dock = DockStyle.Fill;
            Credito.Show();
        }
        private void ButtonCréditos_MouseEnter(object sender, EventArgs e)
        {
            ButtonCréditos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonCréditos_MouseLeave(object sender, EventArgs e)
        {
            ButtonCréditos.BackColor = ColorClass.ColorBoton;
        }
        private void LabelCréditos_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormCredito Credito = new FormCredito();
            Credito.MdiParent = this;
            Credito.Dock = DockStyle.Fill;
            Credito.Show();
        }
        private void LabelCréditos_MouseEnter(object sender, EventArgs e)
        {
            ButtonCréditos.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelCréditos_MouseLeave(object sender, EventArgs e)
        {
            ButtonCréditos.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region SEGUROS events
        private void ButtonSeguros_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormSeguros Seguros = new FormSeguros();
            Seguros.MdiParent = this;
            Seguros.Dock = DockStyle.Fill;
            Seguros.Show();
        }
        private void ButtonSeguros_MouseEnter(object sender, EventArgs e)
        {
            ButtonSeguros.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonSeguros_MouseLeave(object sender, EventArgs e)
        {
            ButtonSeguros.BackColor = ColorClass.ColorBoton;
        }
        private void LabelSeguros_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormSeguros Seguros = new FormSeguros();
            Seguros.MdiParent = this;
            Seguros.Dock = DockStyle.Fill;
            Seguros.Show();
        }
        private void LabelSeguros_MouseEnter(object sender, EventArgs e)
        {
            ButtonSeguros.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelSeguros_MouseLeave(object sender, EventArgs e)
        {
            ButtonSeguros.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region CONFIG events
        private void ButtonConfig_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormConfig Config = new FormConfig(Principal);
            Config.MdiParent = this;
            Config.Dock = DockStyle.Fill;
            Config.Show();
        }
        private void ButtonConfig_MouseEnter(object sender, EventArgs e)
        {
            ButtonConfig.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonConfig_MouseLeave(object sender, EventArgs e)
        {
            ButtonConfig.BackColor = ColorClass.ColorBoton;
        }
        private void LabelConfig_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveChild = this.ActiveMdiChild;
            ActiveChild.Close();
            FormConfig Config = new FormConfig(Principal);
            Config.MdiParent = this;
            Config.Dock = DockStyle.Fill;
            Config.Show();
        }
        private void LabelConfig_MouseEnter(object sender, EventArgs e)
        {
            ButtonConfig.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelConfig_MouseLeave(object sender, EventArgs e)
        {
            ButtonConfig.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region SALIR events
        private void ButtonSalir_MouseClick(object sender, MouseEventArgs e)
        {
            (new FormOut()).Show();
        }
        private void ButtonSalir_MouseEnter(object sender, EventArgs e)
        {
            ButtonSalir.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonSalir_MouseLeave(object sender, EventArgs e)
        {
            ButtonSalir.BackColor = ColorClass.ColorBoton;
        }
        private void LabelSalir_MouseClick(object sender, MouseEventArgs e)
        {
            (new FormOut()).Show();
        }
        private void LabelSalir_MouseEnter(object sender, EventArgs e)
        {
            ButtonSalir.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelSalir_MouseLeave(object sender, EventArgs e)
        {
            ButtonSalir.BackColor = ColorClass.ColorBoton;
        } 
        #endregion
    }
}
