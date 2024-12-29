namespace _8._10
{
    public partial class Form1 : Form
    {
        string a = "", b = "", opertr = "=", str = "";
        bool clear = false;
        public Form1()
        {
            InitializeComponent();
            Text = "Калькулятор";
            textBox1.Text = "0";
            MaximizeBox = false;
            Icon = new Icon("E:/C#/Vasilyev/Vasil'evDZ_2/8.10/Icon/Windows_Calculator_icon.ico");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (a != "")
                {
                    b = textBox1.Text;
                    str += b;
                    str = textBox1.Text = result();
                    a = b = "";
                }
                a = textBox1.Text;
                opertr = "+";
                str += a + opertr;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
            }


        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (a != "")
                {
                    b = textBox1.Text;
                    str += b;
                    str = textBox1.Text = result();
                    a = b = "";
                }
                a = textBox1.Text;
                opertr = "-";
                str += a + opertr;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
            }


        }
        private void buttonTimes_Click(object sender, EventArgs e)
        {
            try
            {
                if (a != "")
                {
                    b = textBox1.Text;
                    str += b;
                    str = textBox1.Text = result();
                    a = b = "";
                }
                a = textBox1.Text;
                opertr = "X";
                str += a + opertr;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
            }



        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (a != "")
                {
                    b = textBox1.Text;
                    str += b;
                    str = textBox1.Text = result();
                    a = b = "";
                }
                a = textBox1.Text;
                opertr = "/";
                str += a + opertr;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
            }


        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            try
            {
                a = textBox1.Text;
                opertr = "pow";
                str = textBox1.Text = result();
            }
            catch (Exception ex)
            {
                //textBox1.Text = ex.Message;
            }
        }
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                a = textBox1.Text;
                opertr = "sqrt";
                str = textBox1.Text = result();
            }
            catch (Exception ex)
            {
                //textBox1.Text = ex.Message;
            }
        }
        private void buttonDivX_Click(object sender, EventArgs e)
        {
            try
            {
                a = textBox1.Text;
                if (a == "0")
                    throw new DivideByZeroException("Деление на ноль невозможно");
                opertr = "divX";
                str = textBox1.Text = result();
            }
            catch (DivideByZeroException ex)
            {
                textBox1.Text = ex.Message;
                BlockButtons(false);
            }

            catch (Exception ex)
            {
                //textBox1.Text = ex.Message;
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Contains(','))
                    return;
                if (textBox1.Text[textBox1.Text.Length - 1] != ',')
                    textBox1.Text += ",";

            }
            catch { textBox1.Text = "0"; }
        }
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0")
                    return;
                if (opertr != "=")
                {
                    textBox1.Text = (-double.Parse(a)).ToString();
                    return;
                }

                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Substring(1);
                else
                    textBox1.Text = '-' + textBox1.Text;
            }
            catch { }
        }
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            //доделать повторное нажатие
            try
            {
                if (opertr != "=")
                {
                    double intgr = double.Parse(textBox1.Text);

                    textBox1.Text = (double.Parse(a) * intgr / 100).ToString();
                }
            }
            catch { }
        }




        private void buttonEquals_Click(object sender, EventArgs e)
        {

            try
            {
                str += textBox1.Text;
                b = textBox1.Text;
                str = textBox1.Text = result();
                a = b = "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                textBox1.Text = "0";
            }
            str = "";
            opertr = "=";
            //clear = true;

        }

        string result()
        {
            double res = 0;
            switch (opertr)
            {
                case "+":
                    res = double.Parse(a) + double.Parse(b);
                    break;
                case "-":
                    res = double.Parse(a) - double.Parse(b);
                    break;
                case "X":
                    res = double.Parse(a) * double.Parse(b);
                    break;
                case "/":
                    res = double.Parse(a) / double.Parse(b);
                    break;
                case "pow":
                    res = double.Parse(a) * double.Parse(a);
                    break;
                case "sqrt":
                    res = Math.Sqrt(double.Parse(a));
                    break;
                case "divX":
                    res = 1 / double.Parse(a);
                    break;


                case "=":
                    res = double.Parse(textBox1.Text);
                    break;
            }
            return res.ToString();
        }


        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 2;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 3;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 4;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 5;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 7;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += 8;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 & textBox1.Text == "0" | a != "")
                textBox1.Text = "";
            textBox1.Text += 9;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            a = b = str = "";
            textBox1.Text = "0";
            opertr = "=";
            BlockButtons(true);
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            BlockButtons(true);
        }
        private void ButtonX_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 1)
                    throw new Exception();
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch
            {
                textBox1.Text = "0";
            }
            BlockButtons(true);

        }

        private void BlockButtons(bool block)
        {
            buttonPercent.Enabled = block;
            buttonDivX.Enabled = block;
            buttonPow.Enabled = block;
            buttonSqrt.Enabled = block;
            buttonDiv.Enabled = block;
            buttonTimes.Enabled = block;
            buttonMinus.Enabled = block;
            buttonPlus.Enabled = block;
            buttonNegate.Enabled = block;
            buttonComma.Enabled = block;
            buttonEquals.Enabled = block;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {/*
            if (clear)
            {
                textBox1.Text = textBox1.Text.Substring((textBox1.Text.Length - 1));
                clear = false;
            }*/
        }

    }
}
