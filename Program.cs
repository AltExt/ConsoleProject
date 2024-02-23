using System;

internal class Program
{
	static void Main()
	{
		//AcmeAccounting();
		//Console.Read();

		//DailyReportAssignment();
		//Console.Read();

		//MathAssignment();
		//Console.Read();
	}

	static void AcmeAccounting()
	{
		Console.WriteLine("Welcome to Acme Accounting Systems.");
		Console.WriteLine("Remember, we're \"accounting\" on you!");
	}

	static void DailyReportAssignment()
	{
		// main heading
		Console.WriteLine("Academy of Learning Career College.\nStudent Daily Report.");

		// questions and answers
		Console.WriteLine("What is your name?");
		string studentName = Console.ReadLine();

		Console.WriteLine("What course are you on?");
		string courseName = Console.ReadLine();

		Console.WriteLine("What page number?");
		uint pageNumber = Convert.ToUInt32(Console.ReadLine());

		Console.WriteLine("Do you need help with anything? (true/false)");
		bool helpNeeded = Convert.ToBoolean(Console.ReadLine());

		Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
		string studentPositiveExperiences = Console.ReadLine();

		Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics.");
		string studentOtherFeedback = Console.ReadLine();

		Console.WriteLine("How many hours did you study today?");
		uint hoursStudied = Convert.ToUInt32(Console.ReadLine());

		Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");

		/*
		Console.WriteLine("Name:\t\t\t" + studentName);
		Console.WriteLine("Course:\t\t\t" + courseName);
		Console.WriteLine("Page:\t\t\t" + pageNumber);
		Console.WriteLine("Help:\t\t\t" + helpNeeded);
		Console.WriteLine("Positive Experiences:\t" + studentPositiveExperiences);
		Console.WriteLine("Other Feedback:\t\t" + studentOtherFeedback);
		Console.WriteLine("Hours Studied:\t\t" + hoursStudied);
		*/

		Console.Read();
	}

	static void MathAssignment()
	{
		int min = 0;
		int max = Int32.MaxValue - 100;

		// gets a number from user, adds 50 and writes to console
		Console.WriteLine("Enter a number: ");
		int inputInt = Convert.ToInt32(GetInput(min, max));
		inputInt += 50;
		Console.WriteLine(inputInt.ToString());

		// gets a number from user, adds 25 and writes to console
		Console.WriteLine("Enter a number: ");
		inputInt = Convert.ToInt32(GetInput(min, max));
		inputInt += 25;
		Console.WriteLine(inputInt.ToString());

		// gets a number from user, multiplies by 12.5 and writes to console
		Console.WriteLine("Enter a number: ");
		decimal inputDecimal = GetInput(min, max);
		inputDecimal *= 12.5m;
		Console.WriteLine(inputDecimal.ToString());

		// gets a number from user, prints true if number > 50, false otherwise
		Console.WriteLine("Enter a number: ");
		inputInt = Convert.ToInt32(GetInput(min, max));
		bool output = inputInt > 50;
		Console.WriteLine(output.ToString());

		// gets a number from user, prints the result of input % 7 to screen
		Console.WriteLine("Enter a number: ");
		inputInt = Convert.ToInt32(GetInput(min, max));
		int remainder = inputInt % 7;
		Console.WriteLine(remainder.ToString());
	}

	static decimal GetInput(int min, int max)
	{
		while ( true )
		{
			decimal temp = Convert.ToDecimal(Console.ReadLine());
			if (temp > min && temp < max)
			{
				return temp;
			}
			else
			{
				Console.WriteLine("Please enter a number between " + min + " and " + max);
			}
		}
	}
}
