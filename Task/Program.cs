//Контрольная работа

string [] array1 = {"Brain+1", "Space", "Geek", "Hellow", "World", "2", "123",  "Go", "Fun"};
string [] array2 = new string[array1.Length];
PrintArray(array1);
ChangeArray(array1, array2);
PrintArray(array2);


void PrintArray(string [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]}  ");
    }
    Console.WriteLine();
}

void ChangeArray(string [] array1, string [] array2)
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