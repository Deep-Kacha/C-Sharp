using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
	internal class T1Q10
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter the Number: ");
			string input = Console.ReadLine();
			string marked = input.Substring(0, input.Length - 5) + new string('X', 5);
			Console.WriteLine("Masked Number: " + marked);
		}
	}
}