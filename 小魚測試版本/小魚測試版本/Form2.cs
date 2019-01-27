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

namespace 小魚測試版本
{
    public partial class Form2 : Form
    {
        SoundPlayer hit = new SoundPlayer("music\\被障礙物打到.wav");
        SoundPlayer mus_exp = new SoundPlayer("music\\吃到魚.wav");
        SoundPlayer mus_lvup = new SoundPlayer("music\\進化.wav");
        int x = 550, y = 200, timestop = 0, hp_timer = 6, exp_timer = 1, LV = 1,eat_fish=0;//player location

        int bkx = -5, bky = 300;//bkground location
        int bk1x = -630, bk1y = 300;//bkground2 location
        int gx =2, gy =100, gx1 = -400, gy1 = 200;
        int fx = -200, fy = 170;
        bool up, down;//player move
        
        
        

        List<PictureBox> a = new List<PictureBox>();
        public Form2()
        {
            InitializeComponent();
            
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            player.Image = new Bitmap("exp\\LV1.png");
            player.Size = new System.Drawing.Size(25, 20);
            bk1.Image = new Bitmap("bk\\1.png");
            bk2.Image = new Bitmap("bk\\2.png");
            player.Location = new Point(x, y);
            bk1.Location = new Point(bkx, bky);
            bk2.Location = new Point(bk1x, bk1y);
            creat_pic gbr = new creat_pic();
            PictureBox gb = gbr.picbox(gx, gy, "gb\\3");
            PictureBox gb1 =gbr.picbox(gx1, gy1, "gb\\2");
            PictureBox f1 = gbr.picbox(fx, fy, "fish\\1");
            f1.Size = new System.Drawing.Size(40, 30);
            panel1.Controls.Add(gb);
            panel1.Controls.Add(gb1);
            panel1.Controls.Add(f1);
            a.Add(gb);
            a.Add(gb1);
            a.Add(f1);
        }

        private void stop_Click(object sender, EventArgs e)//game stop
        {
            if (timestop == 0) { timer1.Stop(); timestop += 1;return; }
            if (timestop == 1) { timer1.Start(); timestop -= 1; return; }
        }

        private void close_box_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox gb = a[0];
            PictureBox gb1 = a[1];
            PictureBox f1 = a[2];
            f1.Location = new Point(fx + 20, fy); fx += 20;
            gb.Location = new Point(gx + 20, gy); gx += 20;
            gb1.Location = new Point(gx1 + 20, gy1); gx1 += 20;
            bk1.Location = new Point(bkx +10, bky); bkx += 10;
            bk2.Location = new Point(bk1x + 10, bk1y); bk1x += 10;


            if (up) //人物移動判斷
            {
                player.Location = new Point(x, y - 5);
                y -= 5;
            }
            if (down)
            {
                player.Location = new Point(x, y + 5);
                y += 5;
            }

            if (player.Bounds.IntersectsWith(f1.Bounds))//碰撞+exp
            {
                eat_fish += 1;
                Form1.eat_fish = eat_fish;
                mus_exp.Play();


                switch (exp_timer)
                {

                    case 1:exp_pic.Image = new Bitmap("exp\\LV02.png"); exp_timer += 1; break;
                    case 2: exp_pic.Image = new Bitmap("exp\\LV03.png"); exp_timer += 1; break;
                    case 3: exp_pic.Image = new Bitmap("exp\\LV04.png"); exp_timer += 1; break;
                    case 4: exp_pic.Image = new Bitmap("exp\\LV05.png"); exp_timer += 1; break;
                    case 5: exp_pic.Image = new Bitmap("exp\\LV06.png"); exp_timer += 1; break;
                    case 6: exp_pic.Image = new Bitmap("exp\\LV07.png"); exp_timer += 1; break;
                    case 7: exp_pic.Image = new Bitmap("exp\\LV08.png"); exp_timer += 1; break;
                    case 8: exp_pic.Image = new Bitmap("exp\\LV09.png"); exp_timer += 1; break;
                    case 9: exp_pic.Image = new Bitmap("exp\\LV10.png"); exp_timer += 1; break;                    
                    case 10: exp_pic.Image = new Bitmap("exp\\LV01.png"); exp_timer -= 9;LV += 1; mus_lvup.Play(); break;
                        


                }
                switch (LV)
                {
                    case 2:
                       
                        player.Image = new Bitmap("exp\\LV2.png"); player.Size = new System.Drawing.Size(30, 25);
                        lvup.Image = new Bitmap("exp\\2.png");
                        
                        break;
                    case 3:
                        
                        player.Image = new Bitmap("exp\\LV3.png"); player.Size = new System.Drawing.Size(35, 25);
                        lvup.Image = new Bitmap("exp\\3.png");
                        
                        break;
                    case 4:
                        
                        player.Image = new Bitmap("exp\\LV4.png"); player.Size = new System.Drawing.Size(40, 40);
                        lvup.Image = new Bitmap("exp\\4.png");
                        
                        break;
                    case 5:
                        
                        player.Image = new Bitmap("exp\\LV5.png"); player.Size = new System.Drawing.Size(50, 55);
                        lvup.Image = new Bitmap("exp\\5.png");
                        
                        break;
                    case 6: timer1.Stop(); this.Close(); break;


                }

            }



            if (fx >= 630 || (f1.Bounds.IntersectsWith(player.Bounds)) || (f1.Bounds.IntersectsWith(gb1.Bounds))|| (f1.Bounds.IntersectsWith(gb.Bounds)))    //小於回放
            {
                Random d = new Random();
                int z = d.Next(3);
                z += 1;
                int y = d.Next(200);
                y += 50;
                f1.Image = new Bitmap("fish\\" + z + ".png");
                fx = -200; fy = y;
                f1.Location = new Point(fx, fy);
                

            }
            if (gb.Bounds.IntersectsWith(player.Bounds))//碰撞扣血
            {
                hit.Play();
                switch (hp_timer)
                {
                    case 6: hp_pic.Image = new Bitmap("hp\\HP06.png"); hp_timer -= 1; break;
                    case 5: hp_pic.Image = new Bitmap("hp\\HP05.png"); hp_timer -= 1; break;
                    case 4: hp_pic.Image = new Bitmap("hp\\HP04.png"); hp_timer -= 1; break;
                    case 3: hp_pic.Image = new Bitmap("hp\\HP03.png"); hp_timer -= 1; break;
                    case 2: hp_pic.Image = new Bitmap("hp\\HP02.png"); hp_timer -= 1; break;
                    case 1: hp_pic.Image = new Bitmap("hp\\HP01.png"); hp_timer -= 1; break;
                    case 0: hp_timer -= 1; timer1.Stop(); this.Close(); break;

                        

                }


            }
            if (gx >= 630 || (gb.Bounds.IntersectsWith(player.Bounds))|| (gb.Bounds.IntersectsWith(gb1.Bounds)))    //gb的回放
            {
                Random d = new Random();
                int z = d.Next(5);
                z += 1;
                int y = d.Next(200);
                y += 50;
                gb.Image = new Bitmap("gb\\" + z + ".png");
                gx = -50; gy = y;
                gb.Location = new Point(gx, y);


            }
            if (player.Bounds.IntersectsWith(gb1.Bounds))//碰撞扣血
            {
                hit.Play();
                switch (hp_timer)
                {
                    case 6: hp_pic.Image = new Bitmap("hp\\HP06.png"); hp_timer -= 1; break;
                    case 5: hp_pic.Image = new Bitmap("hp\\HP05.png"); hp_timer -= 1; break;
                    case 4: hp_pic.Image = new Bitmap("hp\\HP04.png"); hp_timer -= 1; break;
                    case 3: hp_pic.Image = new Bitmap("hp\\HP03.png"); hp_timer -= 1; break;
                    case 2: hp_pic.Image = new Bitmap("hp\\HP02.png"); hp_timer -= 1; break;
                    case 1: hp_pic.Image = new Bitmap("hp\\HP01.png"); hp_timer -= 1; break;
                    case 0: hp_timer -= 1; timer1.Stop(); this.Close(); break;

                }
            }

            if (gx1 >= 630 || gb1.Bounds.IntersectsWith(player.Bounds))    //gb1的回放
            {
                Random d = new Random();
                int z = d.Next(5);
                z += 1;
                int y = d.Next(200);
                y += 50;

                gb1.Image = new Bitmap("gb\\" + z + ".png");
                gx1 = -50; gy1 = y;
                if (gy1 == gy) { int y1 = d.Next(200); gy1 = y1; }
                gb1.Location = new Point(gx1, gy1);
                
            }



            if (bkx >= 630)  //泥土的回放第一張
            {
                Random a = new Random();
                int b = a.Next(5);
                b += 1;
                bk1.Image = new Bitmap("bk\\" + b + ".png");
                bk1.Location = new Point(-610, 300);

                bkx = -610;
            }
            if (bk1x >= 630)  //泥土的回放第一張
            {
                Random a = new Random();
                int b = a.Next(5);
                b += 1;
                bk2.Image = new Bitmap("bk\\" + b + ".png");
                bk2.Location = new Point(-610, 300);

                bk1x = -610;
            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:

                    timer1.Enabled = true;
                    break;
                case Keys.Up:

                    up = false;
                    break;
                case Keys.Right:

                    break;
                case Keys.Down:
                    down = false;

                    break;

            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    
                    timer1.Enabled = true;
                    break;
                case Keys.Up:
                    if (stop.Bounds.IntersectsWith(player.Bounds)|| close_box.Bounds.IntersectsWith(player.Bounds))
                    {
                        up = false;
                        break;
                    }
                    else
                    
                        up = true;
                        break;
                    
                   
                case Keys.Right:
                    
                    break;
                case Keys.Down:
                    if ((player.Bounds.IntersectsWith(bk1.Bounds))|| (player.Bounds.IntersectsWith(bk2.Bounds)))
                    {
                        down = false;
                        break;
                    }
                    else

                        down = true;
                    break;
            }
        }
    }
}
