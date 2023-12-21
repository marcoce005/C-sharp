using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rubrica.Griglia;

namespace Rubrica.FileWatcherRubrica
{
    public class FIleWatcher
    {
        public void CreateFileWatcher(string path, DataGridView dg)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "rubrica.xml";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler((sender, e) => OnChanged(sender, e, dg));
            watcher.Created += new FileSystemEventHandler((sender, e) => OnChanged(sender, e, dg));
            watcher.Deleted += new FileSystemEventHandler((sender, e) => OnChanged(sender, e, dg));
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e, DataGridView dg)
        {
            var griglia = new Griglia.Griglia();
            griglia.CreateGrid(dg);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}