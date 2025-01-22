namespace LaptopShop.Forms
{
    partial class EditDisplayForm
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
            this.laptopShopDataSet = new LaptopShop.LaptopShopDataSet();
            this.diaplaysbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.displaysTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.displaysTableAdapter();
            this.formatTextBox = new System.Windows.Forms.TextBox();
            this.technologyTextBox = new System.Windows.Forms.TextBox();
            this.resolutionTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.matteCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.formatLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.matteLabel = new System.Windows.Forms.Label();
            this.technologyLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaplaysbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laptopShopDataSet
            // 
            this.laptopShopDataSet.DataSetName = "LaptopShopDataSet";
            this.laptopShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diaplaysbindingSource
            // 
            this.diaplaysbindingSource.DataMember = "displays";
            this.diaplaysbindingSource.DataSource = this.laptopShopDataSet;
            // 
            // displaysTableAdapter
            // 
            this.displaysTableAdapter.ClearBeforeFill = true;
            // 
            // formatTextBox
            // 
            this.formatTextBox.Location = new System.Drawing.Point(121, 141);
            this.formatTextBox.Name = "formatTextBox";
            this.formatTextBox.Size = new System.Drawing.Size(98, 20);
            this.formatTextBox.TabIndex = 40;
            // 
            // technologyTextBox
            // 
            this.technologyTextBox.Location = new System.Drawing.Point(121, 86);
            this.technologyTextBox.Name = "technologyTextBox";
            this.technologyTextBox.Size = new System.Drawing.Size(98, 20);
            this.technologyTextBox.TabIndex = 39;
            // 
            // resolutionTextBox
            // 
            this.resolutionTextBox.Location = new System.Drawing.Point(121, 112);
            this.resolutionTextBox.Name = "resolutionTextBox";
            this.resolutionTextBox.Size = new System.Drawing.Size(98, 20);
            this.resolutionTextBox.TabIndex = 38;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(121, 168);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(98, 20);
            this.sizeTextBox.TabIndex = 37;
            // 
            // matteCheckBox
            // 
            this.matteCheckBox.AutoSize = true;
            this.matteCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.matteCheckBox.Location = new System.Drawing.Point(123, 62);
            this.matteCheckBox.Name = "matteCheckBox";
            this.matteCheckBox.Size = new System.Drawing.Size(33, 21);
            this.matteCheckBox.TabIndex = 35;
            this.matteCheckBox.Text = "є";
            this.matteCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Редагування інформації\r\nпро дисплей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.OK_button.Location = new System.Drawing.Point(43, 200);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(149, 26);
            this.OK_button.TabIndex = 33;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.formatLabel.Location = new System.Drawing.Point(27, 142);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(58, 17);
            this.formatLabel.TabIndex = 28;
            this.formatLabel.Text = "Формат:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.sizeLabel.Location = new System.Drawing.Point(27, 171);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(52, 17);
            this.sizeLabel.TabIndex = 29;
            this.sizeLabel.Text = "Розмір:";
            // 
            // matteLabel
            // 
            this.matteLabel.AutoSize = true;
            this.matteLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.matteLabel.Location = new System.Drawing.Point(27, 63);
            this.matteLabel.Name = "matteLabel";
            this.matteLabel.Size = new System.Drawing.Size(71, 17);
            this.matteLabel.TabIndex = 30;
            this.matteLabel.Text = "Матовість:";
            // 
            // technologyLabel
            // 
            this.technologyLabel.AutoSize = true;
            this.technologyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.technologyLabel.Location = new System.Drawing.Point(27, 91);
            this.technologyLabel.Name = "technologyLabel";
            this.technologyLabel.Size = new System.Drawing.Size(77, 17);
            this.technologyLabel.TabIndex = 31;
            this.technologyLabel.Text = "Технологія:";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.resolutionLabel.Location = new System.Drawing.Point(27, 117);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(88, 17);
            this.resolutionLabel.TabIndex = 32;
            this.resolutionLabel.Text = "Розширення:";
            // 
            // EditDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 243);
            this.Controls.Add(this.formatTextBox);
            this.Controls.Add(this.technologyTextBox);
            this.Controls.Add(this.resolutionTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.matteCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.matteLabel);
            this.Controls.Add(this.technologyLabel);
            this.Controls.Add(this.resolutionLabel);
            this.Name = "EditDisplayForm";
            this.Text = "EditDisplayForm";
            this.Load += new System.EventHandler(this.EditDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaplaysbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LaptopShopDataSet laptopShopDataSet;
        private System.Windows.Forms.BindingSource diaplaysbindingSource;
        private LaptopShopDataSetTableAdapters.displaysTableAdapter displaysTableAdapter;
        private System.Windows.Forms.TextBox formatTextBox;
        private System.Windows.Forms.TextBox technologyTextBox;
        private System.Windows.Forms.TextBox resolutionTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.CheckBox matteCheckBox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label matteLabel;
        private System.Windows.Forms.Label technologyLabel;
        private System.Windows.Forms.Label resolutionLabel;
    }
}