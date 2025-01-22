namespace LaptopShop.Forms
{
    partial class EditLaptopForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lookButton = new System.Windows.Forms.Button();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.textBox_HD_cap = new System.Windows.Forms.TextBox();
            this.textBox_RAM = new System.Windows.Forms.TextBox();
            this.textBox_Processor = new System.Windows.Forms.TextBox();
            this.textBox_Producer = new System.Windows.Forms.TextBox();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.textBox_VideoCard = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Color = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.textBox_Features = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Guarantee = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox_Display = new System.Windows.Forms.ComboBox();
            this.displaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laptopShopDataSet = new LaptopShop.LaptopShopDataSet();
            this.displaysTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.displaysTableAdapter();
            this.laptopsTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.laptopsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.displaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(21, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Об\'єм жорст-\r\nкого диску";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label5.Location = new System.Drawing.Point(21, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ОЗП";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label6.Location = new System.Drawing.Point(21, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Процесор";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label7.Location = new System.Drawing.Point(21, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Виробник";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label8.Location = new System.Drawing.Point(21, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Кількість";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label9.Location = new System.Drawing.Point(22, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Вага";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label10.Location = new System.Drawing.Point(22, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Розмір";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label11.Location = new System.Drawing.Point(21, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Колір";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label12.Location = new System.Drawing.Point(21, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Номер дисплею";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label13.Location = new System.Drawing.Point(21, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Відеокарта";
            // 
            // lookButton
            // 
            this.lookButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lookButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.lookButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lookButton.Location = new System.Drawing.Point(262, 284);
            this.lookButton.Name = "lookButton";
            this.lookButton.Size = new System.Drawing.Size(39, 24);
            this.lookButton.TabIndex = 15;
            this.lookButton.Text = "Див.";
            this.lookButton.UseVisualStyleBackColor = true;
            this.lookButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(135, 64);
            this.textBox_Model.MaxLength = 167;
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(121, 20);
            this.textBox_Model.TabIndex = 16;
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(135, 208);
            this.textBox_Size.MaxLength = 7;
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(121, 20);
            this.textBox_Size.TabIndex = 17;
            // 
            // textBox_HD_cap
            // 
            this.textBox_HD_cap.Location = new System.Drawing.Point(135, 169);
            this.textBox_HD_cap.MaxLength = 67;
            this.textBox_HD_cap.Name = "textBox_HD_cap";
            this.textBox_HD_cap.Size = new System.Drawing.Size(121, 20);
            this.textBox_HD_cap.TabIndex = 18;
            // 
            // textBox_RAM
            // 
            this.textBox_RAM.Location = new System.Drawing.Point(135, 143);
            this.textBox_RAM.MaxLength = 5;
            this.textBox_RAM.Name = "textBox_RAM";
            this.textBox_RAM.Size = new System.Drawing.Size(121, 20);
            this.textBox_RAM.TabIndex = 19;
            this.textBox_RAM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_RAM_KeyPress);
            // 
            // textBox_Processor
            // 
            this.textBox_Processor.Location = new System.Drawing.Point(135, 115);
            this.textBox_Processor.MaxLength = 167;
            this.textBox_Processor.Name = "textBox_Processor";
            this.textBox_Processor.Size = new System.Drawing.Size(121, 20);
            this.textBox_Processor.TabIndex = 20;
            // 
            // textBox_Producer
            // 
            this.textBox_Producer.Location = new System.Drawing.Point(135, 90);
            this.textBox_Producer.MaxLength = 167;
            this.textBox_Producer.Name = "textBox_Producer";
            this.textBox_Producer.Size = new System.Drawing.Size(121, 20);
            this.textBox_Producer.TabIndex = 21;
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(135, 233);
            this.textBox_Weight.MaxLength = 7;
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(121, 20);
            this.textBox_Weight.TabIndex = 22;
            this.textBox_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Weight_KeyPress);
            // 
            // textBox_VideoCard
            // 
            this.textBox_VideoCard.Location = new System.Drawing.Point(135, 258);
            this.textBox_VideoCard.MaxLength = 200;
            this.textBox_VideoCard.Name = "textBox_VideoCard";
            this.textBox_VideoCard.Size = new System.Drawing.Size(121, 20);
            this.textBox_VideoCard.TabIndex = 23;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(135, 387);
            this.textBox_Amount.MaxLength = 4;
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(121, 20);
            this.textBox_Amount.TabIndex = 24;
            this.textBox_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Amount_KeyPress);
            // 
            // textBox_Color
            // 
            this.textBox_Color.Location = new System.Drawing.Point(135, 308);
            this.textBox_Color.MaxLength = 27;
            this.textBox_Color.Name = "textBox_Color";
            this.textBox_Color.Size = new System.Drawing.Size(121, 20);
            this.textBox_Color.TabIndex = 25;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(135, 412);
            this.textBox_Price.MaxLength = 15;
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(121, 20);
            this.textBox_Price.TabIndex = 26;
            this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Інформація про ноутбук";
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.OK_button.Location = new System.Drawing.Point(95, 443);
            this.OK_button.Margin = new System.Windows.Forms.Padding(1);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(135, 29);
            this.OK_button.TabIndex = 28;
            this.OK_button.Text = "ОК";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // textBox_Features
            // 
            this.textBox_Features.Location = new System.Drawing.Point(135, 334);
            this.textBox_Features.MaxLength = 200;
            this.textBox_Features.Name = "textBox_Features";
            this.textBox_Features.Size = new System.Drawing.Size(121, 20);
            this.textBox_Features.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label15.Location = new System.Drawing.Point(21, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Особливості";
            // 
            // textBox_Guarantee
            // 
            this.textBox_Guarantee.Location = new System.Drawing.Point(135, 362);
            this.textBox_Guarantee.MaxLength = 200;
            this.textBox_Guarantee.Name = "textBox_Guarantee";
            this.textBox_Guarantee.Size = new System.Drawing.Size(121, 20);
            this.textBox_Guarantee.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label16.Location = new System.Drawing.Point(21, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Гарантія";
            // 
            // comboBox_Display
            // 
            this.comboBox_Display.DataSource = this.displaysBindingSource;
            this.comboBox_Display.DisplayMember = "display_id";
            this.comboBox_Display.FormattingEnabled = true;
            this.comboBox_Display.Location = new System.Drawing.Point(135, 284);
            this.comboBox_Display.Name = "comboBox_Display";
            this.comboBox_Display.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Display.TabIndex = 33;
            this.comboBox_Display.ValueMember = "display_id";
            // 
            // displaysBindingSource
            // 
            this.displaysBindingSource.DataMember = "displays";
            this.displaysBindingSource.DataSource = this.bindingSource1;
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
            // displaysTableAdapter
            // 
            this.displaysTableAdapter.ClearBeforeFill = true;
            // 
            // laptopsTableAdapter
            // 
            this.laptopsTableAdapter.ClearBeforeFill = true;
            // 
            // EditLaptopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 490);
            this.Controls.Add(this.comboBox_Display);
            this.Controls.Add(this.textBox_Guarantee);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_Features);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Color);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.textBox_VideoCard);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.textBox_Producer);
            this.Controls.Add(this.textBox_Processor);
            this.Controls.Add(this.textBox_RAM);
            this.Controls.Add(this.textBox_HD_cap);
            this.Controls.Add(this.textBox_Size);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.lookButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLaptopForm";
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.displaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button lookButton;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.TextBox textBox_HD_cap;
        private System.Windows.Forms.TextBox textBox_RAM;
        private System.Windows.Forms.TextBox textBox_Processor;
        private System.Windows.Forms.TextBox textBox_Producer;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.TextBox textBox_VideoCard;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_Color;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox textBox_Features;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Guarantee;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_Display;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LaptopShopDataSet laptopShopDataSet;
        private System.Windows.Forms.BindingSource displaysBindingSource;
        private LaptopShopDataSetTableAdapters.displaysTableAdapter displaysTableAdapter;
        private LaptopShopDataSetTableAdapters.laptopsTableAdapter laptopsTableAdapter;
    }
}