
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
            this.PeluruActorTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyTembakTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBullet = new System.Windows.Forms.PictureBox();
            this.Latar = new System.Windows.Forms.PictureBox();
            this.meledak = new System.Windows.Forms.PictureBox();
            this.Benteng = new System.Windows.Forms.PictureBox();
            this.PeluruPic = new System.Windows.Forms.PictureBox();
            this.BosPic = new System.Windows.Forms.PictureBox();
            this.ActorPic = new System.Windows.Forms.PictureBox();
            this.Enemy1Pic = new System.Windows.Forms.PictureBox();
            this.Enemy2Pic = new System.Windows.Forms.PictureBox();
            this.Enemy3Pic = new System.Windows.Forms.PictureBox();
            this.SpaceBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meledak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Benteng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BosPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 50;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick_1);
            // 
            // ActorMoveTimer
            // 
            this.ActorMoveTimer.Enabled = true;
            this.ActorMoveTimer.Interval = 30;
            this.ActorMoveTimer.Tick += new System.EventHandler(this.ActorMoveTimer_Tick_1);
            // 
            // PeluruActorTimer
            // 
            this.PeluruActorTimer.Enabled = true;
            this.PeluruActorTimer.Interval = 1;
            this.PeluruActorTimer.Tick += new System.EventHandler(this.PeluruMove_Tick);
            // 
            // PeluruEnemyMoveTimer
            // 
            this.PeluruEnemyMoveTimer.Enabled = true;
            this.PeluruEnemyMoveTimer.Interval = 30;
            this.PeluruEnemyMoveTimer.Tick += new System.EventHandler(this.PeluruEnemyMoveTimer_Tick);
            // 
            // PeluruEnemyTembakTimer
            // 
            this.PeluruEnemyTembakTimer.Enabled = true;
            this.PeluruEnemyTembakTimer.Interval = 700;
            this.PeluruEnemyTembakTimer.Tick += new System.EventHandler(this.PeluruEnemyTembakTimer_Tick);
            // 
            // EnemyBullet
            // 
            this.EnemyBullet.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.bolaapi;
            this.EnemyBullet.Location = new System.Drawing.Point(397, 412);
            this.EnemyBullet.Name = "EnemyBullet";
            this.EnemyBullet.Size = new System.Drawing.Size(36, 32);
            this.EnemyBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBullet.TabIndex = 15;
            this.EnemyBullet.TabStop = false;
            this.EnemyBullet.Visible = false;
            // 
            // Latar
            // 
            this.Latar.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.BackgroundSpaceInvaders;
            this.Latar.Location = new System.Drawing.Point(355, 412);
            this.Latar.Name = "Latar";
            this.Latar.Size = new System.Drawing.Size(36, 32);
            this.Latar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Latar.TabIndex = 14;
            this.Latar.TabStop = false;
            this.Latar.Visible = false;
            // 
            // meledak
            // 
            this.meledak.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.Boomenemy;
            this.meledak.Location = new System.Drawing.Point(313, 412);
            this.meledak.Name = "meledak";
            this.meledak.Size = new System.Drawing.Size(36, 32);
            this.meledak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meledak.TabIndex = 13;
            this.meledak.TabStop = false;
            this.meledak.Visible = false;
            // 
            // Benteng
            // 
            this.Benteng.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.bunker1;
            this.Benteng.Location = new System.Drawing.Point(271, 412);
            this.Benteng.Name = "Benteng";
            this.Benteng.Size = new System.Drawing.Size(36, 32);
            this.Benteng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Benteng.TabIndex = 12;
            this.Benteng.TabStop = false;
            this.Benteng.Visible = false;
            // 
            // PeluruPic
            // 
            this.PeluruPic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.playerBullet;
            this.PeluruPic.Location = new System.Drawing.Point(253, 412);
            this.PeluruPic.Name = "PeluruPic";
            this.PeluruPic.Size = new System.Drawing.Size(12, 32);
            this.PeluruPic.TabIndex = 11;
            this.PeluruPic.TabStop = false;
            this.PeluruPic.Visible = false;
            // 
            // BosPic
            // 
            this.BosPic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.extra;
            this.BosPic.Location = new System.Drawing.Point(207, 412);
            this.BosPic.Name = "BosPic";
            this.BosPic.Size = new System.Drawing.Size(40, 32);
            this.BosPic.TabIndex = 10;
            this.BosPic.TabStop = false;
            this.BosPic.Visible = false;
            // 
            // ActorPic
            // 
            this.ActorPic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.playerTank;
            this.ActorPic.Location = new System.Drawing.Point(138, 412);
            this.ActorPic.Name = "ActorPic";
            this.ActorPic.Size = new System.Drawing.Size(36, 32);
            this.ActorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ActorPic.TabIndex = 9;
            this.ActorPic.TabStop = false;
            this.ActorPic.Visible = false;
            this.ActorPic.Click += new System.EventHandler(this.ActorPic_Click);
            // 
            // Enemy1Pic
            // 
            this.Enemy1Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.red;
            this.Enemy1Pic.Location = new System.Drawing.Point(92, 412);
            this.Enemy1Pic.Name = "Enemy1Pic";
            this.Enemy1Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy1Pic.TabIndex = 8;
            this.Enemy1Pic.TabStop = false;
            this.Enemy1Pic.Visible = false;
            // 
            // Enemy2Pic
            // 
            this.Enemy2Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.yellow;
            this.Enemy2Pic.Location = new System.Drawing.Point(46, 412);
            this.Enemy2Pic.Name = "Enemy2Pic";
            this.Enemy2Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy2Pic.TabIndex = 7;
            this.Enemy2Pic.TabStop = false;
            this.Enemy2Pic.Visible = false;
            // 
            // Enemy3Pic
            // 
            this.Enemy3Pic.Image = global::pkl_app_1_taufiqhdyt.Properties.Resources.green;
            this.Enemy3Pic.Location = new System.Drawing.Point(0, 412);
            this.Enemy3Pic.Name = "Enemy3Pic";
            this.Enemy3Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy3Pic.TabIndex = 6;
            this.Enemy3Pic.TabStop = false;
            this.Enemy3Pic.Visible = false;
            // 
            // SpaceBoard
            // 
            this.SpaceBoard.BackColor = System.Drawing.Color.Black;
            this.SpaceBoard.Location = new System.Drawing.Point(1, 0);
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
            this.ClientSize = new System.Drawing.Size(802, 451);
            this.Controls.Add(this.EnemyBullet);
            this.Controls.Add(this.Latar);
            this.Controls.Add(this.meledak);
            this.Controls.Add(this.Benteng);
            this.Controls.Add(this.PeluruPic);
            this.Controls.Add(this.BosPic);
            this.Controls.Add(this.ActorPic);
            this.Controls.Add(this.Enemy1Pic);
            this.Controls.Add(this.Enemy2Pic);
            this.Controls.Add(this.Enemy3Pic);
            this.Controls.Add(this.SpaceBoard);
            this.Name = "SpaceInvaders";
            this.Text = "SpaceInvaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaders_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaders_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SpaceInvaders_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meledak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Benteng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BosPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ActorPic;
        private System.Windows.Forms.PictureBox Enemy1Pic;
        private System.Windows.Forms.PictureBox Enemy2Pic;
        private System.Windows.Forms.PictureBox Enemy3Pic;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Timer ActorMoveTimer;
        private System.Windows.Forms.PictureBox BosPic;
        private System.Windows.Forms.PictureBox PeluruPic;
        private System.Windows.Forms.Timer PeluruActorTimer;
        private System.Windows.Forms.PictureBox Benteng;
        private System.Windows.Forms.PictureBox meledak;
        private System.Windows.Forms.PictureBox Latar;
        private System.Windows.Forms.Timer PeluruEnemyMoveTimer;
        private System.Windows.Forms.Timer PeluruEnemyTembakTimer;
        private System.Windows.Forms.PictureBox EnemyBullet;
        private System.Windows.Forms.PictureBox SpaceBoard;
    }
}