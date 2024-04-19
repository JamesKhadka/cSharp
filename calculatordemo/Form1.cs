using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatordemo
{
    public partial class Form1 : Form
    {
        double enterFirstValue , enterSecondValue ;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enternumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if(output.Text == "0")
                output.Text = " ";
            {
                if(num.Text == " . ")
                {
                    if(!output.Text.Contains(" "))
                    output.Text = output.Text + num.Text;

                    
                }
                else
                {
                    output.Text = output.Text + num.Text;
                }
            }
        }

        private void click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void opps(object sender, EventArgs e)
        {
            Button num = ( Button)sender;
            enterFirstValue = Convert.ToDouble(output.Text);
            op = num.Text;
            output.Text = " ";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(output.Text);
            switch (op)
            {
                case "+":
                    output.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    output.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "*":
                    output.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "/":
                    output.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;


                case "%":
                    output.Text = ((enterFirstValue / enterSecondValue)*100).ToString();
                    break;


                default:
                    break;
            }
        }

        private void clear(object sender, EventArgs e)
        {
            output.Text = "0";
            string f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue); 
            f = "";
            s = "";
        }
    }
}
