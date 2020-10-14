using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CompGraphisc_Number_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float sizeH, sizeW;
        float newH = 1, newW = 1;
        
        static SolidBrush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(brush, 3);
        Graphics g;

        PointF p1_Н = new PointF(50, 50);
        PointF p2_Н = new PointF(100, 50);
        PointF p3_Н = new PointF(100, 150);
        PointF p4_Н = new PointF(150, 150);
        PointF p5_Н = new PointF(150, 50);
        PointF p6_Н = new PointF(200, 50);
        PointF p7_Н = new PointF(200, 300);
        PointF p8_Н = new PointF(150, 300);
        PointF p9_Н = new PointF(150, 200);
        PointF p10_Н = new PointF(100, 200);
        PointF p11_Н = new PointF(100, 300);
        PointF p12_Н = new PointF(50, 300);

        PointF p1_И = new PointF(250, 50);
        PointF p2_И = new PointF(300, 50);
        PointF p3_И = new PointF(300, 200);
        PointF p4_И = new PointF(400, 50);
        PointF p5_И = new PointF(450, 50);
        PointF p6_И = new PointF(450, 300);
        PointF p7_И = new PointF(400, 300);
        PointF p8_И = new PointF(400, 150);
        PointF p9_И = new PointF(300, 300);
        PointF p10_И = new PointF(250, 300);

        PointF p1_К = new PointF(500, 50);
        PointF p2_К = new PointF(550, 50);
        PointF p3_К = new PointF(550, 150);
        PointF p4_К = new PointF(650, 50);
        PointF p5_К = new PointF(700, 50);
        PointF p6_К = new PointF(575, 175);
        PointF p7_К = new PointF(700, 300);
        PointF p8_К = new PointF(650, 300);
        PointF p9_К = new PointF(550, 200);
        PointF p10_К = new PointF(550, 300);
        PointF p11_К = new PointF(500, 300);

        PointF p1_И2 = new PointF(250 + 500, 50);
        PointF p2_И2 = new PointF(300 + 500, 50);
        PointF p3_И2 = new PointF(300 + 500, 200);
        PointF p4_И2 = new PointF(400 + 500, 50);
        PointF p5_И2 = new PointF(450 + 500, 50);
        PointF p6_И2 = new PointF(450 + 500, 300);
        PointF p7_И2 = new PointF(400 + 500, 300);
        PointF p8_И2 = new PointF(400 + 500, 150);
        PointF p9_И2 = new PointF(300 + 500, 300);
        PointF p10_И2 = new PointF(250 + 500, 300);

        PointF p1_Т = new PointF(1000, 50);
        PointF p2_Т = new PointF(1250, 50);
        PointF p3_Т = new PointF(1250, 100);
        PointF p4_Т = new PointF(1150, 100);
        PointF p5_Т = new PointF(1150, 300);
        PointF p6_Т = new PointF(1100, 300);
        PointF p7_Т = new PointF(1100, 100);
        PointF p8_Т = new PointF(1000, 100);

        PointF p1_A = new PointF(1400, 50);
        PointF p2_A = new PointF(1500, 300);
        PointF p3_A = new PointF(1450, 300);
        PointF p4_A = new PointF(1425, 225);
        PointF p5_A = new PointF(1375, 225);
        PointF p6_A = new PointF(1350, 300);
        PointF p7_A = new PointF(1300, 300);
        PointF p8_A = new PointF(1400, 125);
        PointF p9_A = new PointF(1425, 200);
        PointF p10_A = new PointF(1375, 200);




        private void Form1_Load(object sender, EventArgs e)
        {
            sizeH = ClientSize.Height;
            sizeW = ClientSize.Width;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            newH = ClientSize.Height / sizeH;
            newW = ClientSize.Width / sizeW;

            Invalidate();
        }

        public PointF SetPoint(PointF point, float H, float W)
        {
            PointF temP = new PointF(point.X * W, point.Y * H);
            return temP;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();       
            GraphicsPath path = new GraphicsPath();
            GraphicsPath Defpath = new GraphicsPath();
            GraphicsPath Defpath2 = new GraphicsPath();
            Region gp, gp2;
            
            //Н
            PointF np1_Н = SetPoint(p1_Н, newH, newW);
            PointF np2_Н = SetPoint(p2_Н, newH, newW);
            PointF np3_Н = SetPoint(p3_Н, newH, newW);
            PointF np4_Н = SetPoint(p4_Н, newH, newW);
            PointF np5_Н = SetPoint(p5_Н, newH, newW);
            PointF np6_Н = SetPoint(p6_Н, newH, newW);
            PointF np7_Н = SetPoint(p7_Н, newH, newW);
            PointF np8_Н = SetPoint(p8_Н, newH, newW);
            PointF np9_Н = SetPoint(p9_Н, newH, newW);
            PointF np10_Н = SetPoint(p10_Н, newH, newW);
            PointF np11_Н = SetPoint(p11_Н, newH, newW);
            PointF np12_Н = SetPoint(p12_Н, newH, newW);
            
            //И
            PointF np1_И = SetPoint(p1_И, newH, newW);
            PointF np2_И = SetPoint(p2_И, newH, newW);
            PointF np3_И = SetPoint(p3_И, newH, newW);
            PointF np4_И = SetPoint(p4_И, newH, newW);
            PointF np5_И = SetPoint(p5_И, newH, newW);
            PointF np6_И = SetPoint(p6_И, newH, newW);
            PointF np7_И = SetPoint(p7_И, newH, newW);
            PointF np8_И = SetPoint(p8_И, newH, newW);
            PointF np9_И = SetPoint(p9_И, newH, newW);
            PointF np10_И = SetPoint(p10_И, newH, newW);

            //К
            PointF np1_К = SetPoint(p1_К, newH, newW);
            PointF np2_К = SetPoint(p2_К, newH, newW);
            PointF np3_К = SetPoint(p3_К, newH, newW);
            PointF np4_К = SetPoint(p4_К, newH, newW);
            PointF np5_К = SetPoint(p5_К, newH, newW);
            PointF np6_К = SetPoint(p6_К, newH, newW);
            PointF np7_К = SetPoint(p7_К, newH, newW);
            PointF np8_К = SetPoint(p8_К, newH, newW);
            PointF np9_К = SetPoint(p9_К, newH, newW);
            PointF np10_К = SetPoint(p10_К, newH, newW);
            PointF np11_К = SetPoint(p11_К, newH, newW);

            //И2
            PointF np1_И2 = SetPoint(p1_И2, newH, newW);
            PointF np2_И2 = SetPoint(p2_И2, newH, newW);
            PointF np3_И2 = SetPoint(p3_И2, newH, newW);
            PointF np4_И2 = SetPoint(p4_И2, newH, newW);
            PointF np5_И2 = SetPoint(p5_И2, newH, newW);
            PointF np6_И2 = SetPoint(p6_И2, newH, newW);
            PointF np7_И2 = SetPoint(p7_И2, newH, newW);
            PointF np8_И2 = SetPoint(p8_И2, newH, newW);
            PointF np9_И2 = SetPoint(p9_И2, newH, newW);
            PointF np10_И2 = SetPoint(p10_И2, newH, newW);

            //Т
            PointF np1_Т = SetPoint(p1_Т, newH, newW);
            PointF np2_Т = SetPoint(p2_Т, newH, newW);
            PointF np3_Т = SetPoint(p3_Т, newH, newW);
            PointF np4_Т = SetPoint(p4_Т, newH, newW);
            PointF np5_Т = SetPoint(p5_Т, newH, newW);
            PointF np6_Т = SetPoint(p6_Т, newH, newW);
            PointF np7_Т = SetPoint(p7_Т, newH, newW);
            PointF np8_Т = SetPoint(p8_Т, newH, newW);

            //А
            PointF np1_A = SetPoint(p1_A, newH, newW);
            PointF np2_A = SetPoint(p2_A, newH, newW);
            PointF np3_A = SetPoint(p3_A, newH, newW);
            PointF np4_A = SetPoint(p4_A, newH, newW);
            PointF np5_A = SetPoint(p5_A, newH, newW);
            PointF np6_A = SetPoint(p6_A, newH, newW);
            PointF np7_A = SetPoint(p7_A, newH, newW);
            PointF np8_A = SetPoint(p8_A, newH, newW);
            PointF np9_A = SetPoint(p9_A, newH, newW);
            PointF np10_A = SetPoint(p10_A, newH, newW);



            //_____________________________________________________________________          


            //Н
            path.AddLine(np1_Н, np2_Н);
            path.AddLine(np2_Н, np3_Н);
            path.AddLine(np3_Н, np4_Н);
            path.AddLine(np4_Н, np5_Н);
            path.AddLine(np5_Н, np6_Н);
            path.AddLine(np6_Н, np7_Н);
            path.AddLine(np7_Н, np8_Н);
            path.AddLine(np8_Н, np9_Н);
            path.AddLine(np9_Н, np10_Н);
            path.AddLine(np10_Н, np11_Н);
            path.AddLine(np11_Н, np12_Н);
            path.AddLine(np12_Н, np1_Н);

            //И
            path.AddLine(np1_И, np2_И);
            path.AddLine(np2_И, np3_И);
            path.AddLine(np3_И, np4_И);
            path.AddLine(np4_И, np5_И);
            path.AddLine(np5_И, np6_И);
            path.AddLine(np6_И, np7_И);
            path.AddLine(np7_И, np8_И);
            path.AddLine(np8_И, np9_И);
            path.AddLine(np9_И, np10_И);
            path.AddLine(np10_И, np1_И);

            //К
            path.AddLine(np1_К, np2_К);
            path.AddLine(np2_К, np3_К);
            path.AddLine(np3_К, np4_К);
            path.AddLine(np4_К, np5_К);
            path.AddLine(np5_К, np6_К);
            path.AddLine(np6_К, np7_К);
            path.AddLine(np7_К, np8_К);
            path.AddLine(np8_К, np9_К);
            path.AddLine(np9_К, np10_К);
            path.AddLine(np10_К, np11_К);
            path.AddLine(np11_К, np1_К);

            //И2
            path.AddLine(np1_И2, np2_И2);
            path.AddLine(np2_И2, np3_И2);
            path.AddLine(np3_И2, np4_И2);
            path.AddLine(np4_И2, np5_И2);
            path.AddLine(np5_И2, np6_И2);
            path.AddLine(np6_И2, np7_И2);
            path.AddLine(np7_И2, np8_И2);
            path.AddLine(np8_И2, np9_И2);
            path.AddLine(np9_И2, np10_И2);
            path.AddLine(np10_И2, np1_И2);

            //Т
            path.AddLine(np1_Т, np2_Т);
            path.AddLine(np2_Т, np3_Т);
            path.AddLine(np3_Т, np4_Т);
            path.AddLine(np4_Т, np5_Т);
            path.AddLine(np5_Т, np6_Т);
            path.AddLine(np6_Т, np7_Т);
            path.AddLine(np7_Т, np8_Т);
            path.AddLine(np8_Т, np1_Т);

            //А
            path.AddLine(np1_A, np2_A);
            path.AddLine(np2_A, np3_A);
            path.AddLine(np3_A, np4_A);
            path.AddLine(np4_A, np5_A);
            path.AddLine(np5_A, np6_A);
            path.AddLine(np6_A, np7_A);
            path.AddLine(np7_A, np1_A);
            Defpath.AddLine(np8_A, np9_A);
            Defpath.AddLine(np9_A, np10_A);
            Defpath.AddLine(np10_A, np8_A);


            gp = new Region(Defpath);
            gp2 = new Region(Defpath2);
            e.Graphics.ExcludeClip(gp);
            e.Graphics.ExcludeClip(gp2);
            e.Graphics.FillPath(brush, path);
        } 
    }
}
