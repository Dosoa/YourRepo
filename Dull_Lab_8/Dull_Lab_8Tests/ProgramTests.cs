using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dull_Lab_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dull_Lab_8.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CreategridTest1()
        {
            
        Program.array1 = Program.Creategrid();//set to default
            Boolean test = false;
            try
            {
                if (Program.array1[0][0] == "" || Program.array1[0][1] == "" || Program.array1[0][2] == "" || Program.array1[1][0] == "" || Program.array1[1][1] == "" || Program.array1[1][2] == "" || Program.array1[2][0] == "" || Program.array1[2][1] == "" || Program.array1[2][2] == "")
                {
                    test = true;
                }
                test = true;
            }
            catch
            {
                test = false;
            }
                Assert.IsTrue(test);
        }

        [TestMethod()]
        public void CurrentPlayerTest1()
        {
            Program.player = "x"; //set to default
           
            Assert.AreEqual(Program.CurrentPlayer(),"x");
        }

        [TestMethod()]
        public void ChangePlayerTest1()
        {
            Program.player = "x";//set to default
            Program.ChangePlayer();
                Assert.AreEqual(Program.CurrentPlayer(), "y");
        }

        [TestMethod()]
        public void MakeMoveTestx()
        {
            Program.player = "x";//set to default

            Program.array1 = Program.Creategrid();
            Program.MakeMove(0, 0);
            Assert.AreEqual(Program.array1[0][0], "x");
        }
        [TestMethod()]
        public void MakeMoveTesty()
        {
            Program.player = "x";//set to default
            Program.ChangePlayer();
            Program.array1 = Program.Creategrid();
            Program.MakeMove(0, 0);
            Assert.AreEqual(Program.array1[0][0], "y");

        }

        [TestMethod()]
        public void SpaceInUseTest()
        {
            Program.array1 = Program.Creategrid();//set to default


            Assert.IsTrue(!Program.SpaceInUse(0,0));
        }
    }
}