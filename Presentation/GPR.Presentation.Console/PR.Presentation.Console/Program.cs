using System;
using PR.Services;

namespace PR.Presentation.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new PageRankService();
            var vector = services.PageRank();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(vector[i]+ "\n");
            }
  
             
        }
    }
}
