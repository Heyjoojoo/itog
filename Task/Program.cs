void InPutArray(string [] oldArray, int n)
{

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Пишите, не стесняйтесь: ");
        string a = Console.ReadLine();
        oldArray[i] = a;
    }
}

void FormNewArray(string[] newArray, string[] oldArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {

        if (oldArray[i].Length <= 3)
        {
            newArray[count] = oldArray[i];
            count++;
        }
    }
    Array.Resize(ref newArray, newArray.Length);
}

Console.Clear();
Console.WriteLine("Сколько планируем строк?");
int n = Convert.ToInt32(Console.ReadLine());
string[] oldArray = new string[n];
string[] newArray = new string[n];
InPutArray(oldArray, n);
FormNewArray (newArray, oldArray);
Console.WriteLine($"Вуа-ля: [{string.Join(", ", newArray)}]");



