namespace Apart
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.userName = new DevExpress.XtraEditors.TextEdit();
            this.userPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.userName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(294, 368);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(195, 63);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 165);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "User Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(173, 246);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 29);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Password :";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(339, 162);
            this.userName.Name = "userName";
            this.userName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.userName.Properties.Appearance.Options.UseFont = true;
            this.userName.Size = new System.Drawing.Size(150, 36);
            this.userName.TabIndex = 3;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(339, 243);
            this.userPassword.Name = "userPassword";
            this.userPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.userPassword.Properties.Appearance.Options.UseFont = true;
            this.userPassword.Size = new System.Drawing.Size(150, 36);
            this.userPassword.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(269, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(263, 39);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Apartment System";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(796, 513);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "AdminPage";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit userName;
        private DevExpress.XtraEditors.TextEdit userPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

