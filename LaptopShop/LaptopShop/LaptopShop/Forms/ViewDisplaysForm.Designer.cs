namespace LaptopShop.Forms
{
    partial class ViewDisplaysForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.technologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laptopShopDataSet = new LaptopShop.LaptopShopDataSet();
            this.displaysTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.displaysTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortingCheckBox = new System.Windows.Forms.CheckBox();
            this.dropButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.displayidDataGridViewTextBoxColumn,
            this.matteDataGridViewCheckBoxColumn,
            this.technologyDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.displaysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // displayidDataGridViewTextBoxColumn
            // 
            this.displayidDataGridViewTextBoxColumn.DataPropertyName = "display_id";
            this.displayidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.displayidDataGridViewTextBoxColumn.Name = "displayidDataGridViewTextBoxColumn";
            this.displayidDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayidDataGridViewTextBoxColumn.Width = 66;
            // 
            // matteDataGridViewCheckBoxColumn
            // 
            this.matteDataGridViewCheckBoxColumn.DataPropertyName = "matte";
            this.matteDataGridViewCheckBoxColumn.HeaderText = "Матовість";
            this.matteDataGridViewCheckBoxColumn.Name = "matteDataGridViewCheckBoxColumn";
            this.matteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.matteDataGridViewCheckBoxColumn.Width = 64;
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "technology";
            this.technologyDataGridViewTextBoxColumn.HeaderText = "Технологія";
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            this.technologyDataGridViewTextBoxColumn.ReadOnly = true;
            this.technologyDataGridViewTextBoxColumn.Width = 87;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Розширення";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Width = 95;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Розмір";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 67;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "format_";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Формат";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatDataGridViewTextBoxColumn.Width = 74;
            // 
            // displaysBindingSource
            // 
            this.displaysBindingSource.DataMember = "displays";
            this.displaysBindingSource.DataSource = this.laptopShopDataSet;
            // 
            // laptopShopDataSet
            // 
            this.laptopShopDataSet.DataSetName = "LaptopShopDataSet";
            this.laptopShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // displaysTableAdapter
            // 
            this.displaysTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(529, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Виробник:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.filterComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(530, 83);
            this.filterComboBox.MaximumSize = new System.Drawing.Size(132, 0);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(132, 24);
            this.filterComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(527, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пошук за моделлю:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(530, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 23);
            this.searchTextBox.TabIndex = 14;
            // 
            // sortingCheckBox
            // 
            this.sortingCheckBox.AutoSize = true;
            this.sortingCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.sortingCheckBox.Location = new System.Drawing.Point(530, 121);
            this.sortingCheckBox.Name = "sortingCheckBox";
            this.sortingCheckBox.Size = new System.Drawing.Size(146, 21);
            this.sortingCheckBox.TabIndex = 13;
            this.sortingCheckBox.Text = "сортувати за ціною";
            this.sortingCheckBox.UseVisualStyleBackColor = true;
            // 
            // dropButton
            // 
            this.dropButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dropButton.Location = new System.Drawing.Point(537, 11);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(129, 30);
            this.dropButton.TabIndex = 20;
            this.dropButton.Text = "Скинути фільтри";
            this.dropButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.editButton.Location = new System.Drawing.Point(537, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(129, 30);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.addButton.Location = new System.Drawing.Point(537, 82);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 30);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.dropButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Location = new System.Drawing.Point(-6, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 121);
            this.panel1.TabIndex = 21;
            // 
            // ViewDisplaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 302);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sortingCheckBox);
            this.Name = "ViewDisplaysForm";
            this.Text = "ViewDisplaysForm";
            this.Load += new System.EventHandler(this.ViewDisplaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LaptopShopDataSet laptopShopDataSet;
        private System.Windows.Forms.BindingSource displaysBindingSource;
        private LaptopShopDataSetTableAdapters.displaysTableAdapter displaysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn matteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox sortingCheckBox;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
    }
}