using System;

namespace Coffee_Shop_Project
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAmountToPay = new MetroFramework.Controls.MetroTextBox();
            this.btnPayNow = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentAmount = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Amount to Pay:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.BackColor = System.Drawing.Color.White;
            this.txtAmountToPay.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAmountToPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAmountToPay.Lines = new string[0];
            this.txtAmountToPay.Location = new System.Drawing.Point(157, 115);
            this.txtAmountToPay.MaxLength = 32767;
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.PasswordChar = '\0';
            this.txtAmountToPay.ReadOnly = true;
            this.txtAmountToPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountToPay.SelectedText = "";
            this.txtAmountToPay.Size = new System.Drawing.Size(234, 23);
            this.txtAmountToPay.TabIndex = 6;
            this.txtAmountToPay.UseCustomBackColor = true;
            this.txtAmountToPay.UseCustomForeColor = true;
            this.txtAmountToPay.UseSelectable = true;
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(244, 215);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(147, 23);
            this.btnPayNow.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPayNow.TabIndex = 2;
            this.btnPayNow.Text = "Pay";
            this.btnPayNow.UseCustomBackColor = true;
            this.btnPayNow.UseCustomForeColor = true;
            this.btnPayNow.UseSelectable = true;
            this.btnPayNow.UseStyleColors = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(24, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Payment Amount:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BackColor = System.Drawing.Color.White;
            this.txtPaymentAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPaymentAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPaymentAmount.Lines = new string[0];
            this.txtPaymentAmount.Location = new System.Drawing.Point(157, 173);
            this.txtPaymentAmount.MaxLength = 32767;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.Size = new System.Drawing.Size(234, 23);
            this.txtPaymentAmount.TabIndex = 4;
            this.txtPaymentAmount.UseCustomBackColor = true;
            this.txtPaymentAmount.UseCustomForeColor = true;
            this.txtPaymentAmount.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 19);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            //this.pictureBox3.Image = global::Coffee_Shop_Project.Properties.Resources.Untitled_3;
            this.pictureBox3.Location = new System.Drawing.Point(394, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::Coffee_Shop_Project.Properties.Resources.Untitled_3_copy;
            this.pictureBox2.Location = new System.Drawing.Point(414, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Payment";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(430, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAmountToPay;
        private MetroFramework.Controls.MetroButton btnPayNow;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPaymentAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
    }
}