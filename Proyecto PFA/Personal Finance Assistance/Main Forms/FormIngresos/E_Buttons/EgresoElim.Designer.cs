namespace Personal_Finance_Assistance
{
    partial class EgresoElim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonEliminar = new System.Windows.Forms.Panel();
            this.LabelEliminar = new System.Windows.Forms.Label();
            this.ComboboxSelecc = new System.Windows.Forms.ComboBox();
            this.LabelSelecc = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.Gray;
            this.ButtonEliminar.Controls.Add(this.LabelEliminar);
            this.ButtonEliminar.Location = new System.Drawing.Point(86, 100);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(150, 50);
            this.ButtonEliminar.TabIndex = 27;
            this.ButtonEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEliminar_MouseClick);
            this.ButtonEliminar.MouseEnter += new System.EventHandler(this.ButtonEliminar_MouseEnter);
            this.ButtonEliminar.MouseLeave += new System.EventHandler(this.ButtonEliminar_MouseLeave);
            // 
            // LabelEliminar
            // 
            this.LabelEliminar.AutoSize = true;
            this.LabelEliminar.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEliminar.Location = new System.Drawing.Point(27, 14);
            this.LabelEliminar.Name = "LabelEliminar";
            this.LabelEliminar.Size = new System.Drawing.Size(96, 23);
            this.LabelEliminar.TabIndex = 1;
            this.LabelEliminar.Text = "ELIMINAR";
            this.LabelEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelEliminar_MouseClick);
            this.LabelEliminar.MouseEnter += new System.EventHandler(this.LabelEliminar_MouseEnter);
            this.LabelEliminar.MouseLeave += new System.EventHandler(this.LabelEliminar_MouseLeave);
            // 
            // ComboboxSelecc
            // 
            this.ComboboxSelecc.BackColor = System.Drawing.Color.Silver;
            this.ComboboxSelecc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboboxSelecc.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxSelecc.FormattingEnabled = true;
            this.ComboboxSelecc.Location = new System.Drawing.Point(18, 54);
            this.ComboboxSelecc.Name = "ComboboxSelecc";
            this.ComboboxSelecc.Size = new System.Drawing.Size(290, 24);
            this.ComboboxSelecc.TabIndex = 26;
            // 
            // LabelSelecc
            // 
            this.LabelSelecc.AutoSize = true;
            this.LabelSelecc.BackColor = System.Drawing.Color.Transparent;
            this.LabelSelecc.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelSelecc.Location = new System.Drawing.Point(15, 33);
            this.LabelSelecc.Name = "LabelSelecc";
            this.LabelSelecc.Size = new System.Drawing.Size(244, 18);
            this.LabelSelecc.TabIndex = 25;
            this.LabelSelecc.Text = "Selecciona un gasto para eliminar:";
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.Color.Transparent;
            this.LabelError.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelError.Location = new System.Drawing.Point(15, 419);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(83, 18);
            this.LabelError.TabIndex = 28;
            this.LabelError.Text = "Label Error";
            // 
            // EgresoElim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ComboboxSelecc);
            this.Controls.Add(this.LabelSelecc);
            this.Name = "EgresoElim";
            this.Size = new System.Drawing.Size(323, 470);
            this.ButtonEliminar.ResumeLayout(false);
            this.ButtonEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonEliminar;
        private System.Windows.Forms.Label LabelEliminar;
        private System.Windows.Forms.ComboBox ComboboxSelecc;
        private System.Windows.Forms.Label LabelSelecc;
        private System.Windows.Forms.Label LabelError;
    }
}
