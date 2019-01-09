namespace Personal_Finance_Assistance
{
    partial class GráficaIngresos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartIngresos
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartIngresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartIngresos.Legends.Add(legend1);
            this.ChartIngresos.Location = new System.Drawing.Point(3, 3);
            this.ChartIngresos.Name = "ChartIngresos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartIngresos.Series.Add(series1);
            this.ChartIngresos.Size = new System.Drawing.Size(471, 407);
            this.ChartIngresos.TabIndex = 1;
            this.ChartIngresos.Text = "chart1";
            // 
            // GráficaIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartIngresos);
            this.Name = "GráficaIngresos";
            this.Size = new System.Drawing.Size(477, 413);
            ((System.ComponentModel.ISupportInitialize)(this.ChartIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartIngresos;
    }
}
