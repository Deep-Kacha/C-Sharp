using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProgEra
{
	internal class BiggestPalindrome
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a string: ");
			string input = Console.ReadLine();

			string longestPalindrome = FindLongestPalindrome(input);
			Console.WriteLine("Longest palindromic substring: " + longestPalindrome);
		}

		static string FindLongestPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s)) return "";

			int start = 0, maxLen = 0;

			for (int i = 0; i < s.Length; i++)
			{
				ExpandAroundCenter(s, i, i, ref start, ref maxLen);     // Odd length
				ExpandAroundCenter(s, i, i + 1, ref start, ref maxLen); // Even length
			}

			return s.Substring(start, maxLen);
		}

		static void ExpandAroundCenter(string s, int left, int right, ref int start, ref int maxLen)
		{
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				left--;
				right++;
			}

			int len = right - left - 1;
			if (len > maxLen)
			{
				maxLen = len;
				start = left + 1;
			}
		}
	}
}