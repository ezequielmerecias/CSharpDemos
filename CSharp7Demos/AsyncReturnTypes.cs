using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class AsyncReturnTypes
    {
        public void Start()
        {

            static async Task<long> GetDirSize(string dir)
            {
                if (!Directory.EnumerateFileSystemEntries(dir).Any())
                    return 0;
                return await Task.Run(() => Directory.GetFiles(dir, "*.*",
                    SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
            }

            static async ValueTask<long> GetDirSize2(string dir)
            {
                if (!Directory.EnumerateFileSystemEntries(dir).Any())
                    return 0;
                return await Task.Run(() => Directory.GetFiles(dir, "*.*",
                    SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
            }

            Console.WriteLine(GetDirSize2(@"c:\temp").Result);
        }
    }
}
