namespace ClinicaFrba
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._loginGroupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._loginBtn = new System.Windows.Forms.Button();
            this._password = new System.Windows.Forms.TextBox();
            this._username = new System.Windows.Forms.TextBox();
            this._rolSelectionGroupbox = new System.Windows.Forms.GroupBox();
            this._loginWithRolBtn = new System.Windows.Forms.Button();
            this._rolCombobox = new System.Windows.Forms.ComboBox();
            this._loginGroupbox.SuspendLayout();
            this._rolSelectionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _loginGroupbox
            // 
            this._loginGroupbox.Controls.Add(this.label2);
            this._loginGroupbox.Controls.Add(this.label1);
            this._loginGroupbox.Controls.Add(this._loginBtn);
            this._loginGroupbox.Controls.Add(this._password);
            this._loginGroupbox.Controls.Add(this._username);
            this._loginGroupbox.Location = new System.Drawing.Point(12, 12);
            this._loginGroupbox.Name = "_loginGroupbox";
            this._loginGroupbox.Size = new System.Drawing.Size(208, 107);
            this._loginGroupbox.TabIndex = 0;
            this._loginGroupbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // _loginBtn
            // 
            this._loginBtn.Location = new System.Drawing.Point(19, 72);
            this._loginBtn.Name = "_loginBtn";
            this._loginBtn.Size = new System.Drawing.Size(170, 23);
            this._loginBtn.TabIndex = 2;
            this._loginBtn.Text = "Login";
            this._loginBtn.UseVisualStyleBackColor = true;
            this._loginBtn.Click += new System.EventHandler(this.SubmitLogin);
            // 
            // _password
            // 
            this._password.Location = new System.Drawing.Point(90, 46);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(99, 20);
            this._password.TabIndex = 1;
            this._password.UseSystemPasswordChar = true;
            // 
            // _username
            // 
            this._username.Location = new System.Drawing.Point(90, 19);
            this._username.Name = "_username";
            this._username.Size = new System.Drawing.Size(100, 20);
            this._username.TabIndex = 0;
            // 
            // _rolSelectionGroupbox
            // 
            this._rolSelectionGroupbox.Controls.Add(this._loginWithRolBtn);
            this._rolSelectionGroupbox.Controls.Add(this._rolCombobox);
            this._rolSelectionGroupbox.Enabled = false;
            this._rolSelectionGroupbox.Location = new System.Drawing.Point(12, 126);
            this._rolSelectionGroupbox.Name = "_rolSelectionGroupbox";
            this._rolSelectionGroupbox.Size = new System.Drawing.Size(208, 41);
            this._rolSelectionGroupbox.TabIndex = 1;
            this._rolSelectionGroupbox.TabStop = false;
            // 
            // _loginWithRolBtn
            // 
            this._loginWithRolBtn.Location = new System.Drawing.Point(135, 11);
            this._loginWithRolBtn.Name = "_loginWithRolBtn";
            this._loginWithRolBtn.Size = new System.Drawing.Size(67, 23);
            this._loginWithRolBtn.TabIndex = 1;
            this._loginWithRolBtn.Text = "Ingresar";
            this._loginWithRolBtn.UseVisualStyleBackColor = true;
            this._loginWithRolBtn.Click += new System.EventHandler(this.LoginWithRolClick);
            // 
            // _rolCombobox
            // 
            this._rolCombobox.FormattingEnabled = true;
            this._rolCombobox.Location = new System.Drawing.Point(7, 12);
            this._rolCombobox.Name = "_rolCombobox";
            this._rolCombobox.Size = new System.Drawing.Size(121, 21);
            this._rolCombobox.TabIndex = 0;
            this._rolCombobox.Text = "Seleccione un rol";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 179);
            this.Controls.Add(this._rolSelectionGroupbox);
            this.Controls.Add(this._loginGroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Ingresar";
            this._loginGroupbox.ResumeLayout(false);
            this._loginGroupbox.PerformLayout();
            this._rolSelectionGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _loginGroupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _loginBtn;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.TextBox _username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox _rolSelectionGroupbox;
        private System.Windows.Forms.Button _loginWithRolBtn;
        private System.Windows.Forms.ComboBox _rolCombobox;
    }
}

