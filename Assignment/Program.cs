namespace Assignment
{
    class Program
    {
        public static void Main()
        {

            //Assignment 2

            #region 1.Write a program that allows the user to enter a number then print it.

            /*Console.Write("Please Enter Number ");
               int Num = Convert.ToInt32(Console.ReadLine());
               Console.Clear();
               Console.WriteLine($"Please Enter Number{Num}");*/

            #endregion

            #region 2.Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            /*string Charchter = "Israa";
               int Num = Convert.ToInt32(Charchter);
               Console.WriteLine(Num);*/
            // Can't convert string to an integer 
            #endregion

            #region 3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            float Num1 = 55.5f;
            float Num2 = 66.6f;

            // Perform addition
            float Sum = Num1 + Num2;
            Console.WriteLine(Sum);

            // Perform division
            float divided = Num1 / Num2;
            Console.WriteLine(divided);

            // Perform multiplication
            float number = Num1 * Num2;
            Console.WriteLine(number);

            #endregion

            #region 4.Write C# program that Extract a substring from a given string.

            /*string ST1 = "Haidy.Sobhy";
            string substring = ST1.Substring(0,5);
            Console.WriteLine(substring);*/
            #endregion

            #region 5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            /*int x ;
            x = 10;
            int y;
            y = x;
            Console.WriteLine(y);
            x = 20;
            Console.WriteLine(y);*/

            #endregion
        }
    }
}
