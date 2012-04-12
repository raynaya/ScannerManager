using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class FileHelper
{
    List<string> Folder;
    List<string> Files;
    public void GetFileRecursive(string b)
    {
        // 1.
        // Store results in the file results list.
        Files = new List<string>();
        Folder = new List<string>();

        // 2.
        // Store a stack of our directories.
        Stack<string> stack = new Stack<string>();

        // 3.
        // Add initial directory.
        stack.Push(b);
        //Folder.Add(b);
        // 4.
        // Continue while there are directories to process
        while (stack.Count > 0)
        {
            // A.
            // Get top directory
            string dir = stack.Pop();
            Folder.Add(dir);
            try
            {
                // B
                // Add all files at this directory to the result List.
                Files.AddRange(Directory.GetFiles(dir, "*.*"));

                // C
                // Add all directories at this directory.
                foreach (string dn in Directory.GetDirectories(dir))
                {
                    stack.Push(dn);
                }
            }
            catch
            {
                // D
                // Could not open the directory
            }
        }


        //return Folder;
    }
    public List<string> getFolder()
    {
        return Folder;
    }
    public List<string> getFiles()
    {
        return Files;
    }
}

