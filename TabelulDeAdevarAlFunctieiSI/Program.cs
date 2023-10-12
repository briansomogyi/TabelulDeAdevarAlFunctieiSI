namespace TabelulDeAdevarAlFunctieiSI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition1 = true, condition2 = true;
            Console.WriteLine("Bitwise AND Truth Table");
            Console.WriteLine($"True AND True = {condition1 & condition2}");
            condition2 = false;
            Console.WriteLine($"True AND False = {condition1 & condition2}");
            condition1 = false;
            Console.WriteLine($"False AND False = {condition1 & condition2}");
            condition2 = true;
            Console.WriteLine($"False AND True = {condition1 & condition2}");
        }
    }
}