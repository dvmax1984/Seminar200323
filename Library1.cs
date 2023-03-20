public static class lybrary 
{
    public static int[] FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 5);
        }
    } 
}