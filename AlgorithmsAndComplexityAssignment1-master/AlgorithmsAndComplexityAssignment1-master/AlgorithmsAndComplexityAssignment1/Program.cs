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

			string[] lines = File.ReadAllLines("c:\\2981757.txt");
			//add open with txt files
			int[] values = new int[465];
			Console.WriteLine("Not sorted:");
		
			





			//bubble Sorting
			int[] bubbled = Sort.bubble(values);
			Console.WriteLine("Bubble Sorted:");
			for (int i = 0; i < bubbled.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}
			//sort into every 10th value 
			int[] selected = Sort.selection(values);
			Console.WriteLine("Sorted:");
			for (int i = 0; i < selected.Length; i++)
			{
				Console.WriteLine(selected[i]);
			}
			//Insert sorting
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
