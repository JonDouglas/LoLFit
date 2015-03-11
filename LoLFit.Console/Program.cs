using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLFit.Core;
using LoLFit.Core.Model.Enum;

namespace LoLFit.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            LoLFitApi a = new LoLFitApi("TEST", Region.NA);
            var results = await a.GetMatchDetails(1752090973);
            System.Console.WriteLine(results.ToString());
        }
    }
}
