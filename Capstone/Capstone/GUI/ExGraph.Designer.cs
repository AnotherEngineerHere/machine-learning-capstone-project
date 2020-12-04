namespace Capstone.GUI
{
    partial class ExGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.s1 = new System.Windows.Forms.Button();
            this.s2 = new System.Windows.Forms.Button();
            this.treaning = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea7.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.Graph.Legends.Add(legend7);
            this.Graph.Location = new System.Drawing.Point(12, 12);
            this.Graph.Name = "Graph";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.Graph.Series.Add(series7);
            this.Graph.Size = new System.Drawing.Size(604, 404);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // s1
            // 
            this.s1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.s1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s1.Location = new System.Drawing.Point(682, 63);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(75, 23);
            this.s1.TabIndex = 1;
            this.s1.Text = "Sample 1";
            this.s1.UseVisualStyleBackColor = false;
            this.s1.Click += new System.EventHandler(this.s1_Click);
            // 
            // s2
            // 
            this.s2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.s2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s2.Location = new System.Drawing.Point(682, 109);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(75, 23);
            this.s2.TabIndex = 2;
            this.s2.Text = "Sample 2";
            this.s2.UseVisualStyleBackColor = false;
            this.s2.Click += new System.EventHandler(this.s2_Click);
            // 
            // treaning
            // 
            this.treaning.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.treaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treaning.Location = new System.Drawing.Point(682, 151);
            this.treaning.Name = "treaning";
            this.treaning.Size = new System.Drawing.Size(75, 23);
            this.treaning.TabIndex = 3;
            this.treaning.Text = "Training";
            this.treaning.UseVisualStyleBackColor = false;
            this.treaning.Click += new System.EventHandler(this.treaning_Click);
            // 
            // ExGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treaning);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.Graph);
            this.Name = "ExGraph";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Button s1;
        private System.Windows.Forms.Button s2;
        private System.Windows.Forms.Button treaning;
    }
}