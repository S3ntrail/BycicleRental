﻿
namespace BakfietsenHuren
{
    partial class Form1
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
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numHelmet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRainroof = new System.Windows.Forms.CheckBox();
            this.Subtotaal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.taxOutcome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBycicle = new System.Windows.Forms.ListBox();
            this.overviewPriceList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHelmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(13, 179);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(120, 20);
            this.numDays.TabIndex = 3;
            this.numDays.ValueChanged += new System.EventHandler(this.numDays_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kies uw bakfiets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kies aantal dagen";
            // 
            // numHelmet
            // 
            this.numHelmet.Location = new System.Drawing.Point(138, 252);
            this.numHelmet.Name = "numHelmet";
            this.numHelmet.Size = new System.Drawing.Size(120, 20);
            this.numHelmet.TabIndex = 6;
            this.numHelmet.ValueChanged += new System.EventHandler(this.numHelmet_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Accesoires";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Helmen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Knie / Arm bescherming";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(138, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Regendak";
            // 
            // chkRainroof
            // 
            this.chkRainroof.AutoSize = true;
            this.chkRainroof.Location = new System.Drawing.Point(243, 304);
            this.chkRainroof.Name = "chkRainroof";
            this.chkRainroof.Size = new System.Drawing.Size(15, 14);
            this.chkRainroof.TabIndex = 12;
            this.chkRainroof.UseVisualStyleBackColor = true;
            this.chkRainroof.CheckedChanged += new System.EventHandler(this.chkRainroof_CheckedChanged);
            // 
            // Subtotaal
            // 
            this.Subtotaal.AutoSize = true;
            this.Subtotaal.Location = new System.Drawing.Point(629, 285);
            this.Subtotaal.Name = "Subtotaal";
            this.Subtotaal.Size = new System.Drawing.Size(52, 13);
            this.Subtotaal.TabIndex = 13;
            this.Subtotaal.Text = "Subtotaal";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(697, 285);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubtotal.TabIndex = 14;
            this.lblSubtotal.Text = "0";
            // 
            // taxOutcome
            // 
            this.taxOutcome.AutoSize = true;
            this.taxOutcome.Location = new System.Drawing.Point(697, 310);
            this.taxOutcome.Name = "taxOutcome";
            this.taxOutcome.Size = new System.Drawing.Size(13, 13);
            this.taxOutcome.TabIndex = 16;
            this.taxOutcome.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Btw 21%";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(697, 352);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(13, 13);
            this.totalPrice.TabIndex = 18;
            this.totalPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Totaal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "€5 p/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "€5 p/s";
            // 
            // listBycicle
            // 
            this.listBycicle.FormattingEnabled = true;
            this.listBycicle.Items.AddRange(new object[] {
            "Bakfiets 1",
            "Bakfiets 2",
            "Bakfiets 3"});
            this.listBycicle.Location = new System.Drawing.Point(13, 50);
            this.listBycicle.Name = "listBycicle";
            this.listBycicle.Size = new System.Drawing.Size(120, 95);
            this.listBycicle.TabIndex = 21;
            this.listBycicle.SelectedIndexChanged += new System.EventHandler(this.listBycicle_SelectedIndexChanged);
            // 
            // overviewPriceList
            // 
            this.overviewPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overviewPriceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.overviewPriceList.Location = new System.Drawing.Point(468, 67);
            this.overviewPriceList.Name = "overviewPriceList";
            this.overviewPriceList.ReadOnly = true;
            this.overviewPriceList.Size = new System.Drawing.Size(242, 184);
            this.overviewPriceList.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Aantal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.overviewPriceList);
            this.Controls.Add(this.listBycicle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.taxOutcome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.Subtotaal);
            this.Controls.Add(this.chkRainroof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHelmet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDays);
            this.Name = "Form1";
            this.Text = "UwU";
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHelmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewPriceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHelmet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRainroof;
        private System.Windows.Forms.Label Subtotaal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label taxOutcome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBycicle;
        private System.Windows.Forms.DataGridView overviewPriceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

