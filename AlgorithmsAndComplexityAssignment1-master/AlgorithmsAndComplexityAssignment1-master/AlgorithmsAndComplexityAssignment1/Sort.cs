﻿using System;
namespace AlgorithmsAndComplexityAssignment1
{
	public static class Sort
	{
		
		public static int[] bubble(int[] array)
		{
			
			for (int i = 0; i < array.Length; i++)
			{
				
				for (int j = 1; j < array.Length; j++)
				{
					
					if (array[j - 1] > array[j])
					{
						
						int temp = array[j];
						array[j] = array[j - 1];
						
						array[j - 1] = temp;
					}
				}
			}
			return array;
		}
		
		public static int[] selection(int[] array)
		{
			for (int i = array.Length - 1; i > 0; i--)
			{
				int high = array[0];
				int index = 0;

				for (int j = 0; j < i; j++)
				{
					if (array[j] > high)
					{
						high = array[j];
						index = j;
					}
				}
			}
			return array;
		}
		
		public static int[] insertion(int[] array)
		{
			
			for (int i = 1; i < array.Length; i++)
			{
				int index = array[i];
				int j = i;
				
				while ((j > 0) && (array[j - 1] > index))
				{
					array[j] = array[j - 1];
					j = j - 1;
				}
				array[j] = index;
			}
			return array;
		}
	}
}