int[] array = new int[8];
Random rand = new Random();
for (int n = 0; n < array.Length; n++)
array[n] = rand.Next(0, 2);

foreach (int arr in array)
{
 Console.Write(arr + "  ");   
}