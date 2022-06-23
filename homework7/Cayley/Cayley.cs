using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cayley
{
    class Cayley
    {
        Graphics graphics;
        double th1;//右分支角度
        double th2;//左分支角度
        double per1;//右分支长度比
        double per2;//左分支长度比
        double leng;//主干长度
        int n;//递归深度
        Pen color;//画笔颜色

        public Graphics Graphics { get => graphics; set => graphics = value; }
        public double Th1 { get => th1; set => th1=value; }
        public Pen Color { get => color; set => color = value; }
        public double Th2 { get => th2; set => th2 = value; }
        public double Per1 { get => per1; set => per1 = value; }
        public double Per2 { get => per2; set => per2 = value; }
        public double Leng { get => leng; set => leng = value; }
        public int N { get => n; set => n = value; }
        public Cayley(int n,double th1,double th2,double per1,double per2,double leng)
        {
            this.graphics = null;
            this.color = null;
            this.n = n;
            this.per1 = per1;
            this.per2 = per2;
            this.th1 = th1;
            this.th2 = th2;
            this.leng = leng;
        }
        public Cayley()
        {
            this.graphics = null;
            this.color = null;
            this.n = 3;
            this.per1 =0.6 ;
            this.per2 = 0.7;
            this.th1 = 30;
            this.th2 = 20;
            this.leng = 100;
        }

        public void drawCayley(int n,double x0,double y0,double th,double leng)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayley(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayley(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(this.color, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
