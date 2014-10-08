using System;

namespace AccountType
{
	enum AccountType { Checking, Deposit }
	class MainClass
	{

		public static void Main (string[] args)
		{
			AccountType goldAccount;
			AccountType platinumAccount;

			goldAccount = AccountType.Checking;
			platinumAccount = AccountType.Deposit;

			Console.WriteLine ("Customer account type is {0}", goldAccount);
			Console.WriteLine ("Customer account type is {0}", platinumAccount);
		}
	}
}
