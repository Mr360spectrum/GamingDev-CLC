/*
Karter Ence
Caesar's Cipher
11/29/2020
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

namespace CaesarCipherKE
{
    public partial class CaesarCipher : Form
    {
        public CaesarCipher()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            //Get text from text box
            String decodedString = StringTextBox.Text;
            String encodedString = "";

            for(int i = 0; i < decodedString.Length; i++)
            {
                //Find character at index value
                char thisChar = decodedString[i];
                //Convert character to ASCII value
                int encodedValue = (int)thisChar;
                //Force values to be 3 digits long
                encodedString += encodedValue.ToString("D3") + ",";
            }

            StringTextBox.Text = encodedString;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            String encodedString = StringTextBox.Text;
            String decodedString = "";

            for (int i = 0; i < encodedString.Length; i += 4)
            {
                //Get each set of 3 characters starting at the index of i
                String digits = encodedString.Substring(i, 3);
                int numericValue = int.Parse(digits);
                char decodedValue = (char)numericValue;

                decodedString += decodedValue;
            }

            StringTextBox.Text = decodedString;
            
        }
    }
}
