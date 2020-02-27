using System;
using Crashed.Models;

namespace Crashed
{
 public class Program
 {
  public static Player user = new Player(0, "friend");
  static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(@" █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████    ▄▄▄█████▓ ▒█████      ▄████▄   ██▀███   ▄▄▄        ██████  ██░ ██ ▓█████ ▓█████▄ 
▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀    ▓  ██▒ ▓▒▒██▒  ██▒   ▒██▀ ▀█  ▓██ ▒ ██▒▒████▄    ▒██    ▒ ▓██░ ██▒▓█   ▀ ▒██▀ ██▌
▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███      ▒ ▓██░ ▒░▒██░  ██▒   ▒▓█    ▄ ▓██ ░▄█ ▒▒██  ▀█▄  ░ ▓██▄   ▒██▀▀██░▒███   ░██   █▌
░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄    ░ ▓██▓ ░ ▒██   ██░   ▒▓▓▄ ▄██▒▒██▀▀█▄  ░██▄▄▄▄██   ▒   ██▒░▓█ ░██ ▒▓█  ▄ ░▓█▄   ▌
░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒     ▒██▒ ░ ░ ████▓▒░   ▒ ▓███▀ ░░██▓ ▒██▒ ▓█   ▓██▒▒██████▒▒░▓█▒░██▓░▒████▒░▒████▓ 
░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░     ▒ ░░   ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒▓ ░▒▓░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░ ▒ ░░▒░▒░░ ▒░ ░ ▒▒▓  ▒ 
  ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░       ░      ░ ▒ ▒░      ░  ▒     ░▒ ░ ▒░  ▒   ▒▒ ░░ ░▒  ░ ░ ▒ ░▒░ ░ ░ ░  ░ ░ ▒  ▒ 
  ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░        ░      ░ ░ ░ ▒     ░          ░░   ░   ░   ▒   ░  ░  ░   ░  ░░ ░   ░    ░ ░  ░ 
    ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░                ░ ░     ░ ░         ░           ░  ░      ░   ░  ░  ░   ░  ░   ░    
                        ░                                                           ░                                                    ░    ");
    Console.ResetColor();

    Console.WriteLine("Youve crashed your car with your friend inside. You wake up, and call your friend, but get no response. Find your friend before you lose all your memories of them (because you have amnesia)\n \n Type start to play, or bye to exit game.");
    string prompt = Console.ReadLine();
    if (prompt == "start")
    {
      Console.WriteLine("Good luck");

      StartGame();
    }
    else 
    {
      Console.WriteLine("Exiting Game");
    }
   }
   public static void StartGame()
   {
      Console.WriteLine("Enter name of friend");
      string friend = Console.ReadLine().ToLower();

      Console.WriteLine("Please select difficulty:\n Easy Med Hard");
      string diff = Console.ReadLine().ToLower();
      int mems = 0;
      if (diff == "easy")
      {
        mems = 10;
      }
      else if (diff == "med")
      {
        mems = 7;
      }
      else
      {
        mems = 5;
      }
    user.Memories = mems;
    user.Friend = friend;
    Console.WriteLine("You wake up....");
    Console.WriteLine($"You have {user.Memories} memories.");
    
    // look at locations
    //select location
     Location(); 
   }

   //prompt for location
   public static void Location()
   {
    Console.WriteLine("Here are the places you can go...");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Hospital  ");
    Console.Write("Coffee House  ");
    Console.Write("Your workplace  ");
    Console.Write("Your home  ");
    Console.WriteLine("Your friends home");
    Console.ResetColor();
    string nextLocation = Console.ReadLine().ToLower();
    user.Location = nextLocation;
    Console.WriteLine("Driving there now..");
    if (user.Location == "hospital")
    {
      Console.WriteLine("You walk through the hospital doors. Looking around, you see a woman behind the counter, and the halls are empty.");
      getAction();
    }
    else if (user.Location == "coffee house")
    {
      Console.WriteLine("You walk through the coffee house doors. Looking around, you see a woman behind the counter, and the halls are empty.");
      getAction();
    }
    else if (user.Location == "the office")
    {
      Console.WriteLine("You walk through the office doors. Looking around, you see a woman behind the counter, and the halls are empty.");
      getAction();
    }
    else if (user.Location == "your house")
    {
      Console.WriteLine("You walk into your house. Looking around, you see your mom behind the counter, and the halls are empty.");
      getAction();
    }
    else if (user.Location == "friends house")
    {
      Console.WriteLine("You walk into their house. Looking around, you see creepy roomate behind the counter, and the halls are empty.");
      getAction();
    }
    else
    {
      Location();
    }
  }

  //prompt for action
  public static void getAction()
  {
    Console.WriteLine("You can...");
    Console.Write("Talk To Someone (talk) ");
    Console.Write("Look around the building (look)  ");
    Console.Write("go somewhere else (leave)  ");

    string action = Console.ReadLine().ToLower();

    if (action == "talk") 
    {
      //start dialog method
      Console.WriteLine($"Have you seen {user.Friend}? I woke up from a crash and couldnt find them..");
    }
    else if (action == "look")
    {
      if (user.Location == "friends house") 
      {
        //change this later
        Console.WriteLine("Do you wanna look upstairs? yes or no");
        string response = Console.ReadLine();
        if (response == "yes")
        {
          Console.WriteLine("The Creepy Roommate grabs you from behind and throws you down the stairs!\nGAME OVER");
        }
        else if (response == "no")
        {
          getAction();
        }
        else if (response == "basement")
        {
          Console.WriteLine($"You discover {user.Friend} tied up but okay in the basement.\n They help you sneak to the hospital and contact the police.\nYOU WIN!!!!!!!");
        }
        else 
        {
          Console.WriteLine($"{user.Friend} is no where to be found.");
          getAction();
        }
      }
    }
    else if (action == "leave")
    {
      Location(); 
    }
    else
    {
      getAction();
    }
  }
  public static void getDialog()
  {
    Console.WriteLine($"Have you seen {user.Friend}? I woke up from a crash and couldnt find them..");
    Console.WriteLine($"nah");
    Console.WriteLine($"You sure? o you remember...");
    //heres memory bank, choose memorie to give out
    // if (person == knowing-someone)
    // {
    //   Console.WriteLine("oh yeah! try this place..");
    // } 
    // else
    // {
    //   Console.WriteLine("no, dont rememeber sorry..");
    // }
  }
 }
}