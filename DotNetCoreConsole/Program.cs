using System;
using System.IO;

namespace NodeModulesCleaner
{
  class Program
  {
    static void Main(string[] args)
    {
      var folder = args[0];
      if (!Directory.Exists(folder))
      {
        Console.WriteLine("Folder '" + folder + "' does not exist!");
        return;
      }

      Console.WriteLine("Started scanning folder '" + folder + "'");

      CheckFolder(folder);

      Console.WriteLine("Finished!");
    }

    static private void CheckFolder(string folderPath)
    {
      var files = Directory.EnumerateFiles(folderPath);
      foreach (var file in files)
      {
        // If it's a js file but not a minified version
        if (file.EndsWith(".js") && !file.EndsWith(".min.js"))
        {
          // If there is a minified version of the file then delete the 
          // non-minified version
          if (File.Exists(file.Replace(".js", ".min.js")))
          {
            File.Delete(file);
            Console.WriteLine("Deleted: '" + file + "'");
          }
        }
      }

      // Check subfolders
      var folders = Directory.EnumerateDirectories(folderPath);
      foreach (var folder in folders)
      {
        CheckFolder(folder);
      }
    }
  }
}
