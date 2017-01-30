## Smart Directory Scanner
This class library allows to get any folders structure on your computer.

## How to use
For using add reference on your application like this:
```C#
using System.IO;
using SmartDirectoryScanner;
 
class Program
{
  static void Main(string[] args)
   {
     string directoryToScan = Console.ReadLine();
     string scanned = SmartScan.ScanDirectory(directoryToScan);
     Console.WriteLine(scanned);  
   }
}
```
