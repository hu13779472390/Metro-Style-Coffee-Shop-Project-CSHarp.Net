namespace Coffee_Shop_Project
{
    partial class Add_Product
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
         Properties.Settings
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.linkChooseNewItem = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSaving = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picNewItem = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(33, 233);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(191, 23);
            this.txtPrice.Style = MetroFramework.MetroColorStyle.White;
            this.txtPrice.TabIndex = 0;
            this.txtPrice.UseCustomBackColor = true;
            this.txtPrice.UseCustomForeColor = true;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(338, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(32, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Price";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // linkChooseNewItem
            // 
            this.linkChooseNewItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkChooseNewItem.Location = new System.Drawing.Point(318, 214);
            this.linkChooseNewItem.Name = "linkChooseNewItem";
            this.linkChooseNewItem.Size = new System.Drawing.Size(95, 23);
            this.linkChooseNewItem.Style = MetroFramework.MetroColorStyle.Silver;
            this.linkChooseNewItem.TabIndex = 5;
            this.linkChooseNewItem.Text = "Choose Image";
            this.linkChooseNewItem.UseCustomBackColor = true;
            this.linkChooseNewItem.UseSelectable = true;
            this.linkChooseNewItem.UseStyleColors = true;
            this.linkChooseNewItem.Click += new System.EventHandler(this.linkChooseNewItem_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel2.Location = new System.Drawing.Point(31, 263);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(33, 285);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(316, 97);
            this.txtDescription.Style = MetroFramework.MetroColorStyle.White;
            this.txtDescription.TabIndex = 6;
            this.txtDescription.UseCustomBackColor = true;
            this.txtDescription.UseCustomForeColor = true;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.UseStyleColors = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(103, 392);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(191, 29);
            this.cmbCategory.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmbCategory.TabIndex = 8;
            this.cmbCategory.UseCustomForeColor = true;
            this.cmbCategory.UseSelectable = true;
            this.cmbCategory.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel3.Location = new System.Drawing.Point(33, 398);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Category";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSaving.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSaving.Location = new System.Drawing.Point(274, 450);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(58, 19);
            this.lblSaving.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblSaving.TabIndex = 10;
            this.lblSaving.Text = "Saving...";
            this.lblSaving.UseCustomBackColor = true;
            this.lblSaving.UseCustomForeColor = true;
            this.lblSaving.UseStyleColors = true;
            this.lblSaving.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 19);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox3
            // 
                    
            //this.pictureBox3.Image = Properties.Resources.Untitled_3;
            this.pictureBox3.Location = new System.Drawing.Point(393, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::Coffee_Shop_Project.Properties.Resources.Untitled_3_copy;
            this.pictureBox2.Location = new System.Drawing.Point(413, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox5
            // 
            //this.pictureBox5.Image = global::Coffee_Shop_Project.Properties.Resources.Untitled_3;
            this.pictureBox5.Location = new System.Drawing.Point(532, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            //this.pictureBox6.Image = global::Coffee_Shop_Project.Properties.Resources.Untitled_3_copy;
            this.pictureBox6.Location = new System.Drawing.Point(553, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Product";
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::Coffee_Shop_Project.Properties.Resources.back_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(13, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picNewItem
            // 
            this.picNewItem.BackColor = System.Drawing.Color.White;
            this.picNewItem.Location = new System.Drawing.Point(280, 72);
            this.picNewItem.Name = "picNewItem";
            this.picNewItem.Size = new System.Drawing.Size(134, 140);
            this.picNewItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewItem.TabIndex = 4;
            this.picNewItem.TabStop = false;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(428, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSaving);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.linkChooseNewItem);
            this.Controls.Add(this.picNewItem);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox picNewItem;
        private MetroFramework.Controls.MetroLink linkChooseNewItem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel lblSaving;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}