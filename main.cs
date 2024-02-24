using System;

class Program {
  public static void Main (string[] args) {
    string userInput;
    string nextInput = "";
    int total = 0;
    int num;
    
    do
      {
        Console.Write("Enter something: ");
        userInput = Console.ReadLine();

        if (userInput == "exit")
          {
            break;
          }
        
        else if (int.TryParse(userInput, out num))
          {
            total += num;
            Console.WriteLine("Adding " + num + " to " + (total - num) + " = " + total);
            Console.WriteLine();
          }

        else
          {
            nextInput += userInput;
            Console.WriteLine("Current Message is: " + nextInput);
            Console.WriteLine();
          }
      }
    while (userInput != "exit");
    Console.WriteLine("Closing program...");
  }
}