using System;
using PR.Services;

namespace PR.Presentation.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new PageRankService();
            var matrix = services.ReadMatrix();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(matrix[i,j]+ "\n");
                }   
            }
        }
    }
}
