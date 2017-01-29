using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDirectoryScanner
{
    public static class SmartScan
    {
        public static string ScanDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException("Directory doesn't exists!");
            }

            var directoryBuilder = new StringBuilder();
            var directoryInfo = new DirectoryInfo(directoryPath);
            directoryBuilder.Append(directoryInfo.Name);
            var directoryChildren = directoryInfo.GetDirectories();
            if (directoryChildren.Length >= 0)
            {
                directoryBuilder.Append("\n\t\\");
                foreach (var childDirectory in directoryChildren)
                {
                    directoryBuilder.Append(ScanDirectory(childDirectory.FullName));
                    directoryBuilder.Append("\n\t\t\\");
                }
            }

            return directoryBuilder.ToString();
        }
    }
}
