using System;

namespace Lab1a
{
  class Program
  {
    static void Main(string[] args)
    {
      string line1 = "Welcome to my first lab!";
      string line2 = "Here is the number two-hundred and seventy-six I will display using and int";
      string line3 = "now, here is that number subtracted by seventy-six";
      string line4 = "Divide that by 2 and we get";
      string line5 = "Is this number less than it was before?";
      string line6 = "Can you say that again?";
      string line7 = "Is that number greater than 276 and less than 76?"; 
       /*I put all the strings, ints, doubles, and bools up here because it looks nice, I dont know if this is proper, altough I think it is very nice looking, and i am dragging this comment out so it goes over multiple lines!*/
      int x = 276;
      int y = 76;
      int z = (x - y);
      double v = 200; // I didn't know if we had to use a double
      v /= 2;
      bool yes = true; // Is there a way to display True or False as Yes or No?
      char Myletter = 'E';
      Console.WriteLine(line1); // all of the lines below should write their respective variables
      Console.WriteLine(line2);
      Console.WriteLine(x);  
      Console.WriteLine(line3);
      Console.WriteLine(z);
      Console.WriteLine(line4);
      Console.WriteLine(v);
      Console.WriteLine(line5);
      Console.WriteLine(v < z); // should say true
      Console.WriteLine(line6);
      Console.WriteLine(yes); // should say true
      Console.WriteLine(line7);
      Console.WriteLine(!(v > y && v < 276)); //Should say false
     }
  }
} // This is my first test of a sript, and my first ever written script.