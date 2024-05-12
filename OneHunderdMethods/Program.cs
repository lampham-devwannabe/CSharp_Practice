using System.Collections.Specialized;
using System.Globalization;
using System.Text.RegularExpressions;

namespace OneHunderdMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int findMethod = checkMinMax("Enter method number (1-104): ", 1, 104);
            var method = typeof(Program).GetMethod("Q" + findMethod);
            if (method != null)
            {
                method.Invoke(null, null);
            }
        }

        public static int getInt(String msg)
        {
            Console.Write(msg);
            while (true)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    return a;
                }
                catch (Exception)
                {
                    Console.Write("Invalid int input. Please enter again: ");
                }
            }
        }

        public static int checkMinMax(String msg, int min, int max)
        {
            Console.Write(msg);
            while (true)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    if (a < min || a > max)
                    {
                        throw new Exception();
                    }
                    return a;
                }
                catch (Exception)
                {
                    Console.Write($"Invalid int input. Please enter an int from {min} to {max}: ");
                }
            }
        }

        public static double getDouble(String msg)
        {
            Console.Write(msg);
            while (true)
            {
                try
                {
                    double a = double.Parse(Console.ReadLine());
                    return a;
                }
                catch (Exception e)
                {
                    Console.Write("Invalid double input. Please enter again: ");
                }
            }
        }

        public static string getString(String msg)
        {
            Console.Write(msg);
            while (true)
            {
                try
                {
                    string s = Console.ReadLine();
                    if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s))
                    {
                        throw new Exception();
                    }
                    return s;
                }
                catch (Exception e)
                {
                    Console.Write("Invalid string input. Please enter again: ");
                }
            }
        }

        public static void Q1()
        {
            Console.WriteLine("Hello:");
            Console.WriteLine("Pham Thanh Lam");
        }

        public static void Q2()
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", a + b);
        }

        public static void Q3()
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                Console.WriteLine($"Result: {a / b}");
            }
        }

        public static void Q4()
        {
            Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
            Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"14 + (-4) * 6 / 11 = {14 - 4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 + {2 + 15 / 6 * 1 - 7 % 2}");
        }

        public static void Q5()
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"\nFirst number after swapping: {a}");
            Console.WriteLine($"Second number after swapping: {b}");
        }

        public static void Q6()
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} * {b} * {c} = {a * b * c}");
        }

        public static void Q7()
        {
            double a = getDouble("Input first number: ");        
            double b = getDouble("Input second number: ");
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
                Console.WriteLine($"{a} mod {b} = {a % b}");
            }
        }

        public static void Q8()
        {
            Console.Write("Input a number: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }

        public static void Q9()
        {
            Console.Write("Input first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Input fourth number: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine($"The average of {a}, {b}, {c}, {d} = {(a + b + c + d) / 4}");
        }

        public static void Q10()
        {
            Console.Write("Input first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result of specified numbers {a}, {b}, {c} is  " +
                $"(a + b) * c = {(a + b) * c} and a.b + b.c = {a * b + b * c}");
        }

        public static void Q11()
        {
            int a = getInt("Enter your age: ");
            Console.WriteLine($"You look older than {a}");
        }

        public static void Q12()
        {
            double a = getDouble("Enter a number: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine("");
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(a);
                }
                Console.WriteLine("");
            }
        }

        public static void Q13()
        {
            Console.Write("Enter a number: ");
            double a = double.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                Console.Write(a);
            }
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(a + " " + a);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(a);
            }
        }

        public static void Q14()
        {
            Console.Write("Enter the amount of Celsius: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kelvin = {a + 273.15}");
            Console.WriteLine($"Farenheit = {a * 1.8 + 32}");
        }

        public static void Q15()
        {
            Console.Write("Test data: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(input.Remove(new Random().Next(input.Length - 1), 1));
            }
        }

        public static void Q16()
        {
            Console.Write("Test data: ");
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }

        public static void Q17()
        {
            Console.Write("Test data: ");
            string input = Console.ReadLine();
            string sub = input.Substring(0, 1);
            Console.WriteLine(sub + input + sub);
        }

        public static void Q18()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a > 0 && b < 0 || a < 0 && b > 0);
        }

        public static void Q19()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"Result: {3 * (a + b)}");
            }
            else
            {
                Console.WriteLine($"Result: {(a + b)}");

            }
        }

        public static void Q20()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(2 * Math.Abs(a - b));
            }
            else
            {
                Console.WriteLine(Math.Abs(a - b));
            }
        }

        public static void Q21()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a == 20 || b == 20 || a + b == 20);
        }

        public static void Q22()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(100 - a) <= 20 || Math.Abs(200 - a) <= 20);
        }

        public static void Q23()
        {
            Console.Write("Enter a string: ");
            string a = Console.ReadLine();
            Console.WriteLine(a.ToLower());
        }

        public static void Q24()
        {
            Console.Write("Enter a string: ");
            string a = Console.ReadLine();
            string[] arr = a.Split(new[] { " " }, StringSplitOptions.None);
            string max = "";
            int ctr = 0;
            foreach (var s in arr)
            {
                if (s.Length > ctr)
                {
                    max = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(max);
        }

        public static void Q25()
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if (n == 0 || n == 1) return false;
            for (int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void Q26()
        {
            int sum = 0;
            int count = 0;
            int i = 0;
            while (count < 500)
            {
                if (isPrime(i))
                {
                    sum += i;
                    count++;
                }
                i++;
            }
            Console.WriteLine(sum);
        }

        public static void Q27()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            string arr = a.ToString();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToInt32(arr[i] - '0');
            }
            Console.WriteLine(sum);
        }

        public static void Q28()
        {
            Console.Write("Test data: ");
            string a = Console.ReadLine();
            String[] arr = a.Split(new[] { " " }, StringSplitOptions.None);
            Array.Reverse(arr);
            foreach (var s in arr)
            {
                Console.Write(s + " ");
            }
        }

        public static void Q29()
        {
            FileInfo f = new FileInfo("C:\\Workspace\\Demo\\Q29.txt");
            Console.WriteLine(f.Length.ToString());
        }

        public static void Q30()
        {
            Console.Write("Enter a hex number: ");
            string hex = Console.ReadLine();
            int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine($"Decimal value: {dec}");
        }

        public static void Q31()
        {
            Console.Write("Enter first array: ");
            int[] arr1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter first array: ");
            int[] arr2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Array 1: {string.Join(", ", arr1)}");
            Console.WriteLine($"Array 2: {string.Join(", ", arr2)}");
            Console.WriteLine("Multiply corresponding elements of two arrays:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] * arr2[i] + " ");
            }

        }

        public static void Q32()
        {
            string s = getString("Enter a string: ");
            string[] arr = s.Split(new string[] { " " }, StringSplitOptions.None);
            if (arr.Length < 4)
            {
                Console.WriteLine(s);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(arr[arr.Length - 1] + " ");
                }
            }
        }

        public static void Q33()
        {
            int a = getInt("Enter a positive number: ");
            if (a < 0)
            {
                Console.WriteLine("Input smaller than 0");
            }
        }

        public static void Q34()
        {
            string s = getString("Enter a string: ");
            Console.WriteLine(s.StartsWith("Hello"));
        }

        public static void Q35()
        {
            int a = getInt("Enter first number: ");
            int b = getInt("Enter second number: ");
            Console.WriteLine(a < 100 && b > 200 || a > 200 && b < 0100);
        }

        public static void Q36()
        {
            int a = getInt("Enter first number: ");
            int b = getInt("Enter second number: ");
            Console.WriteLine(-10 <= a && a <= 10 && -10 <= b && b <= 10);
        }

        public static void Q37()
        {
            string s = getString("Enter a string: ");
            if (s.Substring(1, 2).Equals("HP"))
            {
                Console.WriteLine(s.Remove(1, 2));
            } else
            {
                Console.WriteLine("String does not contains 'HP'");
            }
        }
        public static void Q38()
        {
            string s = getString("Enter a string: ");
            string str = s.Substring(0, 2);
            if (str.Equals("PH")) {
                Console.WriteLine(str);
            } else
            {
                Console.WriteLine("Incorrect format");
            }
        }
        public static void Q39()
        {
            int a = getInt("Enter first number: ");
            int b = getInt("Enter second number: ");
            int c = getInt("Enter third number: ");
            Console.WriteLine($"Largest number: {Math.Max(a, Math.Max(b,c))}");
            Console.WriteLine($"Smallest number: {Math.Min(a, Math.Min(b,c))}");
        }

        public static void Q40()
        {
            int a = getInt("Enter first number: ");
            int b = getInt("Enter second number: ");
            int r1 = Math.Abs(20 - a);
            int r2 = Math.Abs(20 - b);
            Console.WriteLine(r1 == r2 ? 0 : (r1 < r2 ? a : b));
        }

        public static void Q41()
        {
            string s = getString("Enter a string: ");
            int count = s.Count(s => s == 'w');
            Console.WriteLine(count >= 1 && count <= 3);
        }

        public static void Q42()
        {
            string s = getString("Enter a string: ");
            if (s.Length < 4)
            {
                Console.WriteLine(s.ToUpper());
            } else
            {
                Console.WriteLine(s.Substring(0,4).ToLower() + s.Substring(4, s.Length - 4));
            }
        }

        public static void Q43()
        {
            string s = getString("Enter a string: ");
            Console.WriteLine(s.StartsWith("wwwww"));
        }

        public static void Q44()
        {
            string s = getString("Enter a string: ");
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(s[i]);
                }
            }
        }

        public static void Q45()
        {
            int amount = getInt("Enter array length: ");
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length ; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int count = 0;
            int find = getInt("Enter an integer you want to find: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == find)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of {find} present in the array: {count}");
        }

        public static void Q46()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int find = getInt("Enter an integer to see if it appears at the first or last element of the array: ");
            Console.WriteLine(arr[0].Equals(find) || arr[arr.Length - 1].Equals(find));
        }

        public static void Q47()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        public static void Q48()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            Console.WriteLine(arr[0].Equals(arr[arr.Length - 1]));
        }

        public static void Q49()
        {
            int amount1 = checkMinMax("Enter first array length: ", 1, int.MaxValue);
            int[] arr1 = new int[amount1];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = getInt("Enter an integer: ");
            }
            int amount2 = checkMinMax("Enter second array length: ", 1, int.MaxValue);
            int[] arr2 = new int[amount2];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = getInt("Enter an integer: ");
            }
            Console.WriteLine(arr1[0].Equals(arr2[0]) || arr1[arr1.Length - 1].Equals(arr2[0]) 
                || arr1[0].Equals(arr2[arr2.Length - 1 ]) || arr1[arr1.Length - 1].Equals(arr2[arr2.Length - 1]));
        }

        public static void Q50()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            Console.Write("Array before rotating: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            int temp = 0;
            temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;
            Console.Write("\nArray after rotating: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        public static void Q51()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Largest number in the array: {max}");
        }

        public static void Q52()
        {
            int amount = getInt("Enter array length: ");
            Console.WriteLine("--- 1st array ---");
            int[] arr1 = new int[amount];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = getInt("Enter an integer: ");
            }
            Console.WriteLine("--- 2nd array ---");
            int[] arr2 = new int[amount];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = getInt("Enter an integer: ");
            }
            Console.WriteLine("--- 3rd array ---");
            int[] arr3 = new int[amount];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = getInt("Enter an integer: ");
            }
            int[] result = new int[3];
            result[0] = arr1[(arr1.Length + 1) /2];
            result[1] = arr2[(arr2.Length + 1) / 2];
            result[2] = arr3[(arr3.Length + 1) / 2];
            Console.WriteLine($"\nNew array: [{string.Join(", ", result)}]");
        }

        public static void Q53()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            bool flag = false;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) 
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag);
        }

        public static void Q54()
        {
            int year = checkMinMax("Enter a year: ", 1, int.MaxValue);
            int century = (year / 100) + (year % 100 == 0 ? 0 : 1);
            Console.WriteLine($"Century of year {year}: {century}");
        }

        public static void Q55()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int index = 0;
            int product = arr[index] * arr[index + 1];
            while (index < arr.Length - 1)
            {
                product = (arr[index] * arr[index + 1] > product) ?
                    (arr[index] * arr[index + 1]) : product;
                index++;
            }
            Console.WriteLine($"Largest product: {product}");
        }

        public static void Q56()
        {
            string input = getString("Enter a string: ");
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr).Equals(input));
        }

        public static void Q57()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int index = 0;
            int product = arr[index] * arr[index + 1];
            while (index < arr.Length - 1)
            {
                product = (arr[index] * arr[index + 1] > product) ?
                    (arr[index] * arr[index + 1]) : product;
                index++;
            }
            Console.WriteLine($"Highest product: {product}");
        }

        public static void Q58()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            Array.Sort(arr);
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // neu arr[i+1] ko phai so lien ke cua arr[i] thi counter + 1
                counter += arr[i + 1] - arr[i] - 1;
            }
            Console.WriteLine(counter);
        }

        public static void Q59()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            Array.Sort(arr);
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                counter += arr[i + 1] - arr[i] - 1;
            }
            Console.WriteLine(counter == 0);
        }

        public static void Q60()
        {
            
        }

        public static void Q61()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter an integer: ");
            }
            int[] temp = arr.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;
            int[]result = arr.Select(x => x >= 0 ? temp[ctr++] : -5).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }

        public static void Q62()
        {
            string s = getString("Enter a string: ");

        }

        public static void Q63()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter a number: ");
            }
            bool flag = false;
            int find = getInt("Enter a number to find in array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == find)
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag);
        }

        public static void Q64()
        {
            FileInfo f = new FileInfo("C:\\Workspace\\Demo\\Q29.txt");
            Console.WriteLine(f.Length.ToString());
        }

        public static void Q65()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length;i++)
            {
                arr[i] = getInt("Enter a number: ");
            }
            Console.Write($"Orginal array: {string.Join(", ", arr)}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr.Length;
            }
            Console.Write($"\nAfter multiply with array length: {string.Join(", ", arr)}");
        }

        public static void Q66()
        {
            int a = getInt("Enter first number: ");
            int b = getInt("Enter second number: ");
            if (a > b)
            {
                Console.WriteLine(a);
            } else
            {
                Console.WriteLine(b);
            }
        }

        public static void Q67()
        {
            string s = getString("Enter a string: ");
            s = s.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
            Console.WriteLine(s);
        }

        public static void Q68()
        {
            string s = getString("Enter a string: ");
            char[] arr = s.ToCharArray();
            int ctr = 0;
            string find = getString("Enter char you want to find: ");
            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i].ToString();
                if (temp.Equals(find, StringComparison.OrdinalIgnoreCase))
                {
                    ctr++;
                }
            }
            Console.WriteLine(ctr);
        }

        public static void Q69()
        {
            string s = getString("Enter a string: ");         
            Console.WriteLine(s.Equals(s.ToLower()) || s.Equals(s.ToUpper()));
        }

        public static void Q70()
        {
            string s = getString("Enter a string: ");
            s = s.Remove(0, 1);
            s = s.Remove(s.Length - 1, 1);
            Console.WriteLine(s);
        }

        public static void Q71()
        {
            string s = getString("Enter a string: ");
            bool flag = false;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals(s[i+1])) {
                    flag = true;
                }
            }
            Console.WriteLine(flag);
        }

        public static void Q72()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                arr[i] = getInt("Enter a number: ");
            }
            Console.WriteLine(arr.Average() % 1 == 0);
        }

        public static void Q73()
        {
            string s = getString("Orginal string: ");
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            Console.WriteLine($"Sorted string: {string.Join("", arr)}");
        }

        public static void Q74()
        {
            string s = getString("Enter a string: ");
            if (s.Length % 2 == 0)
            {
                Console.WriteLine("Even length");
            } else
            {
                Console.WriteLine("Odd length");
            }
        }

        public static void Q75()
        {
            int a = getInt("Enter nth odd number: ");
            Console.WriteLine($"Result: {a * 2 - 1}");
        }

        public static void Q76()
        {
            string s = getString("Enter a char: ");
            char c = char.Parse(s);
            int value = (int)c;
            Console.WriteLine($"ASCII value of {c} is: {value}");
        }

        public static void Q77()
        {
            string word = getString("Enter a word: ");
            Console.WriteLine(word.EndsWith("s"));
        }

        public static void Q78()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter a number: ");
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] * arr[i];
            }
            Console.WriteLine($"Result: {sum}");
        }

        public static void Q79()
        {
            int a = getInt("Enter an integer to convert to string: ");
            Console.WriteLine($"Orginal value and type: {a}, {a.GetType()}");
            string c1 = Convert.ToString(a);
            Console.WriteLine($"Converted value and type: {c1}, {c1.GetType()}");
            string s = getString("Enter a string to convert to int: ");
            Console.WriteLine($"Orginal value and type: {s}, {s.GetType()}");
            int c2 = Convert.ToInt32(s);
            Console.WriteLine($"Converted value and type: {c2}, {c2.GetType()}");
        }

        public static void Q80()
        {          
            object[] arr = new object[5];
            arr[0] = 25;
            arr[1] = "Pham Thanh Lam";
            arr[2] = true;
            arr[3] = System.DateTime.Now;
            arr[4] = 11.55;
            Console.WriteLine("--- Original array ---");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Value -> {arr[i]} :: Type -> {arr[i].GetType()}");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].ToString();
            }
            Console.WriteLine("--- Converted array ---");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Value -> {arr[i]} :: Type -> {arr[i].GetType()}");
            }
        }

        public static void Q81()
        {
            int a = checkMinMax("Enter a number: ", 10, 99);
            int oneDigit = a % 10;
            int tenDigit = a / 10;
            int swap = oneDigit * 10 + tenDigit;
            Console.WriteLine($"Input value > swapped value: {a > swap}");
        }

        public static void Q82()
        {
            string s = getString("Enter a string: ");
            Console.Write($"After removing non-letter characters: {Regex.Replace(s, @"[^a-zA-Z]", "")}");
        }

        public static void Q83()
        {
            string s = getString("Enter a string: ");
            Console.Write($"After removing vowel characters: {Regex.Replace(s, @"[ueoaiUEOAI]", "")}");
        }

        public static void Q84()
        {
            string s = getString("Enter a string: ");
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLower(s[i])) {
                    Console.Write($"{i} ");
                }
            }
        }

        public static void Q85()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            double[] arr = new double[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getDouble("Enter a number: ");
            }
            Console.WriteLine("--- Orginal array ---");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i] + arr[i - 1];
            }
            Console.WriteLine("\n--- Cumulative array ---");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Q86()
        {
            string s = getString("Enter a string: ");
            int letterCount = 0;
            int digitCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    letterCount++;
                }
                if (Char.IsDigit(s[i]))
                {
                    digitCount++;
                }
            }
            Console.Write($"Letter: {letterCount} | Digit: {digitCount}");
        }

        public static void Q87()
        {
            bool input = bool.Parse(getString("Input boolean: "));
            Console.WriteLine($"Reverse boolean: {!input}");
        }

        public static void Q88()
        {
            int a = getInt("Enter number of straight lines: ");
            Console.WriteLine($"Sum of interior angles: {180 * (a - 2)}");
        }

        public static void Q89()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter a number: ");
            }
            int posCount = 0;
            int negCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0) 
                {
                    posCount++;
                } else
                {
                    negCount++;
                }
            }
            Console.WriteLine($"Positive: {posCount} | Negative: {negCount}");
        }

        public static void Q90()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            int[] arr = new int[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getInt("Enter a number: ");
            }
            int zeroCount = 0;
            int oneCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeroCount++;
                }
                if (arr[i] == 1)
                {
                    oneCount++;
                }
            }
            Console.WriteLine($"Zeros: {zeroCount} | Ones: {oneCount}");
        }

        public static void Q91()
        {
            object[] arr = new object[7];
            arr[0] = 25;
            arr[1] = "Pham Thanh Lam";
            arr[2] = true;
            arr[3] = System.DateTime.Now;
            arr[4] = 11.55;
            arr[5]  = 6;
            arr[6] = 12;
            Console.WriteLine("--- Mixed array ---");
            for (int i = 0; i < arr.Length ; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
            int[] int_arr = arr.OfType<int>().ToArray();
            Console.WriteLine("--- Int only array ---");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.WriteLine($"{int_arr[i]} ");
            }
        }

        public static void Q92()
        {
            int a = getInt("Original number: ");
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    a++;
                    i = 2;
                }
            }
            Console.WriteLine($"Next/Current prime number: {a}");
        }

        public static void Q93()
        {
            int a = getInt("Enter a number: ");
            int result = (int) Math.Sqrt(a);
            Console.WriteLine($"{a} -> {result}");
        }

        public static void Q94()
        {
            int amount = checkMinMax("Enter array length: ", 1, int.MaxValue);
            string[] arr = new string[amount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = getString("Enter a string: ");
            }
            string find = arr[0];
            int rl = find.Length;
            foreach (string s in arr)
            {
                int j = 0;
                foreach (char c in s)
                {
                    if (j >= rl || find[j] != c)
                        break;
                    j += 1;
                }
                rl = Math.Min(rl, j);
            }
            string result = find.Substring(0, rl);
            Console.WriteLine($"Longest common prefix: {result}");
        }

        public static void Q95()
        {
            string s = getString("Enter a string: ");
            bool status = true;
            Stack<char> ch = new Stack<char>();
            foreach (var item in s.ToCharArray())
            {
                if (item == '(')
                {
                    ch.Push(')');
                } else if (item == '<')
                {
                    ch.Push('>');
                } else if (item == '[')
                {
                    ch.Push(']');
                } else if (item == '{')
                {
                    ch.Push('}');
                } else if (ch.Count == 0 || ch.Pop() != item)
                {
                    status = false;
                } 
            }
            Console.WriteLine(status);
        }

        public static void Q96()
        {
            string s = getString("Enter a string: ");
            bool status = true;
            if (s.Length > 1)
            {
                var b = s[0];
                for (int i  = 1; i < s.Length; i++)
                {
                    var c = s[i];
                    if (c != b)
                    {
                        status = false;
                    }
                }
            }
            Console.WriteLine(status);
        }

        public static void Q97()
        {
            string s = getString("Enter a string: ");
            Console.WriteLine(double.TryParse(s, out _));
        }

        public static void Q98()
        {
           
        }

        public static void Q99()
        {

        }

        public static void Q100()
        {

        }

        public static void Q101()
        {

        }

        public static void Q102()
        {

        }

        public static void Q103()
        {

        }

        public static void Q104()
        {

        }
    }
}
