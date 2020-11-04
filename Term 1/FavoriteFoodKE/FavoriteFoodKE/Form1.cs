/*
Karter Ence
Favorite Food
10/28/2020
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

namespace FavoriteFoodKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            //See which radio button is checked
            if (radioChinese.Checked)
            {
                MessageBox.Show("General Tso's Chicken is tasty!");
                //Deselect the radio button
                radioChinese.Checked = false;
            }
            else if (radioMexican.Checked)
            {
                MessageBox.Show("I love burritos!");
                radioMexican.Checked = false;
            }
            else if (radioIndian.Checked)
            {
                MessageBox.Show("Try Chicken Tikka Masala!");
                radioIndian.Checked = false;
            }
            else
            {
                MessageBox.Show("Make a selection!");
            }
        }
    }
}
