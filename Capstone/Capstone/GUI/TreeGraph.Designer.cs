namespace Capstone.GUI
{
    partial class TreeGraph
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
            this.id3 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // id3
            // 
            this.id3.Location = new System.Drawing.Point(89, 48);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(603, 332);
            this.id3.TabIndex = 0;
            // 
            // TreeGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id3);
            this.Name = "TreeGraph";
            this.Text = "TreeGraph";
            this.Load += new System.EventHandler(this.TreeGraph_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView id3;
    }
}