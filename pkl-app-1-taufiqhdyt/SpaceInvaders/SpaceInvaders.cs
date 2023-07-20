﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app_1_taufiqhdyt
{
    public partial class SpaceInvaders : Form
    {
        private Bitmap canvas = null;
        const int SPACE_BOARD_WIDTH = 80;
        const int SPACE_BOARD_HEIGHT = 50;
        const int SQUARE_SIZE = 10;
        const int JUMLAH_PELURU_ENEMY = 3;
        private List<EnemyModel> _listEnemy;
        private List<BentengModel> _listBenteng;
        private ActorModel _actor;
        private string _arahEnemy = "left";
        private string _arahActor = "";
        private PeluruModel _peluruActor;
        private List<PeluruModel> _listPeluruEnemy;
        private int _score = 0;
        private bool _isGameOver = false;



        const string ACTOR_NEMBAK_SOUND = "pkl_app_1_taufiqhdyt.Actor-nembak.wav";
        const string ENEMY_NEMBAK_SOUND = "pkl_app_1_taufiqhdyt.Enemy-nembak.wav";
        const string ENEMY_TERTEMBAK_SOUND = "pkl_app_1_taufiqhdyt.Enemy-tertembak.wav";
        const string BENTENG_TERTEMBAK_SOUND = "pkl_app_1_taufiqhdyt.Benteng-tertembak.wav";


        public SpaceInvaders()
        {

            InitializeComponent();
            _listEnemy = new List<EnemyModel>();
            _listBenteng = new List<BentengModel>();
            _actor = new ActorModel();
            _peluruActor = new PeluruModel();
            _listPeluruEnemy = new List<PeluruModel>();



            CreateEnemyObject();
            CreateBentengObject();
            CreateActorObject();
            CreatePeluruActorObject();
            CreatePeluruEnemyObject();
            DrawAll();
        }
        private void DrawAll()
        {
            DrawBoard();
            DrawEnemy();
            DrawBenteng();
            DrawActor();
            DrawPeluru();
            DrawPeluruEnemy();
            DrawScore();


            SpaceBoard.Invalidate();
        }

        private void DrawBoard()
        {
            canvas = new Bitmap(SpaceBoard.Width, SpaceBoard.Height);
            using (var grafik = Graphics.FromImage(canvas))
            {
                for (int x = 0; x < SPACE_BOARD_WIDTH; x++)
                    for (int y = 0; y < SPACE_BOARD_HEIGHT; y++) ;     
                
                //grafik.DrawImage(Properties.Resources.BackgroundSpaceInvaders, 0, 0, canvas.Width, canvas.Height);
                //grafik.DrawRectangle(new Pen(Color.DarkGreen), x * SQUARE_SIZE, y * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
            }
        }
        private void DrawEnemy()
        {
            using (var grafik = Graphics.FromImage(canvas))
            {
                foreach (var enemy in _listEnemy.Where(x => x.IsAlive != 2).ToList())
                {
                    if (enemy.IsAlive == 0)
                        grafik.DrawImage(enemy.Gambar, enemy.PosX * SQUARE_SIZE, enemy.PosY * SQUARE_SIZE, enemy.Width * SQUARE_SIZE, enemy.Height * SQUARE_SIZE);
                    else
                    {
                        grafik.DrawImage(meledak.Image, enemy.PosX * SQUARE_SIZE, enemy.PosY * SQUARE_SIZE, enemy.Width * SQUARE_SIZE, enemy.Height * SQUARE_SIZE);
                        enemy.IsAlive = 2;
                    }

                }
            }
        }
        private void DrawActor()
        {
            using (var grafik = Graphics.FromImage(canvas))
            {
                grafik.DrawImage(_actor.Gambar, _actor.PosX * SQUARE_SIZE, _actor.PosY * SQUARE_SIZE, _actor.Width * SQUARE_SIZE, _actor.Height * SQUARE_SIZE);
            }
        }
        private void DrawPeluru()
        {
            using (var grafik = Graphics.FromImage(canvas))
            {
                grafik.DrawImage(_peluruActor.Gambar, _peluruActor.PosX * SQUARE_SIZE, _peluruActor.PosY * SQUARE_SIZE, _peluruActor.Width * SQUARE_SIZE, _peluruActor.Height * SQUARE_SIZE);
            }
        }
        private void DrawPeluruEnemy()
        {
            using (var grafik = Graphics.FromImage(canvas))
            {
                foreach (var item in _listPeluruEnemy.Where(x => x.IsAktif))
                    grafik.DrawImage(item.Gambar, item.PosX * SQUARE_SIZE, item.PosY * SQUARE_SIZE, item.Width * SQUARE_SIZE, item.Height * SQUARE_SIZE);
            }
        }
        private void PlaySound(string soundName)
        {
            Stream soundStream = typeof(Program).Assembly.GetManifestResourceStream(soundName);
            SoundPlayer soundPlayer = new SoundPlayer(soundStream);
            soundPlayer.Play();
        }

        private void DrawBenteng()
        {
            using (var grafik = Graphics.FromImage(canvas))
            {
                foreach (var benteng in _listBenteng)
                {
                    Brush brush = null;
                    switch (benteng.DefencePower)
                    {
                        case 5:
                            brush = new SolidBrush(Color.Aquamarine);
                            break;
                        case 4:
                            brush = new SolidBrush(Color.Turquoise);
                            break;
                        case 3:
                            brush = new SolidBrush(Color.LightSeaGreen);
                            break;
                        case 2:
                            brush = new SolidBrush(Color.Teal);
                            break;
                        case 1:
                            brush = new SolidBrush(Color.DarkSlateGray);
                            break;
                        default:
                            brush = new SolidBrush(Color.Transparent);
                            break;
                    };
                    grafik.FillRectangle(brush, benteng.PosX * SQUARE_SIZE, benteng.PosY * SQUARE_SIZE, benteng.Width * SQUARE_SIZE, benteng.Height * SQUARE_SIZE);

                }
            }
        }
        private void DrawGameOver()
        {
            using (var grafik = Graphics.FromImage(canvas))
            {
                var margin = 30;

                Font font = new Font("OCR A Extended", 34, FontStyle.Bold);
                string text = "GAME OVER!";
                SizeF size = grafik.MeasureString(text, font);
                size.Width += margin * 2;
                size.Height += margin * 2;

                var posXText = (SpaceBoard.Width / 2) - (size.Width / 2);
                var posYText = 160;


                Rectangle rect = new Rectangle((int)posXText, posYText, (int)size.Width, (int)size.Height);
                var fillBrush = new SolidBrush(Color.DarkRed);

                grafik.FillRectangle(fillBrush, rect);
                var line = new Pen(Color.Red);
                grafik.DrawRectangle(line, rect);

                Brush brush = Brushes.Azure;
                PointF position = new PointF(posXText + margin, posYText + margin);
                grafik.DrawString(text, font, brush, position);
            }
            SpaceBoard.Invalidate();
        }

        private void DrawScore()
        {
            if (_isGameOver)
                return;

            using (var grafik = Graphics.FromImage(canvas))
            {
                var margin = 5;

                Font font = new Font("OCR A Extended", 13, FontStyle.Bold);
                string text = $"Score: {_score}";
                SizeF size = grafik.MeasureString(text, font);
                size.Width += margin * 142;
                size.Height += margin * 2;


                var posXText = (SpaceBoard.Width / 2) - (size.Width / 2);
                var posYText = 0;

                Rectangle rect = new Rectangle((int)posXText, (int)posYText, (int)size.Width, (int)size.Height);
                var fillBrush = new SolidBrush(Color.Black);
                var line = new Pen(Color.LimeGreen);

                grafik.FillRectangle(fillBrush, rect);
                grafik.DrawRectangle(line, rect);

                Brush brush = Brushes.LimeGreen;
                PointF position = new PointF(posXText + margin, posYText + margin);
                grafik.DrawString(text, font, brush, position);
            }
            SpaceBoard.Invalidate();
        }

      




        private void MoveEnemy()
        {
            var modifierX = 0;
            var modifierY = 0;
            switch (_arahEnemy)
            {
                case "up":
                    modifierX = 0;
                    modifierY = -1;
                    break;
                case "down":
                    modifierX = 0;
                    modifierY = 1;
                    break;
                case "left":
                    modifierX = -1;
                    modifierY = 0;
                    break;
                case "right":
                    modifierX = 1;
                    modifierY = 0;
                    break;
            }
            foreach (var enemy in _listEnemy)
            {
                enemy.PosX += modifierX;
                enemy.PosY += modifierY;
            }
        }


      


        private void CreateEnemyObject()
        {
            const int WIDTH = 3;
            const int HEIGHT = 2;

            //  enemy level-3 (paling atas)
            for (var i = 1; i <= 9; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = BosPic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = (i * WIDTH * 2) - WIDTH,
                    PosY = 5
                };
                _listEnemy.Add(newEnemy);
            }

            //  enemy level-2 (tengah)
            for (var i = 10; i <= 18; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy3Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 9) * WIDTH * 2) - WIDTH,
                    PosY = 9
                };
                _listEnemy.Add(newEnemy);
            }

            //  enemy level-1 (baris ke-2)
            for (var i = 19; i <= 27; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy2Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 18) * WIDTH * 2) - WIDTH,
                    PosY = 13
                };
                _listEnemy.Add(newEnemy);
            }

            //  enemy level-1 (baris ke-1)
            for (var i = 28; i <= 36; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy1Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 27) * WIDTH * 2) - WIDTH,
                    PosY = 16
                };
                _listEnemy.Add(newEnemy);
            }
        }

        private void CreateBentengObject()
        {
            const int WIDTH = 6;
            const int HEIGHT = 1;

            for (var i = 1; i <= 8; i++)
            {
                var newBenteng = new BentengModel
                {
                    Id = i,
                    DefencePower = 3,
                    Height = HEIGHT,
                    Width = WIDTH,
                    PosX = (i * (WIDTH + 12)) - WIDTH,
                    PosY = 30
                };
                _listBenteng.Add(newBenteng);
            }

        }
        private void CreateActorObject()
        {
            _actor = new ActorModel
            {
                Gambar = ActorPic.Image,
                Width = 5,
                Height = 3,
                PosX = 0,
                PosY = 36,
            };
        }
        private void CreatePeluruActorObject()
        {
            _peluruActor.IsAktif = false;
            _peluruActor.Width = 1;
            _peluruActor.Height = 3;
            _peluruActor.Gambar = PeluruPic.Image;

        }

        private void CreatePeluruEnemyObject()
        {
            for (var i = 1; i <= JUMLAH_PELURU_ENEMY; i++)
            {
                _listPeluruEnemy.Add(new PeluruModel
                {
                    Gambar = EnemyBullet.Image,
                    PosX = 0,
                    PosY = 0,
                    Height = 3,
                    Width = 3
                });
            }
        }
        private void TembakMusuh()
        {
            if (_peluruActor.IsAktif)
                return;
            _peluruActor.PosX = _actor.PosX + (_actor.Width / 2);
            _peluruActor.PosY = _actor.PosY - 3;
            _peluruActor.IsAktif = true;
            PlaySound(ACTOR_NEMBAK_SOUND);

        }


        private void SpaceBoard_Click(object sender, EventArgs e)
        {

        }

        private void EnemyMoveTimer_Tick_1(object sender, EventArgs e)
        {
            var palingLeft = _listEnemy.Where(x => x.IsAlive == 0).Min(x => x.PosX);
            var palingRight = _listEnemy.Where(x => x.IsAlive == 0).Max(x => x.PosX + x.Width);

            if ((_arahEnemy == "left") && (palingLeft <= 0))
                _arahEnemy = "right";
            if ((_arahEnemy == "right") && (palingRight >= SPACE_BOARD_WIDTH))
                _arahEnemy = "left";
            MoveEnemy();
            DrawAll();
        }

        private void ActorMoveTimer_Tick_1(object sender, EventArgs e)
        {
            if (_arahActor == "left")
                _actor.PosX--;
            if (_arahActor == "right")
                _actor.PosX++;

            if (_actor.PosX <= 0)
                _actor.PosX = 0;
            if (_actor.PosX > SPACE_BOARD_WIDTH - _actor.Width)
                _actor.PosX = SPACE_BOARD_WIDTH - _actor.Width;
            DrawAll();
        }

        private void SpaceBoard_Paint_1(object sender, PaintEventArgs e)
        {
            if (canvas is null) return;
            e.Graphics.DrawImage(canvas, 0, 0);
        }

        private void SpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    _arahActor = "left";
                    break;
                case Keys.D:
                    _arahActor = "right";
                    break;
                case Keys.Space:
                    TembakMusuh();
                    break;
            }
        }

        private void SpaceInvaders_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void SpaceInvaders_KeyUp(object sender, KeyEventArgs e)
        {
            _arahActor = string.Empty;
        }

        private void ActorPic_Click(object sender, EventArgs e)
        {

        }

        private void PeluruMove_Tick(object sender, EventArgs e)
        {

            if (!_peluruActor.IsAktif)
                return;
            _peluruActor.PosY--;

            //  apakah peluru kena benteng?
            var bentengTertembak = GetBentengTertembak();
            if (bentengTertembak != null)
            {
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;
            }

            //  apakah peluru kena enemy?
            var enemyTertembak = GetEnemyTertembak();
            if (enemyTertembak != null)
            {
                enemyTertembak.IsAlive = 1;
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;
                _score += 1;
                PlaySound(ENEMY_TERTEMBAK_SOUND);

            }

            //  apakah peluru kena udah lewat batas atas
            if (_peluruActor.PosY <= 0)
            {
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;
            }
        }
        private EnemyModel GetEnemyTertembak()
        {
            foreach (var enemy in _listEnemy.Where(x => x.IsAlive == 0).OrderByDescending(x => x.Id).ToList())
            {
                //  deteksi apakah kena bagian bawah enemy
                //      - tidak kena
                if (_peluruActor.PosY != enemy.PosY + enemy.Height)
                    continue;
                if (_peluruActor.PosX < enemy.PosX)
                    continue;
                if (_peluruActor.PosX > enemy.PosX + enemy.Width)
                    continue;
                //      - kena!!
                return enemy;
            }
            return null;
        }
        private BentengModel GetBentengTertembak()
        {
            foreach (var benteng in _listBenteng)
            {
                if (_peluruActor.PosY > benteng.PosY - 1 + benteng.Height)
                    continue;
                if (_peluruActor.PosX < benteng.PosX)
                    continue;
                if (_peluruActor.PosX > benteng.PosX + benteng.Width)
                    continue;
                if (benteng.DefencePower <= 0)
                    continue;
                return benteng;
            }
            return null;
        }
        private BentengModel GetBentengTertembakEnemy(PeluruModel peluru)
        {
            if (!peluru.IsAktif) return null;

            foreach (var benteng in _listBenteng)
            {
                if (benteng.DefencePower <= 0)
                    continue;

                if (peluru.PosY < benteng.PosY - 1)
                    continue;
                if (peluru.PosY > benteng.PosY + benteng.Height - 1)
                    continue;
                if (peluru.PosX < benteng.PosX  - 1)
                    continue;
                if (peluru.PosX > benteng.PosX + benteng.Width - 2)
                    continue;
                return benteng;
            }
            return null;
        }

        private void Enemy2Pic_Click(object sender, EventArgs e)
        {

        }

        private void PeluruEnemyMoveTimer_Tick(object sender, EventArgs e)
        {
            foreach (var item in _listPeluruEnemy)
            {
                if (!item.IsAktif)
                    continue;
                item.PosY++;

                if (item.PosY > SPACE_BOARD_HEIGHT)
                {
                    item.IsAktif = false;
                    item.PosY = -10;
                }

                var benteng = GetBentengTertembakEnemy(item);
                if (benteng != null)

                {
                    benteng.DefencePower--;
                    item.IsAktif = false;
                    item.PosY = -10;
                    PlaySound(BENTENG_TERTEMBAK_SOUND);

                }
                if (PeluruEnemyKenaActor(item))
                {
                    StopAllTimer();
                    DrawGameOver();
                }
            }
         }
        

        private bool PeluruEnemyKenaActor(PeluruModel peluru)
        {
            if (!peluru.IsAktif)
                return false;
            if (peluru.PosY < _actor.PosY)
                return false;
            if (peluru.PosY > _actor.PosY + _actor.Height - 1)
                return false;
            if (peluru.PosX < _actor.PosX -1)
                return false;
            if (peluru.PosX > _actor.PosX + _actor.Width - 1)
                return false;
           

            return true;
        }

        private void StopAllTimer()
        {
            EnemyMoveTimer.Stop();
            ActorMoveTimer.Stop();
            PeluruActorTimer.Stop();
            PeluruEnemyMoveTimer.Stop();
            PeluruEnemyTembakTimer.Stop();
        }

        private void PeluruEnemyTembakTimer_Tick(object sender, EventArgs e)
        {
            var enemyNembak = GetRandomEnemyBawah();
            var peluru = _listPeluruEnemy.FirstOrDefault(x => !x.IsAktif);
            if (peluru is null)
                return;

            peluru.IsAktif = true;
            peluru.PosX = enemyNembak.PosX;
            peluru.PosY = enemyNembak.PosY;
            PlaySound(ENEMY_NEMBAK_SOUND);

        }


        private List<EnemyModel> ListEnemyBawah()
        {
            var listPosX = _listEnemy
                 .Where(x => x.IsAlive == 0)
                 .Select(x => x.PosX)
                 .Distinct().ToList();
            var listEnemyBawah = new List<EnemyModel>();
            foreach (var item in listPosX)
            {
                var enemyBawah = _listEnemy
                    .Where(x => x.IsAlive == 0)
                    .Where(x => x.PosX == item)
                    .OrderByDescending(x => x.PosY)
                    .First();
                listEnemyBawah.Add(enemyBawah);
            }
            return listEnemyBawah;
        }


        private EnemyModel GetRandomEnemyBawah()
        {
            var listEnemy = ListEnemyBawah();
            var randomX = new Random();
            var kolomRandom = randomX.Next(1, listEnemy.Count);
            var result = listEnemy.Take(kolomRandom).Last();
            return result;

        }

      
    }
}
