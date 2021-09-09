// See https://aka.ms/new-console-template for more information

using Extensions;

List<string> list = new()
{
    "zero",
    "nje",
    "dy",
    "tre",
    "kater",
    "pese",
    "gjashte",
    "shtate",
    "tete",
    "nente",
    "dhjete"
};

Console.WriteLine(string.Join(',', list));


for (int i = 0; i < 10; i++)
{
    list = new()
    {
        "zero",
        "nje",
        "dy",
        "tre",
        "kater",
        "pese",
        "gjashte",
        "shtate",
        "tete",
        "nente",
        "dhjete"
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




