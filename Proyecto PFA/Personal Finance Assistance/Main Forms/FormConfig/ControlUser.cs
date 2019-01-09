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
    public partial class ControlUser : UserControl
    {
        #region STRINGS
        string temp = "";
        string User;
        string Pass;
        string Mail; 
        #endregion

        public ControlUser()
        {
            InitializeComponent();
            ButtonUser.BackColor = ColorClass.ColorBoton;
            ButtonPass.BackColor = ColorClass.ColorBoton;
            ButtonMail.BackColor = ColorClass.ColorBoton;
            ButtonDelete.BackColor = ColorClass.ColorBoton;
            TextboxUser.BackColor = ColorClass.ColorFondo2;
            TextboxPass.BackColor = ColorClass.ColorFondo2;
            TextboxMail.BackColor = ColorClass.ColorFondo2;

            CreateLabels();
            UpdateUserData();
        }

        public void CreateLabels()
        {
            LabelUser.Text = "";
            LabelPass.Text = "";
            LabelMail.Text = "";
            DBclass.Create_Evaluos();
            DBclass.Upload_Evaluos();
            LabelEvalues.Text = Convert.ToString(DB_Storer.T8_Total_Evaluos[0]);

        }

        private void ChangeUser()
        {
            User = DB_Storer.T1_Usuario[DB_Storer.ID_User - 1];
            Pass = DB_Storer.T1_Contraseña[DB_Storer.ID_User - 1];
            Mail = DB_Storer.T1_Correo[DB_Storer.ID_User - 1];
            if(TextboxUser.Text != "CAMBIAR USUARIO")
            {
                if (TextboxUser.Text != null)
                {
                    try
                    {
                        temp = TextboxUser.Text;
                        DBclass.Modifier_Usuario(temp, Pass, Mail);
                        UpdateUserData();
                    }
                    catch
                    {
                        LabelWrong.Text = "ERROR, contacte con soporte";
                        LabelWrong.Visible = true;
                    }
                }
                else
                {
                    LabelWrong.Text = "Inserte un nuevo usuario";
                    LabelWrong.Visible = true;
                }
            }
            else
            {
                LabelWrong.Text = "Inserte un nuevo usuario";
                LabelWrong.Visible = true;
            }
        }
        private void ChangePass()
        {
            User = DB_Storer.T1_Usuario[DB_Storer.ID_User - 1];
            Pass = DB_Storer.T1_Contraseña[DB_Storer.ID_User - 1];
            Mail = DB_Storer.T1_Correo[DB_Storer.ID_User - 1];
            if (TextboxPass.Text != "CAMBIAR CLAVE")
            {
                if (TextboxPass.Text != null)
                {
                    try
                    {
                        temp = TextboxPass.Text;
                        DBclass.Modifier_Usuario(User, temp, Mail);
                        UpdateUserData();
                    }
                    catch
                    {
                        LabelWrong.Text = "ERROR, contacte con soporte";
                        LabelWrong.Visible = true;
                    }
                }
                else
                {
                    LabelWrong.Text = "Inserte una nueva contraseña";
                    LabelWrong.Visible = true;
                }
            }
            else
            {
                LabelWrong.Text = "Inserte una nueva contraseña";
                LabelWrong.Visible = true;
            }
        }
        private void ChangeMail()
        {
            User = DB_Storer.T1_Usuario[DB_Storer.ID_User - 1];
            Pass = DB_Storer.T1_Contraseña[DB_Storer.ID_User - 1];
            Mail = DB_Storer.T1_Correo[DB_Storer.ID_User - 1];
            if (TextboxUser.Text != "CAMBIAR CORREO")
            {
                if (TextboxMail.Text != null)
                {
                    if (((TextboxMail.Text.Contains("@hotmail")) | (TextboxMail.Text.Contains("@gmail"))) == true)
                    {
                        try
                        {
                            temp = TextboxMail.Text;
                            DBclass.Modifier_Usuario(User, Pass, temp);
                            UpdateUserData();
                        }
                        catch
                        {
                            LabelWrong.Text = "ERROR, contacte con soporte";
                            LabelWrong.Visible = true;
                        }
                    }
                    else
                    {
                        LabelWrong.Text = "Inserte un Correo Hotmail o Gmail válido";
                        LabelWrong.Visible = true;
                    }
                }
                else
                {
                    LabelWrong.Text = "Inserte un nuevo correo";
                    LabelWrong.Visible = true;
                }
            }
            else
            {
                LabelWrong.Text = "Inserte un nuevo correo";
                LabelWrong.Visible = true;
            }
        }

        private void UpdateUserData()
        {
            LabelUser.Text = DB_Storer.T1_Usuario[DB_Storer.ID_User - 1];
            LabelPass.Text = DB_Storer.T1_Contraseña[DB_Storer.ID_User - 1];
            LabelMail.Text = DB_Storer.T1_Correo[DB_Storer.ID_User - 1];
            LabelUser.Location = new Point(UserData.Size.Width - 2 - LabelUser.Size.Width, LabelUser.Location.Y);
            LabelPass.Location = new Point(UserData.Size.Width - 2 - LabelPass.Size.Width, LabelPass.Location.Y);
            LabelMail.Location = new Point(UserData.Size.Width - 2 - LabelMail.Size.Width, LabelMail.Location.Y);
            TextboxUser.Text = "CAMBIAR USUARIO";
            TextboxPass.Text = "CAMBIAR CLAVE";
            TextboxMail.Text = "CAMBIAR CORREO";
        }

        private void ButtonUser_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeUser();
        }
        private void ButtonUser_MouseEnter(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonUser_MouseLeave(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBoton;
        }
        private void LabelButtonUser_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeUser();
        }
        private void LabelButtonUser_MouseEnter(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelButtonUser_MouseLeave(object sender, EventArgs e)
        {
            ButtonUser.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonPass_MouseClick(object sender, MouseEventArgs e)
        {
            ChangePass();
        }
        private void ButtonPass_MouseEnter(object sender, EventArgs e)
        {
            ButtonPass.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonPass_MouseLeave(object sender, EventArgs e)
        {
            ButtonPass.BackColor = ColorClass.ColorBoton;
        }
        private void LabelButtonPass_MouseClick(object sender, MouseEventArgs e)
        {
            ChangePass();
        }
        private void LabelButtonPass_MouseEnter(object sender, EventArgs e)
        {
            ButtonPass.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelButtonPass_MouseLeave(object sender, EventArgs e)
        {
            ButtonPass.BackColor = ColorClass.ColorBoton;
        }

        private void ButtonMail_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeMail();
        }
        private void ButtonMail_MouseEnter(object sender, EventArgs e)
        {
            ButtonMail.BackColor = ColorClass.ColorBotonCursado;
        }
        private void ButtonMail_MouseLeave(object sender, EventArgs e)
        {
            ButtonMail.BackColor = ColorClass.ColorBoton;
        }
        private void LabelButtonMail_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeMail();
        }
        private void LabelButtonMail_MouseEnter(object sender, EventArgs e)
        {
            ButtonMail.BackColor = ColorClass.ColorBotonCursado;
        }
        private void LabelButtonMail_MouseLeave(object sender, EventArgs e)
        {
            ButtonMail.BackColor = ColorClass.ColorBoton;
        }

        private void TextboxUser_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxUser.ResetText();
            LabelWrong.Visible = false;
        }
        private void TextboxPass_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxPass.ResetText();
            LabelWrong.Visible = false;
        }
        private void TextboxMail_MouseClick(object sender, MouseEventArgs e)
        {
            TextboxMail.ResetText();
            LabelWrong.Visible = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string message = "¿Estás seguro que quieres borrar tu usuario?";
            string caption = "blablabla";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DBclass.Delete_Usuario(DB_Storer.ID_User);
                Application.Exit();
            }
        }
    }
}
