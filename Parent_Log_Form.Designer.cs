﻿namespace web_browser1st
{
    partial class Parent_Log_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent_Log_Form));
            this.UserLogBtn = new System.Windows.Forms.Button();
            this.UserLogPass = new System.Windows.Forms.TextBox();
            this.UserLogName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MonLogPass = new System.Windows.Forms.Label();
            this.MonLogName = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLogBtn
            // 
            this.UserLogBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.UserLogBtn.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogBtn.ForeColor = System.Drawing.Color.White;
            this.UserLogBtn.Location = new System.Drawing.Point(186, 374);
            this.UserLogBtn.Name = "UserLogBtn";
            this.UserLogBtn.Size = new System.Drawing.Size(128, 54);
            this.UserLogBtn.TabIndex = 7;
            this.UserLogBtn.Text = "LOGIN";
            this.UserLogBtn.UseVisualStyleBackColor = false;
            this.UserLogBtn.Click += new System.EventHandler(this.UserLogBtn_Click);
            // 
            // UserLogPass
            // 
            this.UserLogPass.Location = new System.Drawing.Point(243, 293);
            this.UserLogPass.Multiline = true;
            this.UserLogPass.Name = "UserLogPass";
            this.UserLogPass.PasswordChar = '*';
            this.UserLogPass.Size = new System.Drawing.Size(156, 28);
            this.UserLogPass.TabIndex = 1;
            // 
            // UserLogName
            // 
            this.UserLogName.Location = new System.Drawing.Point(245, 218);
            this.UserLogName.Multiline = true;
            this.UserLogName.Name = "UserLogName";
            this.UserLogName.Size = new System.Drawing.Size(156, 28);
            this.UserLogName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(120, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "PARENT LOGIN FORM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 45);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Parental Control Web Browser";
            // 
            // MonLogPass
            // 
            this.MonLogPass.AutoSize = true;
            this.MonLogPass.BackColor = System.Drawing.Color.Transparent;
            this.MonLogPass.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLogPass.ForeColor = System.Drawing.Color.White;
            this.MonLogPass.Location = new System.Drawing.Point(104, 283);
            this.MonLogPass.Name = "MonLogPass";
            this.MonLogPass.Size = new System.Drawing.Size(115, 21);
            this.MonLogPass.TabIndex = 24;
            this.MonLogPass.Text = "password";
            this.MonLogPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonLogName
            // 
            this.MonLogName.AutoSize = true;
            this.MonLogName.BackColor = System.Drawing.Color.Transparent;
            this.MonLogName.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLogName.ForeColor = System.Drawing.Color.White;
            this.MonLogName.Location = new System.Drawing.Point(98, 218);
            this.MonLogName.Name = "MonLogName";
            this.MonLogName.Size = new System.Drawing.Size(122, 21);
            this.MonLogName.TabIndex = 23;
            this.MonLogName.Text = "USER NAME";
            this.MonLogName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(440, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 39);
            this.button6.TabIndex = 59;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Parent_Log_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::web_browser1st.Properties.Resources.Untitled_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(504, 605);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.MonLogPass);
            this.Controls.Add(this.MonLogName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserLogBtn);
            this.Controls.Add(this.UserLogPass);
            this.Controls.Add(this.UserLogName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parent_Log_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent_Log_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserLogBtn;
        private System.Windows.Forms.TextBox UserLogPass;
        private System.Windows.Forms.TextBox UserLogName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MonLogPass;
        private System.Windows.Forms.Label MonLogName;
        private System.Windows.Forms.Button button6;
    }
}