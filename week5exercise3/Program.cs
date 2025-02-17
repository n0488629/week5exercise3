using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5exercise3
{
    internal class Program
    {
        static Stack<string> webpages = new Stack<string>(); // static stack 
        static void Main(string[] args)
        {
            int userinput = 0; // declararation for user input for selection
            Console.WriteLine("Welcome to the Web Browser Back button application\n" + // menu text
                "1. Visit New Page \n" +
                "2. Go back\n" +
                "3. View Browsing History\n" +
                "4. Exit ");
            while (true) // loop forever
            {
                Console.Write("Enter your choice: ");
                userinput = Convert.ToInt32(Console.ReadLine()); // user input for switch selection

                switch (userinput) 
                {
                    case 1: // case if user select 1
                        NewWebpage(); // method to add an item to stack
                        break;
                    case 2:
                        GoBack(); // method to view the last item added to the stack
                        break;
                    case 3:
                        ViewHistory(); // method to view the whole stack
                        break;
                    case 4:
                        return;
                    default:
                        break;



                }
            }
        }
        static void NewWebpage() // method to add webpage to stack
        {
            Console.Write("Enter webpage URL: ");
            string page = Console.ReadLine();
            webpages.Push(page); // add user inputted webpage to the stack

            Console.WriteLine("Page successfully visited!");
        }
        static void GoBack() // method to go back to the most recent webpage
        {
            if (webpages.Count > 0) // only execute if there are items in the stack
            {
              //  webpages.Pop();
                Console.WriteLine("Going back to: " + webpages.Peek());
            }
            else { Console.WriteLine("There are no webpages to go back to"); } // display if there are no webpages in stack
        }
        static void ViewHistory() // method to view all webpages in stack
        {
            Console.WriteLine("Browser History: ");
            foreach (string page in webpages) { Console.WriteLine(page); } // display webpage history

            if (webpages.Count < 1) { Console.WriteLine("There are no webpages to view"); } // display if there are no websites in the stack
        }
    }
}
