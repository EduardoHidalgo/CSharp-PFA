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
    public partial class ControlTheme : UserControl
    {
        FormPrincipal Principal;
        FormConfig Config;
        public ControlTheme(FormPrincipal principal, FormConfig config)
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            ButtonTheme.BackColor = ColorClass.ColorBoton;
            ComboboxTheme.BackColor = ColorClass.ColorDecorativo;
            UpdateComboboxTheme();
            ComboboxTheme.SelectedIndex = DB_Storer.T6_Theme[0] - 1;
            PanelFondo1.Visible = true;
            Principal = principal;
            Config = config;
        }

        private void ChangeColors() //int IndexColor
        {
            try
            {
                int Theme = ComboboxTheme.SelectedIndex + 1;
                int Leng = DB_Storer.T6_Lenguage[0];
                DBclass.Modifier_Config(Theme, Leng);

                ColorClass.SelectColor(ComboboxTheme.SelectedIndex + 1);
                PanelFondo1.BackColor = ColorClass.ColorFondo1;
                PanelFondo2.BackColor = ColorClass.ColorFondo2;
                PanelButtons.BackColor = ColorClass.ColorDecorativo;
                Button1.BackColor = ColorClass.ColorBoton;
                Button2.BackColor = ColorClass.ColorBoton;
                Button3.BackColor = ColorClass.ColorBoton;
                Button4.BackColor = ColorClass.ColorBoton;
                Textbox1.BackColor = ColorClass.ColorDecorativo;
                Textbox2.BackColor = ColorClass.ColorDecorativo;
                ButtonTheme.BackColor = ColorClass.ColorBoton;
                ComboboxTheme.BackColor = ColorClass.ColorDecorativo;
                ButtonTheme.BackColor = ColorClass.ColorBoton;
                ComboboxTheme.BackColor = ColorClass.ColorDecorativo;

                Principal.ColorMethod();
                Config.ColorMethod();
            }
            catch
            {
                LabelEjemplo.Text = "ERROR, comuniquese con soporte";
            }
        }

        private void UpdateComboboxTheme()
        {
            ColorClass.InicializateArrayThemes();
            for ( int I = 0; I <= ColorClass.Themes - 1; I++)
            {
                ComboboxTheme.Items.Add(ColorClass.ArrayThemes[I]);
            }
        }

        private void ComboboxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorClass.PreviewSelectColor(ComboboxTheme.SelectedIndex + 1);
            PanelFondo1.BackColor = ColorClass.PreviewColorFondo1;
            PanelFondo2.BackColor = ColorClass.PreviewColorFondo2;
            PanelButtons.BackColor = ColorClass.PreviewColorDecorativo;
            Button1.BackColor = ColorClass.PreviewColorBoton;
            Button2.BackColor = ColorClass.PreviewColorBoton;
            Button3.BackColor = ColorClass.PreviewColorBoton;
            Button4.BackColor = ColorClass.PreviewColorBoton;
            Textbox1.BackColor = ColorClass.PreviewColorDecorativo;
            Textbox2.BackColor = ColorClass.PreviewColorDecorativo;
        }


        private void ButtonTheme_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColors();
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
            ChangeColors();
        }
        private void LabelTheme_MouseEnter(object sender, EventArgs e)
        {
            ButtonTheme.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelTheme_MouseLeave(object sender, EventArgs e)
        {
            ButtonTheme.BackColor = ColorClass.ColorBoton;
        }

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            Button3.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            Button3.BackColor = ColorClass.PreviewColorBoton;
        }
        private void LabelButton3_MouseEnter(object sender, EventArgs e)
        {
            Button3.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void LabelButton3_MouseLeave(object sender, EventArgs e)
        {
            Button3.BackColor = ColorClass.PreviewColorBoton;
        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            Button4.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            Button4.BackColor = ColorClass.PreviewColorBoton;
        }
        private void LabelButton4_MouseEnter(object sender, EventArgs e)
        {
            Button4.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void LabelButton4_MouseLeave(object sender, EventArgs e)
        {
            Button4.BackColor = ColorClass.PreviewColorBoton;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = ColorClass.PreviewColorBoton;
        }
        private void LabelButton1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void LabelButton1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = ColorClass.PreviewColorBoton;
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            Button2.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Button2.BackColor = ColorClass.PreviewColorBoton;
        }
        private void LabelButton2_MouseEnter(object sender, EventArgs e)
        {
            Button2.BackColor = ColorClass.PreviewColorBotonCursado;
        }
        private void LabelButton2_MouseLeave(object sender, EventArgs e)
        {
            Button2.BackColor = ColorClass.PreviewColorBoton;
        }
    }
}
