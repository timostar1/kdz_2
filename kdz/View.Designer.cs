namespace kdz
{
    partial class View
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.domainUpDownAutodillers = new System.Windows.Forms.DomainUpDown();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cylDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.mpgDataGridViewTextBoxColumn,
            this.cylDataGridViewTextBoxColumn,
            this.dispDataGridViewTextBoxColumn,
            this.hpDataGridViewTextBoxColumn,
            this.dratDataGridViewTextBoxColumn,
            this.wtDataGridViewTextBoxColumn,
            this.qsecDataGridViewTextBoxColumn,
            this.vsDataGridViewTextBoxColumn,
            this.amDataGridViewTextBoxColumn,
            this.gearDataGridViewTextBoxColumn,
            this.carbDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.carBindingSource;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView.Location = new System.Drawing.Point(12, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(716, 219);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(740, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewCarToolStripMenuItem
            // 
            this.addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            this.addNewCarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addNewCarToolStripMenuItem.Text = "Add new car";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // domainUpDownAutodillers
            // 
            this.domainUpDownAutodillers.Location = new System.Drawing.Point(498, 41);
            this.domainUpDownAutodillers.Name = "domainUpDownAutodillers";
            this.domainUpDownAutodillers.Size = new System.Drawing.Size(120, 20);
            this.domainUpDownAutodillers.TabIndex = 2;
            this.domainUpDownAutodillers.Text = "domainUpDown1";
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.Width = 56;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 61;
            // 
            // mpgDataGridViewTextBoxColumn
            // 
            this.mpgDataGridViewTextBoxColumn.DataPropertyName = "Mpg";
            this.mpgDataGridViewTextBoxColumn.HeaderText = "Mpg";
            this.mpgDataGridViewTextBoxColumn.Name = "mpgDataGridViewTextBoxColumn";
            this.mpgDataGridViewTextBoxColumn.Width = 53;
            // 
            // cylDataGridViewTextBoxColumn
            // 
            this.cylDataGridViewTextBoxColumn.DataPropertyName = "Cyl";
            this.cylDataGridViewTextBoxColumn.HeaderText = "Cyl";
            this.cylDataGridViewTextBoxColumn.Name = "cylDataGridViewTextBoxColumn";
            this.cylDataGridViewTextBoxColumn.Width = 46;
            // 
            // dispDataGridViewTextBoxColumn
            // 
            this.dispDataGridViewTextBoxColumn.DataPropertyName = "Disp";
            this.dispDataGridViewTextBoxColumn.HeaderText = "Disp";
            this.dispDataGridViewTextBoxColumn.Name = "dispDataGridViewTextBoxColumn";
            this.dispDataGridViewTextBoxColumn.Width = 53;
            // 
            // hpDataGridViewTextBoxColumn
            // 
            this.hpDataGridViewTextBoxColumn.DataPropertyName = "Hp";
            this.hpDataGridViewTextBoxColumn.HeaderText = "Hp";
            this.hpDataGridViewTextBoxColumn.Name = "hpDataGridViewTextBoxColumn";
            this.hpDataGridViewTextBoxColumn.Width = 46;
            // 
            // dratDataGridViewTextBoxColumn
            // 
            this.dratDataGridViewTextBoxColumn.DataPropertyName = "Drat";
            this.dratDataGridViewTextBoxColumn.HeaderText = "Drat";
            this.dratDataGridViewTextBoxColumn.Name = "dratDataGridViewTextBoxColumn";
            this.dratDataGridViewTextBoxColumn.Width = 52;
            // 
            // wtDataGridViewTextBoxColumn
            // 
            this.wtDataGridViewTextBoxColumn.DataPropertyName = "Wt";
            this.wtDataGridViewTextBoxColumn.HeaderText = "Wt";
            this.wtDataGridViewTextBoxColumn.Name = "wtDataGridViewTextBoxColumn";
            this.wtDataGridViewTextBoxColumn.Width = 46;
            // 
            // qsecDataGridViewTextBoxColumn
            // 
            this.qsecDataGridViewTextBoxColumn.DataPropertyName = "Qsec";
            this.qsecDataGridViewTextBoxColumn.HeaderText = "Qsec";
            this.qsecDataGridViewTextBoxColumn.Name = "qsecDataGridViewTextBoxColumn";
            this.qsecDataGridViewTextBoxColumn.Width = 57;
            // 
            // vsDataGridViewTextBoxColumn
            // 
            this.vsDataGridViewTextBoxColumn.DataPropertyName = "Vs";
            this.vsDataGridViewTextBoxColumn.HeaderText = "Vs";
            this.vsDataGridViewTextBoxColumn.Name = "vsDataGridViewTextBoxColumn";
            this.vsDataGridViewTextBoxColumn.Width = 44;
            // 
            // amDataGridViewTextBoxColumn
            // 
            this.amDataGridViewTextBoxColumn.DataPropertyName = "Am";
            this.amDataGridViewTextBoxColumn.HeaderText = "Am";
            this.amDataGridViewTextBoxColumn.Name = "amDataGridViewTextBoxColumn";
            this.amDataGridViewTextBoxColumn.Width = 47;
            // 
            // gearDataGridViewTextBoxColumn
            // 
            this.gearDataGridViewTextBoxColumn.DataPropertyName = "Gear";
            this.gearDataGridViewTextBoxColumn.HeaderText = "Gear";
            this.gearDataGridViewTextBoxColumn.Name = "gearDataGridViewTextBoxColumn";
            this.gearDataGridViewTextBoxColumn.Width = 55;
            // 
            // carbDataGridViewTextBoxColumn
            // 
            this.carbDataGridViewTextBoxColumn.DataPropertyName = "Carb";
            this.carbDataGridViewTextBoxColumn.HeaderText = "Carb";
            this.carbDataGridViewTextBoxColumn.Name = "carbDataGridViewTextBoxColumn";
            this.carbDataGridViewTextBoxColumn.Width = 54;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(kdz.Model.Car);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 304);
            this.Controls.Add(this.domainUpDownAutodillers);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "View";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarToolStripMenuItem;
        private System.Windows.Forms.DomainUpDown domainUpDownAutodillers;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cylDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qsecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

