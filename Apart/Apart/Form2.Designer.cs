namespace Apart
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.removeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.updateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.showBtn.Appearance.Options.UseFont = true;
            this.showBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showBtn.ImageOptions.SvgImage")));
            this.showBtn.Location = new System.Drawing.Point(24, 12);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(207, 58);
            this.showBtn.TabIndex = 0;
            this.showBtn.Text = "Show Data";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 313);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1360, 386);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 224;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apartment No";
            this.columnHeader4.Width = 188;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 218;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 278;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dept";
            this.columnHeader7.Width = 155;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(63, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Name";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(140, 109);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(150, 26);
            this.textEdit1.TabIndex = 3;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(140, 156);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(150, 26);
            this.textEdit2.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 153);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 27);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Surname";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(140, 202);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(150, 26);
            this.textEdit3.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(63, 199);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 27);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "No";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(510, 109);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(150, 26);
            this.textEdit4.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(433, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 27);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Phone";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(510, 156);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(150, 26);
            this.textEdit5.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(433, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 27);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Email";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(510, 202);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(150, 26);
            this.textEdit6.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(433, 199);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 27);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Dept";
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveBtn.ImageOptions.SvgImage")));
            this.saveBtn.Location = new System.Drawing.Point(259, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(192, 58);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.removeBtn.Appearance.Options.UseFont = true;
            this.removeBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("removeBtn.ImageOptions.SvgImage")));
            this.removeBtn.Location = new System.Drawing.Point(476, 12);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(184, 58);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Remove";
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.updateBtn.Appearance.Options.UseFont = true;
            this.updateBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("updateBtn.ImageOptions.SvgImage")));
            this.updateBtn.Location = new System.Drawing.Point(681, 12);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 58);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(889, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(184, 58);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(1100, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(184, 58);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "Search";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(1138, 147);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Purple;
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Size = new System.Drawing.Size(150, 36);
            this.textEdit7.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(1061, 150);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 29);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1361, 699);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.showBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton showBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton removeBtn;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}