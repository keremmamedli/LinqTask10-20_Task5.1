using System.Collections.Immutable;

namespace CodeAcademy_LINQ_10_20_Task_5._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------Exercise 11--------------------------------------------------
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(213);
            //list.Add(12);
            //list.Add(18);
            //list.Add(-32);

            //int n = int.Parse(Console.ReadLine());


            //list.Sort();
            //list.Reverse();

            //for(int i = 0; i < n;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //-----------------------------------------------Exercuse 12--------------------------------------------------

            //    string strName;


            //    strName = Console.ReadLine();

            //    var word = WordFilt(strName);
            //    foreach (string strRet in word)
            //    {
            //        Console.WriteLine(strRet);
            //    }
            //}

            //static IEnumerable<string> WordFilt(string mystr)
            //{
            //    var upWord = mystr.Split(' ')
            //                .Where(x => String.Equals(x, x.ToUpper(),
            //                StringComparison.Ordinal));

            //    return upWord;

            //-----------------------------------------------Exercuse 13--------------------------------------------------
            //int n = int.Parse(Console.ReadLine());
            //string[] array = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Here is the string below created with elements of the above array : ");
            //foreach (string s in array)
            //{
            //    Console.WriteLine(s + " ");
            //}
            //-----------------------------------------------Exercuse 16--------------------------------------------------


            //string[] file = Directory.GetFiles("/Desktop/CodeAcademy/Task1/");


            //var fileSize = file.Select(file => new FileInfo(file).Length).Average();
            //fileSize = Math.Round(fileSize / 10, 1);
            //Console.WriteLine( fileSize);
            //-----------------------------------------------Exercuse 17--------------------------------------------------


            //List<string> stringlist = new List<string>();
            //stringlist.Add("m");
            //stringlist.Add("n");
            //stringlist.Add("o");
            //stringlist.Add("p");
            //stringlist.Add("q");


            //var res = from y in stringlist
            //               select y;
            //foreach (var tchar in res)
            //{
            //    Console.WriteLine("Char: {0} ", tchar);
            //}

            //string newstr = stringlist.FirstOrDefault(en => en == "o");
            //stringlist.Remove(newstr);


            //var res1 = from z in stringlist
            //              select z;
            //foreach (var rChar in res1)
            //{
            //    Console.WriteLine("Char: {0} ", rChar);
            //}
            //-----------------------------------------------Exercuse 18--------------------------------------------------

            //List<string> listOfString = new List<string>();
            //listOfString.Add("m");
            //listOfString.Add("n");
            //listOfString.Add("o");
            //listOfString.Add("p");
            //listOfString.Add("q");



            //var res1 = from y in listOfString
            //               select y;
            //Console.Write("List of items : \n");
            //foreach (var i in res1)
            //{
            //    Console.WriteLine("Char: {0} ", i);
            //}

            //listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


            //var _result = from z in listOfString
            //              select z;
            //Console.Write("\nList which removing 'p' : \n");
            //foreach (var rChar in _result)
            //{
            //    Console.WriteLine("Char: {0} ", rChar);
            //}
            //-----------------------------------------------Exercuse 19--------------------------------------------------
            //List<string> listOfString = new List<string>();
            //listOfString.Add("m");
            //listOfString.Add("n");
            //listOfString.Add("o");
            //listOfString.Add("p");
            //listOfString.Add("q");



            //var res1 = from y in listOfString
            //           select y;
            //Console.Write("List of items : \n");
            //foreach (var i in res1)
            //{
            //    Console.WriteLine("Char: {0} ", i);
            //}

            //listOfString.Remove(listOfString.FirstOrDefault(en => en == "q"));


            //var _result = from z in listOfString
            //              select z;
            //Console.Write("\nList which removing 'q' : \n");
            //foreach (var rChar in _result)
            //{
            //    Console.WriteLine("Char: {0} ", rChar);
            //}
            //-----------------------------------------------Exercuse 20--------------------------------------------------
            //List<string> listOfString = new List<string>();
            //listOfString.Add("m");
            //listOfString.Add("n");
            //listOfString.Add("o");
            //listOfString.Add("p");
            //listOfString.Add("q");



            //var res1 = from y in listOfString
            //           select y;
            //Console.Write("List of items : \n");
            //foreach (var i in res1)
            //{
            //    Console.WriteLine("Char: {0} ", i);
            //}

            //listOfString.RemoveAt(3);


            //var _result = from z in listOfString
            //              select z;
            //Console.Write("\n List that after removing 3 index : \n");
            //foreach (var rChar in _result)
            //{
            //    Console.WriteLine("Char: {0} ", rChar);
            //}
        }
    }

    }


    




    

