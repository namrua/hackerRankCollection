using System;

namespace HackerRankCollections
{
    public class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                this.age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                this.age = initialAge;
            }
        }
        public void amIOld()
        {
            if (this.age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (this.age > 12 && this.age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }
        public void yearPasses()
        {
            this.age++;
        }
        class Program
        {

            static void Main(string[] args)
            {
                //int T = int.Parse(Console.In.ReadLine());
                //for (int i = 0; i < T; i++)
                //{
                //    int age = int.Parse(Console.In.ReadLine());
                //    Person p = new Person(age);
                //    p.amIOld();
                //    for (int j = 0; j < 3; j++)
                //    {
                //        p.yearPasses();
                //    }
                //    p.amIOld();
                //    Console.ReadLine();
                //}
                //int n = Convert.ToInt32(Console.ReadLine());
                //for (int k = 0; k < n; k++)
                //{
                //    string text = Console.ReadLine();
                //    var textArray = text.ToCharArray();
                //    string even = string.Empty;
                //    string odd = string.Empty;
                //    for (int i = 0; i < textArray.Length; i++)
                //    {
                //        if (i % 2 == 0 || i == 0)
                //        {
                //            even += textArray[i];
                //        }
                //        else
                //        {
                //            odd += textArray[i];
                //        }
                //    }
                //    Console.WriteLine(string.Format("{0} {1}", even, odd));
                //}
                int n = Convert.ToInt32(Console.ReadLine());

                var arr = Console.ReadLine().Split(' ');
                for (int i = arr.Length - 1; i > -1; i--)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.ReadKey();
            }
        }
    }
}
