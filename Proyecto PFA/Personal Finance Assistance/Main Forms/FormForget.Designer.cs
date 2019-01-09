namespace Personal_Finance_Assistance
{
    partial class FormForget
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
            this.PanelForget = new System.Windows.Forms.Panel();
            this.LabelF_Wrong = new System.Windows.Forms.Label();
            this.ButtonF_Volver = new System.Windows.Forms.Panel();
            this.LabelF_Volver = new System.Windows.Forms.Label();
            this.ButtonF_Enviar = new System.Windows.Forms.Panel();
            this.LabelF_Enviar = new System.Windows.Forms.Label();
            this.TextboxF_Mail = new System.Windows.Forms.TextBox();
            this.LabelF_Text = new System.Windows.Forms.Label();
            this.PanelForget.SuspendLayout();
            this.ButtonF_Volver.SuspendLayout();
            this.ButtonF_Enviar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForget
            // 
            this.PanelForget.Controls.Add(this.LabelF_Wrong);
            this.PanelForget.Controls.Add(this.ButtonF_Volver);
            this.PanelForget.Controls.Add(this.ButtonF_Enviar);
            this.PanelForget.Controls.Add(this.TextboxF_Mail);
            this.PanelForget.Controls.Add(this.LabelF_Text);
            this.PanelForget.Location = new System.Drawing.Point(5, 5);
            this.PanelForget.Name = "PanelForget";
            this.PanelForget.Size = new System.Drawing.Size(300, 300);
            this.PanelForget.TabIndex = 0;
            // 
            // LabelF_Wrong
            // 
            this.LabelF_Wrong.AutoSize = true;
            this.LabelF_Wrong.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelF_Wrong.Location = new System.Drawing.Point(72, 112);
            this.LabelF_Wrong.Name = "LabelF_Wrong";
            this.LabelF_Wrong.Size = new System.Drawing.Size(157, 18);
            this.LabelF_Wrong.TabIndex = 10;
            this.LabelF_Wrong.Text = "¿Olvidaste tus datos?";
            // 
            // ButtonF_Volver
            // 
            this.ButtonF_Volver.BackColor = System.Drawing.Color.Gray;
            this.ButtonF_Volver.Controls.Add(this.LabelF_Volver);
            this.ButtonF_Volver.Location = new System.Drawing.Point(75, 220);
            this.ButtonF_Volver.Name = "ButtonF_Volver";
            this.ButtonF_Volver.Size = new System.Drawing.Size(150, 50);
            this.ButtonF_Volver.TabIndex = 9;
            this.ButtonF_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonF_Volver_MouseClick);
            this.ButtonF_Volver.MouseEnter += new System.EventHandler(this.ButtonF_Volver_MouseEnter);
            this.ButtonF_Volver.MouseLeave += new System.EventHandler(this.ButtonF_Volver_MouseLeave);
            // 
            // LabelF_Volver
            // 
            this.LabelF_Volver.AutoSize = true;
            this.LabelF_Volver.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelF_Volver.Location = new System.Drawing.Point(35, 14);
            this.LabelF_Volver.Name = "LabelF_Volver";
            this.LabelF_Volver.Size = new System.Drawing.Size(80, 23);
            this.LabelF_Volver.TabIndex = 0;
            this.LabelF_Volver.Text = "VOLVER";
            this.LabelF_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelF_Volver_MouseClick);
            this.LabelF_Volver.MouseEnter += new System.EventHandler(this.LabelF_Volver_MouseEnter);
            this.LabelF_Volver.MouseLeave += new System.EventHandler(this.LabelF_Volver_MouseLeave);
            // 
            // ButtonF_Enviar
            // 
            this.ButtonF_Enviar.BackColor = System.Drawing.Color.Gray;
            this.ButtonF_Enviar.Controls.Add(this.LabelF_Enviar);
            this.ButtonF_Enviar.Location = new System.Drawing.Point(75, 155);
            this.ButtonF_Enviar.Name = "ButtonF_Enviar";
            this.ButtonF_Enviar.Size = new System.Drawing.Size(150, 50);
            this.ButtonF_Enviar.TabIndex = 8;
            this.ButtonF_Enviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonF_Enviar_MouseClick);
            this.ButtonF_Enviar.MouseEnter += new System.EventHandler(this.ButtonF_Enviar_MouseEnter);
            this.ButtonF_Enviar.MouseLeave += new System.EventHandler(this.ButtonF_Enviar_MouseLeave);
            // 
            // LabelF_Enviar
            // 
            this.LabelF_Enviar.AutoSize = true;
            this.LabelF_Enviar.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelF_Enviar.Location = new System.Drawing.Point(37, 13);
            this.LabelF_Enviar.Name = "LabelF_Enviar";
            this.LabelF_Enviar.Size = new System.Drawing.Size(76, 23);
            this.LabelF_Enviar.TabIndex = 0;
            this.LabelF_Enviar.Text = "ENVIAR";
            this.LabelF_Enviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelF_Enviar_MouseClick);
            this.LabelF_Enviar.MouseEnter += new System.EventHandler(this.LabelF_Enviar_MouseEnter);
            this.LabelF_Enviar.MouseLeave += new System.EventHandler(this.LabelF_Enviar_MouseLeave);
            // 
            // TextboxF_Mail
            // 
            this.TextboxF_Mail.BackColor = System.Drawing.Color.Silver;
            this.TextboxF_Mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxF_Mail.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic);
            this.TextboxF_Mail.Location = new System.Drawing.Point(54, 86);
            this.TextboxF_Mail.Name = "TextboxF_Mail";
            this.TextboxF_Mail.Size = new System.Drawing.Size(200, 23);
            this.TextboxF_Mail.TabIndex = 7;
            this.TextboxF_Mail.Text = "USUARIO";
            this.TextboxF_Mail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxF_Mail_MouseClick);
            this.TextboxF_Mail.Enter += new System.EventHandler(this.TextboxF_Mail_Enter);
            // 
            // LabelF_Text
            // 
            this.LabelF_Text.AutoSize = true;
            this.LabelF_Text.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelF_Text.Location = new System.Drawing.Point(20, 17);
            this.LabelF_Text.Name = "LabelF_Text";
            this.LabelF_Text.Size = new System.Drawing.Size(253, 54);
            this.LabelF_Text.TabIndex = 6;
            this.LabelF_Text.Text = "Escriba su  nombre de usuario para \r\nenviarle al correo proporcionado en \r\nel reg" +
    "istro sus datos de Login:";
            // 
            // FormForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 310);
            this.Controls.Add(this.PanelForget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOut";
            this.PanelForget.ResumeLayout(false);
            this.PanelForget.PerformLayout();
            this.ButtonF_Volver.ResumeLayout(false);
            this.ButtonF_Volver.PerformLayout();
            this.ButtonF_Enviar.ResumeLayout(false);
            this.ButtonF_Enviar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForget;
        private System.Windows.Forms.Label LabelF_Text;
        private System.Windows.Forms.TextBox TextboxF_Mail;
        private System.Windows.Forms.Panel ButtonF_Volver;
        private System.Windows.Forms.Label LabelF_Volver;
        private System.Windows.Forms.Panel ButtonF_Enviar;
        private System.Windows.Forms.Label LabelF_Enviar;
        private System.Windows.Forms.Label LabelF_Wrong;
    }
}