using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity9._1
{
    public partial class activity9Frm : Form
    {
        public activity9Frm()
        {
            InitializeComponent();
        }

        private void processAllBtn_Click(object sender, EventArgs e)
        {
           mmtoMeterTxt.Text = millimeterToMeter(1000).ToString();

           fiveNumAveTxt.Text = fiveDoubles(1.0, 2.9, 3.8, 4.7, 5.6).ToString();

           sumTxt.Text = sum(4.2, 4.8).ToString();

           sumRandomTxt.Text = sumRandom().ToString();

           threeIntDiv3Txt.Text = threeIntDiv(3, 6, 9).ToString();

           fewestCharStringTxt.Text = shortestString("Hi", "World");

            //Making the double array to find the longest double
           double[] arr = {100.01, 2.2, 3.3, 4.4, 5.5, 6, 7.7 };
           longestDblTxt.Text = doubleArray(arr).ToString();

           arrayOf50IntTxt.Text = arrayOf50int().ToString();

           boolCheckTxt.Text = checkBool(true, true).ToString();

           productOfIntDoubleTxt.Text = intDblProduct(10, 5.123).ToString();

           //Make the two dimensional array
            int[][] a = new int[2][];
            a[0] = new int[5] { 1, 2, 3, 4, 5 };
            a[1] = new int[2] { 9, 8 };
            twoDimensionalArrayTxt.Text = twoDimensionalArray(a).ToString();


        }

        public int millimeterToMeter(int numMillimeters)
        {
            //Returns the formula, millimeters / 1000
            return numMillimeters / 1000;
        }

        public double fiveDoubles(double a, double b, double c, double d, double e)
        {
            //Adds all possible numbers up and divides them by 5 for the average
            return (a + b + c + d + e) / 5.0;
        }

        public double sum(double a, double b)
        {
            //Adds two integers up for the sum
            return a + b;
        }
        public int sumRandom()
        {
            //Declaring two random numbers
            Random a = new Random();
            Random b = new Random();

            //Declaring two integers and assigning a random number to them
            int c = a.Next();
            int d = b.Next();

            //Returning the sum of the two numbers
            return c + d;
           
        }

        public bool threeIntDiv(int a, int b, int c)
        {
            //Using modulo to determine if the numbers mod 3 are equal to 0
            if(a % 3 == 0 && b % 3 == 0 && c % 3 == 0)
            {
                //Return true if they equal zero
                return true;
            }
            //Return false if they equal anything other than zero
            else { return false;  }
        }

        public string shortestString(string a, string b)
        {
            //Check if 'a' string length is greater than 'b' string length
            if(a.Length > b.Length)
            {
                //Return 'b' if 'a' is greater
                return b;
            } 
            //Otherwise return false
            else { return a; }

        }

        public double doubleArray(double[] a)
        {
            //Sort the array, inspired by a java assignment on chegg
            Array.Sort(a);


            //Returning the Array's element - 1
            return a[a.Length-1];
        }

        public int arrayOf50int()
        {
            int[] a = new int[50];
            Random r = new Random();


            int[] c = new int[50];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i] + ", ");
            }
            return a[49];

        }

       
        public static bool checkBool(bool a, bool b)
        {
            //if value a and b are the same, return true, else return false
            if(a == b)
            {
                return true;
            }
            else { return false;  }
        }

        public double intDblProduct(int a, double b)
        {
            //Return the product of the int and double
            return a * b;
        }

        public int twoDimensionalArray(int[][] a)
        {
            int ave = 0;
            int total = 0;
            //First for loop selects the row
            for (int i = 0; i < a.Length; i++)
            {
                //Second for loop goes through the contents of the array indexes
                for(int j = 0; j < a[i].Length; j++)
                {
                    //The numbers at row i and column j is cycled through and the added value is added to total
                    total += a[i][j];
                    //Ave (average) is incremented by 1 each iteration
                    ave++;
                }
            }
            //return the total numbers 
            return total / ave;
        }
    }
}
