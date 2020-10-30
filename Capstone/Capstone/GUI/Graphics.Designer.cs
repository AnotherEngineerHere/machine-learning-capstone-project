namespace Capstone.GUI
{
    partial class Graphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butPastelPor = new System.Windows.Forms.Button();
            this.precioMaximo = new System.Windows.Forms.Button();
            this.buttonPorCaros = new System.Windows.Forms.Button();
            this.buttPuertas = new System.Windows.Forms.Button();
            this.porcentaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.puntos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntos)).BeginInit();
            this.SuspendLayout();
            // 
            // barras
            // 
            chartArea1.Name = "ChartArea1";
            this.barras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barras.Legends.Add(legend1);
            this.barras.Location = new System.Drawing.Point(12, 12);
            this.barras.Name = "barras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.barras.Series.Add(series1);
            this.barras.Size = new System.Drawing.Size(617, 380);
            this.barras.TabIndex = 0;
            this.barras.Text = "barras";
            // 
            // butPastelPor
            // 
            this.butPastelPor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.butPastelPor.Location = new System.Drawing.Point(652, 29);
            this.butPastelPor.Name = "butPastelPor";
            this.butPastelPor.Size = new System.Drawing.Size(106, 23);
            this.butPastelPor.TabIndex = 1;
            this.butPastelPor.Text = "Porcentaje Marca";
            this.butPastelPor.UseVisualStyleBackColor = false;
            this.butPastelPor.Click += new System.EventHandler(this.butPastelPor_Click);
            // 
            // precioMaximo
            // 
            this.precioMaximo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.precioMaximo.Location = new System.Drawing.Point(652, 58);
            this.precioMaximo.Name = "precioMaximo";
            this.precioMaximo.Size = new System.Drawing.Size(106, 23);
            this.precioMaximo.TabIndex = 2;
            this.precioMaximo.Text = "Caros Marca";
            this.precioMaximo.UseVisualStyleBackColor = false;
            this.precioMaximo.Click += new System.EventHandler(this.precioMaximo_Click);
            // 
            // buttonPorCaros
            // 
            this.buttonPorCaros.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPorCaros.Location = new System.Drawing.Point(652, 87);
            this.buttonPorCaros.Name = "buttonPorCaros";
            this.buttonPorCaros.Size = new System.Drawing.Size(106, 23);
            this.buttonPorCaros.TabIndex = 3;
            this.buttonPorCaros.Text = "Porcentaje Caros";
            this.buttonPorCaros.UseVisualStyleBackColor = false;
            this.buttonPorCaros.Click += new System.EventHandler(this.buttonPorCaros_Click);
            // 
            // buttPuertas
            // 
            this.buttPuertas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttPuertas.Location = new System.Drawing.Point(652, 116);
            this.buttPuertas.Name = "buttPuertas";
            this.buttPuertas.Size = new System.Drawing.Size(106, 25);
            this.buttPuertas.TabIndex = 4;
            this.buttPuertas.Text = "Numero Puertas";
            this.buttPuertas.UseVisualStyleBackColor = false;
            this.buttPuertas.Click += new System.EventHandler(this.buttPuertas_Click);
            // 
            // porcentaje
            // 
            chartArea2.Name = "ChartArea1";
            this.porcentaje.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.porcentaje.Legends.Add(legend2);
            this.porcentaje.Location = new System.Drawing.Point(12, 12);
            this.porcentaje.Name = "porcentaje";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.porcentaje.Series.Add(series2);
            this.porcentaje.Size = new System.Drawing.Size(617, 370);
            this.porcentaje.TabIndex = 5;
            this.porcentaje.Text = "chart1";
            // 
            // puntos
            // 
            chartArea3.Name = "ChartArea1";
            this.puntos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.puntos.Legends.Add(legend3);
            this.puntos.Location = new System.Drawing.Point(12, 12);
            this.puntos.Name = "puntos";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.puntos.Series.Add(series3);
            this.puntos.Size = new System.Drawing.Size(617, 380);
            this.puntos.TabIndex = 6;
            this.puntos.Text = "puetas";
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.buttPuertas);
            this.Controls.Add(this.buttonPorCaros);
            this.Controls.Add(this.precioMaximo);
            this.Controls.Add(this.butPastelPor);
            this.Controls.Add(this.barras);
            this.Name = "Graphics";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart barras;
        private System.Windows.Forms.Button butPastelPor;
        private System.Windows.Forms.Button precioMaximo;
        private System.Windows.Forms.Button buttonPorCaros;
        private System.Windows.Forms.Button buttPuertas;
        private System.Windows.Forms.DataVisualization.Charting.Chart porcentaje;
        private System.Windows.Forms.DataVisualization.Charting.Chart puntos;
    }
}