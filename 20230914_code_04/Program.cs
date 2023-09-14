﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//숫자가 이동하는 코드
namespace _20230914_code_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            int a = 1;
            int X = 2;
            int Y = 4;
            int tmep = 0;
            Random rand = new Random();
            for(int y=0; y<5; y++)
            {
                for (int x=0; x<5; x++)
                {
                    arr[y, x] = a;
                    a++;
                }
            }




            for (int i = 0; i < 10000; i++)
            {
                int num_1 = rand.Next(0, 5);
                int num_2 = rand.Next(0, 5);
                int num_3 = rand.Next(0, 5);
                int num_4 = rand.Next(0, 5);

                tmep = arr[num_1, num_2];
                arr[num_1, num_2] = arr[num_3, num_4];
                arr[num_3, num_4] = tmep;
            }



            while (true)
            {
                Console.Clear();
                Console.WriteLine("=============================");
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        Console.Write(" " + arr[y, x] + " ");

                    }
                    Console.WriteLine();
                }

                //이동식
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y != 0)
                        {
                            
                            tmep = arr[Y-1, X];//이동전 값을 저장
                            arr[Y-1, X] = arr[Y, X];
                            arr[Y, X] = tmep;
                            Y -= 1;
                        }
                       
                        break;
                    case ConsoleKey.DownArrow:
                        if (Y != 4)
                        {

                            tmep = arr[Y + 1, X];//이동전 값을 저장
                            arr[Y + 1, X] = arr[Y, X];
                            arr[Y, X] = tmep;
                            Y += 1;
                        }

                        break;
                    case ConsoleKey.LeftArrow:
                        if (X != 0)
                        {

                            tmep = arr[Y , X-1];//이동전 값을 저장
                            arr[Y, X-1] = arr[Y, X];
                            arr[Y, X] = tmep;
                            X -= 1;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (X != 4)
                        {

                            tmep = arr[Y, X + 1];//이동전 값을 저장
                            arr[Y, X + 1] = arr[Y, X];
                            arr[Y, X] = tmep;
                            X += 1;
                        }

                        break;

                }
                

            }



        }
    }
}
