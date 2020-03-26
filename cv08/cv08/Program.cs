using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cv08
{
    class Program
    {
        public static ArchiveTemperature archive;
        public static bool run = true;

        public static void PrintMenu()
        {
            Console.WriteLine("1 \tLoad from File");
            Console.WriteLine("2 \tSave to File");
            Console.WriteLine("3 \tAdd to archive");
            Console.WriteLine("4 \tPrint archive");
            Console.WriteLine("5 \tPrint average temperatures");
            Console.WriteLine("6 \tPrint month average temperatures");
            Console.WriteLine("7 \tMax temperature");
            Console.WriteLine("8 \tMin temperature");
            Console.WriteLine("9 \tCalibration");
            Console.WriteLine("10\tExit");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }

        public static void loop() 
        {
            while (run) 
            {
                PrintMenu();
                int value = Convert.ToInt32(Console.ReadLine());
                string one;
                int year;
                switch (value)
                {
                    case 1:
                        Console.Write("Is data file in the same directory (yes/no):");
                        one = Console.ReadLine();
                        if (one.Contains("Y") || one.Contains("y") || one.Contains("Yes") || one.Contains("yes"))
                        {
                            Console.Write("Write name of file:");
                            string nameOfFile = Console.ReadLine();
                            archive.LoadFromFile(nameOfFile, true);
                        }
                        else 
                        {
                            Console.Write("Write full path to file:");
                            string path = Console.ReadLine();
                            archive.LoadFromFile(path);
                        }
                        break;
                    case 2:
                        SAVE:
                        Console.Write("Save into same directory where is running program (yes/no):");
                        one = Console.ReadLine();
                        if (one.Contains("Y") || one.Contains("y") || one.Contains("Yes") || one.Contains("yes"))
                        {
                            Console.Write("Set name of file:");
                            string nameOfFile = Console.ReadLine();
                            archive.WriteToFile(nameOfFile, true);
                        }
                        else
                        {
                            Console.Write("Set full path to save file:");
                            string path = Console.ReadLine();
                            archive.WriteToFile(path);
                        }
                        break;
                    case 3:
                        Console.Write("Set year:");
                        year = Convert.ToInt32(Console.ReadLine());
                        List<double> data = new List<double> { };
                        Console.Write("Set data (12 double values devided by ';' or ' '):");
                        one = Console.ReadLine();
                        char[] separators = new char[] { ' ', ';', '\n' };
                        string[] list = one.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string item in list)
                        {
                            try
                            {
                                data.Add(Convert.ToDouble(item));
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message);
                            }
                            
                        }
                        if (data.Count != 12)
                        {
                            Console.WriteLine("invalid input");
                        }
                        else 
                        {
                            archive.add(year, data);
                        }
                        break;
                    case 4:
                        archive.PrintTemperatures();
                        break;
                    case 5:
                        archive.PrintAverageTemperatre();
                        break;
                    case 6:
                        archive.PrintAverageMonthTemperatre();
                        break;
                    case 7:
                        Console.Write("Set year:");
                        year = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Max temperature in {0} was {1,7:0.0}", year, archive.Search(year).MaxTemperatre);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 8:
                        Console.Write("Set year:");
                        year = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Min temperature in {0} was {1,7:0.0}", year, archive.Search(year).MaxTemperatre);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        
                        break;
                    case 9:
                        Console.Write("Set value (double):");
                        one = Console.ReadLine();
                        double cal_value;
                        try
                        {
                            cal_value = Convert.ToDouble(one);
                            archive.Calibration(cal_value);
                            Console.Write("Woudl you like to save data into file (yes/no):");
                            one = Console.ReadLine();
                            if (one.Contains("Y") || one.Contains("y") || one.Contains("Yes") || one.Contains("yes"))
                            {
                                goto SAVE;
                            }

                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 10:
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            archive = new ArchiveTemperature();
            loop();

            /*
            archive.LoadFromFile("data_in.txt", true);
            archive.PrintTemperatures();
            archive.Calibration(-0.1);
            archive.WriteToFile("data_out.txt", true);
            archive.PrintTemperatures();
            archive.PrintAverageTemperatre();
            archive.PrintAverageMonthTemperatre();
            Console.ReadLine();
            */
        }
    }
}
