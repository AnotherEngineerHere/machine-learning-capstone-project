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
            this.butProbe = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTree
            // 
            this.textTree.BackColor = System.Drawing.SystemColors.InfoText;
            this.textTree.ForeColor = System.Drawing.Color.Lime;
            this.textTree.Location = new System.Drawing.Point(16, 100);
            this.textTree.Multiline = true;
            this.textTree.Name = "textTree";
            this.textTree.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTree.Size = new System.Drawing.Size(813, 312);
            this.textTree.TabIndex = 0;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.Color.Transparent;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labResult.Location = new System.Drawing.Point(23, 25);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(71, 24);
            this.labResult.TabIndex = 1;
            this.labResult.Text = "Results";
            // 
            // butProbe
            // 
            this.butProbe.Location = new System.Drawing.Point(38, 419);
            this.butProbe.Name = "butProbe";
            this.butProbe.Size = new System.Drawing.Size(106, 32);
            this.butProbe.TabIndex = 3;
            this.butProbe.Text = "Probe ID3";
            this.butProbe.UseVisualStyleBackColor = true;
            this.butProbe.Visible = false;
            this.butProbe.Click += new System.EventHandler(this.butProbe_Click);
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(150, 419);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(106, 32);
            this.butRegister.TabIndex = 4;
            this.butRegister.Text = "Enter a Example";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(100, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "This window shows the output ID3 for the Training Data Set in the previous window" +
    "";
            // 
            // ID3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.butProbe);
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
        private System.Windows.Forms.Button butProbe;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Label label1;
    }
}