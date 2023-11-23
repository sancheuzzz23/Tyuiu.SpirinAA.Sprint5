using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SpirinAA.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V14.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    File.WriteAllText(pathSaveFile, line.Replace('t', 'T').Replace('i', 'I').Replace('g', 'G').Replace('f', 'F').Replace('a', 'A').Replace('e', 'E').Replace('r', 'R').Replace('s', 'S') + Environment.NewLine);
                }
            }
            return pathSaveFile;
        }
    }
}
