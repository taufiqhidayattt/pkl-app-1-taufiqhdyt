
namespace pkl_app_1_taufiqhdyt
{
    partial class SpaceInvaders
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
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.Enemy4Pic = new System.Windows.Forms.PictureBox();
            this.ActorPic = new System.Windows.Forms.PictureBox();
            this.Enemy3Pic = new System.Windows.Forms.PictureBox();
            this.Enemy2Pic = new System.Windows.Forms.PictureBox();
            this.Enemy1Pic = new System.Windows.Forms.PictureBox();
            this.SpaceBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 500;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick_1);
            // 
            // ActorMoveTimer
            // 
            this.ActorMoveTimer.Enabled = true;
            this.ActorMoveTimer.Interval = 50;
            this.ActorMoveTimer.Tick += new System.EventHandler(this.ActorMoveTimer_Tick_1);
            // 
            // Enemy4Pic
            // 
            this.Enemy4Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.Blue_alien;
            this.Enemy4Pic.Location = new System.Drawing.Point(207, 412);
            this.Enemy4Pic.Name = "Enemy4Pic";
            this.Enemy4Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy4Pic.TabIndex = 10;
            this.Enemy4Pic.TabStop = false;
            this.Enemy4Pic.Visible = false;
            // 
            // ActorPic
            // 
            this.ActorPic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.player_ship;
            this.ActorPic.Location = new System.Drawing.Point(138, 412);
            this.ActorPic.Name = "ActorPic";
            this.ActorPic.Size = new System.Drawing.Size(36, 32);
            this.ActorPic.TabIndex = 9;
            this.ActorPic.TabStop = false;
            this.ActorPic.Visible = false;
            this.ActorPic.Click += new System.EventHandler(this.ActorPic_Click);
            // 
            // Enemy3Pic
            // 
            this.Enemy3Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.Green_alien;
            this.Enemy3Pic.Location = new System.Drawing.Point(92, 412);
            this.Enemy3Pic.Name = "Enemy3Pic";
            this.Enemy3Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy3Pic.TabIndex = 8;
            this.Enemy3Pic.TabStop = false;
            this.Enemy3Pic.Visible = false;
            // 
            // Enemy2Pic
            // 
            this.Enemy2Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.purple_alien;
            this.Enemy2Pic.Location = new System.Drawing.Point(46, 412);
            this.Enemy2Pic.Name = "Enemy2Pic";
            this.Enemy2Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy2Pic.TabIndex = 7;
            this.Enemy2Pic.TabStop = false;
            this.Enemy2Pic.Visible = false;
            // 
            // Enemy1Pic
            // 
            this.Enemy1Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.Red_alien;
            this.Enemy1Pic.Location = new System.Drawing.Point(0, 412);
            this.Enemy1Pic.Name = "Enemy1Pic";
            this.Enemy1Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy1Pic.TabIndex = 6;
            this.Enemy1Pic.TabStop = false;
            this.Enemy1Pic.Visible = false;
            // 
            // SpaceBoard
            // 
            this.SpaceBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SpaceBoard.Location = new System.Drawing.Point(0, 6);
            this.SpaceBoard.Name = "SpaceBoard";
            this.SpaceBoard.Size = new System.Drawing.Size(800, 400);
            this.SpaceBoard.TabIndex = 5;
            this.SpaceBoard.TabStop = false;
            this.SpaceBoard.Click += new System.EventHandler(this.SpaceBoard_Click);
            this.SpaceBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceBoard_Paint_1);
            // 
            // SpaceInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.Enemy4Pic);
            this.Controls.Add(this.ActorPic);
            this.Controls.Add(this.Enemy3Pic);
            this.Controls.Add(this.Enemy2Pic);
            this.Controls.Add(this.Enemy1Pic);
            this.Controls.Add(this.SpaceBoard);
            this.Name = "SpaceInvaders";
            this.Text = "SpaceInvaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaders_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaders_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SpaceInvaders_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ActorPic;
        private System.Windows.Forms.PictureBox Enemy3Pic;
        private System.Windows.Forms.PictureBox Enemy2Pic;
        private System.Windows.Forms.PictureBox Enemy1Pic;
        private System.Windows.Forms.PictureBox SpaceBoard;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Timer ActorMoveTimer;
        private System.Windows.Forms.PictureBox Enemy4Pic;
    }
}