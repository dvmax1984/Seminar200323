// рандомный массив
int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
string ArrayRandom (ref int [] array)
{
    int size =array.Length;
    string resultArr = String.Empty;
    for (int i=0; i<size; i++)
    {
        array [i]= new Random().Next(-100,100);
        resultArr = resultArr + array[i] + " ";
    }
    return resultArr;
}
int length = Input ("введите количество элементов массива: ");
int [] array = new int [length];
Console.Write($"массив: [ " + ArrayRandom(ref array) + "]");
