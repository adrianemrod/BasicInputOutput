using System;
namespace ConsoleApp
{
class GreetingProgram
{
     static void Main(string[] args)
    {
        
        Console.WriteLine("======================================================================");
        Console.Write ("\nEnter your name:");
        string name = Console.ReadLine();
        Console.Write ("\nEnter your Present Address:");
        string preaddress = Console.ReadLine();
        Console.Write ("\nEnter your Permanent Address:");
        string permaadd = Console.ReadLine();
        Console.Write ("\nEnter your Bday:");
        string bday = Console.ReadLine();
        Console.Write ("\nEnter your Civil Status:");
        string civil = Console.ReadLine();
        Console.Write ("\nEnter your Citizenship:");
        string citizen = Console.ReadLine();
        Console.Write ("\nEnter your Place of Birth:");
        string pbirth = Console.ReadLine();
        Console.Write ("\nEnter your Father Name:");
        string fname = Console.ReadLine();
        Console.Write ("\nEnter your Mother's Name:");
        string mname = Console.ReadLine();
        Console.Write ("\nEnter Address:");
        string address = Console.ReadLine();
        Console.Write("\nLanguages or Dialects Spoken:");
        string language = Console.ReadLine();
        Console.Write("\nPerson to be notified In Case of Emergency:");
        string emer = Console.ReadLine();
         Console.Write("\nEnter Your Religion:");
        string religion = Console.ReadLine();
         Console.Write("\nEnter your age:");
        string age = Console.ReadLine();
         Console.Write("\nEnter Your Weight:");
        string weight = Console.ReadLine();
         Console.Write("\nEnter Your Height:");
        string height = Console.ReadLine();
        Console.WriteLine("======================================================================");
        Console.WriteLine("\nName              /" + name );
        Console.WriteLine("Present Address   /" + preaddress );
        Console.WriteLine("Permanent Address /" + permaadd );
        Console.WriteLine("Date of Birth     /" + bday + "                    Religion:"+religion )    ;
        Console.WriteLine("Civil Status      /" + civil+"                            Age:" +age);
        Console.WriteLine("Citizenship       /" + citizen +"                            Weight:" +weight);
        Console.WriteLine("Place of Birth    /" + pbirth +"                     Height:"+height);
        Console.WriteLine("Name of Father    /" + fname );
        Console.WriteLine("Name of Mother    /" + mname );
        Console.WriteLine("Address           /" + address );
        Console.WriteLine("Languages or Dialecs Spoken /" + language );
        Console.WriteLine("Person to be notified In Case of Emergency /" + emer );
         Console.WriteLine("======================================================================");
    }
}
}