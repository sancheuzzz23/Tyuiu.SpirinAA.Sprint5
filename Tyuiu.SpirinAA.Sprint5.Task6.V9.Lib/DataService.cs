using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SpirinAA.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            string r = File.ReadAllText(path).Replace(',', ' ');
            string[] str = r.Split(' ');
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == 3)
                    res++;
            }
            return res;
        }
    }
}
