using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloStaticSharp
{
    internal static class ProjectDirectory
    {
        private static string GetPath([CallerFilePath] string path = "")
        {
            return System.IO.Path.GetDirectoryName(path);
        }
        public static string Path => GetPath();
    }
}
