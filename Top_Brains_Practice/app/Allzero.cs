using System;

class Zero
{
    static void Movezeroend(int[] arr)
    {
        int w = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[w] = arr[i];
                w++;}}
        for (int i = w; i < arr.Length; i++){
            arr[i] = 0;}}
   public  static void zero()
    {
        int[] arr = { 0, 6, 0, -2, 3 };
        Movezeroend(arr);
        Console.WriteLine(string.Join(", ", arr));
    }
}
