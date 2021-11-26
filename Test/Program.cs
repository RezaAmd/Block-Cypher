using BlockCypher.Api;
using System;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var blockCypher = new BlockCypherClient("6277183c7085424b9913ee3e3d955332");
            var result = await blockCypher.GetInfoByAddress("1DEP8i3QJCsomS4BSMY2RpU1upv62aGvhD");

            Console.ReadKey();
        }
    }
}