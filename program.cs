using System;
using System.Linq;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = DateTime.MinValue;
            Exponent();

            Akinator();


            Calc();

            Console.WriteLine("Select revers word:");
            Console.WriteLine("1) Using instruction for");
            Console.WriteLine("2) Using instruction foreach");
            Console.WriteLine("3) Using instruction recursion");
            Console.WriteLine("4) Using instruction collection");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    WordReversFor();
                    break;
                case "2":
                    WordReversForeach();
                    break;
                case "3":
                    WordReversRecursion();
                    break;
                case "4":
                    WordReversCollection();
                    break;
                default:
                    //Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Red;
                    select.Reverse().ToList().ForEach(f=> Console.Write(f));
                    
                    break;
            }
            Console.ReadLine();

            
            

        }

        static void Akinator()
        {
            Console.WriteLine("Загадай число от 0..100... push enter");
            Console.ReadLine();
            Console.Write("");
            string ans = Console.ReadLine();
        }

        static void Exponent()
        {
            Console.WriteLine("Give me bootom number:");
                int bottomInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me top number:");
                int topInt = int.Parse(Console.ReadLine());
            int i = 1;
            long ans = bottomInt;
            while(i++<topInt)
            {
                ans *= bottomInt;
            }
            Console.Write(ans);
        }
        static void WordReversForeach()
        {
            string rev = string.Empty;
            Console.WriteLine("Word write:");
            foreach(var characte in Console.ReadLine())
            {
                rev = characte + rev; 
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(rev);
        }

        static void WordReversFor()
        {
            string rev = string.Empty;
            Console.WriteLine("Word write:");
            string word = Console.ReadLine();
            for (var characte = word.Length-1; characte >= 0; characte--)
            {
                rev = rev + word[characte];
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(rev);
        }

        static void WordReversRecursion()
        {
            Console.WriteLine("Word write:");
            string rev = WordRecursion(Console.ReadLine());
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(rev);
        }

        static string _recWord = string.Empty; 

        static string WordRecursion(string word)
        {
            _recWord = _recWord + word[word.Length - 1];
            word = word.Remove(word.Length - 1);
            if(word.Length > 0)
            {
                WordRecursion(word);
            }
            return _recWord;
        }

        static void WordReversCollection()
        {
            Console.WriteLine("Word write:");
            string word = Console.ReadLine();
            var list = word.ToList();
            list.Reverse();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            list.ForEach(f => Console.Write(f));
        }

        static void Calc()
        {
            Console.WriteLine("First term:");
            int term1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second term:");
            int term2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select operator(+,-,*,/):");
            string op = Console.ReadLine();
            switch(op)
            {
                case "+":
                    Console.WriteLine("{0}+{1}={2}", term1, term2, term1 + term2);
                    break;
                case "-":
                    Console.WriteLine("{0}-{1}={2}", term1, term2, term1 - term2);
                    break;
                case "*":
                    Console.WriteLine("{0}*{1}={2}", term1, term2, term1 * term2);
                    break;
                case "/":
                    Console.WriteLine("{0}/{1}={2}", term1, term2, term1 / term2);
                    break;
                default:
                    Console.WriteLine("Write in English");
                    break;

            }
        }
    }
}
