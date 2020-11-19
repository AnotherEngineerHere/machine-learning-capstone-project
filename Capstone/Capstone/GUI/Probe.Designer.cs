namespace Capstone.GUI
{
    partial class Probe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Probe));
            this.dataProbe = new System.Windows.Forms.DataGridView();
            this.textProbe = new System.Windows.Forms.TextBox();
            this.labIn = new System.Windows.Forms.Label();
            this.labOu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProbe
            // 
            this.dataProbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProbe.Location = new System.Drawing.Point(114, 46);
            this.dataProbe.Name = "dataProbe";
            this.dataProbe.Size = new System.Drawing.Size(661, 212);
            this.dataProbe.TabIndex = 0;
            // 
            // textProbe
            // 
            this.textProbe.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textProbe.ForeColor = System.Drawing.Color.Aquamarine;
            this.textProbe.Location = new System.Drawing.Point(97, 288);
            this.textProbe.Multiline = true;
            this.textProbe.Name = "textProbe";
            this.textProbe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textProbe.Size = new System.Drawing.Size(703, 184);
            this.textProbe.TabIndex = 1;
            // 
            // labIn
            // 
            this.labIn.AutoSize = true;
            this.labIn.BackColor = System.Drawing.Color.Transparent;
            this.labIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labIn.Location = new System.Drawing.Point(394, 9);
            this.labIn.Name = "labIn";
            this.labIn.Size = new System.Drawing.Size(107, 24);
            this.labIn.TabIndex = 2;
            this.labIn.Text = "Input Probe";
            // 
            // labOu
            // 
            this.labOu.AutoSize = true;
            this.labOu.BackColor = System.Drawing.Color.Transparent;
            this.labOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labOu.Location = new System.Drawing.Point(420, 261);
            this.labOu.Name = "labOu";
            this.labOu.Size = new System.Drawing.Size(66, 24);
            this.labOu.TabIndex = 3;
            this.labOu.Text = "Output";
            // 
            // Probe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 495);
            this.Controls.Add(this.labOu);
            this.Controls.Add(this.labIn);
            this.Controls.Add(this.textProbe);
            this.Controls.Add(this.dataProbe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Probe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probe";
            ((System.ComponentModel.ISupportInitialize)(this.dataProbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProbe;
        private System.Windows.Forms.TextBox textProbe;
        private System.Windows.Forms.Label labIn;
        private System.Windows.Forms.Label labOu;
    }
}