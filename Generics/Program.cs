namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // // assignment One 

            //string[] arr = {"Abc","Ade","ale","awx" };

            //ArrayUtils a = new ArrayUtils();
            //Console.WriteLine($"The Max item : { a.FindMax(arr)}");

            //arr = a.ReverseArray(arr);
            //Console.WriteLine("Reversed Items :");
            //foreach (string i in arr)
            //{
            //    Console.WriteLine(i);
            //}



            // // assignment Two 

            Cache<int, int> cache = new Cache<int, int>(3);
            cache.Add(11, 93);
            cache.Add(23, 73);
            cache.Add(54, 33);
            cache.Add(61, 483);

            Console.WriteLine(cache.retrieve(23));
          
            cache.getLRUList();
            cache.Remove(61);
            cache.getLRUList();

        }
    }
}