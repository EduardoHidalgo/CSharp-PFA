namespace Personal_Finance_Assistance
{
    partial class FormConfig
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
            this.PanelConfigs = new System.Windows.Forms.Panel();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonUser = new System.Windows.Forms.Panel();
            this.LabelUser = new System.Windows.Forms.Label();
            this.ButtonTheme = new System.Windows.Forms.Panel();
            this.LabelTheme = new System.Windows.Forms.Label();
            this.ButtonLenguaje = new System.Windows.Forms.Panel();
            this.LabelLenguaje = new System.Windows.Forms.Label();
            this.PanelButtons.SuspendLayout();
            this.ButtonUser.SuspendLayout();
            this.ButtonTheme.SuspendLayout();
            this.ButtonLenguaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelConfigs
            // 
            this.PanelConfigs.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelConfigs.Location = new System.Drawing.Point(0, 0);
            this.PanelConfigs.Name = "PanelConfigs";
            this.PanelConfigs.Size = new System.Drawing.Size(950, 536);
            this.PanelConfigs.TabIndex = 0;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonUser);
            this.PanelButtons.Controls.Add(this.ButtonTheme);
            this.PanelButtons.Controls.Add(this.ButtonLenguaje);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelButtons.Location = new System.Drawing.Point(956, 0);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(240, 536);
            this.PanelButtons.TabIndex = 1;
            // 
            // ButtonUser
            // 
            this.ButtonUser.BackColor = System.Drawing.Color.Gray;
            this.ButtonUser.Controls.Add(this.LabelUser);
            this.ButtonUser.Location = new System.Drawing.Point(2, 118);
            this.ButtonUser.Name = "ButtonUser";
            this.ButtonUser.Size = new System.Drawing.Size(236, 50);
            this.ButtonUser.TabIndex = 7;
            this.ButtonUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonUser_MouseClick);
            this.ButtonUser.MouseEnter += new System.EventHandler(this.ButtonUser_MouseEnter);
            this.ButtonUser.MouseLeave += new System.EventHandler(this.ButtonUser_MouseLeave);
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(19, 13);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(191, 23);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "DATOS DEL USUARIO";
            this.LabelUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelUser_MouseClick);
            this.LabelUser.MouseEnter += new System.EventHandler(this.LabelUser_MouseEnter);
            this.LabelUser.MouseLeave += new System.EventHandler(this.LabelUser_MouseLeave);
            // 
            // ButtonTheme
            // 
            this.ButtonTheme.BackColor = System.Drawing.Color.Gray;
            this.ButtonTheme.Controls.Add(this.LabelTheme);
            this.ButtonTheme.Location = new System.Drawing.Point(2, 62);
            this.ButtonTheme.Name = "ButtonTheme";
            this.ButtonTheme.Size = new System.Drawing.Size(236, 50);
            this.ButtonTheme.TabIndex = 9;
            this.ButtonTheme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonTheme_MouseClick);
            this.ButtonTheme.MouseEnter += new System.EventHandler(this.ButtonTheme_MouseEnter);
            this.ButtonTheme.MouseLeave += new System.EventHandler(this.ButtonTheme_MouseLeave);
            // 
            // LabelTheme
            // 
            this.LabelTheme.AutoSize = true;
            this.LabelTheme.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTheme.Location = new System.Drawing.Point(81, 13);
            this.LabelTheme.Name = "LabelTheme";
            this.LabelTheme.Size = new System.Drawing.Size(72, 23);
            this.LabelTheme.TabIndex = 0;
            this.LabelTheme.Text = "TEMAS";
            this.LabelTheme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelTheme_MouseClick);
            this.LabelTheme.MouseEnter += new System.EventHandler(this.LabelTheme_MouseEnter);
            this.LabelTheme.MouseLeave += new System.EventHandler(this.LabelTheme_MouseLeave);
            // 
            // ButtonLenguaje
            // 
            this.ButtonLenguaje.BackColor = System.Drawing.Color.Gray;
            this.ButtonLenguaje.Controls.Add(this.LabelLenguaje);
            this.ButtonLenguaje.Location = new System.Drawing.Point(2, 6);
            this.ButtonLenguaje.Name = "ButtonLenguaje";
            this.ButtonLenguaje.Size = new System.Drawing.Size(236, 50);
            this.ButtonLenguaje.TabIndex = 8;
            this.ButtonLenguaje.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonLenguaje_MouseClick);
            this.ButtonLenguaje.MouseEnter += new System.EventHandler(this.ButtonLenguaje_MouseEnter);
            this.ButtonLenguaje.MouseLeave += new System.EventHandler(this.ButtonLenguaje_MouseLeave);
            // 
            // LabelLenguaje
            // 
            this.LabelLenguaje.AutoSize = true;
            this.LabelLenguaje.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLenguaje.Location = new System.Drawing.Point(63, 13);
            this.LabelLenguaje.Name = "LabelLenguaje";
            this.LabelLenguaje.Size = new System.Drawing.Size(111, 23);
            this.LabelLenguaje.TabIndex = 0;
            this.LabelLenguaje.Text = "LENGUAJES";
            this.LabelLenguaje.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelLenguaje_MouseClick);
            this.LabelLenguaje.MouseEnter += new System.EventHandler(this.LabelLenguaje_MouseEnter);
            this.LabelLenguaje.MouseLeave += new System.EventHandler(this.LabelLenguaje_MouseLeave);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 536);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PanelConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.PanelButtons.ResumeLayout(false);
            this.ButtonUser.ResumeLayout(false);
            this.ButtonUser.PerformLayout();
            this.ButtonTheme.ResumeLayout(false);
            this.ButtonTheme.PerformLayout();
            this.ButtonLenguaje.ResumeLayout(false);
            this.ButtonLenguaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelConfigs;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel ButtonUser;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Panel ButtonTheme;
        private System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.Panel ButtonLenguaje;
        private System.Windows.Forms.Label LabelLenguaje;
    }
}