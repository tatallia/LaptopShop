namespace LaptopShop.Forms
{
    partial class EditWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWorkerForm));
            this.worker_idLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.first_nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phone_numberLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laptopShopDataSet = new LaptopShop.LaptopShopDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new LaptopShop.LaptopShopDataSetTableAdapters.workersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // worker_idLabel
            // 
            this.worker_idLabel.AutoSize = true;
            this.worker_idLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.worker_idLabel.Location = new System.Drawing.Point(28, 58);
            this.worker_idLabel.Name = "worker_idLabel";
            this.worker_idLabel.Size = new System.Drawing.Size(0, 17);
            this.worker_idLabel.TabIndex = 0;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.surnameLabel.Location = new System.Drawing.Point(28, 60);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(70, 17);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // first_nameLabel
            // 
            this.first_nameLabel.AutoSize = true;
            this.first_nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.first_nameLabel.Location = new System.Drawing.Point(29, 88);
            this.first_nameLabel.Name = "first_nameLabel";
            this.first_nameLabel.Size = new System.Drawing.Size(34, 17);
            this.first_nameLabel.TabIndex = 4;
            this.first_nameLabel.Text = "Ім\'я:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.emailLabel.Location = new System.Drawing.Point(28, 115);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 17);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Е-mail:";
            // 
            // phone_numberLabel
            // 
            this.phone_numberLabel.AutoSize = true;
            this.phone_numberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.phone_numberLabel.Location = new System.Drawing.Point(28, 144);
            this.phone_numberLabel.Name = "phone_numberLabel";
            this.phone_numberLabel.Size = new System.Drawing.Size(52, 17);
            this.phone_numberLabel.TabIndex = 8;
            this.phone_numberLabel.Text = "Номер:";
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.adminLabel.Location = new System.Drawing.Point(28, 172);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(49, 17);
            this.adminLabel.TabIndex = 10;
            this.adminLabel.Text = "Права:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.passwordLabel.Location = new System.Drawing.Point(28, 200);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 17);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.loginLabel.Location = new System.Drawing.Point(28, 226);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(44, 17);
            this.loginLabel.TabIndex = 14;
            this.loginLabel.Text = "Логін:";
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.OK_button.Location = new System.Drawing.Point(74, 256);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(150, 35);
            this.OK_button.TabIndex = 16;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Редагування інформації\r\nпро робітників";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.adminCheckBox.Location = new System.Drawing.Point(113, 171);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(111, 21);
            this.adminCheckBox.TabIndex = 18;
            this.adminCheckBox.Text = "адміністратор";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.surnameTextBox.Location = new System.Drawing.Point(106, 57);
            this.surnameTextBox.MaxLength = 30;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(156, 23);
            this.surnameTextBox.TabIndex = 19;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.phone_numberTextBox.Location = new System.Drawing.Point(106, 141);
            this.phone_numberTextBox.MaxLength = 15;
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(156, 23);
            this.phone_numberTextBox.TabIndex = 15;
            this.phone_numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_numberTextBox_KeyPress);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.loginTextBox.Location = new System.Drawing.Point(106, 221);
            this.loginTextBox.MaxLength = 6;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(156, 23);
            this.loginTextBox.TabIndex = 21;
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTextBox_KeyPress);
            this.loginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loginTextBox_Validating);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(106, 195);
            this.passwordTextBox.MaxLength = 6;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(156, 23);
            this.passwordTextBox.TabIndex = 22;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.emailTextBox.Location = new System.Drawing.Point(106, 114);
            this.emailTextBox.MaxLength = 60;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(156, 23);
            this.emailTextBox.TabIndex = 23;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.first_nameTextBox.Location = new System.Drawing.Point(107, 85);
            this.first_nameTextBox.MaxLength = 30;
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(156, 23);
            this.first_nameTextBox.TabIndex = 24;
            this.first_nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
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
            // EditWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 301);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.worker_idLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.first_nameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phone_numberLabel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private LaptopShopDataSet laptopShopDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label worker_idLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label first_nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phone_numberLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private LaptopShopDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        public System.Windows.Forms.Label label1;
    }
}