namespace Personal_Finance_Assistance
{
    partial class GráficaEgresos
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
            this.ChartEgresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartEgresos
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartEgresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartEgresos.Legends.Add(legend1);
            this.ChartEgresos.Location = new System.Drawing.Point(3, 3);
            this.ChartEgresos.Name = "ChartEgresos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartEgresos.Series.Add(series1);
            this.ChartEgresos.Size = new System.Drawing.Size(471, 407);
            this.ChartEgresos.TabIndex = 0;
            this.ChartEgresos.Text = "chart1";
            // 
            // GráficaEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartEgresos);
            this.Name = "GráficaEgresos";
            this.Size = new System.Drawing.Size(477, 413);
            ((System.ComponentModel.ISupportInitialize)(this.ChartEgresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartEgresos;
    }
}
