using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SnakeWinForm
{
    class Place //поле
    {
        Blocks blocks_a = new Blocks();
        Snake snake_a = new Snake();
        Eat eat_a; 
        PictureBox myPB;
        Color myBackGround = Color.LightGray;
        public int Schet = 0;
        int sizeX = 50;
        int sizeY = 50;
        int koeff;
        public Place (PictureBox a)
        {
            koeff = a.Height / sizeY;
            Random r = new Random();
            myPB=a;
            eat_a=new Eat(new Point(r.Next(sizeX),r.Next(sizeY)), new Point(r.Next(sizeX),r.Next(sizeY)));
            Load_lvl();
        }
        public void Load_lvl()
        {
            StreamReader read = new StreamReader("Snake_map.txt");
            int strokY = 0;
            while (!read.EndOfStream)
            {
                string stroka = read.ReadLine();
                for(int i = 0; i < stroka.Length; i++)
                {
                    if (stroka[i] == '*')
                    {
                        blocks_a.add(new Point(i, strokY));
                    }
                    if(stroka[i] == '$' /*&& stroka[i] < stroka[i+1) && strokY*/)
                    {
                        snake_a.add(new Point(i, strokY));
                    }
                    
                }
                strokY++;
            }
        }
        public void Show()
        {
            Graphics h = Graphics.FromImage(myPB.Image);
            SolidBrush s = new SolidBrush(myBackGround);
            h.FillRectangle(s, 0, 0, myPB.Width, myPB.Height);
            for(int i = 0; i <eat_a.body.Count; i++)
            {
                SolidBrush eatbrush = new SolidBrush(eat_a.a_color);
                h.FillRectangle(eatbrush, eat_a.body[i].x * koeff, eat_a.body[i].y * koeff, koeff, koeff);
            }
           // SolidBrush snakebrush = new SolidBrush(snake_a.snake_color);
            h.FillRectangle(new SolidBrush(Color.Black), snake_a.body[0].x * koeff, snake_a.body[0].y * koeff, koeff, koeff);
            for (int i = 1; i < snake_a.body.Count; i++)
            {
                SolidBrush snakebrush = new SolidBrush(snake_a.a_color);
                h.FillRectangle(snakebrush, snake_a.body[i].x * koeff, snake_a.body[i].y * koeff, koeff, koeff);
            }

            for (int i = 0; i < blocks_a.body.Count; i++)
            {
                SolidBrush blocksbrush = new SolidBrush(blocks_a.a_color);
                h.FillRectangle(blocksbrush, blocks_a.body[i].x * koeff, blocks_a.body[i].y * koeff, koeff, koeff);
            }
            myPB.Refresh();
        }
        public void DelEat(int x, int y)
        {
            for (int i = 0; i < eat_a.body.Count; i++)
            {
                if(snake_a.colission( eat_a.body[i]))
                {
                    //увеличить червяка и сгенерировать еду
                    snake_a.scale(eat_a.body[i],x,y);
                    bool eat_proverka = true;
                    Schet++;
                    do
                    {
                        Point p = eat_a.addeat(i, sizeX, sizeY);
                        for(int j = 0; j < blocks_a.body.Count; j++)
                        {
                            if(p.x == blocks_a.body[j].x && p.y == blocks_a.body[j].y)
                            {
                                eat_proverka = false;
                                break;
                            }
                        }if(eat_proverka == true)
                        {
                            for(int k= 0; k < snake_a.body.Count; k++)
                            {
                                if(snake_a.body[k].x == p.x && snake_a.body[k].y == p.y)
                                {
                                    eat_proverka = false;
                                    break;
                                }
                            }
                        }

                    }
                    while (!eat_proverka);
                }
            }
        }
        public void DelObject()
            {
                Graphics h = Graphics.FromImage(myPB.Image);
                SolidBrush s = new SolidBrush(myBackGround);
                h.FillRectangle(s, 0, 0, myPB.Width, myPB.Height);
            }
        public bool Crush()
        {
            bool prov = true;
            for(int i = 0; i < blocks_a.body.Count; i++)
            {
                if(blocks_a.body[i].x == snake_a.body[0].x && blocks_a.body[i].y == snake_a.body[0].y)
                {
                    prov = false;
                    break;
                }
            }
            if(prov == true)
            {
                for(int j = 1; j<snake_a.body.Count; j++)
                {
                    if(snake_a.body[j].x == snake_a.body[0].x && snake_a.body[j].y == snake_a.body[0].y)
                    {
                        prov = false;
                        break;
                    }
                }
            }
            return prov;
            
        }
            public bool Move(int key)
            {
            bool a = true;
            int x=0;
            int y=0;
                switch (key)
                {
                    case 1:
                        {
                            snake_a.move(0, -1);
                        x = 0; y = -1;
                            break;
                        }
                    case 2:
                        {
                            snake_a.move(0, 1);
                        x = 0;y = 1;
                            break;
                        }
                    case 3:
                        {
                            snake_a.move(-1, 0);
                        x = -1; y = 0;
                            break;
                        }
                    case 4:
                        {
                            snake_a.move(1, 0);
                        x = 1; y = 0;
                            break;
                        }

                }
            DelEat(x,y);
           a = Crush();
            Show();
            return a;
            }
       
        
    }
}
