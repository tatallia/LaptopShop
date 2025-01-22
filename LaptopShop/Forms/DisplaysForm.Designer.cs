namespace LaptopShop.Forms
{
    partial class DisplaysForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaysForm));
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortingCheckBox = new System.Windows.Forms.CheckBox();
            this.dropButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.displayidDataGridViewTextBoxColumn,
            this.matteDataGridViewCheckBoxColumn,
            this.technologyDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.displaysBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(563, 310);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(563, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // displayidDataGridViewTextBoxColumn
            // 
            this.displayidDataGridViewTextBoxColumn.DataPropertyName = "display_id";
            this.displayidDataGridViewTextBoxColumn.FillWeight = 85.38461F;
            this.displayidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.displayidDataGridViewTextBoxColumn.Name = "displayidDataGridViewTextBoxColumn";
            this.displayidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matteDataGridViewCheckBoxColumn
            // 
            this.matteDataGridViewCheckBoxColumn.DataPropertyName = "matte";
            this.matteDataGridViewCheckBoxColumn.FillWeight = 87.81792F;
            this.matteDataGridViewCheckBoxColumn.HeaderText = "Матовість";
            this.matteDataGridViewCheckBoxColumn.Name = "matteDataGridViewCheckBoxColumn";
            this.matteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "technology";
            this.technologyDataGridViewTextBoxColumn.FillWeight = 120.2782F;
            this.technologyDataGridViewTextBoxColumn.HeaderText = "Технологія";
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            this.technologyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
            this.resolutionDataGridViewTextBoxColumn.FillWeight = 129.8782F;
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Розширення";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.FillWeight = 83.47416F;
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Розмір";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "format_";
            this.formatDataGridViewTextBoxColumn.FillWeight = 93.16685F;
            this.formatDataGridViewTextBoxColumn.HeaderText = "Формат";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(597, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Матовість:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пошук за розміром:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(598, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 23);
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sortingCheckBox
            // 
            this.sortingCheckBox.AutoSize = true;
            this.sortingCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sortingCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.sortingCheckBox.Location = new System.Drawing.Point(598, 121);
            this.sortingCheckBox.Name = "sortingCheckBox";
            this.sortingCheckBox.Size = new System.Drawing.Size(118, 38);
            this.sortingCheckBox.TabIndex = 13;
            this.sortingCheckBox.Text = "сортувати \r\nза технологією";
            this.sortingCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sortingCheckBox.UseVisualStyleBackColor = true;
            this.sortingCheckBox.CheckedChanged += new System.EventHandler(this.sortingCheckBox_CheckedChanged);
            // 
            // dropButton
            // 
            this.dropButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dropButton.Location = new System.Drawing.Point(602, 11);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(129, 30);
            this.dropButton.TabIndex = 20;
            this.dropButton.Text = "Скинути фільтри";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.editButton.Location = new System.Drawing.Point(602, 46);
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
            this.addButton.Location = new System.Drawing.Point(602, 82);
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
            this.panel1.Location = new System.Drawing.Point(-3, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 121);
            this.panel1.TabIndex = 21;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.filterComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "так",
            "ні"});
            this.filterComboBox.Location = new System.Drawing.Point(598, 83);
            this.filterComboBox.MaximumSize = new System.Drawing.Size(132, 0);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(132, 24);
            this.filterComboBox.TabIndex = 16;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // DisplaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sortingCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(766, 373);
            this.MinimumSize = new System.Drawing.Size(766, 373);
            this.Name = "DisplaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисплеї";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox sortingCheckBox;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}