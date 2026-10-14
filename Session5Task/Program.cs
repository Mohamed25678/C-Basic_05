namespace Session5Task;




    #region Q1
    //public static bool TryGetPrice(string title, out double price)
    //{
    //    if (title == "Clean Code")
    //    {
    //        price = 25.5;
    //        return true;
    //    }
    //    else
    //    {
    //        price = 0;
    //        return false;
    //    }
    //}
    #endregion

    #region Q2
    //public static void PrintBookInfo(string title, int pages = 300)
    //{
    //    Console.WriteLine($"Title: {title}, Pages: {pages}");
    //}
    #endregion

    #region Q3
    //    public static void PrintAllTitles(params string[] titles)
    //    {
    //        foreach (string title in titles)
    //        {
    //            Console.WriteLine(title);
    //        }
    //    }
    //}
    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //if (Book.TryGetPrice("Clean Code", out double price))
            //{
            //    Console.WriteLine($"Price: {price}");
            //}

            //// 2
            //Book.PrintBookInfo("Clean Code");
            //Book.PrintBookInfo("The Pragmatic Programmer", 352);

            //// 3
            //Book.PrintBookInfo(pages: 450, title: "C# in Depth");

            //// 4
            //Book.PrintAllTitles(
            //    "Clean Code",
            //    "The Pragmatic Programmer",
            //    "C# in Depth"
            //);



            //Book book = new Book();



            //Console.WriteLine(book.copiesInStock);


            //book.Title = "Clean Code";
            //Console.WriteLine(book.Title);


            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);


            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            //int genreNumber = 1;
            //Genre genreFromNumber = (Genre)genreNumber;
            //Console.WriteLine(genreFromNumber);


            //string genreText = "Science";
            //Genre genreFromText = (Genre)Enum.Parse(
            //    typeof(Genre), genreText
            //);
            //Console.WriteLine(genreFromText);


            //string invalidGenreText = "Mystery";

            //if (Enum.TryParse<Genre>(
            //    invalidGenreText, out Genre parsedGenre)
            //    && Enum.IsDefined(typeof(Genre), parsedGenre))
            //{
            //    Console.WriteLine(parsedGenre);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
        }
    }
}

