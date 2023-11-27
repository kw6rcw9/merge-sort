using System;



namespace MergeSort
{

    class Program
    {
        public static void Main()
        
        {
            int[] arr = new int[]{5,2,4,6,1,3,2,6};
            Sort(ref arr, 0, arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

        public static void Sort(ref int[] arr, ref int[] buf, int p, int r) {
            if (p < r)
            {
                int q = (p + r) / 2;
                Sort(ref arr, ref buf, p, q);
                Sort(ref arr, ref buf, q + 1, r);
                Merge(ref arr, ref buf, p , q, r);
            }

            // Merge
            /*int k = l;
            for (int i = l, j = m + 1; i <= m || j <= r; ) {
                if (j > r|| (i <= m && arr[i] < arr[j])) {
                    buf[k] = arr[i];
                    ++i;
                }
                else {
                    buf[k] = arr[j];
                    ++j;
                }
                ++k;
            }
            for (int i = l; i <= r; ++i) {
                arr[i] = buf[i];
            }*/
        
        }

        public static void Sort(ref int[] arr, int p, int r ) {
            if (arr.Length == 0 )
                throw new ArgumentException("Array length can`t be null");
            if(p >= r)
                throw new ArgumentException("The first sort index can`t be greater than the last or equals it ");

            int[] buf = new int[arr.Length];
            Sort(ref arr, ref buf, p, r - 1);
        }

        public static void Merge(ref int[] arr, ref int[] buf, int p, int q, int r)
        {
            int k = p;
            for (int i = p, j = q + 1; i <= q || j <= r; ) {
                if (j > r|| (i <= q && arr[i] < arr[j])) {
                    buf[k] = arr[i];
                    ++i;
                }
                else {
                    buf[k] = arr[j];
                    ++j;
                }
                ++k;
            }
            for (int i = p; i <= r; ++i) {
                arr[i] = buf[i];
            }

        }



    }

   

}