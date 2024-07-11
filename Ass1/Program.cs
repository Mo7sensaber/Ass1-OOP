using System.Security;

namespace Ass1
{
    /* #region Week days
     public enum WeekDays
     {
         Monday,
         Tuesday,
         Wednesday,
         Thursday,
         Friday,
         Saturday,
         Sunday,

     } 
     #endregion*/

    /* #region Season
     public enum Season
     {
         Spring,
         Summer,
         Autumn,
         Winter,
     } 
     #endregion*/

    /* #region Permission
     [Flags]
     public enum Permission
     {
         Read = 1,
         Write = 2,
         Delete = 4,
         Execute = 8,
     }
     public class emp
     {
         public Permission permission;
     } 
     #endregion*/

   /* #region color
    public enum color
    {
        red = 1,
        green = 2,
        blue = 3,
    } 
    #endregion*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /* #region Q1
             Enum D;
             for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine((WeekDays)i);
             } 
             #endregion*/

            /* #region Q2
             string input = Console.ReadLine();
             Enum.TryParse(input, true, out Season s);

             switch (s)
             {
                 case Season.Spring:
                     Console.WriteLine("march to may ");
                     break;
                 case Season.Summer:
                     Console.WriteLine("june to august");
                     break;
                 case Season.Autumn:
                     Console.WriteLine("September to November");
                     break;
                 case Season.Winter:
                     Console.WriteLine("December to February");
                     break;

             } 
             #endregion*/

            /* #region Q3
             emp emplo = new emp();
             emplo.permission = emplo.permission ^ Permission.Read;

             Console.WriteLine(emplo.permission);
             emplo.permission = emplo.permission | Permission.Execute;
             Console.WriteLine(emplo.permission);
             if ((emplo.permission & Permission.Delete) == Permission.Delete)
                 Console.WriteLine("existed ");
             else
                 Console.WriteLine("not existed "); 
             #endregion*/

            /* #region Q4
             string input = Console.ReadLine();

             if (Enum.TryParse(input, true, out color C))
             {
                 if (C == color.green || C == color.blue || C == color.red)
                     Console.WriteLine($"{C} is a primary color.");
                 else
                     Console.WriteLine($"{C} is not a primary color.");


             }

             #endregion*/

           /* #region Q5
            Console.WriteLine("Enter the firest point X and Y");
            double.TryParse(Console.ReadLine(), out double output1);
            double.TryParse(Console.ReadLine(), out double output2);
            Point p1 = new Point(output1, output2);

            Console.WriteLine("Enter the second point X and Y");
            double.TryParse(Console.ReadLine(), out double output3);
            double.TryParse(Console.ReadLine(), out double output4);
            Point p2 = new Point(output3, output4);

            double distance = p2.x - p1.x;
            double distance2 = p2.y - p1.y;
            Console.WriteLine("the distance is ");
            double calc = Math.Sqrt((distance * distance) + (distance2 * distance2));
            Console.WriteLine(calc); 
            #endregion*/

        }
    }
}