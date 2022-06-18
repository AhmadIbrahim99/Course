using System;
using System.Collections.Generic;

namespace Course.FirstStage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var players = new List<Player>();
            var enemies = new List<Enemy>();


            Console.WriteLine(" players ");

            for (int i = 1; i <= 10; i++) {
                Player player = new Player();
                player.Name = "Ahmad" + i;
                player.ID = 5 * i == 0 ? 1 : 5 * i;
                player.Level = 10 * i == 0 ? 1 : 10 * i;
                player.Heal = 100;
                player.takeDamge( i * i);
                
                //here we add Player To List
                players.Add(player);
            }    
            //Here We Show All Players
            players.ForEach(p => Console.WriteLine(p.ToString()));

            /* End Firs Class */

            Console.WriteLine(" enemies ");
            for (int i = 0; i < 10; i++) 
            {
                enemies.Add(new Enemy() { ID = i, Name = $"Enemy {i}", Heal = 100, Level = 100 });
                enemies[i].takeDamge();
            }
            
            enemies.ForEach(e => Console.WriteLine(e.ToString()));



            var json =new Dictionary<string, dynamic>();
            json.Add("ID", 0);
            json.Add("Name", "json");
            json.Add("Level", 99);
            json.Add("Heal", 99);
            
            Console.WriteLine(Player.FromJson(json));

            Console.WriteLine(Player.FromJson(players[0].ToJson()));

            

        }
    }
}
