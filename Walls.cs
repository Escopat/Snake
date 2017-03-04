using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHaight)
        {
            wallList = new List<Figure>();

            //Оотрисовка рамочки
            HorizontalLine topline = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomline = new HorizontalLine(0, mapWidth - 2, mapHaight - 1, '+');
            VerticalLine leftline = new VerticalLine(0, mapHaight - 1, 0, '+');
            VerticalLine rightline = new VerticalLine(0, mapHaight - 1, mapWidth - 2, '+');

            wallList.Add(topline);
            wallList.Add(bottomline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

        public void GameOver()
        {
            int mapWidth = Console.BufferWidth;
            int mapHaight = Console.BufferHeight;
            string goText = "ИГРА ОКОНЧЕНА";
            string goAuthor = "Автор: Валерий Курочкин, 2017г.";
            string goGeek = "По урокам с сайта geekbrains.ru";


            Console.SetCursorPosition((mapWidth / 2) - (goText.Length / 2), (mapHaight / 2) - 2);
            Console.WriteLine(goText);
            Console.SetCursorPosition((mapWidth / 2) - (goAuthor.Length / 2), (mapHaight / 2));
            Console.WriteLine(goAuthor);
            Console.SetCursorPosition((mapWidth / 2) - (goGeek.Length / 2), (mapHaight / 2) + 1);
            Console.WriteLine(goGeek);


            HorizontalLine UpLine = new HorizontalLine(mapWidth / 3 - 10, mapWidth - (mapWidth / 3) + 10, (mapHaight / 2) - 3, '=');
            HorizontalLine DownLine = new HorizontalLine(mapWidth / 3 - 10, mapWidth - (mapWidth / 3) + 10, (mapHaight / 2) + 3, '=');

            Console.ForegroundColor = ConsoleColor.Yellow;
            UpLine.Draw();
            DownLine.Draw();

            Console.ReadLine();
        }
    }
}
