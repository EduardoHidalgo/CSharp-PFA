namespace Personal_Finance_Assistance
{
    partial class Stats
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
            this.ComboboxStats = new System.Windows.Forms.ComboBox();
            this.PanelStats = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ComboboxStats
            // 
            this.ComboboxStats.BackColor = System.Drawing.Color.Silver;
            this.ComboboxStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboboxStats.Font = new System.Drawing.Font("Exo 2", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxStats.FormattingEnabled = true;
            this.ComboboxStats.Location = new System.Drawing.Point(25, 12);
            this.ComboboxStats.Name = "ComboboxStats";
            this.ComboboxStats.Size = new System.Drawing.Size(427, 33);
            this.ComboboxStats.TabIndex = 10;
            this.ComboboxStats.SelectedIndexChanged += new System.EventHandler(this.ComboboxStats_SelectedIndexChanged);
            // 
            // PanelStats
            // 
            this.PanelStats.Location = new System.Drawing.Point(0, 56);
            this.PanelStats.Name = "PanelStats";
            this.PanelStats.Size = new System.Drawing.Size(477, 413);
            this.PanelStats.TabIndex = 11;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelStats);
            this.Controls.Add(this.ComboboxStats);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(477, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboboxStats;
        private System.Windows.Forms.Panel PanelStats;
    }
}
