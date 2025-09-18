namespace Subroutines10C25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInput = 0;
           
            while (!between10And20(numInput))
            {
                Console.Write("Enter a number: ");
                numInput = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("well done");
          
        }
        static bool between10And20(int numInput)
        {
            if(numInput>10 && numInput < 20)
            {
                return true;
            }
            return false;
        }
        static bool greaterThanTen(int numToCheck)
        {
            if (numToCheck > 10)
            {
                return true;
                Console.WriteLine("This will never run!");
            }
            return false;
        }

        static int giveMeANumber()
        {
            int numNums = 0;
            Console.Write("How many numbers: ");
            numNums =Convert.ToInt32( Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < numNums; i++)
            {
                Console.Write("Enter a number: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }


            return sum;

        }
        static void notAFunction()
        {
            Console.WriteLine("You called a procedure");
            Console.WriteLine("I won't return!");
        }
    }
}
