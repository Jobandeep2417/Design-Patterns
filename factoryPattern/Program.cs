using System;

namespace factory{

    public class Program{
        public static void Main(string[] args){
            
            string? shipType = null;


            while(true)
            {
                System.Console.WriteLine("Enter UFO/Rocket to get an Enemy Ship or Q to quit");
                shipType = Console.ReadLine();
                
                if(!String.IsNullOrEmpty(shipType))
                {
                    if(shipType=="Q")
                    {
                        break;
                    }
                    EnemyShip ship = EnemyShipFactory.GetEnemyShip(shipType);
                    System.Console.WriteLine(ship.getName());
                }
                else{
                    System.Console.WriteLine("Enter UFO or Rocket");
                }
            }

        }
    }
}