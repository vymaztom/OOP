using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] list1 = new int[] {1 , 2 , 3, 48, 7, -7};
            string[] list2 = new string[] {"a", "b", "c", "d"};
            Ring[] list3 = new Ring[] {new Ring(1), new Ring(2.65), new Ring(3.5)};
            Rectangle[] list4 = new Rectangle[] { new Rectangle(1, 0.7), new Rectangle(2.65, 5.3), new Rectangle(3.5, 1.5) };
            Ellipse[] list5 = new Ellipse[] { new Ellipse(1, 0.7), new Ellipse(2.65, 5.3), new Ellipse(3.5, 1.5) };
            Triangle[] list6 = new Triangle[] { new Triangle(1, 0.7), new Triangle(2.65, 5.3), new Triangle(3.5, 1.5) };
            Square[] list7 = new Square[] { new Square(1), new Square(2.65), new Square(3.5) };
            Object2D[] list8 = new Object2D[] { new Square(1), new Ellipse(1, 0.7), new Triangle(2.65, 5.3), new Rectangle(3.5, 1.5), new Ring(3.5) };

            Console.WriteLine("List1 Max:{0} ; Min:{1}", Extremes.Max<int>(list1), Extremes.Min<int>(list1));
            Console.WriteLine("List2 Max:{0} ; Min:{1}", Extremes.Max<string>(list2), Extremes.Min<string>(list2));
            Console.WriteLine("List3 Max:{0} ; Min:{1}", Extremes.Max<Ring>(list3), Extremes.Min<Ring>(list3));
            Console.WriteLine("List4 Max:{0} ; Min:{1}", Extremes.Max<Rectangle>(list4), Extremes.Min<Rectangle>(list4));
            Console.WriteLine("List5 Max:{0} ; Min:{1}", Extremes.Max<Ellipse>(list5), Extremes.Min<Ellipse>(list5));
            Console.WriteLine("List6 Max:{0} ; Min:{1}", Extremes.Max<Triangle>(list6), Extremes.Min<Triangle>(list6));
            Console.WriteLine("List7 Max:{0} ; Min:{1}", Extremes.Max<Square>(list7), Extremes.Min<Square>(list7));
            Console.WriteLine("List8 Max:{0} ; Min:{1}", Extremes.Max<Object2D>(list8), Extremes.Min<Object2D>(list8));

            // LINQ
            Console.WriteLine("LINQ function:");
            IEnumerable<int> values = new List<int>() { 1, 3, 5, 7, 9 };
            IEnumerable<int> ret = from c in values where c >= 4 && c <= 8 orderby c descending select c;
            foreach (int c in ret)
            {
                Console.WriteLine(c);
            }



            Console.ReadLine();
        }
    }
}
