﻿using System;

namespace pawnshop
{
    partial class Buyingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyingform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chb_iphone = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chb_shark = new System.Windows.Forms.CheckBox();
            this.chb_A53 = new System.Windows.Forms.CheckBox();
            this.chb_redmi = new System.Windows.Forms.CheckBox();
            this.chb_red = new System.Windows.Forms.CheckBox();
            this.chb_rog = new System.Windows.Forms.CheckBox();
            this.chb_S23 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 164);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "CURRENT STACK";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1100, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 162);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chb_iphone
            // 
            this.chb_iphone.AutoSize = true;
            this.chb_iphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_iphone.Location = new System.Drawing.Point(0, 21);
            this.chb_iphone.Name = "chb_iphone";
            this.chb_iphone.Size = new System.Drawing.Size(222, 33);
            this.chb_iphone.TabIndex = 0;
            this.chb_iphone.Text = "iphone X ₱7,500";
            this.chb_iphone.UseVisualStyleBackColor = true;
            this.chb_iphone.CheckedChanged += new System.EventHandler(this.chb_iphone_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chb_shark);
            this.panel2.Controls.Add(this.chb_A53);
            this.panel2.Controls.Add(this.chb_redmi);
            this.panel2.Controls.Add(this.chb_red);
            this.panel2.Controls.Add(this.chb_rog);
            this.panel2.Controls.Add(this.chb_S23);
            this.panel2.Controls.Add(this.chb_iphone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 653);
            this.panel2.TabIndex = 13;
            // 
            // chb_shark
            // 
            this.chb_shark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chb_shark.Location = new System.Drawing.Point(3, 345);
            this.chb_shark.Name = "chb_shark";
            this.chb_shark.Size = new System.Drawing.Size(381, 48);
            this.chb_shark.TabIndex = 0;
            this.chb_shark.Text = "Xiaomi Black Shark 5 ₱30,000";
            this.chb_shark.CheckedChanged += new System.EventHandler(this.chb_shark_CheckedChanged_1);
            // 
            // chb_A53
            // 
            this.chb_A53.AutoSize = true;
            this.chb_A53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_A53.Location = new System.Drawing.Point(3, 301);
            this.chb_A53.Name = "chb_A53";
            this.chb_A53.Size = new System.Drawing.Size(381, 33);
            this.chb_A53.TabIndex = 5;
            this.chb_A53.Text = "Samsung Galaxy A53 ₱15,000";
            this.chb_A53.UseVisualStyleBackColor = true;
            this.chb_A53.CheckedChanged += new System.EventHandler(this.chb_A53_CheckedChanged);
            // 
            // chb_redmi
            // 
            this.chb_redmi.AutoSize = true;
            this.chb_redmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_redmi.Location = new System.Drawing.Point(3, 246);
            this.chb_redmi.Name = "chb_redmi";
            this.chb_redmi.Size = new System.Drawing.Size(327, 33);
            this.chb_redmi.TabIndex = 4;
            this.chb_redmi.Text = "Xiaomi Redmi 9A. ₱4,000";
            this.chb_redmi.UseVisualStyleBackColor = true;
            this.chb_redmi.CheckedChanged += new System.EventHandler(this.chb_redmi_CheckedChanged);
            // 
            // chb_red
            // 
            this.chb_red.AutoSize = true;
            this.chb_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_red.Location = new System.Drawing.Point(3, 186);
            this.chb_red.Name = "chb_red";
            this.chb_red.Size = new System.Drawing.Size(324, 33);
            this.chb_red.TabIndex = 3;
            this.chb_red.Text = "Red Magic 8 Pro ₱30,000";
            this.chb_red.UseVisualStyleBackColor = true;
            this.chb_red.CheckedChanged += new System.EventHandler(this.chb_red_CheckedChanged);
            // 
            // chb_rog
            // 
            this.chb_rog.AutoSize = true;
            this.chb_rog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_rog.Location = new System.Drawing.Point(3, 134);
            this.chb_rog.Name = "chb_rog";
            this.chb_rog.Size = new System.Drawing.Size(369, 33);
            this.chb_rog.TabIndex = 2;
            this.chb_rog.Text = "ASUS ROG Phone 5 ₱35,000";
            this.chb_rog.UseVisualStyleBackColor = true;
            this.chb_rog.CheckedChanged += new System.EventHandler(this.chb_rog_CheckedChanged);
            // 
            // chb_S23
            // 
            this.chb_S23.AutoSize = true;
            this.chb_S23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_S23.Location = new System.Drawing.Point(3, 75);
            this.chb_S23.Name = "chb_S23";
            this.chb_S23.Size = new System.Drawing.Size(412, 33);
            this.chb_S23.TabIndex = 1;
            this.chb_S23.Text = "Samsung Galaxy S23 Ultra ₱40k ";
            this.chb_S23.UseVisualStyleBackColor = true;
            this.chb_S23.CheckedChanged += new System.EventHandler(this.chb_S23_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(462, 185);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(277, 33);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.Text = "personalized gold bar";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(477, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "5g 18karat  ₱23,139";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(462, 272);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(254, 33);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "Bracelet Rose Gold";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(477, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "18karat  ₱12,426";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(462, 370);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(185, 33);
            this.checkBox10.TabIndex = 18;
            this.checkBox10.Text = "Ring Bi-Color";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(477, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "18karat  ₱14,140";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(462, 465);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(220, 33);
            this.checkBox11.TabIndex = 20;
            this.checkBox11.Text = "Earring Tri-Color";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(477, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "18karat  ₱8,570";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(462, 559);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(272, 33);
            this.checkBox12.TabIndex = 22;
            this.checkBox12.Text = "Necklace White Gold";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(477, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = " 14karat  ₱38,686";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(947, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 439);
            this.listBox1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1100, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(947, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 27;
            this.button2.Text = "DONE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(1063, 641);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "_____________";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(918, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 38);
            this.button4.TabIndex = 30;
            this.button4.Text = "TotAL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Buyingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 817);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Buyingform";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Buyingform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chb_shark_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb_iphone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chb_rog;
        private System.Windows.Forms.CheckBox chb_S23;
        private System.Windows.Forms.CheckBox chb_shark;
        private System.Windows.Forms.CheckBox chb_A53;
        private System.Windows.Forms.CheckBox chb_redmi;
        private System.Windows.Forms.CheckBox chb_red;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}