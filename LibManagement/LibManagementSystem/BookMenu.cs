using System;
using System.Collections.Generic;
using System.Text;

namespace LibManagementSystem.LibManagementSystem
{
    class BookMenu
    {
        public void Run()

        {
            BookUtility utility = new BookUtility();
            while (true)
            {
                Console.WriteLine("welcome to lib Management system");
                Console.WriteLine("press 1 to add a book");
                Console.WriteLine("press 2 to search a book");
                Console.WriteLine("press 3 to issue a book");
                Console.WriteLine("press 4 to display all book");
                Console.WriteLine("press 5 to exit");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1: utility.AddBook();
                        break;
                    case 2:
                        Console.WriteLine("title :");
                        string t=Console.ReadLine();
                        utility.Search(t);
                        break;
                    case 3:
                        Console.WriteLine("title :");
                        string title = Console.ReadLine();
                        utility.Issue(title);
                        break;
                    case 4:
                       utility.Display();
                        break;
                    case 5:
                        return;
                }

            }
            }
        }
    }

