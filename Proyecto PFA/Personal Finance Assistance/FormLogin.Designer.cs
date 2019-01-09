namespace Personal_Finance_Assistance
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.LabelL_Wrong = new System.Windows.Forms.Label();
            this.LabelL_Forget = new System.Windows.Forms.Label();
            this.ButtonL_Iniciar = new System.Windows.Forms.Panel();
            this.LabelL_Iniciar = new System.Windows.Forms.Label();
            this.ButtonL_Volver = new System.Windows.Forms.Panel();
            this.LabelL_Volver = new System.Windows.Forms.Label();
            this.TextboxL_Pass = new System.Windows.Forms.TextBox();
            this.TextboxL_User = new System.Windows.Forms.TextBox();
            this.PanelSalir = new System.Windows.Forms.Panel();
            this.ButtonSalir = new System.Windows.Forms.Panel();
            this.PictureboxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new System.Windows.Forms.Panel();
            this.LabelIniciar = new System.Windows.Forms.Label();
            this.ButtonRegistrer = new System.Windows.Forms.Panel();
            this.LabelRegistrarse = new System.Windows.Forms.Label();
            this.PanelRegistrer = new System.Windows.Forms.Panel();
            this.LabelR_Wrong = new System.Windows.Forms.Label();
            this.TextboxR_Mail = new System.Windows.Forms.TextBox();
            this.ButtonR_Registrer = new System.Windows.Forms.Panel();
            this.LabelR_Registrarse = new System.Windows.Forms.Label();
            this.ButtonR_Volver = new System.Windows.Forms.Panel();
            this.LabelR_Volver = new System.Windows.Forms.Label();
            this.TextboxR_Pass = new System.Windows.Forms.TextBox();
            this.TextboxR_User = new System.Windows.Forms.TextBox();
            this.PanelPrincipal.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.ButtonL_Iniciar.SuspendLayout();
            this.ButtonL_Volver.SuspendLayout();
            this.PanelSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxLogo)).BeginInit();
            this.ButtonLogin.SuspendLayout();
            this.ButtonRegistrer.SuspendLayout();
            this.PanelRegistrer.SuspendLayout();
            this.ButtonR_Registrer.SuspendLayout();
            this.ButtonR_Volver.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelPrincipal.Controls.Add(this.PanelLogin);
            this.PanelPrincipal.Controls.Add(this.PanelSalir);
            this.PanelPrincipal.Controls.Add(this.PictureboxLogo);
            this.PanelPrincipal.Controls.Add(this.ButtonLogin);
            this.PanelPrincipal.Controls.Add(this.ButtonRegistrer);
            this.PanelPrincipal.Controls.Add(this.PanelRegistrer);
            this.PanelPrincipal.Location = new System.Drawing.Point(5, 5);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(350, 630);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.LabelL_Wrong);
            this.PanelLogin.Controls.Add(this.LabelL_Forget);
            this.PanelLogin.Controls.Add(this.ButtonL_Iniciar);
            this.PanelLogin.Controls.Add(this.ButtonL_Volver);
            this.PanelLogin.Controls.Add(this.TextboxL_Pass);
            this.PanelLogin.Controls.Add(this.TextboxL_User);
            this.PanelLogin.Enabled = false;
            this.PanelLogin.Location = new System.Drawing.Point(0, 270);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(350, 283);
            this.PanelLogin.TabIndex = 9;
            // 
            // LabelL_Wrong
            // 
            this.LabelL_Wrong.AutoSize = true;
            this.LabelL_Wrong.BackColor = System.Drawing.Color.Transparent;
            this.LabelL_Wrong.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelL_Wrong.Location = new System.Drawing.Point(152, 102);
            this.LabelL_Wrong.Name = "LabelL_Wrong";
            this.LabelL_Wrong.Size = new System.Drawing.Size(42, 18);
            this.LabelL_Wrong.TabIndex = 5;
            this.LabelL_Wrong.Text = "Error";
            // 
            // LabelL_Forget
            // 
            this.LabelL_Forget.AutoSize = true;
            this.LabelL_Forget.BackColor = System.Drawing.Color.Transparent;
            this.LabelL_Forget.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelL_Forget.Location = new System.Drawing.Point(96, 180);
            this.LabelL_Forget.Name = "LabelL_Forget";
            this.LabelL_Forget.Size = new System.Drawing.Size(157, 18);
            this.LabelL_Forget.TabIndex = 4;
            this.LabelL_Forget.Text = "¿Olvidaste tus datos?";
            this.LabelL_Forget.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelL_Forget_MouseClick);
            this.LabelL_Forget.MouseEnter += new System.EventHandler(this.LabelL_Forget_MouseEnter);
            this.LabelL_Forget.MouseLeave += new System.EventHandler(this.LabelL_Forget_MouseLeave);
            // 
            // ButtonL_Iniciar
            // 
            this.ButtonL_Iniciar.BackColor = System.Drawing.Color.Gray;
            this.ButtonL_Iniciar.Controls.Add(this.LabelL_Iniciar);
            this.ButtonL_Iniciar.Location = new System.Drawing.Point(100, 130);
            this.ButtonL_Iniciar.Name = "ButtonL_Iniciar";
            this.ButtonL_Iniciar.Size = new System.Drawing.Size(150, 50);
            this.ButtonL_Iniciar.TabIndex = 3;
            this.ButtonL_Iniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonL_Iniciar_MouseClick);
            this.ButtonL_Iniciar.MouseEnter += new System.EventHandler(this.ButtonL_Iniciar_MouseEnter);
            this.ButtonL_Iniciar.MouseLeave += new System.EventHandler(this.ButtonL_Iniciar_MouseLeave);
            // 
            // LabelL_Iniciar
            // 
            this.LabelL_Iniciar.AutoSize = true;
            this.LabelL_Iniciar.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelL_Iniciar.Location = new System.Drawing.Point(5, 14);
            this.LabelL_Iniciar.Name = "LabelL_Iniciar";
            this.LabelL_Iniciar.Size = new System.Drawing.Size(143, 23);
            this.LabelL_Iniciar.TabIndex = 1;
            this.LabelL_Iniciar.Text = "INICIAR SESIÓN";
            this.LabelL_Iniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelL_Iniciar_MouseClick);
            this.LabelL_Iniciar.MouseEnter += new System.EventHandler(this.LabelL_Iniciar_MouseEnter);
            this.LabelL_Iniciar.MouseLeave += new System.EventHandler(this.LabelL_Iniciar_MouseLeave);
            // 
            // ButtonL_Volver
            // 
            this.ButtonL_Volver.BackColor = System.Drawing.Color.Gray;
            this.ButtonL_Volver.Controls.Add(this.LabelL_Volver);
            this.ButtonL_Volver.Location = new System.Drawing.Point(100, 200);
            this.ButtonL_Volver.Name = "ButtonL_Volver";
            this.ButtonL_Volver.Size = new System.Drawing.Size(150, 50);
            this.ButtonL_Volver.TabIndex = 2;
            this.ButtonL_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonL_Volver_MouseClick);
            this.ButtonL_Volver.MouseEnter += new System.EventHandler(this.ButtonL_Volver_MouseEnter);
            this.ButtonL_Volver.MouseLeave += new System.EventHandler(this.ButtonL_Volver_MouseLeave);
            // 
            // LabelL_Volver
            // 
            this.LabelL_Volver.AutoSize = true;
            this.LabelL_Volver.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelL_Volver.Location = new System.Drawing.Point(35, 14);
            this.LabelL_Volver.Name = "LabelL_Volver";
            this.LabelL_Volver.Size = new System.Drawing.Size(80, 23);
            this.LabelL_Volver.TabIndex = 1;
            this.LabelL_Volver.Text = "VOLVER";
            this.LabelL_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelL_Volver_MouseClick);
            this.LabelL_Volver.MouseEnter += new System.EventHandler(this.LabelL_Volver_MouseEnter);
            this.LabelL_Volver.MouseLeave += new System.EventHandler(this.LabelL_Volver_MouseLeave);
            // 
            // TextboxL_Pass
            // 
            this.TextboxL_Pass.BackColor = System.Drawing.Color.Silver;
            this.TextboxL_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxL_Pass.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic);
            this.TextboxL_Pass.Location = new System.Drawing.Point(75, 70);
            this.TextboxL_Pass.Name = "TextboxL_Pass";
            this.TextboxL_Pass.Size = new System.Drawing.Size(200, 23);
            this.TextboxL_Pass.TabIndex = 1;
            this.TextboxL_Pass.Text = "CONTRASEÑA";
            this.TextboxL_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxL_Pass_MouseClick);
            this.TextboxL_Pass.Enter += new System.EventHandler(this.TextboxL_Pass_Enter);
            // 
            // TextboxL_User
            // 
            this.TextboxL_User.BackColor = System.Drawing.Color.Silver;
            this.TextboxL_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxL_User.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxL_User.Location = new System.Drawing.Point(75, 30);
            this.TextboxL_User.Name = "TextboxL_User";
            this.TextboxL_User.Size = new System.Drawing.Size(200, 23);
            this.TextboxL_User.TabIndex = 0;
            this.TextboxL_User.Text = "USUARIO";
            this.TextboxL_User.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxL_User_MouseClick);
            this.TextboxL_User.Enter += new System.EventHandler(this.TextboxL_User_Enter);
            // 
            // PanelSalir
            // 
            this.PanelSalir.BackColor = System.Drawing.Color.Transparent;
            this.PanelSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSalir.BackgroundImage")));
            this.PanelSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelSalir.Controls.Add(this.ButtonSalir);
            this.PanelSalir.Location = new System.Drawing.Point(300, 582);
            this.PanelSalir.Name = "PanelSalir";
            this.PanelSalir.Size = new System.Drawing.Size(50, 50);
            this.PanelSalir.TabIndex = 7;
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Location = new System.Drawing.Point(16, 16);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(18, 18);
            this.ButtonSalir.TabIndex = 0;
            this.ButtonSalir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonSalir_MouseClick);
            // 
            // PictureboxLogo
            // 
            this.PictureboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureboxLogo.Enabled = false;
            this.PictureboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureboxLogo.Image")));
            this.PictureboxLogo.Location = new System.Drawing.Point(59, 22);
            this.PictureboxLogo.Name = "PictureboxLogo";
            this.PictureboxLogo.Size = new System.Drawing.Size(231, 250);
            this.PictureboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureboxLogo.TabIndex = 4;
            this.PictureboxLogo.TabStop = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.Gray;
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLogin.Controls.Add(this.LabelIniciar);
            this.ButtonLogin.Location = new System.Drawing.Point(100, 340);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(150, 50);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonLogin_MouseClick);
            this.ButtonLogin.MouseEnter += new System.EventHandler(this.ButtonLogin_MouseEnter);
            this.ButtonLogin.MouseLeave += new System.EventHandler(this.ButtonLogin_MouseLeave);
            // 
            // LabelIniciar
            // 
            this.LabelIniciar.AutoSize = true;
            this.LabelIniciar.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIniciar.Location = new System.Drawing.Point(38, 14);
            this.LabelIniciar.Name = "LabelIniciar";
            this.LabelIniciar.Size = new System.Drawing.Size(74, 23);
            this.LabelIniciar.TabIndex = 1;
            this.LabelIniciar.Text = "INICIAR";
            this.LabelIniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelIniciar_MouseClick);
            this.LabelIniciar.MouseEnter += new System.EventHandler(this.LabelIniciar_MouseLeave);
            this.LabelIniciar.MouseLeave += new System.EventHandler(this.LabelIniciar_MouseEnter);
            // 
            // ButtonRegistrer
            // 
            this.ButtonRegistrer.BackColor = System.Drawing.Color.Gray;
            this.ButtonRegistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRegistrer.Controls.Add(this.LabelRegistrarse);
            this.ButtonRegistrer.Location = new System.Drawing.Point(100, 400);
            this.ButtonRegistrer.Name = "ButtonRegistrer";
            this.ButtonRegistrer.Size = new System.Drawing.Size(150, 50);
            this.ButtonRegistrer.TabIndex = 6;
            this.ButtonRegistrer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRegistrer_MouseClick);
            this.ButtonRegistrer.MouseEnter += new System.EventHandler(this.ButtonRegistrer_MouseEnter);
            this.ButtonRegistrer.MouseLeave += new System.EventHandler(this.ButtonRegistrer_MouseLeave);
            // 
            // LabelRegistrarse
            // 
            this.LabelRegistrarse.AutoSize = true;
            this.LabelRegistrarse.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrarse.Location = new System.Drawing.Point(10, 14);
            this.LabelRegistrarse.Name = "LabelRegistrarse";
            this.LabelRegistrarse.Size = new System.Drawing.Size(130, 23);
            this.LabelRegistrarse.TabIndex = 1;
            this.LabelRegistrarse.Text = "REGISTRARSE";
            this.LabelRegistrarse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelRegistrarse_MouseClick);
            this.LabelRegistrarse.MouseEnter += new System.EventHandler(this.LabelRegistrarse_MouseEnter);
            this.LabelRegistrarse.MouseLeave += new System.EventHandler(this.LabelRegistrarse_MouseLeave);
            // 
            // PanelRegistrer
            // 
            this.PanelRegistrer.Controls.Add(this.LabelR_Wrong);
            this.PanelRegistrer.Controls.Add(this.TextboxR_Mail);
            this.PanelRegistrer.Controls.Add(this.ButtonR_Registrer);
            this.PanelRegistrer.Controls.Add(this.ButtonR_Volver);
            this.PanelRegistrer.Controls.Add(this.TextboxR_Pass);
            this.PanelRegistrer.Controls.Add(this.TextboxR_User);
            this.PanelRegistrer.Enabled = false;
            this.PanelRegistrer.Location = new System.Drawing.Point(0, 270);
            this.PanelRegistrer.Name = "PanelRegistrer";
            this.PanelRegistrer.Size = new System.Drawing.Size(350, 306);
            this.PanelRegistrer.TabIndex = 10;
            // 
            // LabelR_Wrong
            // 
            this.LabelR_Wrong.AutoSize = true;
            this.LabelR_Wrong.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelR_Wrong.Location = new System.Drawing.Point(95, 139);
            this.LabelR_Wrong.Name = "LabelR_Wrong";
            this.LabelR_Wrong.Size = new System.Drawing.Size(157, 18);
            this.LabelR_Wrong.TabIndex = 5;
            this.LabelR_Wrong.Text = "¿Olvidaste tus datos?";
            // 
            // TextboxR_Mail
            // 
            this.TextboxR_Mail.BackColor = System.Drawing.Color.Silver;
            this.TextboxR_Mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxR_Mail.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic);
            this.TextboxR_Mail.Location = new System.Drawing.Point(75, 110);
            this.TextboxR_Mail.Name = "TextboxR_Mail";
            this.TextboxR_Mail.Size = new System.Drawing.Size(200, 23);
            this.TextboxR_Mail.TabIndex = 4;
            this.TextboxR_Mail.Text = "CORREO";
            this.TextboxR_Mail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxR_Mail_MouseClick);
            this.TextboxR_Mail.Enter += new System.EventHandler(this.TextboxR_Mail_Enter);
            // 
            // ButtonR_Registrer
            // 
            this.ButtonR_Registrer.BackColor = System.Drawing.Color.Gray;
            this.ButtonR_Registrer.Controls.Add(this.LabelR_Registrarse);
            this.ButtonR_Registrer.Location = new System.Drawing.Point(100, 165);
            this.ButtonR_Registrer.Name = "ButtonR_Registrer";
            this.ButtonR_Registrer.Size = new System.Drawing.Size(150, 50);
            this.ButtonR_Registrer.TabIndex = 3;
            this.ButtonR_Registrer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonR_Registrer_MouseClick);
            this.ButtonR_Registrer.MouseEnter += new System.EventHandler(this.ButtonR_Registrer_MouseEnter);
            this.ButtonR_Registrer.MouseLeave += new System.EventHandler(this.ButtonR_Registrer_MouseLeave);
            // 
            // LabelR_Registrarse
            // 
            this.LabelR_Registrarse.AutoSize = true;
            this.LabelR_Registrarse.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelR_Registrarse.Location = new System.Drawing.Point(11, 13);
            this.LabelR_Registrarse.Name = "LabelR_Registrarse";
            this.LabelR_Registrarse.Size = new System.Drawing.Size(130, 23);
            this.LabelR_Registrarse.TabIndex = 0;
            this.LabelR_Registrarse.Text = "REGISTRARSE";
            this.LabelR_Registrarse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelR_Registrarse_MouseClick);
            this.LabelR_Registrarse.MouseEnter += new System.EventHandler(this.LabelR_Registrarse_MouseEnter);
            this.LabelR_Registrarse.MouseLeave += new System.EventHandler(this.LabelR_Registrarse_MouseLeave);
            // 
            // ButtonR_Volver
            // 
            this.ButtonR_Volver.BackColor = System.Drawing.Color.Gray;
            this.ButtonR_Volver.Controls.Add(this.LabelR_Volver);
            this.ButtonR_Volver.Location = new System.Drawing.Point(100, 230);
            this.ButtonR_Volver.Name = "ButtonR_Volver";
            this.ButtonR_Volver.Size = new System.Drawing.Size(150, 50);
            this.ButtonR_Volver.TabIndex = 2;
            this.ButtonR_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonR_Volver_MouseClick);
            this.ButtonR_Volver.MouseEnter += new System.EventHandler(this.ButtonR_Volver_MouseEnter);
            this.ButtonR_Volver.MouseLeave += new System.EventHandler(this.ButtonR_Volver_MouseLeave);
            // 
            // LabelR_Volver
            // 
            this.LabelR_Volver.AutoSize = true;
            this.LabelR_Volver.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.LabelR_Volver.Location = new System.Drawing.Point(37, 13);
            this.LabelR_Volver.Name = "LabelR_Volver";
            this.LabelR_Volver.Size = new System.Drawing.Size(80, 23);
            this.LabelR_Volver.TabIndex = 0;
            this.LabelR_Volver.Text = "VOLVER";
            this.LabelR_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelR_Volver_MouseClick);
            this.LabelR_Volver.MouseEnter += new System.EventHandler(this.LabelR_Volver_MouseEnter);
            this.LabelR_Volver.MouseLeave += new System.EventHandler(this.LabelR_Volver_MouseLeave);
            // 
            // TextboxR_Pass
            // 
            this.TextboxR_Pass.BackColor = System.Drawing.Color.Silver;
            this.TextboxR_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxR_Pass.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic);
            this.TextboxR_Pass.Location = new System.Drawing.Point(75, 70);
            this.TextboxR_Pass.Name = "TextboxR_Pass";
            this.TextboxR_Pass.Size = new System.Drawing.Size(200, 23);
            this.TextboxR_Pass.TabIndex = 1;
            this.TextboxR_Pass.Text = "CONTRASEÑA";
            this.TextboxR_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxR_Pass_MouseClick);
            this.TextboxR_Pass.Enter += new System.EventHandler(this.TextboxR_Pass_Enter);
            // 
            // TextboxR_User
            // 
            this.TextboxR_User.BackColor = System.Drawing.Color.Silver;
            this.TextboxR_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxR_User.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxR_User.Location = new System.Drawing.Point(75, 30);
            this.TextboxR_User.Name = "TextboxR_User";
            this.TextboxR_User.Size = new System.Drawing.Size(200, 23);
            this.TextboxR_User.TabIndex = 0;
            this.TextboxR_User.Text = "USUARIO";
            this.TextboxR_User.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxR_User_MouseClick);
            this.TextboxR_User.Enter += new System.EventHandler(this.TextboxR_User_Enter);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ButtonL_Iniciar.ResumeLayout(false);
            this.ButtonL_Iniciar.PerformLayout();
            this.ButtonL_Volver.ResumeLayout(false);
            this.ButtonL_Volver.PerformLayout();
            this.PanelSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxLogo)).EndInit();
            this.ButtonLogin.ResumeLayout(false);
            this.ButtonLogin.PerformLayout();
            this.ButtonRegistrer.ResumeLayout(false);
            this.ButtonRegistrer.PerformLayout();
            this.PanelRegistrer.ResumeLayout(false);
            this.PanelRegistrer.PerformLayout();
            this.ButtonR_Registrer.ResumeLayout(false);
            this.ButtonR_Registrer.PerformLayout();
            this.ButtonR_Volver.ResumeLayout(false);
            this.ButtonR_Volver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox PictureboxLogo;
        private System.Windows.Forms.Panel PanelSalir;
        private System.Windows.Forms.Panel ButtonRegistrer;
        private System.Windows.Forms.Panel ButtonLogin;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Panel ButtonL_Volver;
        private System.Windows.Forms.TextBox TextboxL_Pass;
        private System.Windows.Forms.TextBox TextboxL_User;
        private System.Windows.Forms.Panel ButtonL_Iniciar;
        private System.Windows.Forms.Panel PanelRegistrer;
        private System.Windows.Forms.TextBox TextboxR_Mail;
        private System.Windows.Forms.Panel ButtonR_Registrer;
        private System.Windows.Forms.Label LabelR_Registrarse;
        private System.Windows.Forms.Panel ButtonR_Volver;
        private System.Windows.Forms.Label LabelR_Volver;
        private System.Windows.Forms.TextBox TextboxR_Pass;
        private System.Windows.Forms.TextBox TextboxR_User;
        private System.Windows.Forms.Label LabelL_Forget;
        private System.Windows.Forms.Label LabelL_Wrong;
        private System.Windows.Forms.Label LabelR_Wrong;
        private System.Windows.Forms.Panel ButtonSalir;
        private System.Windows.Forms.Label LabelRegistrarse;
        private System.Windows.Forms.Label LabelIniciar;
        private System.Windows.Forms.Label LabelL_Iniciar;
        private System.Windows.Forms.Label LabelL_Volver;
    }
}

