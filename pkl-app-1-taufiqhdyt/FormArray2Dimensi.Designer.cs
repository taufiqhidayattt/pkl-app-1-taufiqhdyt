﻿
namespace pkl_app_1_taufiqhdyt
{
    partial class FormArray2Dimensi
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelPapanCatur = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPapanCatur
            // 
            this.panelPapanCatur.Location = new System.Drawing.Point(31, 62);
            this.panelPapanCatur.Name = "panelPapanCatur";
            this.panelPapanCatur.Size = new System.Drawing.Size(354, 261);
            this.panelPapanCatur.TabIndex = 1;
            this.panelPapanCatur.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormArray2Dimensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPapanCatur);
            this.Controls.Add(this.button1);
            this.Name = "FormArray2Dimensi";
            this.Text = "FormArray2Dimensi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPapanCatur;
    }
}