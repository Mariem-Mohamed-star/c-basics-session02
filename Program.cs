using C__Basics_Session02;

namespace Basics_Session02;
class program
{
    static void Main()
    {
        //#region part 1
        //object book = new Book { title = "C# Basics", pages = 150 };
        //Console.WriteLine($"{book.ToString()}");
        //#endregion

        //#region part 2
        //object book = new Book { title = "C# Basics", pages = 150 };
        //Console.WriteLine($"{book.ToString()}"); //overided in Book
        //Console.WriteLine($"{book.Equals(book)}");
        //Console.WriteLine($"{book.GetHashCode()}");
        //Console.WriteLine($"{book.GetType()}");
        //#endregion

        //#region part 3
        ////answer: compile erroe
        //int pages = int.Parse("464");
        //#endregion

        //#region part 4
        //try
        //{
        //    int a = 10, b = 0;
        //    Console.WriteLine(a / b);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("Cannot divide by zero");
        //}
        //finally {
        //    Console.WriteLine("Done");
        //}
        //#endregion

        //#region part 5 
        //int pages = 300; double num_pages = pages;
        //#endregion

        //#region part 6
        //double price = 49.99; int Price = (int)price;
        //#endregion

        //#region part 7
        //string pagesText = "464";
        //int num = Convert.ToInt32(pagesText);
        //#endregion

        // #region page 8
        // string yearText = "2023";
        // int num1=int.Parse(yearText);
        // string badText = "abc";
        //bool answer= int.TryParse(badText,out int valid);
        // if (!answer) { Console.WriteLine("Invalid number"); }
        // else { Console.WriteLine(valid); }
        // #endregion

        //#region part 9
        //int pages = 464;
        //string answer=Convert.ToString(pages);
        //Console.WriteLine(answer.GetType());
        //#endregion

        #region part 10
        int copies = 100;
        object ob=copies;
        int copies2 =(int)ob;
        Console.WriteLine($"int: {copies2}");
        Console.WriteLine($"object: {ob}");
        #endregion

    }
}