using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.FirstStage
{
    public class Player :Move
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Heal { get; set; }

        virtual protected void DoDamge(int damage) 
        {
            Heal -= damage;
        }
        virtual public void takeDamge(int damage = 10)
        {
            DoDamge(damage); 
        }
        static public Player FromJson(dynamic json) =>
            new Player { ID = json["ID"], Level = json["Level"], Name = json["Name"] , Heal = json["Heal"] };


        public Dictionary<string, dynamic> ToJson() 
        {
            Dictionary<string, dynamic> map =  new Dictionary<string, dynamic>(); 
            map.Add("ID", ID);
            map.Add("Name", Name);
            map.Add("Level",Level);
            map.Add("Heal", Heal);
            return map;
        }
        public string ToString() => $"Id : {ID} Name : {Name} level : {Level} Heal : {Heal}";
    }
}
