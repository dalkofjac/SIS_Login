namespace sis_login
{
    partial class FrmRegister
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_reg_name = new System.Windows.Forms.TextBox();
            this.textBox_reg_surname = new System.Windows.Forms.TextBox();
            this.textBox_reg_email = new System.Windows.Forms.TextBox();
            this.textBox_reg_username = new System.Windows.Forms.TextBox();
            this.textBox_reg_password = new System.Windows.Forms.TextBox();
            this.textBox_reg_sq = new System.Windows.Forms.TextBox();
            this.button_reg = new System.Windows.Forms.Button();
            this._16038_DBDataSet = new sis_login._16038_DBDataSet();
            this.sis_dk_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sis_dk_userTableAdapter = new sis_login._16038_DBDataSetTableAdapters.sis_dk_userTableAdapter();
            this.tableAdapterManager = new sis_login._16038_DBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this._16038_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sis_dk_userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIS-Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Secret question:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "What is your first pet\'s name:";
            // 
            // textBox_reg_name
            // 
            this.textBox_reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reg_name.Location = new System.Drawing.Point(140, 127);
            this.textBox_reg_name.Name = "textBox_reg_name";
            this.textBox_reg_name.Size = new System.Drawing.Size(251, 26);
            this.textBox_reg_name.TabIndex = 9;
            // 
            // textBox_reg_surname
            // 
            this.textBox_reg_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reg_surname.Location = new System.Drawing.Point(140, 169);
            this.textBox_reg_surname.Name = "textBox_reg_surname";
            this.textBox_reg_surname.Size = new System.Drawing.Size(251, 26);
            this.textBox_reg_surname.TabIndex = 10;
            // 
            // textBox_reg_email
            // 
            this.textBox_reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reg_email.Location = new System.Drawing.Point(140, 221);
            this.textBox_reg_email.Name = "textBox_reg_email";
            this.textBox_reg_email.Size = new System.Drawing.Size(251, 26);
            this.textBox_reg_email.TabIndex = 11;
            // 
            // textBox_reg_username
            // 
            this.textBox_reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reg_username.Location = new System.Drawing.Point(147, 298);
            this.textBox_reg_username.Name = "textBox_reg_username";
            this.textBox_reg_username.Size = new System.Drawing.Size(251, 26);
            this.textBox_reg_username.TabIndex = 12;
            // 
            // textBox_reg_password
            // 
            this.textBox_reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reg_password.Location = new System.Drawing.Point(147, 341);
            this.textBox_reg_password.Name = "textBox_reg_password";
            this.textBox_reg_password.PasswordChar = '*';
            this.textBox_reg_password.Size = new System.Drawing.Size(251, 26);
            this.textBox_reg_password.TabIndex = 13;
            // 
            // textBox_reg_sq
            // 
            this.textBox_reg_sq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reg_sq.Location = new System.Drawing.Point(64, 466);
            this.textBox_reg_sq.Name = "textBox_reg_sq";
            this.textBox_reg_sq.Size = new System.Drawing.Size(334, 26);
            this.textBox_reg_sq.TabIndex = 14;
            this.textBox_reg_sq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_reg_sq_KeyDown);
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(147, 512);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(198, 46);
            this.button_reg.TabIndex = 15;
            this.button_reg.Text = "Register!";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // _16038_DBDataSet
            // 
            this._16038_DBDataSet.DataSetName = "_16038_DBDataSet";
            this._16038_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sis_dk_userBindingSource
            // 
            this.sis_dk_userBindingSource.DataMember = "sis_dk_user";
            this.sis_dk_userBindingSource.DataSource = this._16038_DBDataSet;
            // 
            // sis_dk_userTableAdapter
            // 
            this.sis_dk_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sis_dk_userTableAdapter = this.sis_dk_userTableAdapter;
            this.tableAdapterManager.UpdateOrder = sis_login._16038_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 571);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.textBox_reg_sq);
            this.Controls.Add(this.textBox_reg_password);
            this.Controls.Add(this.textBox_reg_username);
            this.Controls.Add(this.textBox_reg_email);
            this.Controls.Add(this.textBox_reg_surname);
            this.Controls.Add(this.textBox_reg_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIS-Register";
            ((System.ComponentModel.ISupportInitialize)(this._16038_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sis_dk_userBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_reg_name;
        private System.Windows.Forms.TextBox textBox_reg_surname;
        private System.Windows.Forms.TextBox textBox_reg_email;
        private System.Windows.Forms.TextBox textBox_reg_username;
        private System.Windows.Forms.TextBox textBox_reg_password;
        private System.Windows.Forms.TextBox textBox_reg_sq;
        private System.Windows.Forms.Button button_reg;
        private _16038_DBDataSet _16038_DBDataSet;
        private System.Windows.Forms.BindingSource sis_dk_userBindingSource;
        private _16038_DBDataSetTableAdapters.sis_dk_userTableAdapter sis_dk_userTableAdapter;
        private _16038_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}