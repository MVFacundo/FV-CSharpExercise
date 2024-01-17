public class Program
{
    public static void Main()
    {
        //------------------------------------------------------------First exercise------------------------------------------------------------

        int[] testArray1 = { 1, 2, 3, 4, 5 };
        //int[] testArray1 = { 3, 2, 1, 4, 5 };
        //int[] testArray1 = { 3, 2, 1, 4, 1 };
        //int[] testArray1 = { 1, 2, 3, 4 };
        //int[] testArray1 = { };
        //int[] testArray1 = { 10 };

        var result1 = IsArrayCentered(testArray1);

        Console.WriteLine("First exercise result");
        Console.WriteLine(result1);
        Console.WriteLine();


        int IsArrayCentered(int[] array1)
        {
            int lengthArray = array1.Length;
            if (lengthArray % 2 == 0 || lengthArray == 0)
            {
                return 0;
            }

            int mediumIndex = array1.Length / 2;
            for (int i = 1; i <= mediumIndex; i++)
            {
                if (array1[mediumIndex] >= array1[mediumIndex - i] || array1[mediumIndex] >= array1[mediumIndex + i])
                {
                    return 0;
                }
            }

            return 1;
        }

        //------------------------------------------------------------Second exercise------------------------------------------------------------


        int testNumber = 1234;
        //int testNumber = 12005;
        //int testNumber = 1;
        //int testNumber = 1000;
        //int testNumber = 10;
        //int testNumber = -12345;

        var result2 = f2(testNumber);
        Console.WriteLine("Second exercise result");
        Console.WriteLine(result2);
        Console.WriteLine();

        int f2(int n)
        {
            int result = 0;

            while (n != 0)
            {
                int digit = n % 10;
                result = result * 10 + digit;
                n /= 10;
            }

            return result;
        }


        //------------------------------------------------------------Third exercise------------------------------------------------------------



        int[] testArray3 = { 1 };
        //int[] testArray3 = { 1,2 };
        //int[] testArray3 = { 1,2,3 };
        //int[] testArray3 = { 1,2,3,4 };
        //int[] testArray3 = { 3,3,4,4 };
        //int[] testArray3 = { 3,2,3,4 };
        //int[] testArray3 = { 4,1,2,3 };
        //int[] testArray3 = { 1,1 };
        //int[] testArray3 = { };



        var result3 = f3(testArray3);

        int f3(int[] array3)
        {
            //Let X = the sum of the odd numbers
            //Let Y = the sum of the even numbers
            int x = 0, y = 0;
            foreach (var item in array3)
            {
                if (item % 2 == 0)
                {
                    y = y + item;
                }
                else
                {
                    x = x + item;
                }
            }

            return x - y;
        }

        Console.WriteLine("Third exercise result");
        Console.WriteLine(result3);
    }
}
