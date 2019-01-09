namespace Personal_Finance_Assistance
{
    partial class FormOut
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
            this.PanelSalir = new System.Windows.Forms.Panel();
            this.ButtonOut_Salir = new System.Windows.Forms.Panel();
            this.LabelSalir = new System.Windows.Forms.Label();
            this.ButtonOut_Volver = new System.Windows.Forms.Panel();
            this.LabelVolver = new System.Windows.Forms.Label();
            this.LabelAsk = new System.Windows.Forms.Label();
            this.PanelSalir.SuspendLayout();
            this.ButtonOut_Salir.SuspendLayout();
            this.ButtonOut_Volver.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSalir
            // 
            this.PanelSalir.Controls.Add(this.ButtonOut_Salir);
            this.PanelSalir.Controls.Add(this.ButtonOut_Volver);
            this.PanelSalir.Controls.Add(this.LabelAsk);
            this.PanelSalir.Location = new System.Drawing.Point(5, 5);
            this.PanelSalir.Name = "PanelSalir";
            this.PanelSalir.Size = new System.Drawing.Size(250, 250);
            this.PanelSalir.TabIndex = 0;
            // 
            // ButtonOut_Salir
            // 
            this.ButtonOut_Salir.BackColor = System.Drawing.Color.Gray;
            this.ButtonOut_Salir.Controls.Add(this.LabelSalir);
            this.ButtonOut_Salir.Location = new System.Drawing.Point(50, 160);
            this.ButtonOut_Salir.Name = "ButtonOut_Salir";
            this.ButtonOut_Salir.Size = new System.Drawing.Size(150, 50);
            this.ButtonOut_Salir.TabIndex = 5;
            this.ButtonOut_Salir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonF_Salir_MouseClick);
            this.ButtonOut_Salir.MouseEnter += new System.EventHandler(this.ButtonF_Salir_MouseEnter);
            this.ButtonOut_Salir.MouseLeave += new System.EventHandler(this.ButtonF_Salir_MouseLeave);
            // 
            // LabelSalir
            // 
            this.LabelSalir.AutoSize = true;
            this.LabelSalir.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSalir.Location = new System.Drawing.Point(45, 13);
            this.LabelSalir.Name = "LabelSalir";
            this.LabelSalir.Size = new System.Drawing.Size(60, 23);
            this.LabelSalir.TabIndex = 0;
            this.LabelSalir.Text = "SALIR";
            this.LabelSalir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSalir_MouseClick);
            this.LabelSalir.MouseEnter += new System.EventHandler(this.LabelSalir_MouseEnter);
            this.LabelSalir.MouseLeave += new System.EventHandler(this.LabelSalir_MouseLeave);
            // 
            // ButtonOut_Volver
            // 
            this.ButtonOut_Volver.BackColor = System.Drawing.Color.Gray;
            this.ButtonOut_Volver.Controls.Add(this.LabelVolver);
            this.ButtonOut_Volver.Location = new System.Drawing.Point(50, 100);
            this.ButtonOut_Volver.Name = "ButtonOut_Volver";
            this.ButtonOut_Volver.Size = new System.Drawing.Size(150, 50);
            this.ButtonOut_Volver.TabIndex = 4;
            this.ButtonOut_Volver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonF_Volver_MouseClick);
            this.ButtonOut_Volver.MouseEnter += new System.EventHandler(this.ButtonF_Volver_MouseEnter);
            this.ButtonOut_Volver.MouseLeave += new System.EventHandler(this.ButtonF_Volver_MouseLeave);
            // 
            // LabelVolver
            // 
            this.LabelVolver.AutoSize = true;
            this.LabelVolver.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolver.Location = new System.Drawing.Point(36, 13);
            this.LabelVolver.Name = "LabelVolver";
            this.LabelVolver.Size = new System.Drawing.Size(80, 23);
            this.LabelVolver.TabIndex = 0;
            this.LabelVolver.Text = "VOLVER";
            this.LabelVolver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelVolver_MouseClick);
            this.LabelVolver.MouseEnter += new System.EventHandler(this.LabelVolver_MouseEnter);
            this.LabelVolver.MouseLeave += new System.EventHandler(this.LabelVolver_MouseLeave);
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelAsk.Location = new System.Drawing.Point(10, 25);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(228, 18);
            this.LabelAsk.TabIndex = 0;
            this.LabelAsk.Text = "¿Estás seguro que deseas salir?";
            // 
            // FormOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 260);
            this.Controls.Add(this.PanelSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForget";
            this.PanelSalir.ResumeLayout(false);
            this.PanelSalir.PerformLayout();
            this.ButtonOut_Salir.ResumeLayout(false);
            this.ButtonOut_Salir.PerformLayout();
            this.ButtonOut_Volver.ResumeLayout(false);
            this.ButtonOut_Volver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSalir;
        private System.Windows.Forms.Label LabelAsk;
        private System.Windows.Forms.Panel ButtonOut_Salir;
        private System.Windows.Forms.Label LabelSalir;
        private System.Windows.Forms.Panel ButtonOut_Volver;
        private System.Windows.Forms.Label LabelVolver;
    }
}