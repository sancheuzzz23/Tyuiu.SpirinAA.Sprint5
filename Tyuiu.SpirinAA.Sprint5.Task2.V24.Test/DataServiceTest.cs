using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SpirinAA.Sprint5.Task2.V24.Lib;

namespace Tyuiu.SpirinAA.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\Sascha\source\repos\Tyuiu.SpirinAA.Sprint5\Tyuiu.SpirinAA.Sprint5.Task2.V24\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
