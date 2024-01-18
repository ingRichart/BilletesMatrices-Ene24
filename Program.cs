internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escribe la cantidad correspondiente:");
        var cantidad = Convert.ToInt32(Console.ReadLine());

        int[,] billetes = {
            {1000, 0} ,
            {500, 0} ,
            {200, 0} ,
            {100, 0} ,
            {50, 0} ,
            {20, 0} ,
            {10, 0} ,
            {5, 0} ,
            {1, 0} ,
        };

        for (var fila = 0; fila < billetes.GetLength(0); fila++)
        {
            billetes[fila, 1] = cantidad / billetes[fila, 0];
            if (billetes[fila, 1] >= 1)
            {
                //cantidad -= billetes[fila, 0] * billetes[fila, 1];
                cantidad -= billetes[fila, 0] * billetes[fila, 1];
            }
        }

        PrintArray(billetes);
    }

    static void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write($"{inputArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

}