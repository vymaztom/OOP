using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Program
    {

        /* 
            
            
            ERROR I WAS NOT ABLE TO RUN PROGRAM :(
         
        cv06.exe (CLR v4.0.30319: DefaultDomain): Načteno C:\WINDOWS\Microsoft.Net\assembly\GAC_64\mscorlib\v4.0_4.0.0.0__b77a5c561934e089\mscorlib.dll. Nahrávání symbolů se vynechalo. Modul je optimalizovaný a volba Pouze můj kód je povolená.
        cv06.exe (CLR v4.0.30319: DefaultDomain): Načteno C:\Users\vymaztom\Desktop\VUT\OOP\OOP\cv06\cv06\bin\Debug\cv06.exe. Symboly byly načteny.
        Program '[15448] cv06.exe' skončil s kódem 0 (0x0).
        

            BUT BUILD WAS SUCCESSFUL

        1>------ Operace "Znovu sestavit vše" zahájena: Projekt:cv06, Konfigurace: Debug Any CPU ------
        1>  cv06 -> C:\Users\vymaztom\Desktop\VUT\OOP\OOP\cv06\cv06\bin\Debug\cv06.exe
        ========== Nové sestavení všeho: 1 úspěšně, 0 se nezdařilo, 0 přeskočeno ==========

            PROBABLY PROBLEM WITH DYNAMIC LIB, I WILL TRY REINSTALL WS2017 ... BUT NOW I DO NOT HAVE ENOUGH TIME

          
        */



        static void Main(string[] args)
        {
            PrintData2DObject(new Ring(2.3));
            PrintData2DObject(new Rectangle(2 , 3));
            PrintData2DObject(new Ellipse(2, 3));
            PrintData2DObject(new Triangle(2, 3));
            PrintData3DObject(new Block(2, 3, 4));
            PrintData3DObject(new Cylinder(2, 3));
            PrintData3DObject(new Ball(2));
            PrintData3DObject(new Pyramid(2.5, 3.8, 3));
        }

        public static void PrintData2DObject(Object2D one)
        {
            one.Draw();
            Console.WriteLine("Content = {0}", one.SumContent());
        }

        public static void PrintData3DObject(Object3D one)
        {
            one.Draw();
            one.Draw();
            Console.WriteLine("Content = {0}", one.SumContent());
            Console.WriteLine("Capacity = {0}", one.SumCapacity());
        }
    }
}
