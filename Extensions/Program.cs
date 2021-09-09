// See https://aka.ms/new-console-template for more information

using Extensions;

List<string> list = new()
{
    "0",
    "1",
    "2",
    "3",
    "4",
    "5",
    "6",
    "7",
    "8",
    "9",
    "10"

};

Console.WriteLine(string.Join(',', list));
Console.WriteLine();

int i = 5;

for (i = 0; i < 11; i++)
{
    list = new()
    {
        "0","1","2","3","4","5","6","7","8","9","10"
    };

    List<string> subset = new()
    {
        list[2],
        list[5],
        list[10]
    };


    list.MoveElements(subset, i);

    Console.WriteLine(string.Join(',', list));

}




