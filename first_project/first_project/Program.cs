using System;

namespace first_project
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string myName;
			Console.WriteLine ("Please, enter you name");
			myName = Console.ReadLine ();
			Console.WriteLine ("Hello {0}", myName);
		}
	}
}
