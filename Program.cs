using System;

internal class Program
{
	static void Main()
	{
		//AcmeAccounting();

		//DailyReportAssignment();
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
}
