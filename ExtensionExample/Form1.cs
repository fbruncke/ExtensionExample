using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int testInt = 128;
            
            MessageBox.Show("128 in Hex is: " + testInt.ConvertToHex(10) );

            //FileStream fs = new FileStream("file.txt", FileMode.Create);
            //fs.WriteByte(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Point p = new Point
            {
                X = 20,
                Y = 30
            };

            MessageBox.Show("point x is:" + p.GetPointX());
            p.ThisIsCool();


            ArrayList al = new ArrayList();

            MessageBox.Show(al.ThisIsCool());

            
            

            List<Object> list = new List<Object>();

            
           
        }





        /// <summary>
        /// Exercise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    even.Add(item);
                }
                else
                {
                    odd.Add(item);
                }
            }
            MessageBox.Show("sum of even: " + even.Sum());
            MessageBox.Show("sum of odd: " + odd.Sum());

        }

        /// <summary>
        /// LINQ version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultEven = array.Where(m => m % 2 == 0).OrderBy(m => m).ToList().Sum();
            var resultOdd = array.Where(m => m % 2 == 1).OrderBy(m => m).ToList().Sum();

            MessageBox.Show($"Sum for even is: {resultEven}");
            MessageBox.Show($"Sum for even is: {resultOdd}");
        }
    }
}
