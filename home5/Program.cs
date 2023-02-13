using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace String_homework_06._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //Console.Write("Enter str: ");
            //string str = Console.ReadLine();
            //Console.Write("\nEnter number delet symbol: ");
            //string n = Console.ReadLine();
            //int num = Convert.ToInt32(n);
            //str = str.Remove(num, 1);
            //Console.WriteLine($"\nNew str: {str}\n");
            #endregion

            #region ex2
            //string str = "abcd abcd abcd";
            //Console.Write($"{str}\nEnter symbol: ");
            //string sym = Console.ReadLine();
            //char symbol = Convert.ToChar(sym);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == symbol)
            //    {
            //        str = str.Remove(i, 1);
            //    }
            //}
            //Console.WriteLine($"\nNew string: {str}\n");
            #endregion

            #region ex3
            //string str = "Hi, my name is Gustavo";
            //Console.WriteLine($"String = {str}");
            //Console.Write("\nEnter position: ");
            //string pos = Console.ReadLine();
            //int position = Convert.ToInt32(pos);
            //Console.Write("\nEnter symbol: ");
            //string symbol = Console.ReadLine();
            //str = str.Insert(position, symbol);
            //Console.WriteLine($"\nNew string = {str}");
            #endregion

            #region ex4
            //Console.WriteLine("Enter string:");
            //string str = Console.ReadLine();
            //int count_a = 0;
            //for (int first = 0, last = str.Length - 1; first < last; ++first, --last)
            //{
            //    if (str[first] == str[last])
            //    {
            //        count_a++;
            //    }
            //}
            //if (count_a == str.Length / 2)
            //{
            //    Console.WriteLine("It's polindrom!");
            //}
            //else { Console.WriteLine("It's not polindrom!"); }
            #endregion

            #region ex5
            //Console.Write("Enter a sentence: ");
            //string str = Console.ReadLine();
            //string[] textArray = str.Split(new char[] { ' ' });
            //Console.WriteLine($"Amount of words = {textArray.Length}");
            #endregion

            #region ex6
            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();
            //Console.Write("Enter word to search it: ");
            //string search_word = Console.ReadLine();
            //bool b = text.Contains(search_word);
            //Console.WriteLine("'{0}' is int the string '{1}' : {2}", search_word, text, b);
            //Console.Write("Enter word: ");
            //string word = Console.ReadLine();
            //Console.Write("Enter word to change it: ");
            //string change_word = Console.ReadLine();
            //text = text.Replace(change_word, word);
            //Console.WriteLine($"\nNew text: {text}\n");
            #endregion

            #region ex7
            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();
            //Console.WriteLine("Enter word which you wanna change:");
            //Console.Write("1) ");
            //string first_word = Console.ReadLine();
            //Console.Write("2) ");
            //string second_word = Console.ReadLine();
            //text = text.Replace(first_word, "tt");
            //text = text.Replace(second_word, first_word);
            //text = text.Replace("tt", second_word);
            //Console.WriteLine($"New text: {text}");
            #endregion

            #region ex8
            //Console.Write("Введите текст: ");
            //string text = Console.ReadLine();
            //char[] mas_letter = new char[] { 'а', 'о', 'у', 'е', 'и', 'ё', 'ы', 'я', 'э' };
            //int count = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ' ')
            //    {
            //        for (int j = 0; j < mas_letter.Length; j++)
            //        {
            //            if (text[i - 1] == mas_letter[j]) { count++; }
            //        }
            //    }
            //    if (i == text.Length - 1)
            //    {
            //        for (int j = 0; j < mas_letter.Length; j++)
            //        {
            //            if (text[i] == mas_letter[j]) { count++; }
            //        }
            //    }
            //}
            //Console.WriteLine($"Amount of words = {count}");
            #endregion

        }
    }
}