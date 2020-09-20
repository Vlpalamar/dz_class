using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   partial class Lighter
    {
        private string type;
        private int max_vol;
        private float vol_left;
        private string color;
        private string fuel;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Max_vol
        {
            set {
                if (value<0)
                {
                    value = 0;
                }
                max_vol = value; 
                }
            get { return max_vol; }
            
        }
        public float Vol_left
        {
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine($"{Fuel} кончился");
                }
                vol_left = value;
            }
            get { return vol_left; }

        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Fuel
        {

            set
            {
                string val = value;
                val = val.ToLower();
                if (val != "газ" || val != "gas" || val != "бензин" || val != "petrol")
                    value = "";
                fuel = value;
            }
            get { return fuel; }
        }


        public Lighter(string _type, int _max_vol, string _color, string _fuel)
        {
            Type = _type;
            Max_vol = _max_vol;
            Vol_left = Max_vol;
            Color = _color;
            Fuel = _fuel;
        }
        public Lighter(string _type, int _max_vol, string _fuel)
        {
            Type = _type;
            Max_vol = _max_vol;
            Vol_left = Max_vol;
            Color = "Black";
            Fuel = _fuel;
        }

        public Lighter()
        {
            Type = "";
            Max_vol = 0;
            Vol_left = Max_vol;
            Color = "Black";
            Fuel = "";
        }
   


        public  void Info()
        {
            Console.WriteLine($"зажигалка типа:{Type}");
            Console.WriteLine($"обьем:{Max_vol}");
            Console.WriteLine($"{Color} цвет");
            Console.WriteLine($"использует {Fuel} как топливо");
            Console.WriteLine($"осталось {Vol_left} единиц {Fuel}'a ");
        }
        public void Light_up(float time)
        {
            time = time / 100;
            Vol_left = Vol_left - time;
        }
        public void Fill_to_full()
        {
           Vol_left = Max_vol;
        }
    
    }
   
}
