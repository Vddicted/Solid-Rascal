﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Rascal
{
    class Program
    {
        public static MainGame game;

        static void Main(string[] args)
        {
            Console.SetWindowSize(110, 36);
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
            game = new MainGame();

        }
    }
}
