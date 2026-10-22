using System;
using System.Collections.Generic;
using System.Text;

static class Konzol
{
	public static void messze(string szoveg)
	{
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine($"      {szoveg}      ");
		Console.ResetColor();
	}

	public static void kozelebb(string szoveg)
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine($"      {szoveg}      ");
		Console.ResetColor();
	}

	public static void kozel(string szoveg)
	{
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine($"      {szoveg}      ");
		Console.ResetColor();
	}
	public static void nagyonkozel(string szoveg)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"      {szoveg}      ");
		Console.ResetColor();
	}
	public static void megvan(string szoveg)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"======{szoveg}======");
		Console.ResetColor();
	}

	public static void hiba(string szoveg)
	{
		Console.ForegroundColor = ConsoleColor.DarkRed;
		Console.WriteLine($"X {szoveg} X");
		Console.ResetColor();
	}

}