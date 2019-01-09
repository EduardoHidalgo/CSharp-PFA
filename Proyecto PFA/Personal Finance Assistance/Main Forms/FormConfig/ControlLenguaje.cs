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
    public partial class ControlLenguaje : UserControl
    {
        FormPrincipal Principal;
        FormConfig Config;
        public ControlLenguaje(FormPrincipal principal, FormConfig config)
        {
            InitializeComponent();
            Principal = principal;
            Config = config;
            ColorMethod();
            LenguajeMethod();
            ComboboxLenguaje.Items.Add("Español");
            ComboboxLenguaje.Items.Add("English");
        }
        public void ColorMethod()
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBoton;
            Button1.BackColor = ColorClass.ColorBoton;
            Button2.BackColor = ColorClass.ColorBoton;
            Button3.BackColor = ColorClass.ColorBoton;
            Button4.BackColor = ColorClass.ColorBoton;
            ComboboxLenguaje.BackColor = ColorClass.ColorFondo1;
            PanelButtons.BackColor = ColorClass.ColorFondo2;
            PanelFondo1.BackColor = ColorClass.ColorFondo1;
            PanelFondo2.BackColor = ColorClass.ColorFondo2;
            this.BackColor = ColorClass.ColorDecorativo;
            Textbox1.BackColor = ColorClass.ColorDecorativo;
            Textbox2.BackColor = ColorClass.ColorDecorativo;
        }
        public void LenguajeMethod()
        {
            if (DB_Storer.T6_Lenguage[0] == 0)
            {
                LabelButton1.Text = "BOTÓN DE EJEMPLO";
                LabelButton2.Text = "BOTÓN DE EJEMPLO";
                LabelButton3.Text = "BOTÓN DE EJEMPLO";
                LabelButton4.Text = "BOTÓN DE EJEMPLO";
                LabelEjemplo.Text = "Texto de ejemplo";
                LabelLenguaje.Text = "CAMBIAR LENGUAJE";
                Textbox1.Text = "TEXTO DE EJEMPLO";
                Textbox2.Text = "TEXTO DE EJEMPLO";
            }
            else if (DB_Storer.T6_Lenguage[0] == 1)
            {
                LabelButton1.Text = "EXAMPLE BUTTON";
                LabelButton2.Text = "EXAMPLE BUTTON";
                LabelButton3.Text = "EXAMPLE BUTTON";
                LabelButton4.Text = "EXAMPLE BUTTON";
                LabelEjemplo.Text = "Example Text";
                LabelLenguaje.Text = "CHANGE LENGUAJE";
                Textbox1.Text = "EXAMPLE TEXT";
                Textbox2.Text = "EXAMPLE TEXT";
            }
            FormMethods.CentrarTextos(LabelButton1, Button1);
            FormMethods.CentrarTextos(LabelButton2, Button2);
            FormMethods.CentrarTextos(LabelButton3, Button3);
            FormMethods.CentrarTextos(LabelButton4, Button4);
            FormMethods.CentrarTextos(LabelLenguaje, ButtonLenguaje);
        }

        public void UpdatePanel()
        {
            if (ComboboxLenguaje.SelectedIndex == 0)
            {
                LabelButton1.Text = "BOTÓN DE EJEMPLO";
                LabelButton2.Text = "BOTÓN DE EJEMPLO";
                LabelButton3.Text = "BOTÓN DE EJEMPLO";
                LabelButton4.Text = "BOTÓN DE EJEMPLO";
                LabelEjemplo.Text = "Texto de ejemplo";
                LabelLenguaje.Text = "CAMBIAR LENGUAJE";
                Textbox1.Text = "TEXTO DE EJEMPLO";
                Textbox2.Text = "TEXTO DE EJEMPLO";
            }
            else if (ComboboxLenguaje.SelectedIndex == 1)
            {
                LabelButton1.Text = "EXAMPLE BUTTON";
                LabelButton2.Text = "EXAMPLE BUTTON";
                LabelButton3.Text = "EXAMPLE BUTTON";
                LabelButton4.Text = "EXAMPLE BUTTON";
                LabelEjemplo.Text = "Example Text";
                LabelLenguaje.Text = "CHANGE LENGUAJE";
                Textbox1.Text = "EXAMPLE TEXT";
                Textbox2.Text = "EXAMPLE TEXT";
            }
            FormMethods.CentrarTextos(LabelButton1, Button1);
            FormMethods.CentrarTextos(LabelButton2, Button2);
            FormMethods.CentrarTextos(LabelButton3, Button3);
            FormMethods.CentrarTextos(LabelButton4, Button4);
            FormMethods.CentrarTextos(LabelLenguaje, ButtonLenguaje);
        }
        public void UpdateAll()
        {
            int Theme = DB_Storer.T6_Theme[0];
            int Leng = ComboboxLenguaje.SelectedIndex;
            DBclass.Modifier_Config(Theme, Leng);
            Principal.LenguajeMethod();
            Config.LenguajeMethod();
            LenguajeMethod();
        }

        private void ButtonLenguaje_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateAll();
        }
        private void ButtonLenguaje_MouseEnter(object sender, EventArgs e)
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonLenguaje_MouseLeave(object sender, EventArgs e)
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBoton;
        }

        private void LabelLenguaje_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateAll();
        }
        private void LabelLenguaje_MouseEnter(object sender, EventArgs e)
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelLenguaje_MouseLeave(object sender, EventArgs e)
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBoton;
        }

        private void ComboboxLenguaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePanel();
        }
    }
}
