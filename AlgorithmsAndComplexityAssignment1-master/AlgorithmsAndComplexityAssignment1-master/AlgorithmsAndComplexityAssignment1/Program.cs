using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsAndComplexityAssignment1
{
    class Program
    {
       

            public static void Main(string[] args)
            {

                  Array theLines;


			      string[] lines = File.ReadAllLines("Road1-256.txt");
			      lines = new string[lines.Length];
			      lines = lines.ToArray();
			      theLines = new string[lines.Length];
			      Console.WriteLine(lines);
                  
			      int[] values = new int[theLines.Length];
                  Console.WriteLine("This isn't sorted:");

            char userKeyPress;
            do
            {
                Console.WriteLine("Input Number:");
                userKeyPress = Console.ReadKey().KeyChar;
            }
            while (values.Contains(userKeyPress));
                  if (values.Contains(userKeyPress))
                  {
                        Console.WriteLine("Vaild");
                  }
                  else
                        Console.WriteLine("Input invalid");





            //bubble sorting
            int[] bubbled = Sort.bubble(values);
                  Console.WriteLine("Bubble Sorted:");
                  for (int i = 0; i < bubbled.Length; i++)
                  {
                        Console.WriteLine(bubbled[i]);
                  }
                  //election sorting
                  int[] selected = Sort.selection(values);
                  Console.WriteLine("Selection Sorted:");
                  for (int i = 0; i < selected.Length; i++)
                  {
                        Console.WriteLine(selected[i]);
                  }
                  //insertion sorting
                  int[] inserted = Sort.insertion(values);
                  Console.WriteLine("Insertion Sorted:");
                  for (int i = 0; i < inserted.Length; i++)
                  {
                        Console.WriteLine(bubbled[i]);
                  }





            Console.ReadLine();
            }

      }
}
