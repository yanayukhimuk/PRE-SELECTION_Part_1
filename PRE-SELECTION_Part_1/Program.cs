using System;

namespace PRE_SELECTION_Part_1
{
    class Calculator
    {
        static int GetNumbers()
        {
            Console.WriteLine("Enter the number: ");
            return int.Parse(Console.ReadLine());
        }

        static int GetOperation(int a, int b)
        {
            int OperationResult = 0;
            switch (char.Parse(Console.ReadLine()))
            {
                case '*': OperationResult = a * b;
                    break;
                case '+': OperationResult = a + b;
                    break;
                case '-': OperationResult = a - b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Can't divide into 0!");
                        break;
                    }
                    else
                    {
                        OperationResult = a / b;
                        break;
                    }
            }

            return OperationResult;
        }

        static void FillArray(string[] arr)
        {
            Console.WriteLine("Let's fill the array of strings: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
        }

        static void SortArray(string[] arr)
        {
            Console.WriteLine("The sorted array is: ");
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - 1 - i; j++)
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
        }

        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {

            int FirstNumber, SecondNumber;
            char answer = 'n';

            do
            {
                FirstNumber = GetNumbers();
                SecondNumber = GetNumbers();

                Console.WriteLine("The entered numbers are: ");
                Console.WriteLine(FirstNumber);
                Console.WriteLine(SecondNumber);

                Console.WriteLine("Choose the calculator operation: *, /, +, - : ");

                Console.WriteLine(GetOperation(FirstNumber, SecondNumber));

                Console.WriteLine("Do you want to try again? (y / n) : ");
                answer = char.Parse(Console.ReadLine());
            }
            while (answer != 'n');

            int SIZE;
            Console.WriteLine("Enter the array size: ");
            SIZE = int.Parse(Console.ReadLine());

            string[] ArrayOfStrings = new string[SIZE];
            FillArray(ArrayOfStrings);

            Console.WriteLine("The entered array is: ");
            PrintArray(ArrayOfStrings);

            SortArray(ArrayOfStrings);
            PrintArray(ArrayOfStrings);
        }
    }
}
