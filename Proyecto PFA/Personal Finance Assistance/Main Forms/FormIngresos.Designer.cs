namespace Personal_Finance_Assistance
{
    partial class FormIngresos
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
            this.TreeviewLista = new System.Windows.Forms.TreeView();
            this.ButtonIngresos = new System.Windows.Forms.Panel();
            this.LabelIngresos = new System.Windows.Forms.Label();
            this.ButtonEgresos = new System.Windows.Forms.Panel();
            this.LabelEgresos = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.ButtonStats = new System.Windows.Forms.Panel();
            this.LabelStats = new System.Windows.Forms.Label();
            this.ButtonMetas = new System.Windows.Forms.Panel();
            this.LabelMetas = new System.Windows.Forms.Label();
            this.PanelStats = new System.Windows.Forms.Panel();
            this.ButtonIngresos.SuspendLayout();
            this.ButtonEgresos.SuspendLayout();
            this.ButtonStats.SuspendLayout();
            this.ButtonMetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeviewLista
            // 
            this.TreeviewLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeviewLista.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.TreeviewLista.Location = new System.Drawing.Point(488, 5);
            this.TreeviewLista.Name = "TreeviewLista";
            this.TreeviewLista.Size = new System.Drawing.Size(220, 526);
            this.TreeviewLista.TabIndex = 0;
            // 
            // ButtonIngresos
            // 
            this.ButtonIngresos.BackColor = System.Drawing.Color.Gray;
            this.ButtonIngresos.Controls.Add(this.LabelIngresos);
            this.ButtonIngresos.Location = new System.Drawing.Point(5, 5);
            this.ButtonIngresos.Name = "ButtonIngresos";
            this.ButtonIngresos.Size = new System.Drawing.Size(236, 50);
            this.ButtonIngresos.TabIndex = 4;
            this.ButtonIngresos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonIngresos_MouseClick);
            this.ButtonIngresos.MouseEnter += new System.EventHandler(this.ButtonIngresos_MouseEnter);
            this.ButtonIngresos.MouseLeave += new System.EventHandler(this.ButtonIngresos_MouseLeave);
            // 
            // LabelIngresos
            // 
            this.LabelIngresos.AutoSize = true;
            this.LabelIngresos.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngresos.Location = new System.Drawing.Point(61, 13);
            this.LabelIngresos.Name = "LabelIngresos";
            this.LabelIngresos.Size = new System.Drawing.Size(99, 23);
            this.LabelIngresos.TabIndex = 0;
            this.LabelIngresos.Text = "INGRESOS";
            this.LabelIngresos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelIngresos_MouseClick);
            this.LabelIngresos.MouseEnter += new System.EventHandler(this.LabelIngresos_MouseEnter);
            this.LabelIngresos.MouseLeave += new System.EventHandler(this.LabelIngresos_MouseLeave);
            // 
            // ButtonEgresos
            // 
            this.ButtonEgresos.BackColor = System.Drawing.Color.Gray;
            this.ButtonEgresos.Controls.Add(this.LabelEgresos);
            this.ButtonEgresos.Location = new System.Drawing.Point(246, 5);
            this.ButtonEgresos.Name = "ButtonEgresos";
            this.ButtonEgresos.Size = new System.Drawing.Size(236, 50);
            this.ButtonEgresos.TabIndex = 4;
            this.ButtonEgresos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEgresos_MouseClick);
            this.ButtonEgresos.MouseEnter += new System.EventHandler(this.ButtonEgresos_MouseEnter);
            this.ButtonEgresos.MouseLeave += new System.EventHandler(this.ButtonEgresos_MouseLeave);
            // 
            // LabelEgresos
            // 
            this.LabelEgresos.AutoSize = true;
            this.LabelEgresos.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEgresos.Location = new System.Drawing.Point(77, 13);
            this.LabelEgresos.Name = "LabelEgresos";
            this.LabelEgresos.Size = new System.Drawing.Size(80, 23);
            this.LabelEgresos.TabIndex = 0;
            this.LabelEgresos.Text = "GASTOS";
            this.LabelEgresos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelEgresos_MouseClick);
            this.LabelEgresos.MouseEnter += new System.EventHandler(this.LabelEgresos_MouseEnter);
            this.LabelEgresos.MouseLeave += new System.EventHandler(this.LabelEgresos_MouseLeave);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(5, 60);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(150, 470);
            this.PanelButtons.TabIndex = 5;
            // 
            // PanelControls
            // 
            this.PanelControls.Location = new System.Drawing.Point(160, 60);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(323, 470);
            this.PanelControls.TabIndex = 6;
            // 
            // ButtonStats
            // 
            this.ButtonStats.BackColor = System.Drawing.Color.Gray;
            this.ButtonStats.Controls.Add(this.LabelStats);
            this.ButtonStats.Location = new System.Drawing.Point(955, 5);
            this.ButtonStats.Name = "ButtonStats";
            this.ButtonStats.Size = new System.Drawing.Size(236, 50);
            this.ButtonStats.TabIndex = 7;
            this.ButtonStats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonStats_MouseClick);
            this.ButtonStats.MouseEnter += new System.EventHandler(this.ButtonStats_MouseEnter);
            this.ButtonStats.MouseLeave += new System.EventHandler(this.ButtonStats_MouseLeave);
            // 
            // LabelStats
            // 
            this.LabelStats.AutoSize = true;
            this.LabelStats.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStats.Location = new System.Drawing.Point(57, 13);
            this.LabelStats.Name = "LabelStats";
            this.LabelStats.Size = new System.Drawing.Size(134, 23);
            this.LabelStats.TabIndex = 0;
            this.LabelStats.Text = "ESTADÍSTICAS";
            this.LabelStats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelStats_MouseClick);
            this.LabelStats.MouseEnter += new System.EventHandler(this.LabelStats_MouseEnter);
            this.LabelStats.MouseLeave += new System.EventHandler(this.LabelStats_MouseLeave);
            // 
            // ButtonMetas
            // 
            this.ButtonMetas.BackColor = System.Drawing.Color.Gray;
            this.ButtonMetas.Controls.Add(this.LabelMetas);
            this.ButtonMetas.Enabled = false;
            this.ButtonMetas.Location = new System.Drawing.Point(714, 5);
            this.ButtonMetas.Name = "ButtonMetas";
            this.ButtonMetas.Size = new System.Drawing.Size(236, 50);
            this.ButtonMetas.TabIndex = 8;
            this.ButtonMetas.Visible = false;
            this.ButtonMetas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonMetas_MouseClick);
            this.ButtonMetas.MouseEnter += new System.EventHandler(this.ButtonMetas_MouseEnter);
            this.ButtonMetas.MouseLeave += new System.EventHandler(this.ButtonMetas_MouseLeave);
            // 
            // LabelMetas
            // 
            this.LabelMetas.AutoSize = true;
            this.LabelMetas.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMetas.Location = new System.Drawing.Point(82, 13);
            this.LabelMetas.Name = "LabelMetas";
            this.LabelMetas.Size = new System.Drawing.Size(72, 23);
            this.LabelMetas.TabIndex = 0;
            this.LabelMetas.Text = "METAS";
            this.LabelMetas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelMetas_MouseClick);
            this.LabelMetas.MouseEnter += new System.EventHandler(this.LabelMetas_MouseEnter);
            this.LabelMetas.MouseLeave += new System.EventHandler(this.LabelMetas_MouseLeave);
            // 
            // PanelStats
            // 
            this.PanelStats.Location = new System.Drawing.Point(714, 61);
            this.PanelStats.Name = "PanelStats";
            this.PanelStats.Size = new System.Drawing.Size(477, 469);
            this.PanelStats.TabIndex = 9;
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 536);
            this.Controls.Add(this.PanelStats);
            this.Controls.Add(this.ButtonStats);
            this.Controls.Add(this.ButtonMetas);
            this.Controls.Add(this.PanelControls);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.ButtonEgresos);
            this.Controls.Add(this.ButtonIngresos);
            this.Controls.Add(this.TreeviewLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresos";
            this.Text = "FormPrincipal_Ingresos";
            this.ButtonIngresos.ResumeLayout(false);
            this.ButtonIngresos.PerformLayout();
            this.ButtonEgresos.ResumeLayout(false);
            this.ButtonEgresos.PerformLayout();
            this.ButtonStats.ResumeLayout(false);
            this.ButtonStats.PerformLayout();
            this.ButtonMetas.ResumeLayout(false);
            this.ButtonMetas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView TreeviewLista;
        private System.Windows.Forms.Panel ButtonIngresos;
        private System.Windows.Forms.Label LabelIngresos;
        private System.Windows.Forms.Panel ButtonEgresos;
        private System.Windows.Forms.Label LabelEgresos;
        public System.Windows.Forms.Panel PanelButtons;
        public System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.Panel ButtonStats;
        private System.Windows.Forms.Label LabelStats;
        private System.Windows.Forms.Panel ButtonMetas;
        private System.Windows.Forms.Label LabelMetas;
        public System.Windows.Forms.Panel PanelStats;
    }
}