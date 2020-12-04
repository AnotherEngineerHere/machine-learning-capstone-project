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
            this.labResult = new System.Windows.Forms.Label();
            this.butProbe = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeData = new System.Windows.Forms.TreeView();
            this.radID3 = new System.Windows.Forms.RadioButton();
            this.radID3N = new System.Windows.Forms.RadioButton();
            this.butShow = new System.Windows.Forms.Button();
            this.butAccord = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.butProbe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butProbe.Location = new System.Drawing.Point(38, 390);
            this.butProbe.Name = "butProbe";
            this.butProbe.Size = new System.Drawing.Size(106, 32);
            this.butProbe.TabIndex = 3;
            this.butProbe.Text = "Probe ID3-Blood";
            this.butProbe.UseVisualStyleBackColor = true;
            this.butProbe.Visible = false;
            this.butProbe.Click += new System.EventHandler(this.butProbe_Click);
            // 
            // butRegister
            // 
            this.butRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRegister.Location = new System.Drawing.Point(262, 390);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(127, 32);
            this.butRegister.TabIndex = 4;
            this.butRegister.Text = "Enter A Example(B-A)";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Visible = false;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(62, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "This window shows the output ID3 for the Training Data Set in the previous window" +
    "";
            // 
            // treeData
            // 
            this.treeData.Location = new System.Drawing.Point(27, 90);
            this.treeData.Name = "treeData";
            this.treeData.Size = new System.Drawing.Size(728, 294);
            this.treeData.TabIndex = 6;
            // 
            // radID3
            // 
            this.radID3.AutoSize = true;
            this.radID3.BackColor = System.Drawing.Color.Transparent;
            this.radID3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radID3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radID3.Location = new System.Drawing.Point(767, 112);
            this.radID3.Name = "radID3";
            this.radID3.Size = new System.Drawing.Size(142, 24);
            this.radID3.TabIndex = 7;
            this.radID3.TabStop = true;
            this.radID3.Text = "ID3 with blood";
            this.radID3.UseVisualStyleBackColor = false;
            // 
            // radID3N
            // 
            this.radID3N.AutoSize = true;
            this.radID3N.BackColor = System.Drawing.Color.Transparent;
            this.radID3N.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radID3N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radID3N.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radID3N.Location = new System.Drawing.Point(767, 142);
            this.radID3N.Name = "radID3N";
            this.radID3N.Size = new System.Drawing.Size(117, 24);
            this.radID3N.TabIndex = 8;
            this.radID3N.TabStop = true;
            this.radID3N.Text = "ID3 Accord";
            this.radID3N.UseVisualStyleBackColor = false;
            // 
            // butShow
            // 
            this.butShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShow.Location = new System.Drawing.Point(761, 172);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(106, 32);
            this.butShow.TabIndex = 9;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butAccord
            // 
            this.butAccord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAccord.Location = new System.Drawing.Point(150, 390);
            this.butAccord.Name = "butAccord";
            this.butAccord.Size = new System.Drawing.Size(106, 32);
            this.butAccord.TabIndex = 10;
            this.butAccord.Text = "Probe ID3-Acoord";
            this.butAccord.UseVisualStyleBackColor = true;
            this.butAccord.Click += new System.EventHandler(this.butAccord_Click);
            // 
            // ID3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 464);
            this.Controls.Add(this.butAccord);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.radID3N);
            this.Controls.Add(this.radID3);
            this.Controls.Add(this.treeData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.butProbe);
            this.Controls.Add(this.labResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ID3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button butProbe;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeData;
        private System.Windows.Forms.RadioButton radID3;
        private System.Windows.Forms.RadioButton radID3N;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butAccord;
    }
}