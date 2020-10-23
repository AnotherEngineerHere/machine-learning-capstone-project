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
            this.textTree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textTree
            // 
            this.textTree.Location = new System.Drawing.Point(48, 75);
            this.textTree.Multiline = true;
            this.textTree.Name = "textTree";
            this.textTree.Size = new System.Drawing.Size(686, 253);
            this.textTree.TabIndex = 0;
            // 
            // ID3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTree);
            this.Name = "ID3";
            this.Text = "ID3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTree;
    }
}