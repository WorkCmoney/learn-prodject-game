using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace boombgame
{
    public partial class Form2 : Form
    {
 //--------腳色操控---------------------------------
        bool left, right, up, down;
        int px = 250, py = 150;int speed = 10;
        Bitmap img;
        int goleft = 0, turnleft = 0;//控制人物圖片切換
        int goright = 0;
        int hit_hp = 3, point_timer = 0, eatscore = 0; //人物血量,物品重新產生時間,得分
        int timestop = 0;//遊戲暫停
        //----------------------------------------------
        //-----------怪物資訊--------------------------
        int gx = 0, gy = 120, mspeed = 4,touchg=0,beefly=0;//控制人物撞擊怪物圖片切換
        int boomx = 0, boomy = 0, boom_pictime = 0, boom_create = 0,boom_shake=0;
        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop(); this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timestop == 0) { timer1.Stop();timer2.Stop(); timestop += 1; return; }
            if (timestop == 1) { timer1.Start(); timer2.Start(); timestop -= 1; return; }
        }

        private void lab_score_Click(object sender, EventArgs e)
        {

        }

        
        SoundPlayer hit = new SoundPlayer("sound\\playersound.wav");
        SoundPlayer eat = new SoundPlayer("sound\\eatsound.wav");
        //SoundPlayer bk = new SoundPlayer(@"C:\Users\kay\source\repos\boombgame\boombgame\bin\Debug\sound\BeepBox.wav");



        public Form2()
        {
            InitializeComponent();
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {
           boom1.Location = new Point(-50, -50);
           player.Image = new Bitmap("pic\\the guy\\stand.png");
           player.Location = new Point(px, py);
           player.Parent = panel1;
            bee1.Parent = panel1;
           
           bee1.Image = new Bitmap("pic\\Bee\\costume1.png");
           bee1.Location = new Point(gx, gy);
           timer1.Start();
           timer2.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point_timer += 1;
            boom_create += 1;
            boom_pictime += 1;

            if (up)//角色移動
            {
                player.Location = new Point(px, py-speed); py -= speed; 

            }
            if (down)
            {
                player.Location = new Point(px, py + speed);py += speed;

            }
            if (left)
            {
                player.Location = new Point(px - speed, py); px -= speed;
            }
            if (right)
            {      
                player.Location = new Point(px+ speed, py ); px += speed;

            }
            if (bee1.Left > player.Left)//怪物追蹤
            {
                bee1.Left -= mspeed;
                
            }
            if (bee1.Top > player.Top)
            {
                bee1.Top -= mspeed;
            }
            if (bee1.Left < player.Left)
            {
                bee1.Left += mspeed;
            }
            if (bee1.Top < player.Top)
            {
                bee1.Top += mspeed;
            }
            boomx = bee1.Left;
            boomy = bee1.Top;

            if (boom_create >= 150)                          //炸彈產生
            {
                boom_pictime = 0;
                boom1.Size = new System.Drawing.Size(34, 38);
                boom1.Location = new Point(boomx-5, boomy+2);
                boom_create -= 150;
            }
            if (boom_pictime < 85)
            {
                switch (boom_shake)
                {
                    case 0:boom1.Left -= 3; boom_shake += 1; break;
                    case 1:boom1.Left += 3; boom_shake -= 1; break;
                }
            }
            switch (boom_pictime)
            {
                case 0:
                    boom1.Image = new Bitmap("pic\\bomb\\costume1.png"); break;               
                case 10:
                    boom1.Image = new Bitmap("pic\\bomb\\costume2.png"); break;
                case 20:
                    boom1.Image = new Bitmap("pic\\bomb\\costume3.png"); break;
                case 30:
                    boom1.Image = new Bitmap("pic\\bomb\\costume4.png");break;
                case 40:
                    boom1.Image = new Bitmap("pic\\bomb\\costume5.png"); break;
                case 50:
                    boom1.Image = new Bitmap("pic\\bomb\\costume6.png");  break;
                case 60:
                    boom1.Image = new Bitmap("pic\\bomb\\costume7.png"); break;
                case 70:
                    boom1.Image = new Bitmap("pic\\bomb\\costume8.png");  break;
                case 80:
                    boom1.Image = new Bitmap("pic\\bomb\\costume9.png"); break;
                case 81:
                    boom1.Image = new Bitmap("pic\\bomb\\costume10.png"); break;
                case 82:
                    boom1.Image = new Bitmap("pic\\bomb\\costume11.png"); break;
                case 83:
                    boom1.Image = new Bitmap("pic\\bomb\\costume11.png");  break;
                case 84:
                    boom1.Image = new Bitmap("pic\\bomb\\costume12.png");break;
                case 86:
                    boom1.Image = new Bitmap("pic\\bomb\\costume13.png"); boom1.Size = new System.Drawing.Size(50, 70); ; break;
                                       
            }
            if (player.Bounds.IntersectsWith(boom1.Bounds))  //碰到炸彈
            {
                hit_hp -= 1; boom_pictime = 82; touchg = 18;
                switch (boom_pictime)
                {
                    case 82:
                        boom1.Image = new Bitmap("pic\\bomb\\costume11.png"); break;
                    case 83:
                        boom1.Image = new Bitmap("pic\\bomb\\costume11.png"); break;
                    case 84:
                        boom1.Image = new Bitmap("pic\\bomb\\costume12.png"); break;
                    case 86:
                        boom1.Image = new Bitmap("pic\\bomb\\costume13.png"); boom1.Size = new System.Drawing.Size(50, 70); ; break;

                }
                if (touchg > 3)
                {
                    if (bee1.Left > player.Left)//往右
                    {
                        player.Image = new Bitmap("pic\\the guy\\hit.png");
                        player.Location = new Point(px - 25, py); px -= 25;
                        touchg -= 1;
                    }
                    if (bee1.Left < player.Left)//往左
                    {
                        img = new Bitmap("pic\\the guy\\hit.png");
                        img.RotateFlip(RotateFlipType.Rotate180FlipY);
                        player.Image = img;
                        player.Location = new Point(px + 25, py); px += 25;
                        touchg -= 1;
                    }
                    if (bee1.Top < player.Top) //往下彈
                    {
                        player.Image = new Bitmap("pic\\the guy\\hit.png");
                        player.Location = new Point(px, py + 25); py += 25;
                        touchg -= 1;
                    }
                    if (bee1.Top > player.Top) //往上彈
                    {
                        player.Image = new Bitmap("pic\\the guy\\hit.png");
                        player.Location = new Point(px, py - 12); py -= 12;
                        touchg -= 1;
                    }
                }
                if (3 >= touchg || touchg > 0)  //閃光換圖片
                {

                    switch (touchg)
                    {
                        case 3: player.Image = new Bitmap("pic\\the guy\\costume10.png"); touchg -= 1; break;
                        case 2: player.Image = new Bitmap("pic\\the guy\\costume11.png"); touchg -= 1; break;
                        case 1: player.Image = new Bitmap("pic\\the guy\\costume10.png"); touchg -= 1; break;
                    }
                }

                switch (hit_hp)
                {
                    case 2: pic_hp.Image = new Bitmap("pic\\hp\\2.png"); break;
                    case 1: pic_hp.Image = new Bitmap("pic\\hp\\1.png"); break;
                    case 0: pic_hp.Image = new Bitmap("pic\\hp\\0.png"); break;
                    case -1:
                        timer1.Stop();
                        timer2.Stop(); this.Dispose(); break;
                }
            }

            if (player.Bounds.IntersectsWith(point.Bounds))//吃到東西後重新產生
            {
                eat.Play();
                eatscore += 1;
                Form1.score = eatscore;
                point.Location = new Point(-5, -5);
                point.Visible = false;
                point_timer = 0;
                lab_score.Text = "" + eatscore;
            }
            if (point_timer >= 50)
            {
                Form1.score = eatscore;
                Random a = new Random();
                int x = a.Next(500);
                int y = a.Next(300);
                x += 50;
                y += 80;
                point.Location = new Point(x, y);
                point.Visible = true;
                point_timer = 0;
            }
                
                
                //碰撞獎勵
            if (player.Bounds.IntersectsWith(bee1.Bounds))//碰撞怪物彈跳判斷
            {
                hit.Play();
                hit_hp -= 1;
                switch (hit_hp) {
                    case 2: pic_hp.Image = new Bitmap("pic\\hp\\2.png");break;
                    case 1: pic_hp.Image = new Bitmap("pic\\hp\\1.png"); break;
                    case 0: pic_hp.Image = new Bitmap("pic\\hp\\0.png"); break;
                    case -1:
                        timer1.Stop();
                        timer2.Stop(); this.Dispose(); break;
                }
                touchg = 18;
            }
            if (touchg > 3)
            {
                if (bee1.Left > player.Left)//往右
                {
                    player.Image = new Bitmap("pic\\the guy\\hit.png");
                    player.Location = new Point(px - 25, py); px -= 25;
                    touchg -= 1;
                }
                if (bee1.Left < player.Left)//往左
                {
                    img = new Bitmap("pic\\the guy\\hit.png");
                    img.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Image = img;
                    player.Location = new Point(px + 25, py); px += 25;
                    touchg -= 1;
                }
                if (bee1.Top < player.Top) //往下彈
                {
                    player.Image = new Bitmap("pic\\the guy\\hit.png");
                    player.Location = new Point(px, py + 25); py += 25;
                    touchg -= 1;
                }
                if (bee1.Top > player.Top) //往上彈
                {
                    player.Image = new Bitmap("pic\\the guy\\hit.png");
                    player.Location = new Point(px, py - 12); py -= 12;
                    touchg -= 1;
                }
            }
            if (3 >= touchg || touchg > 0)  //閃光換圖片
            {

                switch (touchg)
                {
                    case 3: player.Image = new Bitmap("pic\\the guy\\costume10.png"); touchg -= 1; break;
                    case 2: player.Image = new Bitmap("pic\\the guy\\costume11.png"); touchg -= 1; break;
                    case 1: player.Image = new Bitmap("pic\\the guy\\costume10.png"); touchg -= 1; break;                   
                }
            }
            if (px >= 550) //邊界判斷
            {               
                if (py >= 300)
                {
                    player.Location = new Point(548, 290); px = 545;py = 290;
                }
                if (py <= 20)
                {
                    player.Location = new Point(548, 25); px = 545; py = 25;
                }
                else { player.Location = new Point(548, py); px =548;}
            }
            if (px <= 0)
            {
                if (py >= 300)
                {
                    player.Location = new Point(10, 290); px = 10; py = 290;
                }
                if (py <= 20)
                {
                    player.Location = new Point(10, 25); px = 10; py = 25;
                }
                else { player.Location = new Point(10, py); px = 10; }
            }
            if (py <= 20)
            {
                if (px >= 550)
                {
                    player.Location = new Point(548, 25); px = 548; py = 25;
                }
                if (px <= 0)
                {
                    player.Location = new Point(5, 25); px = 5; py = 25;
                }
                else { player.Location = new Point(px, 23); py = 23; }
            }
            if (py >= 300)
            {
                if (px >= 550)
                {
                    player.Location = new Point(548, 295); px = 548; py = 295;
                }
                if (px <= 0)
                {
                    player.Location = new Point(5, 295); px = 5; py = 295;
                }
                else { player.Location = new Point(px, 295); py = 295; }
            }






        }
        private void timer2_Tick(object sender, EventArgs e) //人物轉向圖片轉換判斷
        {

            switch (beefly) {
                case 1: bee1.Image = new Bitmap("pic\\Bee\\costume1.png"); beefly -= 1; break;
                case 0: bee1.Image = new Bitmap("pic\\Bee\\costume2.png"); beefly += 1; break;

            }


            if (up)
            {
                if (turnleft == 0)
                {

                    img = new Bitmap("pic\\the guy\\run4.png");
                    img.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Image = img;

                }
                else
                {
                    player.Image = new Bitmap("pic\\the guy\\run4.png");
                }
            }


            if (!up)
            {
                if (turnleft == 0)
                {
                    img = new Bitmap("pic\\the guy\\stand2.png");
                    img.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Image = img;
                }
               else player.Image = new Bitmap("pic\\the guy\\stand2.png");


            }
            if (down)
            {
                if (turnleft == 0)
                {

                    img = new Bitmap("pic\\the guy\\run4.png");
                    img.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Image = img;

                }
                else
                {
                    player.Image = new Bitmap("pic\\the guy\\run4.png");
                }
            }


            if (!down)
            {
                if (turnleft == 0)
                {
                    img = new Bitmap("pic\\the guy\\stand2.png");
                    img.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Image = img;
                }

                else player.Image = new Bitmap("pic\\the guy\\stand2.png");
            }


            if (left)
            {
                switch (goleft)
                {
                    case 0:
                        img = new Bitmap("pic\\the guy\\run1.png");
                        img.RotateFlip(RotateFlipType.Rotate180FlipY);
                        player.Image = img; goleft += 1; break;
                    case 1:
                        img = new Bitmap("pic\\the guy\\run2.png");
                        img.RotateFlip(RotateFlipType.Rotate180FlipY);
                        player.Image = img; goleft += 1; break;

                    case 2:

                        img = new Bitmap("pic\\the guy\\run3.png");
                        img.RotateFlip(RotateFlipType.Rotate180FlipY);
                        player.Image = img; goleft += 1; break;
                    case 3:

                        img = new Bitmap("pic\\the guy\\run4.png");
                        img.RotateFlip(RotateFlipType.Rotate180FlipY);
                        player.Image = img; goleft -= 3; break;
                }


            }
            if (right)
            {
                switch (goright)
                {
                    case 0:
                        player.Image = new Bitmap("pic\\the guy\\run1.png");
                        goright += 1; break;
                    case 1:
                        player.Image = new Bitmap("pic\\the guy\\run2.png");
                        goright += 1; break;

                    case 2:
                        player.Image = new Bitmap("pic\\the guy\\run3.png");
                        goright += 1; break;
                    case 3:
                        player.Image = new Bitmap("pic\\the guy\\run4.png");
                        goright -= 3; break;
                }
              
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left = true;
                    if (turnleft == 1)
                    {
                        turnleft -= 1;
                    }
                    break;
                case Keys.Up:
                    up = true;
                    
                    break;
                case Keys.Right:
                    right = true;
                    if (turnleft ==0)
                    {
                        turnleft += 1;
                    }
                    break;
                case Keys.Down:
                    down = true;
                   
                    break;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left = false;
                    img = new Bitmap("pic\\the guy\\stand2.png");
                    img.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Image = img; break;
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Right:
                    right = false;
                    player.Image = new Bitmap("pic\\the guy\\stand2.png");
                    break;
                case Keys.Down:
                    down = false;
                    break;
            }
        }
    }
}
