using System;

    int[] arr = new int[] { 5, 2, 4, 6, 1, 3, 2, 6 };
    Sort(ref arr, 0, arr.Length - 1);

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    
    
    void Sort(ref int[] arr, int p, int r)
    {
        if (arr.Length == 0)
            throw new ArgumentException("Array length can`t be null");
        if (p >= r)
            throw new ArgumentException("The first sort index can`t be greater than the last or equals it ");

        int[] buf = new int[arr.Length];
        MergeSort(ref arr, ref buf, p, r);
    }
    void MergeSort(ref int[] arr, ref int[] buf, int p, int r)
    {
        if (p < r)
        {
            int q = (p + r) / 2;
            MergeSort(ref arr, ref buf, p, q);
            MergeSort(ref arr, ref buf, q + 1, r);
            Merge(ref arr, ref buf, p, q, r);
        }
    }

    void Merge(ref int[] arr, ref int[] buf, int p, int q, int r)
    {
        int k = p;
        for (int i = p, j = q + 1; i <= q || j <= r;)
        {
            if (j > r || (i <= q && arr[i] < arr[j]))
            {
                buf[k] = arr[i];
                ++i;
            }
            else
            {
                buf[k] = arr[j];
                ++j;
            }

            ++k;
        }

        for (int i = p; i <= r; ++i)
        {
            arr[i] = buf[i];
        }

    }
    