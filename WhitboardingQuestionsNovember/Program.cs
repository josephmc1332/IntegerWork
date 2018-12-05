using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhitboardingQuestionsNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12344;

            Console.WriteLine(Duplicate(a));
        }

        public static bool Duplicate(params int [] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            foreach(var item in x)
            {
                if (d.ContainsKey (item) == true)
                    return true;
                else
                {
                    d.Add(item, 1);
                }            
            }
            return false;
        }


        public static int Digits(int a)
        {
            int sum = 0;
            int num = 0;

            while(a != 0)
            {    
                sum += a % 10;
                a = a / 10;
            }
            return sum;
        }



        public static int Sum(int [] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] % 2 == 0 ? arr[i] : 0;
            }
            return sum;
        }
        public static int Majority(int [] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            double majority = x.Length/2.0;
            
            foreach (int i in x)
            {
                if(d.ContainsKey(i))
                {
                    d[i]++;

                    if (d[i] > majority)
                        return i;
                }
                else
                {
                    d.Add(i, 1);
                }
            }
            
            throw new Exception("Contains no majority");
            
        }
        public static bool IsAnagram(string a)
        {
            int dec = a.Length - 1;

            for (int i = 0; i < a.Length /2 + 1; i++)
            {
                if(a[i] == a[dec])
                {
                    dec--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static int [] Reverse(int [] arr)
        {
            Stack<int> nums = new Stack<int>(arr);

            foreach (var item in nums)
            {
                int i = 0;
                arr[i] = item;
                nums.Pop();
            }
            return arr;
        }
    }
}
