using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Program
    {

        private static PersonalCar personalCar;
        private static Truck truck;


        static void Main(string[] args)
        {
            personalCar = new PersonalCar(Car.FUEL.Benzine, 30.33, 5);
            truck = new Truck(Car.FUEL.Oil, 75.0, 2000.56);
            GUI();
        }

        public static void PrintLine()
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
            }
            Console.ForegroundColor = def;
            Console.WriteLine("");
        }

        public static void PrintLine(String middleText)
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            int half = middleText.Length / 2;
            int j = 0;
            for (int i = 0; i < 50-half; i++)
            {
                j++;
                Console.Write("-");
            }
            Console.Write(middleText);
            j += middleText.Length;
            for (int i = j; i < 100; i++)
            {
                Console.Write("-");
            }
            Console.ForegroundColor = def;
            Console.WriteLine("");
        }


        public static void PrintStatusCars()
        {
            PrintLine("PersonalCar");
            Console.WriteLine(personalCar.ToString());
            Console.WriteLine(personalCar.Radio.ToString());
            PrintLine("Truck");
            Console.WriteLine(truck.ToString());
            Console.WriteLine(truck.Radio.ToString());
        }
        
        public static void PrintMenu()
        {
            PrintLine("HELP OF COMMANDS");
            PrintLineOfMenu("exit", "end of program");
            PrintLineOfMenu("PersonalCar addPerson 'name'", "add Perosn into Personal Car");
            PrintLineOfMenu("Truck addCargo 'name' 'doubleWeight'", "add Cargo into Truck");
            PrintLineOfMenu("'Truck/PersonalCar' addFuel 'Oil/Benzin' 'doubleVolume'", "add Fuel into Car");
            PrintLineOfMenu("'Truck/PersonalCar' radio 'on/off'", "switch on/off car radio");
            PrintLineOfMenu("'Truck/PersonalCar' radio fm 'doubleFMvalue'", "set FM frekvency");
            PrintLineOfMenu("'Truck/PersonalCar' radio set 'intValuePreset' 'doubleFMvalue'", "set Preset of radio");
            PrintLineOfMenu("'Truck/PersonalCar' radio select 'intValuePreset'", "FM in radio Preset");
            PrintLine();


        }

        private static void PrintLineOfMenu(String comand, String text)
        {
            ConsoleColor def = Console.ForegroundColor;
            
            Console.Write(comand);
            for (int i = comand.Length; i < 70; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = def;
        }

        public static void PrintHistory(List<String> comands, List<String> log)
        {
            ConsoleColor def = Console.ForegroundColor;
            int maxLeng = 60;
            foreach (String item in comands)
            {
                if (maxLeng < item.Length)
                {
                    maxLeng = item.Length + 20;
                }
            }

            for (int i = 0; i < comands.Count; i++)
            {
                Console.Write("Your command: ");
                Console.Write(comands[i]);
                for (int j = comands[i].Length; j <maxLeng ; j++)
                {
                    Console.Write(" ");
                }
                if (log[i] == "OK")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(log[i]);
                    Console.ForegroundColor = def;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(log[i]);
                    Console.ForegroundColor = def;
                }
                Console.WriteLine("");
            }
        }

        public static void GUI()
        {
            bool loop = true;
            List<String> comands = new List<string>();
            List<String> logs = new List<string>();

            while (loop)
            {
                Console.Clear();
                PrintStatusCars();
                PrintMenu();
                Car selected = null;
                PrintHistory(comands, logs);
                Console.Write("Your command: ");
                String ans = "ERR: Invalid comand";
                String line = Console.ReadLine();

                char[] separators = new char[] {' ', '\n', '\t'};
                String[] list = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (line.Contains("exit"))
                {
                    loop = false;
                }
                else if (list[0] == "Truck")
                {
                    selected = truck;                
                }
                else if (list[0] == "PersonalCar")
                {
                    selected = personalCar;
                }
                else
                {
                    ans = "ERR: None selected Car";
                }

                if ((selected != null) && (list[1] == "addFuel"))
                {
                    try
                    {
                        if (list[2] == "Oil")
                        {
                            selected.AddFuel(Car.FUEL.Oil, Convert.ToDouble(list[3]));
                            ans = "OK";
                        }
                        else if (list[2] == "Benzine")
                        {
                            selected.AddFuel(Car.FUEL.Benzine, Convert.ToDouble(list[3]));
                            ans = "OK";
                        }
                        else
                        {
                            throw new Exception("Invalid Kind of Fuel");
                        }

                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    }
                }
                if ((selected != null) && (list[1] == "radio"))
                {
                    try
                    {
                        if (list[2] == "on")
                        {
                            selected.Radio.RadioOn = true;
                            ans = "OK";
                        }
                        if (list[2] == "off")
                        {
                            selected.Radio.RadioOn = false;
                            ans = "OK";
                        }
                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    } 
                }
                if ((selected != null) && (list[1] == "radio") && (list[2] == "fm"))
                {
                    try
                    {
                        selected.Radio.RadioFrekvency = Convert.ToDouble(list[3]);
                        ans = "OK";
                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    }
                }
                if ((selected != null) && (list[1] == "radio") && (list[2] == "set"))
                {
                    try
                    {
                        selected.Radio.SetPreset(Convert.ToInt32(list[3]), Convert.ToDouble(list[4]));
                        ans = "OK";
                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    }
                }
                if ((selected != null) && (list[1] == "radio") && (list[2] == "select"))
                {
                    try
                    {
                        selected.Radio.SelectPreset(Convert.ToInt32(list[3]));
                        ans = "OK";
                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    }
                }
                if ((selected is PersonalCar)&&(list[1] == "addPerson"))
                {
                    try
                    {
                        PersonalCar one = (PersonalCar)selected;
                        one.AddPerson(list[2]);
                        ans = "OK";
                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    }
                }
                if ((selected is Truck) && (list[1] == "addCargo"))
                {
                    try
                    {
                        Truck one = (Truck)selected;
                        one.AddCargo(list[2], Convert.ToDouble(list[3]));
                        ans = "OK";
                    }
                    catch (Exception e)
                    {
                        ans = e.Message;
                    }
                }

                comands.Add(line);
                logs.Add(ans);
            }

        }
    }
}
