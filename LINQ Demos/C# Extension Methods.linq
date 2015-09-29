<Query Kind="Program" />

// C# Primer on extension methods
void Main()
{
	string name = "Travis";
	string message = name.Sleepy();
	message.Dump();
	message = name.Sleepy(666);
	message.Dump();
}

// Define other methods and classes here
public static class StringExtenstion
{
	public static string Sleepy(this string text)
	{
		return text + " is sleepy";
	}
	public static string Sleepy(this string text, int count)
	{
		string tired = "Yawn";
		while (count > 0)
		{
			text = text + " - " + tired;
			count--;
		}
		return text + "! Are we there yet?";
	}
}