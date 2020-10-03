/*
Karter Ence
10/2/2020
Experiment with Data Types
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTypesFormKE
{
    public partial class DataTypesForm : Form
    {
        public DataTypesForm()
        {
            InitializeComponent();
        }

        private void NumericButton_Click(object sender, EventArgs e)
        {   
            //Initialize variables
            int theInteger = 57;
            double theDouble = 4278.3456;
            decimal theDecimal = 2;
            float theFloat = 6.789f;

            //Show message boxes
            MessageBox.Show("theInteger: " + theInteger.ToString());
            MessageBox.Show("theDouble: " + theDouble.ToString());
            MessageBox.Show("theDecimal: " + theDecimal.ToString());
            MessageBox.Show("theFloat: " + theFloat.ToString());
        }

        private void BoolButton_Click(object sender, EventArgs e)
        {
            bool theBoolean = false;

            MessageBox.Show("theBoolean: " + theBoolean.ToString());
        }

        private void ConstantButton_Click(object sender, EventArgs e)
        {
            //Constants cannot be changed
            const double PI = 3.1415926535897932384626;
            const int THE_CONSTANT_INTEGER = 68;

            MessageBox.Show("PI: " + PI.ToString());
            MessageBox.Show("THE_CONSTANT_INTEGER: " + THE_CONSTANT_INTEGER.ToString());
        }

        private void StringButton_Click(object sender, EventArgs e)
        {
            char theChar = 'k';
            String theString = "hola muchacho";

            MessageBox.Show("theChar: " + theChar);
            MessageBox.Show("theString: " + theString);
        }
    }
}
