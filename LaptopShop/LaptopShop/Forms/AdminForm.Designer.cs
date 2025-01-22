namespace LaptopShop
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.консультантиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top5ConsultantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top5ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10LaptopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laptopShopDataSet = new LaptopShop.LaptopShopDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.workersTableAdapter();
            this.tableAdapterManager = new LaptopShop.LaptopShopDataSetTableAdapters.TableAdapterManager();
            this.commonLabel = new System.Windows.Forms.Label();
            this.sortingCheckBox = new System.Windows.Forms.CheckBox();
            this.filtrationСheckBox = new System.Windows.Forms.CheckBox();
            this.searchingTextBox = new System.Windows.Forms.TextBox();
            this.searchingLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.консультантиToolStripMenuItem,
            this.статистикиToolStripMenuItem,
            this.звітністьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(658, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // консультантиToolStripMenuItem
            // 
            this.консультантиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewWorkersToolStripMenuItem,
            this.editWorkerToolStripMenuItem,
            this.addWorkerToolStripMenuItem,
            this.deleteWorkerToolStripMenuItem});
            this.консультантиToolStripMenuItem.Name = "консультантиToolStripMenuItem";
            this.консультантиToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.консультантиToolStripMenuItem.Text = "Робітники";
            this.консультантиToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // reviewWorkersToolStripMenuItem
            // 
            this.reviewWorkersToolStripMenuItem.Name = "reviewWorkersToolStripMenuItem";
            this.reviewWorkersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reviewWorkersToolStripMenuItem.Text = "Переглянути";
            this.reviewWorkersToolStripMenuItem.Click += new System.EventHandler(this.reviewToolStripMenuItem_Click);
            // 
            // editWorkerToolStripMenuItem
            // 
            this.editWorkerToolStripMenuItem.Name = "editWorkerToolStripMenuItem";
            this.editWorkerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editWorkerToolStripMenuItem.Text = "Редагувати";
            this.editWorkerToolStripMenuItem.Click += new System.EventHandler(this.editWorkerToolStripMenuItem_Click);
            // 
            // addWorkerToolStripMenuItem
            // 
            this.addWorkerToolStripMenuItem.Name = "addWorkerToolStripMenuItem";
            this.addWorkerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addWorkerToolStripMenuItem.Text = "Додати";
            this.addWorkerToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteWorkerToolStripMenuItem
            // 
            this.deleteWorkerToolStripMenuItem.Name = "deleteWorkerToolStripMenuItem";
            this.deleteWorkerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteWorkerToolStripMenuItem.Text = "Видалити";
            this.deleteWorkerToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // статистикиToolStripMenuItem
            // 
            this.статистикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top5ConsultantsToolStripMenuItem,
            this.top5ClientsToolStripMenuItem,
            this.top10LaptopsToolStripMenuItem});
            this.статистикиToolStripMenuItem.Name = "статистикиToolStripMenuItem";
            this.статистикиToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.статистикиToolStripMenuItem.Text = "Статистики";
            this.статистикиToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // top5ConsultantsToolStripMenuItem
            // 
            this.top5ConsultantsToolStripMenuItem.Name = "top5ConsultantsToolStripMenuItem";
            this.top5ConsultantsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.top5ConsultantsToolStripMenuItem.Text = "ТОП-5 консультантів";
            this.top5ConsultantsToolStripMenuItem.Click += new System.EventHandler(this.top5ConsultantsToolStripMenuItem_Click);
            // 
            // top5ClientsToolStripMenuItem
            // 
            this.top5ClientsToolStripMenuItem.Name = "top5ClientsToolStripMenuItem";
            this.top5ClientsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.top5ClientsToolStripMenuItem.Text = "ТОП-5 клієнтів";
            this.top5ClientsToolStripMenuItem.Click += new System.EventHandler(this.top5ClientsToolStripMenuItem_Click);
            // 
            // top10LaptopsToolStripMenuItem
            // 
            this.top10LaptopsToolStripMenuItem.Name = "top10LaptopsToolStripMenuItem";
            this.top10LaptopsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.top10LaptopsToolStripMenuItem.Text = "ТОП-10 ноутбуків";
            this.top10LaptopsToolStripMenuItem.Click += new System.EventHandler(this.top10LaptopsToolStripMenuItem_Click);
            // 
            // звітністьToolStripMenuItem
            // 
            this.звітністьToolStripMenuItem.Name = "звітністьToolStripMenuItem";
            this.звітністьToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.звітністьToolStripMenuItem.Text = "Звітність";
            // 
            // commonDataGridView
            // 
            this.commonDataGridView.AllowUserToAddRows = false;
            this.commonDataGridView.AllowUserToDeleteRows = false;
            this.commonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.commonDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.commonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commonDataGridView.Location = new System.Drawing.Point(20, 90);
            this.commonDataGridView.Name = "commonDataGridView";
            this.commonDataGridView.ReadOnly = true;
            this.commonDataGridView.Size = new System.Drawing.Size(616, 206);
            this.commonDataGridView.TabIndex = 1;
            this.commonDataGridView.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.laptopShopDataSet;
            this.bindingSource1.Position = 0;
            // 
            // laptopShopDataSet
            // 
            this.laptopShopDataSet.DataSetName = "LaptopShopDataSet";
            this.laptopShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.laptopShopDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cheksTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.displaysTableAdapter = null;
            this.tableAdapterManager.laptopsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LaptopShop.LaptopShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // commonLabel
            // 
            this.commonLabel.AutoSize = true;
            this.commonLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.commonLabel.Location = new System.Drawing.Point(19, 64);
            this.commonLabel.Name = "commonLabel";
            this.commonLabel.Size = new System.Drawing.Size(53, 20);
            this.commonLabel.TabIndex = 2;
            this.commonLabel.Text = "label1";
            this.commonLabel.Visible = false;
            // 
            // sortingCheckBox
            // 
            this.sortingCheckBox.AutoSize = true;
            this.sortingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortingCheckBox.Location = new System.Drawing.Point(460, 30);
            this.sortingCheckBox.Name = "sortingCheckBox";
            this.sortingCheckBox.Size = new System.Drawing.Size(175, 21);
            this.sortingCheckBox.TabIndex = 3;
            this.sortingCheckBox.Text = "сортувати за прізвищем";
            this.sortingCheckBox.UseVisualStyleBackColor = true;
            this.sortingCheckBox.Visible = false;
            this.sortingCheckBox.CheckedChanged += new System.EventHandler(this.sortingCheckBox_CheckedChanged);
            // 
            // filtrationСheckBox
            // 
            this.filtrationСheckBox.AutoSize = true;
            this.filtrationСheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filtrationСheckBox.Location = new System.Drawing.Point(460, 50);
            this.filtrationСheckBox.Name = "filtrationСheckBox";
            this.filtrationСheckBox.Size = new System.Drawing.Size(155, 21);
            this.filtrationСheckBox.TabIndex = 4;
            this.filtrationСheckBox.Text = "лише адміністратори";
            this.filtrationСheckBox.UseVisualStyleBackColor = true;
            this.filtrationСheckBox.Visible = false;
            this.filtrationСheckBox.CheckedChanged += new System.EventHandler(this.filtrationСheckBox_CheckedChanged);
            // 
            // searchingTextBox
            // 
            this.searchingTextBox.Location = new System.Drawing.Point(460, 3);
            this.searchingTextBox.Name = "searchingTextBox";
            this.searchingTextBox.Size = new System.Drawing.Size(163, 23);
            this.searchingTextBox.TabIndex = 5;
            this.searchingTextBox.Visible = false;
            this.searchingTextBox.TextChanged += new System.EventHandler(this.searchingTextBox_TextChanged);
            // 
            // searchingLabel
            // 
            this.searchingLabel.AutoSize = true;
            this.searchingLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.searchingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchingLabel.Location = new System.Drawing.Point(406, 5);
            this.searchingLabel.Name = "searchingLabel";
            this.searchingLabel.Size = new System.Drawing.Size(48, 17);
            this.searchingLabel.TabIndex = 6;
            this.searchingLabel.Text = "Пошук";
            this.searchingLabel.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(658, 316);
            this.Controls.Add(this.searchingLabel);
            this.Controls.Add(this.searchingTextBox);
            this.Controls.Add(this.filtrationСheckBox);
            this.Controls.Add(this.sortingCheckBox);
            this.Controls.Add(this.commonLabel);
            this.Controls.Add(this.commonDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaptopShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem консультантиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top5ConsultantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top5ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10LaptopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звітністьToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LaptopShopDataSet laptopShopDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private LaptopShopDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private LaptopShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView commonDataGridView;
        private System.Windows.Forms.ToolStripMenuItem deleteWorkerToolStripMenuItem;
        private System.Windows.Forms.Label commonLabel;
        private System.Windows.Forms.CheckBox sortingCheckBox;
        private System.Windows.Forms.CheckBox filtrationСheckBox;
        private System.Windows.Forms.TextBox searchingTextBox;
        private System.Windows.Forms.Label searchingLabel;
    }
}