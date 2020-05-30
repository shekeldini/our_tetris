﻿using System;
using System.Drawing;

namespace Tetris
{
    class ShapeFactory
    {
        // Фигуры
        private static readonly int[,] tetr1 = new int[4, 4]{
            {0,0,1,0  },
            {0,0,1,0  },
            {0,0,1,0  },
            {0,0,1,0  },
        };

        private static readonly int[,] tetr2 = new int[3, 3]{
            {0,2,0  },
            {0,2,2 },
            {0,0,2 },
        };

        private static readonly int[,] tetr3 = new int[3, 3]{
            {0,0,0  },
            {3,3,3 },
            {0,3,0 },
        };

        private static readonly int[,] tetr4 = new int[3, 3]{
            { 4,0,0  },
            {4,0,0 },
            {4,4,0 },
        };
        private static readonly int[,] tetr5 = new int[2, 2]{
            { 5,5  },
            {5,5 },
        };
        private static readonly int[,] tetr6 = new int[3, 3]{
            { 0,0,6  },
            {0,6,6 },
            {0,6,0 },
        };

        private static readonly int[,] tetr7 = new int[3, 3]{
            { 0,7,7  },
            {0,0,7 },
            {0,0,7 },
        };

        // Генерация фигур
        public static Shape GenerateShape(int x, int y)
        {
            Random r = new Random();
            switch (r.Next(1, 8))
            {
                case 1:
                    return new Shape(x, y, tetr1, Brushes.Red);
                case 2:
                    return new Shape(x, y, tetr2, Brushes.Green);
                case 3:
                    return new Shape(x, y, tetr3, Brushes.Yellow);
                case 4:
                    return new Shape(x, y, tetr4, Brushes.Purple);
                case 5:
                    return new Shape(x, y, tetr5, Brushes.Blue);
                case 6:
                    return new Shape(x, y, tetr6, Brushes.Pink);
                default:
                    return new Shape(x, y, tetr7, Brushes.Black);
            }
        }
    }
}
