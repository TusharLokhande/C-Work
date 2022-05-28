using System;

namespace Test_1
{
     class Class2
    {
      


        static void secondLarget(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(arr[arr.Length - 2]);
        }

        static void rvereseArray(int [] arr)
        {
            int temp;
            int start=0,  end = arr.Length-1;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine(string.Join(',',arr));

        }
        static void avg(int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            int avg = sum / arr.Length;
            Console.WriteLine(avg);
        }

        static void merge(int[]a, int[] b)
        {
            int[] x = new int[a.Length + b.Length];
            for(int i = 0; i < a.Length; i++)
            {
                x[i] = a[i];
            }

            for(int i = 0; i < b.Length; i++)
            {
                x[a.Length + i] = b[i];
            }
            sort(x, x.Length-1,0);
            Console.WriteLine(string.Join(",", x));
        }

        static void totalDuplicate(int []arr)
        {
            int[] count = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                int k = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        k++;
                    }
                }
                count[i] = k;
            }
            sum(count);
        }

        static void DeleteDuplicate(int []arr1)
        {
            int i, j;
            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr1[j] == arr1[i])
                        break;
                }
                if (arr1.Length == j)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
        }

        static void count(int []arr)
        {
            int [] count = new int[arr.Length];

            int visited = -1;
            
            for(int i = 0; i < arr.Length; i++)
            {
                int k = 0;
                for (int j=i+1;j< arr.Length; j++)
                {
                   if(arr[i] == arr[j])
                    {
                        k++;
                        count[j] = k;
                    }
                }

                if (count[i] != visited)
                {
                    count[i] = k;
                }
            }

            Console.WriteLine(string.Join(",", count));
        }

        static void sort(int[] arr, int r, int c)
        {
            if (r == 0)
            {
                return;
            }
            if (r > c)
            {
                if (arr[c] > arr[r])
                {
                    int temp = arr[r];
                    arr[r] = arr[c];
                    arr[c] = temp;
                }
                sort(arr, r, c + 1);
            }
            sort(arr, r - 1, 0);
        }

        static void unique(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int k = 0;
                for(int j= 0; j < arr.Length; j++)
                {
                   if(arr[j] == arr[i])
                    {
                        k++;
                    }
                }

                if (k == 1)
                {
                    Console.Write(arr[i]);
                }

            }

            
        }

        static  void addElement(int[]arr, int x)
        {   
            int n = arr.Length;
            int[] newarr = new int[n + 1];
            for (int i = 0; i < n; i++)
                newarr[i] = arr[i];
            
            newarr[n] = x;
            Console.WriteLine(string.Join(",", newarr));
           
        }

        static void negative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }
        }

        static void evenOdd(int []arr)
        {
            int even = 0, odd = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 ==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Even: " + even + " Odd: " + odd);
        }

        static void sum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        static void getMaxAndMin(int []arr)
        {
            int max = arr[0];
            int min = arr[0];

            for(int i= 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Max: "+max+" Min: "+min);

        }

        static void jaggedArray()
        {
            int[][] arr = new int[3][] { 
                                        new int[3] { 1, 2, 4 } ,
                                        new int[2] { 9, 7 },
                                        new int[1] { 2  },
                                        };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                   Console.WriteLine(arr[i][j]);
                }
            }


        }

        static void two2din1d()
        {
            int[][] arr = new int[][] {
                                      new int[] {1, 2},
                                      new int[] {3, 4},
                                      new int[] {5, 6}
                                     };

            int[] k = new int[6];
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    k[a] = arr[i][j];
                    a++;
                }
            }

            foreach (int i in k)
            {
                Console.WriteLine(i);
            }

        }
    }
}
