using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp71
{
    class program1
    {

        static string url = "http://google.com/robots.txt";

        static async Task MainAsync()
        {
            Console.WriteLine(await new HttpClient().GetStringAsync(url));
        }

    }

}
