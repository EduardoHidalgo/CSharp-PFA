using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Personal_Finance_Assistance
{
    public partial class FormLogin : Form
    {
        string Left = "Left", Right = "Right";

        public FormLogin()
        {
            InitializeComponent();
            bool Confirm = DBclass.FileEXist();
            if (Confirm == false)
            {
                MessageBox.Show("Error en la database, envíe un mensaje a EDREI_PFA@hotmail.com para recibir asistencia.");
                Application.Exit();
            }
            else
            {
                DBclass.Create_Usuarios();
                DBclass.Upload_Usuarios();
                ColorClass.SelectColor(2);
            }
            PanelLogin.Location = new Point(0 - PanelLogin.Size.Width, PanelLogin.Location.Y);
            PanelRegistrer.Location = new Point(0 - PanelRegistrer.Size.Width, PanelLogin.Location.Y);
            LabelR_Wrong.Visible = false;
            LabelL_Wrong.Visible = false;
            ColorMethod();
        }
        public void ColorMethod()
        {
            LabelR_Wrong.ForeColor = ColorClass.ColorFondo1;
            BackColor = ColorClass.ColorFondo1;
            PanelPrincipal.BackColor = ColorClass.ColorFondo2;
            ButtonLogin.BackColor = ColorClass.ColorBoton;
            ButtonRegistrer.BackColor = ColorClass.ColorBoton;
            ButtonL_Iniciar.BackColor = ColorClass.ColorBoton;
            ButtonL_Volver.BackColor = ColorClass.ColorBoton;
            TextboxL_Pass.BackColor = ColorClass.ColorDecorativo;
            TextboxL_User.BackColor = ColorClass.ColorDecorativo;
            ButtonR_Registrer.BackColor = ColorClass.ColorBoton;
            ButtonR_Volver.BackColor = ColorClass.ColorBoton;
            TextboxR_Pass.BackColor = ColorClass.ColorDecorativo;
            TextboxR_User.BackColor = ColorClass.ColorDecorativo;
            TextboxR_Mail.BackColor = ColorClass.ColorDecorativo;
            PanelRegistrer.BackColor = ColorClass.ColorFondo2;
            PanelLogin.BackColor = ColorClass.ColorFondo2;
        }

        public void Login()
        {
            DBclass.Create_Usuarios();
            DBclass.Upload_Usuarios();

            LabelL_Wrong.Visible = false;
            bool User, Pass;
            if ((String.IsNullOrEmpty(TextboxL_User.Text) | String.IsNullOrEmpty(TextboxL_Pass.Text)))
            {
                User = false;
                Pass = false;
            }
            if ((TextboxL_User.Text == "USUARIO") | (TextboxL_Pass.Text == "CONTRASEÑA"))
            {
                User = false;
                Pass = false;
            }
            else
            {
                if (DB_Storer.T1_Usuario.Contains(TextboxL_User.Text))
                {
                    User = true;

                }
                else
                {
                    User = false;
                }
                if (DB_Storer.T1_Contraseña.Contains(TextboxL_Pass.Text))
                {
                    Pass = true;
                }
                else
                {
                    Pass = false;
                }
            }
            if ((User & Pass) == true)
            {
                try
                {
                    DB_Storer.ID_User = DB_Storer.T1_ID_usuario[Array.IndexOf(DB_Storer.T1_Usuario, TextboxL_User.Text)];
                    LabelL_Wrong.Text = "Sesión Iniciada";
                    FormMethods.Centrar(LabelL_Wrong, PanelLogin.Size.Width);
                    LabelL_Wrong.Visible = true;
                    DBclass.Create_Config();
                    DBclass.Upload_Config();
                    ColorClass.SelectColor(DB_Storer.T6_Theme[0]);
                    (new FormPrincipal()).Show();
                    this.Hide();
                }
                catch
                {
                    LabelL_Wrong.Text = "Error al Logear, Contacte con soporte";
                    FormMethods.Centrar(LabelL_Wrong, PanelLogin.Size.Width);
                    LabelL_Wrong.Visible = true;
                }
            }
            else
            {
                LabelL_Wrong.Text = "Revise el ingreso de los datos";
                FormMethods.Centrar(LabelL_Wrong, PanelLogin.Size.Width);
                LabelL_Wrong.Visible = true;
            }
        }
        public void Registrer()
        {
            DBclass.Create_Usuarios();
            DBclass.Upload_Usuarios();

            LabelR_Wrong.Visible = false;
            bool B_User = false;
            bool B_Pass = false;
            bool B_Mail = false;
            if (string.IsNullOrEmpty(TextboxR_User.Text))
            {
                B_User = false;
            }
            else
            {
                B_User = true;
            }
            if (string.IsNullOrEmpty(TextboxR_Pass.Text))
            {
                B_Pass = false;
            }
            else
            {
                B_Pass = true;
            }
            if (string.IsNullOrEmpty(TextboxR_Mail.Text))
            {
                B_Mail = false;
            }
            else
            {
                B_Mail = true;
            }
            if ((TextboxR_User.Text == "USUARIO") | (TextboxR_Pass.Text == "CONTRASEÑA") | (TextboxR_Mail.Text == "CORREO"))
            {
                B_User = false;
                B_Pass = false;
                B_Mail = false;
            }
            else
            {

            }

            if ((B_User == true) & (B_Pass == true) & (B_Mail == true))
            {
                if (TextboxR_Mail.Text.Contains("@hotmail") | TextboxR_Mail.Text.Contains("@gmail"))
                {
                    try
                    {
                        DBclass.Insert_Usuario(TextboxR_User.Text, TextboxR_Pass.Text, TextboxR_Mail.Text);
                        FormMethods.Centrar(LabelR_Wrong, PanelRegistrer.Size.Width);
                        LabelR_Wrong.Text = "Registro Completado";
                        LabelR_Wrong.Visible = true;
                    }
                    catch (Exception)
                    {
                        LabelR_Wrong.Text = "Error en la ejecución";
                        FormMethods.Centrar(LabelR_Wrong, PanelRegistrer.Size.Width);
                        LabelR_Wrong.Visible = true;
                    }
                }
                else
                {
                    LabelR_Wrong.Text = "Inserte un Correo Hotmail o Gmail válido";
                    FormMethods.Centrar(LabelR_Wrong, PanelRegistrer.Size.Width);
                    LabelR_Wrong.Visible = true;
                }
            }
            else
            {
                LabelR_Wrong.Text = "Rellene todos los campos";
                FormMethods.Centrar(LabelR_Wrong, PanelRegistrer.Size.Width);
                LabelR_Wrong.Visible = true;
            }
        }

        #region LabelForget Events
        private void LabelL_Forget_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            (new FormForget()).Show();
        }
        private void LabelL_Forget_MouseLeave(object sender, EventArgs e)
        {
            LabelL_Forget.ForeColor = Color.Black;
        }
        private void LabelL_Forget_MouseEnter(object sender, EventArgs e)
        {
            LabelL_Forget.ForeColor = ColorClass.ColorBotonCursado;
        }
        #endregion 

        #region ButtonLogin Events
        private void LabelIniciar_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Right, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Right, PanelPrincipal.Size.Width);
            PanelLogin.Enabled = true;
            PanelLogin.Visible = true;
            FormMethods.DesplazamientoHorizontal(PanelLogin, Right, PanelPrincipal.Size.Width);
        }
        private void LabelIniciar_MouseLeave(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = ColorClass.ColorBoton;
        }
        private void LabelIniciar_MouseEnter(object sender, EventArgs e)
        {

            ButtonLogin.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonLogin_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Right, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Right, PanelPrincipal.Size.Width);
            PanelLogin.Enabled = true;
            PanelLogin.Visible = true;
            FormMethods.DesplazamientoHorizontal(PanelLogin, Right, PanelPrincipal.Size.Width);
        }
        private void ButtonLogin_MouseLeave(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = ColorClass.ColorBoton;
        }
        private void ButtonLogin_MouseEnter(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = ColorClass.ColorBotonCursado;
        }
        #endregion
        #region ButtonRegistrer Events
        private void LabelRegistrarse_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Right, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Right, PanelPrincipal.Size.Width);
            PanelRegistrer.Enabled = true;
            PanelRegistrer.Visible = true;
            FormMethods.DesplazamientoHorizontal(PanelRegistrer, Right, PanelPrincipal.Size.Width);
        }
        private void LabelRegistrarse_MouseEnter(object sender, EventArgs e)
        {
            ButtonRegistrer.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            ButtonRegistrer.BackColor = ColorClass.ColorBoton;
        }
        private void ButtonRegistrer_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Right, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Right, PanelPrincipal.Size.Width);
            PanelRegistrer.Enabled = true;
            PanelRegistrer.Visible = true;
            FormMethods.DesplazamientoHorizontal(PanelRegistrer, Right, PanelPrincipal.Size.Width);
        }
        private void ButtonRegistrer_MouseEnter(object sender, EventArgs e)
        {
            ButtonRegistrer.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonRegistrer_MouseLeave(object sender, EventArgs e)
        {
            ButtonRegistrer.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region ButtonL_Iniciar Events
        private void ButtonL_Iniciar_MouseClick(object sender, MouseEventArgs e)
        {
            Login();
        }
        private void ButtonL_Iniciar_MouseEnter(object sender, EventArgs e)
        {
            ButtonL_Iniciar.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonL_Iniciar_MouseLeave(object sender, EventArgs e)
        {
            ButtonL_Iniciar.BackColor = ColorClass.ColorBoton;
        }
        private void LabelL_Iniciar_MouseClick(object sender, MouseEventArgs e)
        {
            Login();
        }
        private void LabelL_Iniciar_MouseLeave(object sender, EventArgs e)
        {
            ButtonL_Iniciar.BackColor = ColorClass.ColorBoton;
        }
        private void LabelL_Iniciar_MouseEnter(object sender, EventArgs e)
        {
            ButtonL_Iniciar.BackColor = ColorClass.ColorBotonCursado;
        }
        #endregion
        #region ButtonL_Volver Events
        private void ButtonL_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(PanelLogin, Left, PanelPrincipal.Size.Width);
            PanelLogin.Enabled = false;
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Left, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Left, PanelPrincipal.Size.Width);
            TextboxL_User.Text = "USUARIO";
            TextboxL_Pass.Text = "CONTRASEÑA";
            TextboxL_Pass.PasswordChar = '\0';
        }
        private void ButtonL_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonL_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonL_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonL_Volver.BackColor = ColorClass.ColorBoton;
        }
        private void LabelL_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(PanelLogin, Left, PanelPrincipal.Size.Width);
            PanelLogin.Enabled = false;
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Left, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Left, PanelPrincipal.Size.Width);
            TextboxL_User.Text = "USUARIO";
            TextboxL_Pass.Text = "CONTRASEÑA";
            TextboxL_Pass.PasswordChar = '\0';
        }
        private void LabelL_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonL_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelL_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonL_Volver.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region ButtonR_Registrer
        private void ButtonR_Registrer_MouseClick(object sender, MouseEventArgs e)
        {
            Registrer();
        }
        private void ButtonR_Registrer_MouseEnter(object sender, EventArgs e)
        {
            ButtonR_Registrer.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonR_Registrer_MouseLeave(object sender, EventArgs e)
        {
            ButtonR_Registrer.BackColor = ColorClass.ColorBoton;
        }
        private void LabelR_Registrarse_MouseClick(object sender, MouseEventArgs e)
        {
            Registrer();
        }
        private void LabelR_Registrarse_MouseEnter(object sender, EventArgs e)
        {
            ButtonR_Registrer.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelR_Registrarse_MouseLeave(object sender, EventArgs e)
        {
            ButtonR_Registrer.BackColor = ColorClass.ColorBoton;
        }
        #endregion
        #region ButtonR_Volver
        private void ButtonR_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(PanelRegistrer, Left, PanelPrincipal.Size.Width);
            PanelRegistrer.Enabled = false;
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Left, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Left, PanelPrincipal.Size.Width);
            TextboxR_User.Text = "USUARIO";
            TextboxR_Pass.Text = "CONTRASEÑA";
            TextboxR_Mail.Text = "CORREO";
            TextboxR_Pass.PasswordChar = '\0';
        }
        private void ButtonR_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonR_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonR_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonR_Volver.BackColor = ColorClass.ColorBoton;
        }
        private void LabelR_Volver_MouseClick(object sender, MouseEventArgs e)
        {
            FormMethods.DesplazamientoHorizontal(PanelRegistrer, Left, PanelPrincipal.Size.Width);
            PanelRegistrer.Enabled = false;
            FormMethods.DesplazamientoHorizontal(ButtonLogin, Left, PanelPrincipal.Size.Width);
            FormMethods.DesplazamientoHorizontal(ButtonRegistrer, Left, PanelPrincipal.Size.Width);
            TextboxR_User.Text = "USUARIO";
            TextboxR_Pass.Text = "CONTRASEÑA";
            TextboxR_Mail.Text = "CORREO";
            TextboxR_Pass.PasswordChar = '\0';
        }
        private void LabelR_Volver_MouseEnter(object sender, EventArgs e)
        {
            ButtonR_Volver.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelR_Volver_MouseLeave(object sender, EventArgs e)
        {
            ButtonR_Volver.BackColor = ColorClass.ColorBoton;
        }
        #endregion

        #region Textboxs(2) Login Events
        private void TextboxL_User_MouseClick(object sender, MouseEventArgs e) //QUITA EL TEXTO PREDETERMINADO DEL TEXTBOX
        {
            TextboxL_User.Text = null;
            LabelL_Wrong.Visible = false;
        }
        private void TextboxL_User_Enter(object sender, EventArgs e)
        {
            TextboxL_User.Text = null;
        }
        private void TextboxL_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxL_Pass.Text = null;
            LabelL_Wrong.Visible = false;
            TextboxL_Pass.PasswordChar = '*';
        }
        private void TextboxL_Pass_Enter(object sender, EventArgs e)
        {
            TextboxL_Pass.Text = null;
            TextboxL_Pass.PasswordChar = '*';
        }
        #endregion
        #region Textboxs(3) Registrer Events
        private void TextboxR_User_Enter(object sender, EventArgs e)
        {
            TextboxR_User.Text = null;
        }
        private void TextboxR_User_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxR_User.Text = null;
            LabelR_Wrong.Visible = false;
        }
        private void TextboxR_Pass_Enter(object sender, EventArgs e)
        {
            TextboxR_Pass.Text = null;
            TextboxR_Pass.PasswordChar = '*';
        }
        private void TextboxR_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxR_Pass.Text = null;
            LabelR_Wrong.Visible = false;
            TextboxR_Pass.PasswordChar = '*';
        }
        private void TextboxR_Mail_Enter(object sender, EventArgs e)
        {
            TextboxR_Mail.Text = null;
        }
        private void TextboxR_Mail_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxR_Mail.Text = null;
            LabelR_Wrong.Visible = false;
        }
        #endregion

        private void ButtonSalir_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
