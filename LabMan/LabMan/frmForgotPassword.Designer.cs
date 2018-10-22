namespace LabMan
{
    partial class frmForgotPassword
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
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBackLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Hint = "Username";
            this.txtUsername.Location = new System.Drawing.Point(21, 217);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(299, 23);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mejor amigo de la infancia",
            "Primer mascota",
            "Ciudad natal"});
            this.comboBox1.Location = new System.Drawing.Point(21, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Depth = 0;
            this.txtAnswer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Hint = "Answer";
            this.txtAnswer.Location = new System.Drawing.Point(21, 303);
            this.txtAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.SelectionLength = 0;
            this.txtAnswer.SelectionStart = 0;
            this.txtAnswer.Size = new System.Drawing.Size(299, 23);
            this.txtAnswer.TabIndex = 10;
            this.txtAnswer.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Depth = 0;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(124, 351);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(95, 31);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::LabMan.Properties.Resources.LOGOSINLETRAS;
            this.pictureBox2.Location = new System.Drawing.Point(70, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnBackLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackLogin.Location = new System.Drawing.Point(288, 30);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(24, 24);
            this.btnBackLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBackLogin.TabIndex = 0;
            this.btnBackLogin.TabStop = false;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 480);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBackLogin);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar contraseña";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBackLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAnswer;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    }
}