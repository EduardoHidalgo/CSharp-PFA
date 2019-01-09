namespace Personal_Finance_Assistance
{
    partial class IClasifElim
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
            this.LabelCombobox = new System.Windows.Forms.Label();
            this.ComboboxClasif = new System.Windows.Forms.ComboBox();
            this.ButtonEliminar = new System.Windows.Forms.Panel();
            this.LabelButton = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCombobox
            // 
            this.LabelCombobox.AutoSize = true;
            this.LabelCombobox.BackColor = System.Drawing.Color.Transparent;
            this.LabelCombobox.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelCombobox.Location = new System.Drawing.Point(15, 15);
            this.LabelCombobox.Name = "LabelCombobox";
            this.LabelCombobox.Size = new System.Drawing.Size(267, 36);
            this.LabelCombobox.TabIndex = 7;
            this.LabelCombobox.Text = "Selecciona la clasificación que deseas\r\neliminar:";
            // 
            // ComboboxClasif
            // 
            this.ComboboxClasif.BackColor = System.Drawing.Color.Silver;
            this.ComboboxClasif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboboxClasif.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxClasif.FormattingEnabled = true;
            this.ComboboxClasif.Location = new System.Drawing.Point(18, 54);
            this.ComboboxClasif.Name = "ComboboxClasif";
            this.ComboboxClasif.Size = new System.Drawing.Size(290, 24);
            this.ComboboxClasif.TabIndex = 8;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.Gray;
            this.ButtonEliminar.Controls.Add(this.LabelButton);
            this.ButtonEliminar.Location = new System.Drawing.Point(81, 100);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(150, 50);
            this.ButtonEliminar.TabIndex = 11;
            this.ButtonEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEliminar_MouseClick);
            this.ButtonEliminar.MouseEnter += new System.EventHandler(this.ButtonEliminar_MouseEnter);
            this.ButtonEliminar.MouseLeave += new System.EventHandler(this.ButtonEliminar_MouseLeave);
            // 
            // LabelButton
            // 
            this.LabelButton.AutoSize = true;
            this.LabelButton.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelButton.Location = new System.Drawing.Point(27, 14);
            this.LabelButton.Name = "LabelButton";
            this.LabelButton.Size = new System.Drawing.Size(96, 23);
            this.LabelButton.TabIndex = 1;
            this.LabelButton.Text = "ELIMINAR";
            this.LabelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelButton_MouseClick);
            this.LabelButton.MouseEnter += new System.EventHandler(this.LabelButton_MouseEnter);
            this.LabelButton.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.Color.Transparent;
            this.LabelError.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelError.Location = new System.Drawing.Point(15, 419);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(83, 18);
            this.LabelError.TabIndex = 12;
            this.LabelError.Text = "Label Error";
            // 
            // IClasifElim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ComboboxClasif);
            this.Controls.Add(this.LabelCombobox);
            this.Name = "IClasifElim";
            this.Size = new System.Drawing.Size(323, 470);
            this.ButtonEliminar.ResumeLayout(false);
            this.ButtonEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCombobox;
        private System.Windows.Forms.ComboBox ComboboxClasif;
        private System.Windows.Forms.Panel ButtonEliminar;
        private System.Windows.Forms.Label LabelButton;
        private System.Windows.Forms.Label LabelError;
    }
}
