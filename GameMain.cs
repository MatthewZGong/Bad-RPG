using System;

class GameMain
{
    static void Main()
    {
      Console.WriteLine("1. New Game\n" +"2. Load Game\n" + "3. Exit Game\n");
      string c = Console.ReadLine();
      bool Mainscrean = true ;
      while( Mainscrean == true){
          switch(c){
              case "1":
                //create characeter command
                Mainscrean = false ;
                break;
              case"2": 
                Console.WriteLine("Sorry we have not made this yet. Please use another command");
                break;
              case "3":
                Environment.Exit(0);
                break;
              default: 
                Console.WriteLine("That is not a correct command.");
                break;
          }
          if(Mainscrean == true){
              c = Console.ReadLine(); 
          }
        Console.WriteLine("test");
        //Game start 
      }
      
    }
}

