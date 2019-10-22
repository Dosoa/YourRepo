using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dull_Lab_8
{
   public static  class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            


      //      1. CreateBoard()
      //2. CurrentPlayer()
      //3. ChangePlayer()
      //4. MakeMove()
      //5. SpaceInUse()
        }
        public static string player = "x";
       public static string[][] array1;
        public static string[][] Creategrid()
        {
            string[][] Board1 = new string[3][];
            for (int i = 0; i < Board1.GetLength(0); i++)
            {
                Board1[i] = new string[3];
            }
            return Board1;
        }


        public static string CurrentPlayer()
        {
            return player;
        }
        public static void ChangePlayer()
        {
            if (player == "x")
            {
                player = "y";
            }
            else player = "x";
        }
        public static void MakeMove(int x, int y)
        {
            array1[x][y] = CurrentPlayer();
            ChangePlayer();
        }
        public static Boolean SpaceInUse(int x, int y)
        {
            try
            {
                if (array1[x][y] == "x" || array1[x][y] == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
