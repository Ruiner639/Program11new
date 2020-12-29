using System;

namespace Program11new
{
    public class laptop
    {
        string model = "Lenovo Yoga 2 Pro";
        string manufacturer = "Lenovo";
        string processor = "Intel Core i5-4210U";
        int RAM = 8;
        string graphics_card = "Intel HD Graphics 4400";
        int HDD_GB = 128;
        string HDD_type = " SSD";
        int screen = 13;
        int price = 2259;
        public laptop()
        {
            Console.WriteLine("Enter (full info,main info)");
            string choice = Console.ReadLine();
            while (((choice == "full info") || (choice == "main info")) != true)
            {
                Console.WriteLine("Please, enter correct information(full info, main info)");
                choice = Console.ReadLine();
            }
            if (choice == "full info")
            {
                showInfo();
            }
            else
            {
                showMainInfo();
            }
        }
        public void showInfo()
        {
            Console.WriteLine("Model: " + testString(this.model));
            Console.WriteLine("Manufacturer: " + testString(this.manufacturer));
            Console.WriteLine("Processor: " + testString(this.processor));
            Console.WriteLine("RAM: " + testNumber(this.RAM) + " GB");
            Console.WriteLine("Graphics_card: " + testString(this.graphics_card));
            Console.WriteLine("HDD: " + testNumber(this.HDD_GB) + " GB " + testString(this.HDD_type));
            Console.WriteLine("Screen: " + testNumber(this.screen));
            Console.WriteLine("Price: " + testNumber(price) + " lv.");
            new battery();
        }
        public void showMainInfo()
        {
            Console.WriteLine("Model: " + testString(this.model));
            Console.WriteLine("Price: " + testNumber(price) + " lv.");
        }
        public int testNumber(int number)
        {
            while ((number >= 0) != true)
            {
                Console.WriteLine("Eror, try again");
                number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            return number;
        }
        public string testString(string str)
        {
            while ((String.IsNullOrEmpty(str)) != false)
            {
                Console.WriteLine("Eror, try again");
                str = Console.ReadLine();
                return str;
            }
            return str;
        }
    }
    public class battery
    {
        public battery()
        {
            string battery = "Li-lon, 4 ctlls, 2550mAh, ";
            double battery_life = 4.5;
            Console.WriteLine("Battery info:");
            Console.WriteLine("Battery: " + testString(battery));
            Console.WriteLine("Battery life: " + testNumber(battery_life) + " hours");
        }
        public string testString(string str)
        {
            while ((String.IsNullOrEmpty(str)) != false)
            {
                Console.WriteLine("Eror, try again");
                str = Console.ReadLine();
                return str;
            }
            return str;
        }
        public double testNumber(double number)
        {
            while ((number >= 0) != true)
            {
                Console.WriteLine("Eror, try again");
                number = Convert.ToDouble(Console.ReadLine());
                return number;
            }
            return number;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            new laptop();
        }
    }
}
