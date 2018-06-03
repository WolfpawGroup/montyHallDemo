using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace montyHallDemo
{
	class Program
	{
		public static double WinPercent = 0d;
		public static double SwitchPercent = 0d;
		public static double StayPercent = 0d;

		public static bool showProgress = false;

		static void Main(string[] args)
		{
			if(args != null && args.Length > 0)
			{
				showProgress = true;
			}

			intro();
			start();
		}

		public static void intro()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Greeting goes here");
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		public static void start()
		{
			door 
				choiceA = door.lose, 
				choiceB = door.lose, 
				choiceC = door.lose;

			List<door> lstdr = new List<door>();

			int tmp = new Random().Next();

			if (tmp % 3 == 0)
			{
				choiceA = door.win;
			}
			else if (tmp % 2 == 0)
			{
				choiceB = door.win;
			}
			else
			{
				choiceC = door.win;
			}


		}

		public enum door
		{
			win,
			lose,
			none
		}
	}
}
