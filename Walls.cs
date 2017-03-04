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
    }
}
