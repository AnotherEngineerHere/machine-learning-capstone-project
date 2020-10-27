namespace Capstone.GUI
{
    partial class ID3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ID3));
            this.textTree = new System.Windows.Forms.TextBox();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTree
            // 
            this.textTree.BackColor = System.Drawing.SystemColors.InfoText;
            this.textTree.ForeColor = System.Drawing.Color.Lime;
            this.textTree.Location = new System.Drawing.Point(12, 60);
            this.textTree.Multiline = true;
            this.textTree.Name = "textTree";
            this.textTree.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTree.Size = new System.Drawing.Size(534, 177);
            this.textTree.TabIndex = 0;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.Color.AliceBlue;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labResult.Image = ((System.Drawing.Image)(resources.GetObject("labResult.Image")));
            this.labResult.Location = new System.Drawing.Point(12, 24);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(71, 24);
            this.labResult.TabIndex = 1;
            this.labResult.Text = "Results";
            // 
            // ID3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 463);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.textTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ID3";
            this.Text = "ID3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTree;
        private System.Windows.Forms.Label labResult;
    }
}