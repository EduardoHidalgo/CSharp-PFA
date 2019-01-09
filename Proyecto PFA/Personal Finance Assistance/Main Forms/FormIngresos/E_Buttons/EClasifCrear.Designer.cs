namespace Personal_Finance_Assistance
{
    partial class EClasifCrear
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
            this.LabelClasif = new System.Windows.Forms.Label();
            this.ComboboxClasif = new System.Windows.Forms.ComboBox();
            this.LabelTextbox = new System.Windows.Forms.Label();
            this.TextboxClasif = new System.Windows.Forms.TextBox();
            this.ButtonCrear = new System.Windows.Forms.Panel();
            this.LabelButton = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelClasif
            // 
            this.LabelClasif.AutoSize = true;
            this.LabelClasif.BackColor = System.Drawing.Color.Transparent;
            this.LabelClasif.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelClasif.Location = new System.Drawing.Point(15, 15);
            this.LabelClasif.Name = "LabelClasif";
            this.LabelClasif.Size = new System.Drawing.Size(294, 36);
            this.LabelClasif.TabIndex = 7;
            this.LabelClasif.Text = "Selecciona un tipo de fecha para la nueva \r\nclasificación:";
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
            // LabelTextbox
            // 
            this.LabelTextbox.AutoSize = true;
            this.LabelTextbox.BackColor = System.Drawing.Color.Transparent;
            this.LabelTextbox.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.LabelTextbox.Location = new System.Drawing.Point(15, 81);
            this.LabelTextbox.Name = "LabelTextbox";
            this.LabelTextbox.Size = new System.Drawing.Size(237, 36);
            this.LabelTextbox.TabIndex = 9;
            this.LabelTextbox.Text = "Escriba un nombre para la nueva \r\nclasificación:";
            // 
            // TextboxClasif
            // 
            this.TextboxClasif.BackColor = System.Drawing.Color.Silver;
            this.TextboxClasif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxClasif.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxClasif.Location = new System.Drawing.Point(18, 120);
            this.TextboxClasif.Name = "TextboxClasif";
            this.TextboxClasif.Size = new System.Drawing.Size(290, 23);
            this.TextboxClasif.TabIndex = 10;
            // 
            // ButtonCrear
            // 
            this.ButtonCrear.BackColor = System.Drawing.Color.Gray;
            this.ButtonCrear.Controls.Add(this.LabelButton);
            this.ButtonCrear.Location = new System.Drawing.Point(81, 157);
            this.ButtonCrear.Name = "ButtonCrear";
            this.ButtonCrear.Size = new System.Drawing.Size(150, 50);
            this.ButtonCrear.TabIndex = 11;
            this.ButtonCrear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonCrear_MouseClick);
            this.ButtonCrear.MouseEnter += new System.EventHandler(this.ButtonCrear_MouseEnter);
            this.ButtonCrear.MouseLeave += new System.EventHandler(this.ButtonCrear_MouseLeave);
            // 
            // LabelButton
            // 
            this.LabelButton.AutoSize = true;
            this.LabelButton.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelButton.Location = new System.Drawing.Point(43, 14);
            this.LabelButton.Name = "LabelButton";
            this.LabelButton.Size = new System.Drawing.Size(68, 23);
            this.LabelButton.TabIndex = 1;
            this.LabelButton.Text = "CREAR";
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
            // EClasifCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonCrear);
            this.Controls.Add(this.TextboxClasif);
            this.Controls.Add(this.LabelTextbox);
            this.Controls.Add(this.ComboboxClasif);
            this.Controls.Add(this.LabelClasif);
            this.Name = "EClasifCrear";
            this.Size = new System.Drawing.Size(323, 470);
            this.ButtonCrear.ResumeLayout(false);
            this.ButtonCrear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelClasif;
        private System.Windows.Forms.ComboBox ComboboxClasif;
        private System.Windows.Forms.Label LabelTextbox;
        private System.Windows.Forms.TextBox TextboxClasif;
        private System.Windows.Forms.Panel ButtonCrear;
        private System.Windows.Forms.Label LabelButton;
        private System.Windows.Forms.Label LabelError;
    }
}
