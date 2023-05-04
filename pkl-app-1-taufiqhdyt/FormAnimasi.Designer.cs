
namespace pkl_app_1_taufiqhdyt
{
    partial class FormAnimasi
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.life_3 = new System.Windows.Forms.PictureBox();
            this.life_2 = new System.Windows.Forms.PictureBox();
            this.life_1 = new System.Windows.Forms.PictureBox();
            this.Tubuh = new System.Windows.Forms.PictureBox();
            this.Kepala = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.life_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tubuh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kepala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // life_3
            // 
            this.life_3.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.life;
            this.life_3.Location = new System.Drawing.Point(744, 94);
            this.life_3.Name = "life_3";
            this.life_3.Size = new System.Drawing.Size(45, 45);
            this.life_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life_3.TabIndex = 6;
            this.life_3.TabStop = false;
            // 
            // life_2
            // 
            this.life_2.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.life;
            this.life_2.Location = new System.Drawing.Point(688, 94);
            this.life_2.Name = "life_2";
            this.life_2.Size = new System.Drawing.Size(45, 45);
            this.life_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life_2.TabIndex = 5;
            this.life_2.TabStop = false;
            // 
            // life_1
            // 
            this.life_1.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.life;
            this.life_1.Location = new System.Drawing.Point(629, 94);
            this.life_1.Name = "life_1";
            this.life_1.Size = new System.Drawing.Size(45, 45);
            this.life_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life_1.TabIndex = 4;
            this.life_1.TabStop = false;
            // 
            // Tubuh
            // 
            this.Tubuh.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.badan;
            this.Tubuh.Location = new System.Drawing.Point(684, 342);
            this.Tubuh.Name = "Tubuh";
            this.Tubuh.Size = new System.Drawing.Size(49, 52);
            this.Tubuh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tubuh.TabIndex = 3;
            this.Tubuh.TabStop = false;
            this.Tubuh.Visible = false;
            // 
            // Kepala
            // 
            this.Kepala.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.Head;
            this.Kepala.Location = new System.Drawing.Point(629, 342);
            this.Kepala.Name = "Kepala";
            this.Kepala.Size = new System.Drawing.Size(49, 52);
            this.Kepala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kepala.TabIndex = 1;
            this.Kepala.TabStop = false;
            this.Kepala.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(50, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 525);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // FormAnimasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 749);
            this.Controls.Add(this.life_3);
            this.Controls.Add(this.life_2);
            this.Controls.Add(this.life_1);
            this.Controls.Add(this.Tubuh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kepala);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAnimasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME SNAKE";
            this.Load += new System.EventHandler(this.FormAnimasi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnimasi_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormAnimasi_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.life_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tubuh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kepala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Kepala;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Tubuh;
        private System.Windows.Forms.PictureBox life_1;
        private System.Windows.Forms.PictureBox life_2;
        private System.Windows.Forms.PictureBox life_3;
    }
}