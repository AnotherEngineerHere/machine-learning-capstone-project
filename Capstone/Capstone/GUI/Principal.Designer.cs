

namespace DesicionTree_CapstoneProject
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.labWelcome = new System.Windows.Forms.Label();
            this.butLoad = new System.Windows.Forms.Button();
            this.dataCar = new System.Windows.Forms.DataGridView();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.labCategories = new System.Windows.Forms.Label();
            this.ComboMultiple = new System.Windows.Forms.ComboBox();
            this.labFilter = new System.Windows.Forms.Label();
            this.butAcceptar = new System.Windows.Forms.Button();
            this.butAll = new System.Windows.Forms.Button();
            this.labMin = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.labMax = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butGraf = new System.Windows.Forms.Button();
            this.butTree = new System.Windows.Forms.Button();
            this.butExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labWelcome.Location = new System.Drawing.Point(34, 37);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(347, 24);
            this.labWelcome.TabIndex = 1;
            this.labWelcome.Text = "Welcome to the ID3 managemet system!";
            // 
            // butLoad
            // 
            this.butLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLoad.Location = new System.Drawing.Point(48, 480);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(103, 34);
            this.butLoad.TabIndex = 2;
            this.butLoad.Text = "Load Data";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // dataCar
            // 
            this.dataCar.AllowUserToAddRows = false;
            this.dataCar.AllowUserToDeleteRows = false;
            this.dataCar.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCar.Location = new System.Drawing.Point(27, 68);
            this.dataCar.Name = "dataCar";
            this.dataCar.ReadOnly = true;
            this.dataCar.Size = new System.Drawing.Size(670, 390);
            this.dataCar.TabIndex = 3;
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(762, 87);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(206, 21);
            this.CategoriesCB.TabIndex = 4;
            this.CategoriesCB.Visible = false;
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // labCategories
            // 
            this.labCategories.AutoSize = true;
            this.labCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCategories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labCategories.Location = new System.Drawing.Point(759, 68);
            this.labCategories.Name = "labCategories";
            this.labCategories.Size = new System.Drawing.Size(74, 16);
            this.labCategories.TabIndex = 5;
            this.labCategories.Text = "Categories";
            this.labCategories.Visible = false;
            // 
            // ComboMultiple
            // 
            this.ComboMultiple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMultiple.FormattingEnabled = true;
            this.ComboMultiple.Location = new System.Drawing.Point(762, 163);
            this.ComboMultiple.Name = "ComboMultiple";
            this.ComboMultiple.Size = new System.Drawing.Size(206, 21);
            this.ComboMultiple.TabIndex = 6;
            this.ComboMultiple.Visible = false;
            // 
            // labFilter
            // 
            this.labFilter.AutoSize = true;
            this.labFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labFilter.Location = new System.Drawing.Point(759, 133);
            this.labFilter.Name = "labFilter";
            this.labFilter.Size = new System.Drawing.Size(129, 16);
            this.labFilter.TabIndex = 7;
            this.labFilter.Text = "Filter/Search/Range";
            this.labFilter.Visible = false;
            // 
            // butAcceptar
            // 
            this.butAcceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAcceptar.Location = new System.Drawing.Point(762, 211);
            this.butAcceptar.Name = "butAcceptar";
            this.butAcceptar.Size = new System.Drawing.Size(86, 26);
            this.butAcceptar.TabIndex = 8;
            this.butAcceptar.Text = "Ok";
            this.butAcceptar.UseVisualStyleBackColor = true;
            this.butAcceptar.Visible = false;
            this.butAcceptar.Click += new System.EventHandler(this.butAcceptar_Click);
            // 
            // butAll
            // 
            this.butAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAll.Location = new System.Drawing.Point(157, 480);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(103, 34);
            this.butAll.TabIndex = 9;
            this.butAll.Text = "All Data";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Visible = false;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labMin.Location = new System.Drawing.Point(762, 170);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(29, 16);
            this.labMin.TabIndex = 10;
            this.labMin.Text = "Min";
            this.labMin.Visible = false;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(797, 166);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(50, 20);
            this.textMin.TabIndex = 11;
            this.textMin.Visible = false;
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labMax.Location = new System.Drawing.Point(853, 170);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(33, 16);
            this.labMax.TabIndex = 12;
            this.labMax.Text = "Max";
            this.labMax.Visible = false;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(892, 166);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(50, 20);
            this.textMax.TabIndex = 13;
            this.textMax.Visible = false;
            // 
            // textSearch
            // 
            this.textSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textSearch.Location = new System.Drawing.Point(762, 164);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(206, 20);
            this.textSearch.TabIndex = 14;
            this.textSearch.Visible = false;
            // 
            // butGraf
            // 
            this.butGraf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGraf.Location = new System.Drawing.Point(266, 480);
            this.butGraf.Name = "butGraf";
            this.butGraf.Size = new System.Drawing.Size(103, 34);
            this.butGraf.TabIndex = 15;
            this.butGraf.Text = "Graphics";
            this.butGraf.UseVisualStyleBackColor = true;
            this.butGraf.Visible = false;
            this.butGraf.Click += new System.EventHandler(this.butGraf_Click);
            // 
            // butTree
            // 
            this.butTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butTree.Location = new System.Drawing.Point(375, 480);
            this.butTree.Name = "butTree";
            this.butTree.Size = new System.Drawing.Size(103, 34);
            this.butTree.TabIndex = 16;
            this.butTree.Text = "ID3-ID3 Accord";
            this.butTree.UseVisualStyleBackColor = true;
            this.butTree.Visible = false;
            this.butTree.Click += new System.EventHandler(this.butTree_Click);
            // 
            // butExp
            // 
            this.butExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExp.Location = new System.Drawing.Point(484, 480);
            this.butExp.Name = "butExp";
            this.butExp.Size = new System.Drawing.Size(103, 34);
            this.butExp.TabIndex = 17;
            this.butExp.Text = "Experiment";
            this.butExp.UseVisualStyleBackColor = true;
            this.butExp.Visible = false;
            this.butExp.Click += new System.EventHandler(this.butExp_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 542);
            this.Controls.Add(this.butExp);
            this.Controls.Add(this.butTree);
            this.Controls.Add(this.butGraf);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.labMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.butAll);
            this.Controls.Add(this.butAcceptar);
            this.Controls.Add(this.labFilter);
            this.Controls.Add(this.ComboMultiple);
            this.Controls.Add(this.labCategories);
            this.Controls.Add(this.CategoriesCB);
            this.Controls.Add(this.dataCar);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.labWelcome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labWelcome;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.DataGridView dataCar;
        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.Label labCategories;
        private System.Windows.Forms.ComboBox ComboMultiple;
        private System.Windows.Forms.Label labFilter;
        private System.Windows.Forms.Button butAcceptar;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Label labMax;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butGraf;
        private System.Windows.Forms.Button butTree;
        private System.Windows.Forms.Button butExp;
    }
}

