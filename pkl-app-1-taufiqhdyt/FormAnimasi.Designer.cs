
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            this.life_3 = new System.Windows.Forms.PictureBox();
            this.life_2 = new System.Windows.Forms.PictureBox();
            this.life_1 = new System.Windows.Forms.PictureBox();
            this.Tubuh = new System.Windows.Forms.PictureBox();
            this.Kepala = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arah";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = ".";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button1_PreviewKeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.uy;
            this.pictureBox2.Location = new System.Drawing.Point(627, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // food
            // 
            this.food.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.rat;
            this.food.Location = new System.Drawing.Point(627, 388);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(49, 52);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food.TabIndex = 7;
            this.food.TabStop = false;
            this.food.Visible = false;
            // 
            // life_3
            // 
            this.life_3.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.life;
            this.life_3.Location = new System.Drawing.Point(487, 7);
            this.life_3.Name = "life_3";
            this.life_3.Size = new System.Drawing.Size(32, 30);
            this.life_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life_3.TabIndex = 6;
            this.life_3.TabStop = false;
            // 
            // life_2
            // 
            this.life_2.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.life;
            this.life_2.Location = new System.Drawing.Point(449, 7);
            this.life_2.Name = "life_2";
            this.life_2.Size = new System.Drawing.Size(32, 30);
            this.life_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life_2.TabIndex = 5;
            this.life_2.TabStop = false;
            // 
            // life_1
            // 
            this.life_1.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.life;
            this.life_1.Location = new System.Drawing.Point(411, 7);
            this.life_1.Name = "life_1";
            this.life_1.Size = new System.Drawing.Size(32, 30);
            this.life_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life_1.TabIndex = 4;
            this.life_1.TabStop = false;
            // 
            // Tubuh
            // 
            this.Tubuh.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.badan;
            this.Tubuh.Location = new System.Drawing.Point(627, 330);
            this.Tubuh.Name = "Tubuh";
            this.Tubuh.Size = new System.Drawing.Size(49, 52);
            this.Tubuh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tubuh.TabIndex = 3;
            this.Tubuh.TabStop = false;
            this.Tubuh.Visible = false;
            // 
            // Kepala
            // 
            this.Kepala.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.kanan;
            this.Kepala.Location = new System.Drawing.Point(627, 272);
            this.Kepala.Name = "Kepala";
            this.Kepala.Size = new System.Drawing.Size(49, 52);
            this.Kepala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kepala.TabIndex = 1;
            this.Kepala.TabStop = false;
            this.Kepala.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 525);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // FormAnimasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(688, 612);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.food);
            this.Controls.Add(this.life_3);
            this.Controls.Add(this.life_2);
            this.Controls.Add(this.life_1);
            this.Controls.Add(this.Tubuh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kepala);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "FormAnimasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME SNAKE";
            this.Load += new System.EventHandler(this.FormAnimasi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnimasi_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormAnimasi_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
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
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}