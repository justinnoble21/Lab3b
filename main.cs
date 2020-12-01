using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Input Salesperson's Name:");
    string name = Console.ReadLine();

    Console.WriteLine("Input Sales Amount:");
    double amount = Double.Parse(Console.ReadLine());

    double commission = 200 + (0.09 * amount);

    Console.WriteLine ("Sales commission for " + name + " is $" + commission);
    string s = null;

    if (0 < amount && amount < 2999) {
      s = "poor";
    }
    if (3000 < amount && amount < 4999) {
      s = "average";
    }
    if (5000 < amount && amount < 9999) {
      s = "good";
    }
    if (10000 < amount && amount < 14999) {
      s = "excellent";
    }
    if (amount > 15000) {
      s = "outstanding";
    }

    Console.WriteLine("Performance is " + s);
  }
}