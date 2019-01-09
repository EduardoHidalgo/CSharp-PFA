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
    public partial class FormConfig : Form
    {
        ControlLenguaje ControlLenguaje;
        ControlTheme ControlTheme;
        ControlUser ControlUser;
        FormPrincipal Principal;
        FormConfig Config;
    
        
        public FormConfig(FormPrincipal principal)
        {
            InitializeComponent();
            ColorMethod();
            LenguajeMethod();
            DBclass.Create_Config();
            DBclass.Upload_Config();
            Principal = principal;
            Config = this;
        }
        public void ColorMethod()
        {
            this.BackColor = ColorClass.ColorFondo2;
            PanelConfigs.BackColor = ColorClass.ColorFondo2;
            PanelButtons.BackColor = ColorClass.ColorFondo2;
            ButtonLenguaje.BackColor = ColorClass.ColorBoton;
            ButtonTheme.BackColor = ColorClass.ColorBoton;
            ButtonUser.BackColor = ColorClass.ColorBoton;
        }
        public void LenguajeMethod()
        {
            if (DB_Storer.T6_Lenguage[0] == 0) //ESPAÑOL
            {
                LabelLenguaje.Text = "LENGUAJES";
                LabelTheme.Text = "TEMAS";
                LabelUser.Text = "DATOS DEL USUARIO";
            }
            else if (DB_Storer.T6_Lenguage[0] == 1) //INGLES
            {
                LabelLenguaje.Text = "LENGUAJE";
                LabelTheme.Text = "THEME";
                LabelUser.Text = "USER DATA";
            }
            FormMethods.CentrarTextos(LabelLenguaje, ButtonLenguaje);
            FormMethods.CentrarTextos(LabelTheme, ButtonTheme);
            FormMethods.CentrarTextos(LabelUser, ButtonUser);
        }

        private void ButtonLenguaje_MouseClick(object sender, MouseEventArgs e)
        {
            PanelConfigs.Controls.Clear();
            ControlLenguaje = new ControlLenguaje(Principal, Config);
            PanelConfigs.Controls.Add(ControlLenguaje);
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
            PanelConfigs.Controls.Clear();
            ControlLenguaje = new ControlLenguaje(Principal, Config);
            PanelConfigs.Controls.Add(ControlLenguaje);
        }
        private void LabelLenguaje_MouseEnter(object sender, EventArgs e)
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelLenguaje_MouseLeave(object sender, EventArgs e)
        {
            ButtonLenguaje.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonTheme_MouseClick(object sender, MouseEventArgs e)
        {
            PanelConfigs.Controls.Clear();
            ControlTheme = new ControlTheme(Principal, Config);
            PanelConfigs.Controls.Add(ControlTheme);
        }
        private void ButtonTheme_MouseEnter(object sender, EventArgs e)
        {
            ButtonTheme.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonTheme_MouseLeave(object sender, EventArgs e)
        {
            ButtonTheme.BackColor = ColorClass.ColorBoton;
        }
        private void LabelTheme_MouseClick(object sender, MouseEventArgs e)
        {
            PanelConfigs.Controls.Clear();
            ControlTheme = new ControlTheme(Principal, Config);
            PanelConfigs.Controls.Add(ControlTheme);
        }
        private void LabelTheme_MouseEnter(object sender, EventArgs e)
        {
            ButtonTheme.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelTheme_MouseLeave(object sender, EventArgs e)
        {
            ButtonTheme.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonUser_MouseClick(object sender, MouseEventArgs e)
        {
            PanelConfigs.Controls.Clear();
            ControlUser = new ControlUser();
            PanelConfigs.Controls.Add(ControlUser);
        }
        private void ButtonUser_MouseEnter(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonUser_MouseLeave(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBoton;
        }
        private void LabelUser_MouseClick(object sender, MouseEventArgs e)
        {
            PanelConfigs.Controls.Clear();
            ControlUser = new ControlUser();
            PanelConfigs.Controls.Add(ControlUser);
        }
        private void LabelUser_MouseEnter(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelUser_MouseLeave(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBoton;
        }
    }
}
