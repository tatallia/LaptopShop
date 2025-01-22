namespace LaptopShop.Forms
{
    partial class LaptopsForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.sortingCheckBox = new System.Windows.Forms.CheckBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.laptopShopDataSet = new LaptopShop.LaptopShopDataSet();
            this.laptopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laptopsTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.laptopsTableAdapter();
            this.laptopsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.laptopsTableAdapter1 = new LaptopShop.LaptopShopDataSetTableAdapters.laptopsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dropButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.makeCheckButton = new System.Windows.Forms.Button();
            this.addInChekButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopsBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.editButton.Location = new System.Drawing.Point(764, 42);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(129, 30);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.addButton.Location = new System.Drawing.Point(764, 78);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.deleteButton.Location = new System.Drawing.Point(764, 114);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // sortingCheckBox
            // 
            this.sortingCheckBox.AutoSize = true;
            this.sortingCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.sortingCheckBox.Location = new System.Drawing.Point(571, 15);
            this.sortingCheckBox.Name = "sortingCheckBox";
            this.sortingCheckBox.Size = new System.Drawing.Size(146, 21);
            this.sortingCheckBox.TabIndex = 4;
            this.sortingCheckBox.Text = "сортувати за ціною";
            this.sortingCheckBox.UseVisualStyleBackColor = true;
            this.sortingCheckBox.CheckedChanged += new System.EventHandler(this.sortingCheckBox_CheckedChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(156, 13);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(154, 23);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пошук за моделлю:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(731, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // laptopShopDataSet
            // 
            this.laptopShopDataSet.DataSetName = "LaptopShopDataSet";
            this.laptopShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laptopsBindingSource
            // 
            this.laptopsBindingSource.DataMember = "laptops";
            this.laptopsBindingSource.DataSource = this.laptopShopDataSet;
            // 
            // laptopsTableAdapter
            // 
            this.laptopsTableAdapter.ClearBeforeFill = true;
            // 
            // laptopsBindingSource1
            // 
            this.laptopsBindingSource1.DataMember = "laptops";
            this.laptopsBindingSource1.DataSource = this.laptopShopDataSet;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.filterComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(405, 11);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(132, 24);
            this.filterComboBox.TabIndex = 8;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // laptopsTableAdapter1
            // 
            this.laptopsTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.dropButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Location = new System.Drawing.Point(-1, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 155);
            this.panel2.TabIndex = 11;
            // 
            // dropButton
            // 
            this.dropButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dropButton.Location = new System.Drawing.Point(764, 7);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(129, 30);
            this.dropButton.TabIndex = 4;
            this.dropButton.Text = "Скинути фільтри";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(326, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Виробник:";
            // 
            // makeCheckButton
            // 
            this.makeCheckButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.makeCheckButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.makeCheckButton.Location = new System.Drawing.Point(763, 44);
            this.makeCheckButton.Name = "makeCheckButton";
            this.makeCheckButton.Size = new System.Drawing.Size(129, 30);
            this.makeCheckButton.TabIndex = 13;
            this.makeCheckButton.Text = "Сформувати чек";
            this.makeCheckButton.UseVisualStyleBackColor = false;
            this.makeCheckButton.Click += new System.EventHandler(this.makeCheckButton_Click);
            // 
            // addInChekButton
            // 
            this.addInChekButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addInChekButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.addInChekButton.Location = new System.Drawing.Point(761, 80);
            this.addInChekButton.Name = "addInChekButton";
            this.addInChekButton.Size = new System.Drawing.Size(129, 30);
            this.addInChekButton.TabIndex = 14;
            this.addInChekButton.Text = "Додати у чек";
            this.addInChekButton.UseVisualStyleBackColor = false;
            this.addInChekButton.Visible = false;
            this.addInChekButton.Click += new System.EventHandler(this.addInChekButton_Click);
            // 
            // LaptopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 428);
            this.Controls.Add(this.addInChekButton);
            this.Controls.Add(this.makeCheckButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sortingCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(902, 428);
            this.MinimumSize = new System.Drawing.Size(902, 428);
            this.Name = "LaptopsForm";
            this.Text = "LaptopsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopsBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckBox sortingCheckBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private LaptopShopDataSet laptopShopDataSet;
        private System.Windows.Forms.BindingSource laptopsBindingSource;
        private LaptopShopDataSetTableAdapters.laptopsTableAdapter laptopsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource laptopsBindingSource1;
        private System.Windows.Forms.ComboBox filterComboBox;
        private LaptopShopDataSetTableAdapters.laptopsTableAdapter laptopsTableAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button makeCheckButton;
        private System.Windows.Forms.Button addInChekButton;
    }
}