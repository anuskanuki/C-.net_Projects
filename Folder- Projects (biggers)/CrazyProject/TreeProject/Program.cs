using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;

namespace TreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAsk();
            Console.ReadKey();
        }
        public static void UserAsk()
        {
            Console.WriteLine("\n-----What do you want to do?-----\n");
            Console.WriteLine("ENTER 1 to show a tree\n ");
            Console.WriteLine("ENTER 2 to calclulate a square area\n ");
            Console.WriteLine("ENTER 3 to show a beer list\n ");
            Console.WriteLine("ENTER 4 to show a car brands list\n ");
            var userAnswer = int.Parse(Console.ReadLine());
            switch (userAnswer)
            {
                case 1:
                    Tree();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("----Square Area Calculator----");
                    Console.WriteLine("\nType the square side measurement:\n ");
                    SquareAreaCalculation(double.Parse(Console.ReadLine()));
                    break;
                case 3:
                    BeerList();
                    break;
                case 4:
                    CarsList();
                    break;
                default:
                    Console.WriteLine("Type a valid number to proceed");
                    break;
            }
        }

        public static void CarsList()
        {
            Console.Clear();
            Console.WriteLine("\n--- Cars Brand List: ---\n");
            Console.WriteLine(@"Renault
Volkswagen
KIA
Hyundai
Fiat
Ford");

        }
        public static void BeerList()
        {
            Console.Clear();
            Console.WriteLine("\n--- Beer List: ---\n");
            Console.WriteLine(@"Skol 
Brahma
Itaipava
Amstel
Devassa
Heineken
Budweiser
Antarctica");

        }
        public static void SquareAreaCalculation(double side)
        {
            double squareArea = 0.0;
            squareArea = side * side;
            Console.WriteLine("\nCalculated Area=  " + squareArea.ToString());
        }

        public static void Tree()
        {
            Image image = Image.FromFile(@"C:\Users\900067\Downloads\nuki.gif"); //tamanho max 50x50
            FrameDimension dimension = new FrameDimension(image.FrameDimensionsList[0]);
            int frameCount = image.GetFrameCount(dimension);
            StringBuilder sb;

            int left = Console.WindowLeft, top = Console.WindowTop;

            char[] chars = { '.', '#', '@', '%', '=', '.', '*', ':', '-', '.', ' ' };

            for (int i = 0; ; i = (i + 1) % frameCount)
            {
                sb = new StringBuilder();
                image.SelectActiveFrame(dimension, i);

                for (int h = 0; h < image.Height; h++)
                {
                    for (int w = 0; w < image.Width; w++)
                    {
                        Color cl = ((Bitmap)image).GetPixel(w, h);
                        int gray = (cl.R + cl.R + cl.B) / 3;
                        int index = (gray * (chars.Length - 1)) / 255;

                        sb.Append(chars[index]);
                    }
                    sb.Append('\n');
                }

                Console.SetCursorPosition(left, top);
                Console.Write(sb.ToString());

                System.Threading.Thread.Sleep(600);
            }
        }

        static Image ScaleImage(Image source, int width, int height)
        {
            Image dest = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(dest))
            {
                gr.FillRectangle(Brushes.White, 0, 0, width, height);
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                float srcwidth = source.Width;
                float srcheight = source.Height;
                float dstwidth = width;
                float dstheight = height;

                if (srcwidth <= dstwidth && srcheight <= dstheight)
                {
                    int left = (width - source.Width) / 2;
                    int top = (height - source.Height) / 2;
                    gr.DrawImage(source, left, top, source.Width, source.Height);
                }
                else if (srcwidth / srcheight > dstwidth * dstheight)
                {
                    float cy = srcheight / srcwidth * dstwidth;
                    float top = ((float)dstheight - cy) / 2.0f;
                    if (top < 1.0f) top = 0;
                    gr.DrawImage(source, 0, top, dstwidth, cy);
                }
                else
                {
                    float cx = srcwidth / srcheight * dstheight;
                    float left = ((float)dstwidth - cx) / 2.0f;
                    if (left < 1.0f) left = 0;
                    gr.DrawImage(source, 0, left, cx, dstheight);
                }
                return dest;
            }
        }


    }
}
