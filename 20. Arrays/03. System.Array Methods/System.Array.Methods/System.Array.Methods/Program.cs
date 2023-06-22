namespace ArrayMethods
{
    class Program
    {
        static void Main()
        {
            //create array
            double[] a = new double[7] { 10, 20, 30,30, 40, 50, 60 };

            //search for 30 in the array
            int n = Array.IndexOf(a, 30);
            Console.WriteLine("30 is found at "+n);

            //search for 30 in the array (second occurrence)
            int n2 = Array.IndexOf(a, 30, 3);
            Console.WriteLine("30 second occurrence is found at " + n2);

            //search for 100 in the array (not exists)
            int n3 = Array.IndexOf(a, 100);
            Console.WriteLine("100 is found at " + n3);
            //search for 30 in the array (first half)
            int n4 = Array.BinarySearch(a, 30);
            Console.WriteLine("30 is found at " + n4);

            //search for 100 in the array (second half)
            int n5 = Array.BinarySearch(a, 60);
            Console.WriteLine("60 is found at " + n5);

            //clear elements of array
            Array.Clear(a, 2, 3);

            //display array
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //create array
            int[] a_resize = new int[] { 10, 20, 30 };

            //resize array to 5
            Array.Resize(ref a_resize, 5);

            //print array
            foreach (var item in a_resize)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //create array
            int[] a_sort = new int[] { 67, 12, 99, 4, 500, 125 };

            //sort ascending order
            Array.Sort(a_sort);

            //display array after sort
            foreach (var item in a_sort)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //reverse the array (it becomes descending order)
            Array.Reverse(a_sort);

            //display array after sort
            foreach (var item in a_sort)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}