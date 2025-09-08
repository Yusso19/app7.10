//2ededin arasindaki ededderi chap edin
//int a = 2;
//int b = 40;
Console.Write("a-ni daxil edin: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("a-ni daxil edin: ");
int b = Convert.ToInt32(Console.ReadLine());

int S = 0;
int v = 0;
if (b >= a)
{
    for (int i = a; i <= b; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
            S = S + 1;
            v = v + i;
        }
    }

}
else
{
    for (int i = b; i <= a; i++)
    {


        if (i % 2 == 0)
        {
            Console.WriteLine(i);
            S = S + 1;
            v = v + i;
        }     


    }
}


Console.WriteLine("negeder var arasinda =" +S);
Console.WriteLine("bide sredne arifmetik =" + v/S);






