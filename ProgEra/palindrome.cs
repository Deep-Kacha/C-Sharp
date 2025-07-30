using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProgEra
{
	internal class palindrome
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a string: ");
			string input = Console.ReadLine();

			if (IsPalindrome(input))
			{
				Console.WriteLine("The string is a palindrome.");
			}
			else
			{
				Console.WriteLine("The string is not a palindrome.");
			}
		}

		static bool IsPalindrome(string str)
		{
			str = str.ToLower(); // Optional: normalize case

			int left = 0;
			int right = str.Length - 1;

			while (left < right)
			{
				if (str[left] != str[right])
					return false;

				left++;
				right--;
			}

			return true;
		}
	}
}	