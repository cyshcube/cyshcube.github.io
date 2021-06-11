using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] m = new char[8, 10] { {'□','□','■','□','■','□','□','□','□','■'},
                                          {'■','□','■','□','■','■','■','■','□','■'},
                                          {'■','□','□','□','□','□','□','□','□','■'},
                                          {'■','■','■','□','■','■','■','■','□','■'},
                                          {'■','□','□','□','□','□','□','■','■','■'},
                                          {'■','■','■','■','□','■','□','□','□','■'},
                                          {'□','□','□','□','□','□','□','□','□','■'},
                                          {'■','■','■','■','■','■','□','□','□','□'}};

            findPath(m, 0, 0);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void findPath(char[,] m, int r, int c)
        {
            m[r, c] = '–';
            if (r == 7 && c == 9)
                printMap(m);
            else
            {
                if ((r - 1 >= 0) && m[r - 1, c] == '□') // 上
                    findPath(m, r - 1, c);
                if ((c + 1 <= 9) && m[r, c + 1] == '□') // 右
                    findPath(m, r, c + 1);
                if ((r + 1 <= 7) && m[r + 1, c] == '□') // 下
                    findPath(m, r + 1, c);
                if ((c - 1 >= 0) && m[r, c - 1] == '□') // 左
                    findPath(m, r, c - 1);
                //m[r, c] = '◇';
            }
        }

        static void printMap(char[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j]);
                Console.WriteLine(); //Console.WriteLine在輸出後會自動換行
            }
        }

    }
}
