namespace Capstone.GUI
{
    partial class ID3Probe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ID3Probe));
            this.dataProbe = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labTittle = new System.Windows.Forms.Label();
            this.labOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProbe
            // 
            this.dataProbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProbe.Location = new System.Drawing.Point(21, 52);
            this.dataProbe.Name = "dataProbe";
            this.dataProbe.Size = new System.Drawing.Size(738, 184);
            this.dataProbe.TabIndex = 0;
            this.dataProbe.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(40, 268);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(692, 150);
            this.textBox1.TabIndex = 1;
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.BackColor = System.Drawing.Color.Transparent;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTittle.Location = new System.Drawing.Point(36, 25);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(169, 24);
            this.labTittle.TabIndex = 2;
            this.labTittle.Text = "Input Data to Probe";
            // 
            // labOut
            // 
            this.labOut.AutoSize = true;
            this.labOut.BackColor = System.Drawing.Color.Transparent;
            this.labOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labOut.Location = new System.Drawing.Point(349, 241);
            this.labOut.Name = "labOut";
            this.labOut.Size = new System.Drawing.Size(66, 24);
            this.labOut.TabIndex = 3;
            this.labOut.Text = "Output";
            // 
            // ID3Probe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labOut);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataProbe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ID3Probe";
            this.Text = "ID3Probe";
            this.Load += new System.EventHandler(this.ID3Probe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProbe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Label labOut;
    }
}