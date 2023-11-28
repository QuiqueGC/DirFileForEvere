using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirFileForEver.DataClasses
{
    internal class DirFile
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public long Size { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public bool IsDirectory { get; set; }

        public DirFile() { }

        public DirFile(string name, string fullName)
        {
            Name = name;
            FullName = fullName;
        }




        /// <summary>
        /// Rellena los datos del objeto en caso de ser un directorio
        /// </summary>
        /// <param name="dirInfo">El DirectoryInfo de donde extraeremos los datos</param>
        public void WrittingDirData(DirectoryInfo dirInfo)
        {
            this.Name = dirInfo.Name;
            this.FullName = dirInfo.FullName;
            this.Date = dirInfo.CreationTime;
            this.Type = dirInfo.Extension;
            this.Size = takingSizeOfDir(dirInfo);
            this.IsDirectory = true;
        }


        /// <summary>
        /// Explora el directorio por dentro para extraer el tamaño conjunto
        /// de todo su contenido
        /// </summary>
        /// <param name="dirInfo"></param>
        /// <returns></returns>
        private long takingSizeOfDir(DirectoryInfo dirInfo)
        {
            long size = 0;

            try
            {
                foreach (FileInfo file in dirInfo.EnumerateFiles())
                {
                    try
                    {
                        size += file.Length;
                    }
                    catch (UnauthorizedAccessException e)
                    {
                           Debug.WriteLine(e);
                    }
                }

                foreach (DirectoryInfo nextDir in dirInfo.EnumerateDirectories("*"))
                {
                    try
                    {
                        foreach (FileInfo file in nextDir.EnumerateFiles("*", SearchOption.AllDirectories))
                        {
                            try
                            {
                                size += file.Length;
                            }
                            catch (UnauthorizedAccessException e)
                            {
                                Debug.WriteLine(e);
                            }
                        }
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        Debug.WriteLine(e);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Debug.WriteLine(e);
            }

            return size;

        }


        /// <summary>
        /// Rellena los datos del objeto en caso de ser un fichero
        /// </summary>
        /// <param name="fileInfo">El FileInfo de donde extraeremos los datos</param>
        public void WrittingFileData(FileInfo fileInfo)
        {
            this.Name = fileInfo.Name;
            this.FullName = fileInfo.FullName;
            this.Date = fileInfo.CreationTime;
            this.Type = fileInfo.Extension;
            this.Size = fileInfo.Length;
            this.IsDirectory = false;
        }

    }
    
}
