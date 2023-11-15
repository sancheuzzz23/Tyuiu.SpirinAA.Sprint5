using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using Tyuiu.SpirinAA.Sprint5.Task0.V7.Lib;

namespace Tyuiu.SpirinAA.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Sascha\source\repos\Tyuiu.SpirinAA.Sprint5\Tyuiu.SpirinAA.Sprint5.Task0.V7\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
