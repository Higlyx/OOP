using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            //Отрисовка границ
            Horizontal Top = new Horizontal(1, 119, 1, '#');
            Horizontal Bottom = new Horizontal(1, 119, 29, '#');
            Vertical Left = new Vertical(1, 0, 28, '#');
            Vertical Right = new Vertical(119, 0, 28, '#');
            Top.Draw();
            Bottom.Draw();
            Left.Draw();
            Right.Draw();

            //Отрисовка точек
            Point p1 = new Point(5, 5, 'o');
            p1.Draw();
            Point p2 = new Point(6, 8, 'o');
            p2.Draw();
            Point p3 = new Point(10, 5, 'o');
            p3.Draw();

            //Отрисовка змейки
            Point s = new Point(5, 10, '*');
            Snake snake = new Snake(s, 4, Direction.UP);
            snake.Draw();

            Console.ReadLine();//Написать класс горизонтальных линий и класс вертикальных
        }
    }
}
