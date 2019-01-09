namespace Personal_Finance_Assistance
{
    partial class EClasifModif
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
            this.LabelError = new System.Windows.Forms.Label();
            this.ComboboxClasif = new System.Windows.Forms.ComboBox();
            this.LabelCombobox = new System.Windows.Forms.Label();
            this.ButtonModificar = new System.Windows.Forms.Panel();
            this.LabelButton = new System.Windows.Forms.Label();
            this.TextboxClasif = new System.Windows.Forms.TextBox();
            this.LabelTextbox = new System.Windows.Forms.Label();
            this.ComboboxSelecc = new System.Windows.Forms.ComboBox();
            this.LabelSelecc = new System.Windows.Forms.Label();
            this.ButtonModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.Color.Transparent;
            this.LabelError.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelError.Location = new System.Drawing.Point(15, 419);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(83, 18);
            this.LabelError.TabIndex = 13;
            this.LabelError.Text = "Label Error";
            // 
            // ComboboxClasif
            // 
            this.ComboboxClasif.BackColor = System.Drawing.Color.Silver;
            this.ComboboxClasif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboboxClasif.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxClasif.FormattingEnabled = true;
            this.ComboboxClasif.Location = new System.Drawing.Point(18, 120);
            this.ComboboxClasif.Name = "ComboboxClasif";
            this.ComboboxClasif.Size = new System.Drawing.Size(290, 24);
            this.ComboboxClasif.TabIndex = 21;
            // 
            // LabelCombobox
            // 
            this.LabelCombobox.AutoSize = true;
            this.LabelCombobox.BackColor = System.Drawing.Color.Transparent;
            this.LabelCombobox.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelCombobox.Location = new System.Drawing.Point(15, 81);
            this.LabelCombobox.Name = "LabelCombobox";
            this.LabelCombobox.Size = new System.Drawing.Size(293, 36);
            this.LabelCombobox.TabIndex = 20;
            this.LabelCombobox.Text = "Selecciona un nuevo tipo de fecha para la \r\nclasificación:";
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.BackColor = System.Drawing.Color.Gray;
            this.ButtonModificar.Controls.Add(this.LabelButton);
            this.ButtonModificar.Location = new System.Drawing.Point(81, 223);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(150, 50);
            this.ButtonModificar.TabIndex = 19;
            this.ButtonModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonModificar_MouseClick);
            this.ButtonModificar.MouseEnter += new System.EventHandler(this.ButtonModificar_MouseEnter);
            this.ButtonModificar.MouseLeave += new System.EventHandler(this.ButtonModificar_MouseLeave);
            // 
            // LabelButton
            // 
            this.LabelButton.AutoSize = true;
            this.LabelButton.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelButton.Location = new System.Drawing.Point(23, 14);
            this.LabelButton.Name = "LabelButton";
            this.LabelButton.Size = new System.Drawing.Size(108, 23);
            this.LabelButton.TabIndex = 1;
            this.LabelButton.Text = "MODIFICAR";
            this.LabelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelButton_MouseClick);
            this.LabelButton.MouseEnter += new System.EventHandler(this.LabelButton_MouseEnter);
            this.LabelButton.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            // 
            // TextboxClasif
            // 
            this.TextboxClasif.BackColor = System.Drawing.Color.Silver;
            this.TextboxClasif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxClasif.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxClasif.Location = new System.Drawing.Point(18, 186);
            this.TextboxClasif.Name = "TextboxClasif";
            this.TextboxClasif.Size = new System.Drawing.Size(290, 23);
            this.TextboxClasif.TabIndex = 18;
            // 
            // LabelTextbox
            // 
            this.LabelTextbox.AutoSize = true;
            this.LabelTextbox.BackColor = System.Drawing.Color.Transparent;
            this.LabelTextbox.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelTextbox.Location = new System.Drawing.Point(15, 147);
            this.LabelTextbox.Name = "LabelTextbox";
            this.LabelTextbox.Size = new System.Drawing.Size(233, 36);
            this.LabelTextbox.TabIndex = 17;
            this.LabelTextbox.Text = "Escriba un nuevo nombre para la\r\nclasificación:";
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
            this.ComboboxSelecc.TabIndex = 16;
            // 
            // LabelSelecc
            // 
            this.LabelSelecc.AutoSize = true;
            this.LabelSelecc.BackColor = System.Drawing.Color.Transparent;
            this.LabelSelecc.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelSelecc.Location = new System.Drawing.Point(15, 15);
            this.LabelSelecc.Name = "LabelSelecc";
            this.LabelSelecc.Size = new System.Drawing.Size(269, 36);
            this.LabelSelecc.TabIndex = 15;
            this.LabelSelecc.Text = "Selecciona la clasificación que quieres\r\nmodificar:\r\n";
            // 
            // EClasifModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboboxClasif);
            this.Controls.Add(this.LabelCombobox);
            this.Controls.Add(this.ButtonModificar);
            this.Controls.Add(this.TextboxClasif);
            this.Controls.Add(this.LabelTextbox);
            this.Controls.Add(this.ComboboxSelecc);
            this.Controls.Add(this.LabelSelecc);
            this.Controls.Add(this.LabelError);
            this.Name = "EClasifModif";
            this.Size = new System.Drawing.Size(323, 470);
            this.ButtonModificar.ResumeLayout(false);
            this.ButtonModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.ComboBox ComboboxClasif;
        private System.Windows.Forms.Label LabelCombobox;
        private System.Windows.Forms.Panel ButtonModificar;
        private System.Windows.Forms.Label LabelButton;
        private System.Windows.Forms.TextBox TextboxClasif;
        private System.Windows.Forms.Label LabelTextbox;
        private System.Windows.Forms.ComboBox ComboboxSelecc;
        private System.Windows.Forms.Label LabelSelecc;
    }
}
