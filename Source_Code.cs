using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
      //Introduces the AI to the user and tells them what it's used for
			Console.Write("Hello, i'm an AI (artificial inteligence) designed by Linko on github and i'here to help you with anything you need.");
      //checks for commands
      var command = Console.ReadLine();
      while (command == null)
      {
      Console.Write("Go on say a command.");
      wait(10)
      
      if (command == what time is it || what time is it?)
      {
        //prints the time
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("F"));
        Console.Write(time)
        string[] months = {"January", "February", "March", "April", "May",
        "June", "July", "August", "September", "October", "November", "December"};

         DateTime now = DateTime.Now;

        Console.WriteLine("Today's date: {0}", now.Date);
        Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
        Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
        Console.WriteLine("Today's time: {0}", now.TimeOfDay);
        Console.WriteLine("Hour: {0}", now.Hour);
        Console.WriteLine("Minute: {0}", now.Minute);
        Console.WriteLine("Second: {0}", now.Second);
        Console.WriteLine("Millisecond: {0}", now.Millisecond);
        Console.WriteLine("The day of week: {0}", now.DayOfWeek);
        Console.WriteLine("Kind: {0}", now.Kind);
      }
		  }
    }   
	}
}
