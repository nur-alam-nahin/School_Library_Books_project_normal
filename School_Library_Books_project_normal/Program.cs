using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project_normal
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Add books = ");
            int row = Convert.ToInt32(Console.ReadLine());
            string[] books = new string[row];
            int[,] price = new int[row, 2];


            for (int i = 0; i < books.GetLength(0); i++)
            {

                    Console.Write("title = ");
                    books[i] = Console.ReadLine();
            }


      

            for (int i = 0; i < price.GetLength(0); i++)
            {
                
                for (int j = 0; j < 2; j++)
                {
                    if (price[i,j] == price[i,0])
                    {

                        Console.Write("price = ");
                        price[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. Printed Book = ");
                        Console.WriteLine("2. Digital Book = ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if(num > 0 && num < 3)
                        {

                            switch (num )
                            {
                                case 1:
                                    Console.Write("Printed Book  charge  = ");
                                    price[i, j] = Convert.ToInt32(Console.ReadLine());
                                 
                                    break;

                                case 2:
                                    Console.Write("Digital Book  charge  = ");
                                    price[i, j] = Convert.ToInt32(Console.ReadLine());
                                    
                                    break;
                            }
                        }

                        
                    }

                    
                }
            }

            Console.WriteLine();
            for (int i = 0; i < books.GetLength(0); i++)
            {
                    Console.WriteLine("title = "+books[i]);

                int sum = 0;
                for (int j = 0; j < price.GetLength(1); j++)
                {
                    sum += price[i, j];
                    if(price[i,j] == price[i,1])
                    {
                        
                        Console.WriteLine("Final price = "+ sum);

                    }
                    else
                    {
                        Console.WriteLine("price = " + sum);
                    }

                }
                Console.WriteLine();
            }














            //else if(price[i, j] == price[i, 1])
            //{
            //    Console.Write("Printed Book  charge  = ");
            //    price[i, j] = Convert.ToInt32(Console.ReadLine());
            //}



            //int num;
            //do
            //{
            //    Console.WriteLine("----- School Library Books ------");
            //    Console.WriteLine("1. Add Books ");
            //    Console.Write("Click = ");
            //    num = Convert.ToInt32(Console.ReadLine());


            //    switch (num)
            //    {
            //        case 1:

            //            //int row = 0;
            //            for (int i = 0; i < books.GetLength(0); i++)
            //            {
            //                //books[i] = new string[2];
            //                for (int j = 0; j < 2; j++)
            //                {
            //                    //Console.Write("Title = ");
            //                    books[i,j] = Console.ReadLine();
            //                    //Console.Write("price = ");
            //                    //books[i, j++] = Console.ReadLine();


            //                    //storeBook = books[i, j];
            //                    //storeBook = books[i, j++];
            //                }
            //            }

            //            break;


            //        case 2:
            //            for (int i = 0; i < books.GetLength(0); i++)
            //            {
            //                for (int j = 0; j < books.GetLength(1); j++)
            //                {
            //                    Console.WriteLine(books[i, j]);
            //                    //Console.WriteLine(books[i, j++]);

            //                }
            //                Console.WriteLine();
            //            }
            //            break;
            //    }



            //}while (num != 0);



            Console.ReadKey();
        }
    }
}
