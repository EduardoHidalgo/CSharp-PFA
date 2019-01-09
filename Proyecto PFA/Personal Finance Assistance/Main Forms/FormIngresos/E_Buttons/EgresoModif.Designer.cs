namespace Personal_Finance_Assistance
{
    partial class EgresoModif
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
            this.ButtonCrear = new System.Windows.Forms.Panel();
            this.LabelButton = new System.Windows.Forms.Label();
            this.LabelDatetime = new System.Windows.Forms.Label();
            this.TextboxCrear = new System.Windows.Forms.TextBox();
            this.LabelCrear = new System.Windows.Forms.Label();
            this.DateTimeCrear = new System.Windows.Forms.DateTimePicker();
            this.LabelClasif = new System.Windows.Forms.Label();
            this.ComboboxClasif = new System.Windows.Forms.ComboBox();
            this.ComboboxSelecc = new System.Windows.Forms.ComboBox();
            this.LabelSelecc = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCrear
            // 
            this.ButtonCrear.BackColor = System.Drawing.Color.Gray;
            this.ButtonCrear.Controls.Add(this.LabelButton);
            this.ButtonCrear.Location = new System.Drawing.Point(80, 290);
            this.ButtonCrear.Name = "ButtonCrear";
            this.ButtonCrear.Size = new System.Drawing.Size(150, 50);
            this.ButtonCrear.TabIndex = 19;
            this.ButtonCrear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonCrear_MouseClick);
            this.ButtonCrear.MouseEnter += new System.EventHandler(this.ButtonCrear_MouseEnter);
            this.ButtonCrear.MouseLeave += new System.EventHandler(this.ButtonCrear_MouseLeave);
            // 
            // LabelButton
            // 
            this.LabelButton.AutoSize = true;
            this.LabelButton.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelButton.Location = new System.Drawing.Point(21, 14);
            this.LabelButton.Name = "LabelButton";
            this.LabelButton.Size = new System.Drawing.Size(108, 23);
            this.LabelButton.TabIndex = 1;
            this.LabelButton.Text = "MODIFICAR";
            this.LabelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelButton_MouseClick);
            this.LabelButton.MouseEnter += new System.EventHandler(this.LabelButton_MouseEnter);
            this.LabelButton.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            // 
            // LabelDatetime
            // 
            this.LabelDatetime.AutoSize = true;
            this.LabelDatetime.BackColor = System.Drawing.Color.Transparent;
            this.LabelDatetime.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelDatetime.Location = new System.Drawing.Point(15, 213);
            this.LabelDatetime.Name = "LabelDatetime";
            this.LabelDatetime.Size = new System.Drawing.Size(290, 36);
            this.LabelDatetime.TabIndex = 18;
            this.LabelDatetime.Text = "Selecciona la fecha en la que obtuviste tu\r\ngasto:";
            // 
            // TextboxCrear
            // 
            this.TextboxCrear.BackColor = System.Drawing.Color.Silver;
            this.TextboxCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxCrear.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxCrear.Location = new System.Drawing.Point(17, 187);
            this.TextboxCrear.Name = "TextboxCrear";
            this.TextboxCrear.Size = new System.Drawing.Size(290, 23);
            this.TextboxCrear.TabIndex = 17;
            // 
            // LabelCrear
            // 
            this.LabelCrear.AutoSize = true;
            this.LabelCrear.BackColor = System.Drawing.Color.Transparent;
            this.LabelCrear.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelCrear.Location = new System.Drawing.Point(15, 166);
            this.LabelCrear.Name = "LabelCrear";
            this.LabelCrear.Size = new System.Drawing.Size(266, 36);
            this.LabelCrear.TabIndex = 16;
            this.LabelCrear.Text = "Escriba un monto nuevo para el gasto\r\n:";
            // 
            // DateTimeCrear
            // 
            this.DateTimeCrear.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeCrear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeCrear.Location = new System.Drawing.Point(17, 252);
            this.DateTimeCrear.Name = "DateTimeCrear";
            this.DateTimeCrear.Size = new System.Drawing.Size(291, 23);
            this.DateTimeCrear.TabIndex = 13;
            // 
            // LabelClasif
            // 
            this.LabelClasif.AutoSize = true;
            this.LabelClasif.BackColor = System.Drawing.Color.Transparent;
            this.LabelClasif.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelClasif.Location = new System.Drawing.Point(14, 81);
            this.LabelClasif.Name = "LabelClasif";
            this.LabelClasif.Size = new System.Drawing.Size(250, 36);
            this.LabelClasif.TabIndex = 14;
            this.LabelClasif.Text = "Selecciona una clasificación para el\r\ngasto:";
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
            this.ComboboxClasif.TabIndex = 15;
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
            this.ComboboxSelecc.TabIndex = 21;
            // 
            // LabelSelecc
            // 
            this.LabelSelecc.AutoSize = true;
            this.LabelSelecc.BackColor = System.Drawing.Color.Transparent;
            this.LabelSelecc.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelSelecc.Location = new System.Drawing.Point(15, 33);
            this.LabelSelecc.Name = "LabelSelecc";
            this.LabelSelecc.Size = new System.Drawing.Size(253, 18);
            this.LabelSelecc.TabIndex = 20;
            this.LabelSelecc.Text = "Selecciona un gasto para modificar:";
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.Color.Transparent;
            this.LabelError.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelError.Location = new System.Drawing.Point(15, 419);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(83, 18);
            this.LabelError.TabIndex = 22;
            this.LabelError.Text = "Label Error";
            // 
            // EgresoModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ComboboxSelecc);
            this.Controls.Add(this.LabelSelecc);
            this.Controls.Add(this.ButtonCrear);
            this.Controls.Add(this.LabelDatetime);
            this.Controls.Add(this.TextboxCrear);
            this.Controls.Add(this.LabelCrear);
            this.Controls.Add(this.ComboboxClasif);
            this.Controls.Add(this.LabelClasif);
            this.Controls.Add(this.DateTimeCrear);
            this.Name = "EgresoModif";
            this.Size = new System.Drawing.Size(323, 470);
            this.ButtonCrear.ResumeLayout(false);
            this.ButtonCrear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonCrear;
        private System.Windows.Forms.Label LabelButton;
        private System.Windows.Forms.Label LabelDatetime;
        private System.Windows.Forms.TextBox TextboxCrear;
        private System.Windows.Forms.Label LabelCrear;
        private System.Windows.Forms.DateTimePicker DateTimeCrear;
        private System.Windows.Forms.Label LabelClasif;
        private System.Windows.Forms.ComboBox ComboboxClasif;
        private System.Windows.Forms.ComboBox ComboboxSelecc;
        private System.Windows.Forms.Label LabelSelecc;
        private System.Windows.Forms.Label LabelError;
    }
}
