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
    public partial class FormForget : Form
    {
        public FormForget()
        {
            InitializeComponent();
            BackColor = ColorClass.ColorFondo1;
            PanelForget.BackColor = ColorClass.ColorFondo2;
            ButtonF_Enviar.BackColor = ColorClass.ColorBoton;
            ButtonF_Volver.BackColor = ColorClass.ColorBoton;
            TextboxF_Mail.BackColor = ColorClass.ColorDecorativo;
            LabelF_Text.ForeColor = ColorClass.ColorDecorativo;
            LabelF_Wrong.Visible = false;
        }

        private void Send()
        {
            DBclass.Create_Usuarios();
            DBclass.Upload_Usuarios();
            string Usuario = TextboxF_Mail.Text;
            try
            {
                if (DB_Storer.T1_Usuario.Contains(Usuario))
                {
                    int Iter = Array.IndexOf(DB_Storer.T1_Usuario, Usuario);
                    string Contraseña = DB_Storer.T1_Contraseña[Iter];
                    string Correo = DB_Storer.T1_Correo[Iter];
                    Send_Mail.Send(Usuario, Contraseña, Correo);
                    FormMethods.Centrar(LabelF_Wrong, PanelForget.Size.Width);
                    LabelF_Wrong.Text = "Mensaje Enviado";
                    LabelF_Wrong.Visible = true;
                    MessageBox.Show("Datos enviados, revise su e-mail.");
                }
                else
                {
                    FormMethods.Centrar(LabelF_Wrong, PanelForget.Size.Width);
                    LabelF_Wrong.Text = "Error en el envío. Revise su usuario";
                    LabelF_Wrong.Visible = true;
                    TextboxF_Mail.Text = "USUARIO";
                }
            }
            catch
            {
                MessageBox.Show("Error, envíe un mensaje a EDREI_PFA@hotmail.com \npara recibir asistencia.");
            }
        }

        #region Textbox Mail Events
        private void TextboxF_Mail_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxF_Mail.Text = null;
            LabelF_Wrong.Visible = false;
        }
        private void TextboxF_Mail_Enter(object sender, EventArgs e)
        {
            LabelF_Wrong.Visible = false;
            if (TextboxF_Mail.Text == "USUARIO")
            {
                TextboxF_Mail.Text = null;
            }
        } 
        #endregion

        #region Button Enviar Events
        private void ButtonF_Enviar_MouseClick(object sender, MouseEventArgs e)
        {
            Send();
        }
        private void ButtonF_Enviar_MouseEnter(object sender, EventArgs e)
        {
            ButtonF_Enviar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonF_Enviar_MouseLeave(object sender, EventArgs e)
        {
            ButtonF_Enviar.BackColor = ColorClass.ColorBoton;
        }
        private void LabelF_Enviar_MouseClick(object sender, MouseEventArgs e)
        {
            Send();
        }
        private void LabelF_Enviar_MouseEnter(object sender, EventArgs e)
        {
            ButtonF_Enviar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelF_Enviar_MouseLeave(object sender, EventArgs e)
        {
            ButtonF_Enviar.BackColor = ColorClass.ColorBoton;
        } 
        #endregion
        #region Button Volver Events
        private void ButtonF_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            (new FormLogin()).Show();
        }
        private void ButtonF_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonF_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonF_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonF_Volver.BackColor = ColorClass.ColorBoton;
        }
        private void LabelF_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            (new FormLogin()).Show();
        }
        private void LabelF_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonF_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelF_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonF_Volver.BackColor = ColorClass.ColorBoton;
        } 
        #endregion
    }
}
