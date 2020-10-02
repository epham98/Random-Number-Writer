using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            //declare int var
            int randNum = 0;

            //declare streamwriter var
            StreamWriter outFile;
            outFile = File.CreateText("numbers.txt");

            //get number of integers to hold in file
            int numInts = int.Parse(numberTextBox.Text);

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //create file
                //outFile = File.CreateText(saveFile.FileName);

                //create random obj
                Random rand = new Random();

                for (int i = 0; i < numInts; i++)
                {
                    //generate random numbers and assign to randNum var
                    randNum = rand.Next(1, 101);

                    //write to file
                    outFile.WriteLine(randNum);

                    //add number to listbox
                    randNumListBox.Items.Add(randNum);
                }
                //close file outside loop
                outFile.Close();
            }
            else
            {
                //error msg
                MessageBox.Show("Operation canceled.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
