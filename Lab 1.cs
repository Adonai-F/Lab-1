// Adonai Ford-Williams
// Lab 1
// Date: January 22nd, 2021
// NETD2202
// Description: 
// This program calculates the average of seven user inputted whole numbers.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class formAverageCalculator : Form
    {
        public formAverageCalculator()
        {
            InitializeComponent();
            
        }

        // Global Variables.
        int counter = 0;
        int dayTracker = 2;
        int sum = 0;

        /// <summary>
        /// This closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit application.
            Close();
        }

        /// <summary>
        /// This resets all of the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset Variables.
            counter = 0;
            dayTracker = 2;
            sum = 0;
            
            // Clear all fields.
            textBoxUnits.Clear();
            textBoxStored.Clear();
            labelOutput.Text = "";
            labelDay.Text = "Day 1";

           // Enable input controls.
            textBoxUnits.Enabled = true;
            calculateButton.Enabled = true;
           
            // Highlight units textbox.
            textBoxUnits.Focus();
        }

        /// <summary>
        /// This validates and performs the calculation. Provides an error messsage if not valid. Disables all fields when complete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declarations.          
            int validUnits;
            const int AverageNumber = 7;
            const int MiniumumRange = 0;
            const int MaximumRange = 5000;

            // Validation
            while (counter < 8)
            {
                if (int.TryParse(textBoxUnits.Text, out validUnits) && (validUnits > MiniumumRange & validUnits < MaximumRange))
                { 
                    // Append new numbers to the list.
                    textBoxStored.Text += textBoxUnits.Text + "\r\n";
                    counter++;
                    sum += validUnits;
                    labelDay.Text = "Day " + dayTracker++;

                    if (counter == 7)
                    {
                        // Perform Calculations.
                        double total = (double)sum / (double)AverageNumber;
                        labelOutput.Text = "The Average amount per day is: " + Math.Round (total, 2);
                       
                        // Set labels and buttons.
                        labelDay.Text = "Day 7";
                        calculateButton.Enabled = false;
                        textBoxUnits.Enabled = false;
                        resetButton.Focus();
                        validUnits = 0;
                    }
                   
                    // Clear textbox for another input.
                    textBoxUnits.Clear();
                    break;
                }
                else
                {
                    MessageBox.Show("Please input a whole number between " + MiniumumRange +  " and " + MaximumRange);
                    textBoxUnits.SelectAll();
                    textBoxUnits.Focus();
                    break;
                }
            }
        }
    }
}

