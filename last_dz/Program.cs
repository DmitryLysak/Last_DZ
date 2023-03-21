string[] array1 = new string[8] {"Hello", "2", "world", ":-)", "1234", "Russia", "-2", "computer science"};
string[] array2 = new string[array1.Length];
void Array(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
Array(array1, array2);