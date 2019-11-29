using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricChartCalculations
{
    public partial class Form1 : Form
    {
        // These are the input variables needed throughout the entire program
        int[] choices = new int[2];
        double[] inputValues = new double[2];
        double ambPressureInput = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clears Variable #1 groupbox
            radioButtonDryBulbTemp1.Checked = false;
            radioButtonWetBulbTemp1.Checked = false;
            radioButtonSpecHumidity1.Checked = false;
            radioButtonRelHumidity1.Checked = false;
            textBoxFirstVar.Text = null;

            // Clears Variable #2 groupbox
            radioButtonDryBulbTemp2.Checked = false;
            radioButtonWetBulbTemp2.Checked = false;
            radioButtonSpecHumidity2.Checked = false;
            radioButtonRelHumidity2.Checked = false;
            textBoxSecondVar.Text = null;

            // Clears Ambient Pressure input
            textBoxAmbPressure.Text = null;

            // Clears Results groupbox
            textBoxDryBulbTempResult.Text = null;
            textBoxWetBulbTempResult.Text = null;
            textBoxSpecHumidityResult.Text = null;
            textBoxRelHumidityResult.Text = null;
            textBoxEnthalpyResult.Text = null;
            textBoxSpecVolumeResult.Text = null;
            textBoxAmbPressureResult.Text = null;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            GetUserChoices();
            GetUserInputValues();
            CalcAndPrintResults();
        }

        private void GetUserInputValues()
        {
            // Tries to store the values the user inputs
            try
            {
                inputValues[0] = double.Parse(textBoxFirstVar.Text);
                inputValues[1] = double.Parse(textBoxSecondVar.Text);
                ambPressureInput = double.Parse(textBoxAmbPressure.Text);
            }

            // Catches exception when any textbox is left blank or there is a non numeric input
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }
           
        private void GetUserChoices()
        {
            try
            {
                // Checks which radio button is checked in the Variable #1 groupbox and 
                //  sets choices[0] according to which one is checked
                if (radioButtonDryBulbTemp1.Checked == true)
                {
                    choices[0] = 1;
                }

                else if (radioButtonWetBulbTemp1.Checked == true)
                {
                    choices[0] = 2;
                }

                else if (radioButtonSpecHumidity1.Checked == true)
                {
                    choices[0] = 3;
                }

                else if (radioButtonRelHumidity1.Checked == true)
                {
                    choices[0] = 4;
                }

                else
                {
                    throw new Exception("Please select what each variable represents");
                }

                // Checks which radio button is checked in the Variable #2 groupbox and 
                //  sets choices[0] according to which one is checked
                if (radioButtonDryBulbTemp2.Checked == true)
                {
                    choices[1] = 1;
                }

                else if (radioButtonWetBulbTemp2.Checked == true)
                {
                    choices[1] = 2;
                }

                else if (radioButtonSpecHumidity2.Checked == true)
                {
                    choices[1] = 3;
                }

                else if (radioButtonRelHumidity2.Checked == true)
                {
                    choices[1] = 4;
                }

                else
                {
                    throw new Exception("Please select what each variable represents");
                }

                // Throws exception when 
                if (choices[0] == choices[1])
                {
                    throw new Exception("Please select two different types of variables to input");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcAndPrintResults()
        {
            double dryTemp = 0;
            double wetTemp = 0;
            double specificHumidity = 0;
            double relativeHumidity = 0;
            double enthalpy = 0;
            double specificVolume = 0;

            // If the user inputs Dry Temperature and Wet Temperature
            if ((choices[0] == 1 && choices[1] == 2) || (choices[0] == 2 && choices[1] == 1))
            {
                // Switch statement to set variables as neede with user input
                switch (choices[0])
                {
                    case 1:
                        dryTemp = inputValues[0];
                        wetTemp = inputValues[1];
                        break;
                    case 2:
                        dryTemp = inputValues[1];
                        wetTemp = inputValues[0];
                        break;
                }

                // Insert Calculations for everything here when you have Dry and Wet temperatures
                //  Need to set the rest of the variables equal to their calculations
            }

            // Else if the user inputs Dry Temperature and Specific Humidity
            else if ((choices[0] == 1 && choices[1] == 3) || (choices[0] == 3 && choices[1] == 1))
            {
                // Switch statement to set variables as neede with user input
                switch (choices[0])
                {
                    case 1:
                        dryTemp = inputValues[0];
                        specificHumidity = inputValues[1];
                        break;
                    case 3:
                        dryTemp = inputValues[1];
                        specificHumidity = inputValues[0];
                        break;
                }
                // Insert Calculations for everything here when you have Dry Temp and Specific Humidity
                //  Need to set the rest of the variables equal to their calculations
            }

            // Else if the user inputs Dry Temperature and Relative Humidity
            else if ((choices[0] == 1 && choices[1] == 4) || (choices[0] == 4 && choices[1] == 1))
            {
                // Switch statement to set variables as neede with user input
                switch (choices[0])
                {
                    case 1:
                        dryTemp = inputValues[0];
                        relativeHumidity = inputValues[1];
                        break;
                    case 4:
                        dryTemp = inputValues[1];
                        relativeHumidity = inputValues[0];
                        break;
                }
                // Insert Calculations for everything here when you have Dry Temp and Relative Humidity
                //  Need to set the rest of the variables equal to their calculations
            }

            // Else if the user inputs Wet Temperature and Specific Humidity
            else if((choices[0] == 2 && choices[1] == 3) || (choices[0] == 3 && choices[1] == 2))
            {
                // Switch statement to set variables as neede with user input
                switch (choices[0])
                {
                    case 2:
                        wetTemp = inputValues[0];
                        specificHumidity = inputValues[1];
                        break;
                    case 3:
                        wetTemp = inputValues[1];
                        specificHumidity = inputValues[0];
                        break;
                }
                // Insert Calculations for everything here when you have Wet Temp and Specific Humidity
                //  Need to set the rest of the variables equal to their calculations
            }

            // Else if the user inputs Wet Temperature and Specifc Humidity
            else if((choices[0] == 2 && choices[1] == 4) || (choices[0] == 4 && choices[1] == 2))
            {
                // Switch statement to set variables as neede with user input
                switch (choices[0])
                {
                    case 2:
                        wetTemp = inputValues[0];
                        relativeHumidity = inputValues[1];
                        break;
                    case 4:
                        wetTemp = inputValues[1];
                        relativeHumidity = inputValues[0];
                        break;
                }
                // Insert Calculations for everything here when you have Wet Temp and Relative Humidity
                //  Need to set the rest of the variables equal to their calculations
            }

            // Else if the user inputs Specific Humidity and Relative Humidity
            else if ((choices[0] == 3 && choices[1] == 4) || (choices[0] == 4 && choices[1] == 3))
            {
                // Switch statement to set variables as neede with user input
                switch (choices[0])
                {
                    case 3:
                        specificHumidity = inputValues[0];
                        relativeHumidity = inputValues[1];
                        break;
                    case 4:
                        specificHumidity = inputValues[1];
                        relativeHumidity = inputValues[0];
                        break;
                }
                // Insert Calculations for everything here when you have Specific Humidity and Relative Humidity
                //  Need to set the rest of the variables equal to their calculations
            }

            // Outputs results of all variables to user
            textBoxDryBulbTempResult.Text = dryTemp.ToString();
            textBoxWetBulbTempResult.Text = wetTemp.ToString();
            textBoxSpecHumidityResult.Text = specificHumidity.ToString();
            textBoxRelHumidityResult.Text = relativeHumidity.ToString();
            textBoxEnthalpyResult.Text = enthalpy.ToString();
            textBoxSpecVolumeResult.Text = specificVolume.ToString();
            textBoxAmbPressureResult.Text = ambPressureInput.ToString();

        }
    }
}
