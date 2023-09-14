using System;
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
            int X = 0;
            int Y = 0;
            int win = 1;
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

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                   if( arr[y, x]==25)
                    {
                        arr[y, x] = 0;
                        Y = y;
                        X = x;
                    }
                   
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=============================");
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        Console.Write(arr[y, x] +"  ");

                    }
                    Console.WriteLine();
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


                for (int y = 0; y < 5; y++)
                {
                    if(y==4)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (arr[y, x] == win)
                            {
                                win++;
                            }
                        }
                    }
                    for (int x = 0; x < 5; x++)
                    {
                        if (arr[y, x] == win)
                        {
                            win++;
                        }
                    }
                }

      

                if (win==25)
                {
                    Console.WriteLine("게임승리");
                    Console.ReadKey();
                }
                else
                {
                    win = 1;
                }
               
            


            }



        }
    }
}
