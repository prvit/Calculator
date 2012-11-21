using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        private decimal currentNumber;
        private decimal memoryNumber;

        private bool add = false;
        private bool sub = false;
        private bool div = false;
        private bool mul = false;
        private bool result = false;
        public Calc()
        {
            InitializeComponent();
            currentNumber = 0;
            memoryNumber = 0;
        }

        private void InsertButton(string s)
        {
            if (result)
            {
                clearDisplay();
                this.tbDisplay.Text += s;
                result = false;
            }
            else
                this.tbDisplay.Text += s;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (this.tbDisplay.Text != "0")
                InsertButton("0");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            InsertButton("1");

        }

        private void b2_Click(object sender, EventArgs e)
        {
            InsertButton("2");

        }

        private void b3_Click(object sender, EventArgs e)
        {
            InsertButton("3");

        }

        private void b4_Click(object sender, EventArgs e)
        {
            InsertButton("4");

        }

        private void b5_Click(object sender, EventArgs e)
        {
            InsertButton("5");

        }

        private void b6_Click(object sender, EventArgs e)
        {
            InsertButton("6");

        }

        private void b7_Click(object sender, EventArgs e)
        {
            InsertButton("7");

        }

        private void b8_Click(object sender, EventArgs e)
        {
            InsertButton("8");

        }

        private void b9_Click(object sender, EventArgs e)
        {
            InsertButton("9");
        }

        private void saveCurrentNumber()
        {
            if (this.tbDisplay.Text == "")
                currentNumber = 0;
            else
                currentNumber = Convert.ToDecimal(this.tbDisplay.Text);
            this.tbDisplay.Text = "";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!(add || sub || div || mul))    
                saveCurrentNumber();
            this.add = true;
            this.sub = false;
            this.div = false;
            this.mul = false;
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            if (!(add || sub || div || mul))
                saveCurrentNumber();
            this.add = false;
            this.sub = true;
            this.div = false;
            this.mul = false;
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            if (this.add)
		        this.tbDisplay.Text = (currentNumber + Convert.ToDecimal(this.tbDisplay.Text)).ToString();
            else if (sub)
		        this.tbDisplay.Text = (currentNumber - Convert.ToDecimal(this.tbDisplay.Text)).ToString();
            else if (mul)
		        this.tbDisplay.Text = (currentNumber * Convert.ToDecimal(this.tbDisplay.Text)).ToString();
            else if (div)
                if (Convert.ToDecimal(this.tbDisplay.Text) != 0)
	            {
	    	        this.tbDisplay.Text = (currentNumber / Convert.ToDecimal(this.tbDisplay.Text)).ToString();
		        }
                else
                    MessageBox.Show("Can't divide by zero !");
            add = false;
            sub = false;
            div = false;
            mul = false;
            result = true;
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if (this.tbDisplay.Text == "")
            {
                InsertButton("0,");
            }
            if(!this.tbDisplay.Text.Contains(","))
                InsertButton(",");
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if(!(add || sub || div || mul))
                saveCurrentNumber();
            add = false;
            sub = false;
            div = true;
            mul = false;
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            if (!(add || sub || div || mul))
                saveCurrentNumber();
            add = false;
            sub = false;
            div = false;
            mul = true;
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            clearDisplay();
            this.currentNumber = 0;
        }
        private void clearDisplay()
        {
            this.tbDisplay.Text = "";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            clearDisplay();
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            if(this.tbDisplay.Text != "")
                this.tbDisplay.Text = this.tbDisplay.Text.Remove(this.tbDisplay.Text.Length - 1);
        }

        private void bMR_Click(object sender, EventArgs e)
        {
            if (this.tbDisplay.Text != "")
                memoryNumber = Convert.ToDecimal(this.tbDisplay.Text);
        }

        private void bMp_Click(object sender, EventArgs e)
        {
            this.tbDisplay.Text = memoryNumber.ToString();
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal s = Convert.ToDecimal(tbDisplay.Text);
            }
            catch (System.FormatException)
            {
                //MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
            this.Text = this.tbDisplay.Text;
        }
        private void tbDisplay_KeyPress(object sender, KeyPressEventArgs  e)
        {
            if (Char.IsNumber(e.KeyChar))
                return;
            else e.Handled = true;
        }
        /*private void Calc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
                InsertButton("0");
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                InsertButton("1");
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                InsertButton("2");
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                InsertButton("3");
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                InsertButton("4");
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                InsertButton("5");
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                InsertButton("6");
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                InsertButton("7");
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                InsertButton("8");
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                InsertButton("9");
            else if (e.KeyCode == Keys.Back)
                if (this.tbDisplay.Text != "")
                    this.tbDisplay.Text = this.tbDisplay.Text.Remove(this.tbDisplay.Text.Length - 1);
                else ;
            else if (e.KeyCode == Keys.Divide)
            {
                if (!(add || sub || div || mul))
                    saveCurrentNumber();
                add = false;
                sub = false;
                div = true;
                mul = false;
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                if (!(add || sub || div || mul))
                    saveCurrentNumber();
                add = false;
                sub = false;
                div = false;
                mul = true;
            }
        }*/
        

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
}
