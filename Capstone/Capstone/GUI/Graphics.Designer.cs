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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMarca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butPastelPor = new System.Windows.Forms.Button();
            this.precioMaximo = new System.Windows.Forms.Button();
            this.buttonPorCaros = new System.Windows.Forms.Button();
            this.buttPuertas = new System.Windows.Forms.Button();
            this.porcentaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.puertas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMarca
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMarca.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMarca.Legends.Add(legend4);
            this.chartMarca.Location = new System.Drawing.Point(12, 12);
            this.chartMarca.Name = "chartMarca";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartMarca.Series.Add(series4);
            this.chartMarca.Size = new System.Drawing.Size(617, 380);
            this.chartMarca.TabIndex = 0;
            this.chartMarca.Text = "chartMarca";
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
            chartArea5.Name = "ChartArea1";
            this.porcentaje.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.porcentaje.Legends.Add(legend5);
            this.porcentaje.Location = new System.Drawing.Point(12, 12);
            this.porcentaje.Name = "porcentaje";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.porcentaje.Series.Add(series5);
            this.porcentaje.Size = new System.Drawing.Size(617, 370);
            this.porcentaje.TabIndex = 5;
            this.porcentaje.Text = "chart1";
            // 
            // puertas
            // 
            chartArea6.Name = "ChartArea1";
            this.puertas.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.puertas.Legends.Add(legend6);
            this.puertas.Location = new System.Drawing.Point(12, 12);
            this.puertas.Name = "puertas";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.puertas.Series.Add(series6);
            this.puertas.Size = new System.Drawing.Size(617, 380);
            this.puertas.TabIndex = 6;
            this.puertas.Text = "puetas";
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.puertas);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.buttPuertas);
            this.Controls.Add(this.buttonPorCaros);
            this.Controls.Add(this.precioMaximo);
            this.Controls.Add(this.butPastelPor);
            this.Controls.Add(this.chartMarca);
            this.Name = "Graphics";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarca;
        private System.Windows.Forms.Button butPastelPor;
        private System.Windows.Forms.Button precioMaximo;
        private System.Windows.Forms.Button buttonPorCaros;
        private System.Windows.Forms.Button buttPuertas;
        private System.Windows.Forms.DataVisualization.Charting.Chart porcentaje;
        private System.Windows.Forms.DataVisualization.Charting.Chart puertas;
    }
}