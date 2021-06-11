using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Calculator
{
    public partial class frmCalculator : Form
    {
        private const Operation noneSelected = Operation.NoneSelected;
        #region Private Members
        private double? output;
        private double? operand1;
        private double? operand2;
        private bool _decimalOn = false;
        private bool MinusOn = false;
        private Operation currentOperation = noneSelected;
        private string operationChar = "";

        #endregion
        #region Public Members
        public enum Operation
        {
            NoneSelected = 0,
            SquareRoot = 1,
            Square = 2,
            Power = 3,
            Reciprocal = 4,

            Division = 5,
            Multiplication = 6,
            Subtraction = 7,
            Addition = 8
        }
        #endregion
        #region Form-related methods and events
        public frmCalculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(frmCalculator_KeyPress);
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            //var frm = frmCalculator.ActiveForm.AcceptButton.DialogResult;

            lblInstructions.Text += "New text.";

            var pow = Math.Pow(3, 4);
            var sqrt = Math.Sqrt(3);
            var result = 4;
            txtInputOutput.Text = result.ToString();
            //var b = btnSquareRoot;
            //var dt = Tester(6,7);
            //double dt2 = 7.454545;
            //bool truer = true;
            //int what = 5;
            //float sdafdf = 5.456f;
            //decimal dsaf = 4.36m;
            MessageBox.Show("The min value of integer is:" + int.MinValue +
                            "and the max value of integer is: " + int.MaxValue);

            var num = 9.95m;
            string s = "text";
            int i = 6 + 7;
            //MessageBox.Show(s ?? "The string was null.");
            MessageBox.Show(s == string.Empty ? "The string was empty." : "The string was not empty.");
            //s?.
        }

        int Tester(int tst, int tst2)
        {
            return 6;
        }

        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)//0x30
            {
                MessageBox.Show("Form.KeyPress: '" +
                                e.KeyChar.ToString() + "' pressed.");

                switch (e.KeyChar)//(int)e.KeyChar)
                {
                    case '0':
                        btnZero_Click(sender, e);
                        break;
                    case '1':
                        btnOne_Click(sender, e);
                        break;
                    case '2':
                        btnTwo_Click(sender, e);
                        break;
                    case '3':
                        btnThree_Click(sender, e);
                        break;
                    case '4':
                        btnFour_Click(sender, e);
                        break;
                    case '5':
                        btnFive_Click(sender, e);
                        break;
                    case '6':
                        btnSix_Click(sender, e);
                        break;
                    case '7':
                        btnSeven_Click(sender, e);
                        break;
                    case '8':
                        btnEight_Click(sender, e);
                        break;
                    case '9':
                        btnNine_Click(sender, e);
                        break;
                    default:
                        MessageBox.Show("Form.KeyPress: '" +
                                        e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }
            }
        }
        void frmCalculator_KeyUp(object sender, KeyPressEventArgs e)
        {
        }

        void frmCalculator_KeyDown(object sender, KeyPressEventArgs e)
        {
        }

        #endregion
        #region Input/Output Textbox Events
        private void txtInputOutput_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region Power-based Button Events
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (operand1 == null) return; //need a first operand to continue

            var btn = (Button)sender;
            double num = 0;

            Math.Sqrt(5);

            if (Double.TryParse(btn.Text, out num))

                txtInputOutput.Text = output.ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
         
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (operand1 == null)
            {
                txtInputOutput.Text = "Enter a number first";
                return;
            }
           currentOperation = Operation.Power;

        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (operand1 == null) return; //need an operand to continue
            if (operand1 == 0) txtInputOutput.Text = "Cannot Divide By Zero.";
           // currentOperation = Operation.Reciprocal;

            var btn = (Button)sender;
            double num = 0;

            if (Double.TryParse(txtInputOutput.Text, out num))
            {
                if (num < 0)
                {
                    return; //cannot take square root of negative numbers
                }
                else
                {

                }
            }

        }
        #endregion
        #region Clear Text Button Events
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            currentOperation = noneSelected;
            MinusOn = false;
            //decimalOn = false;
            txtInputOutput.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(operand1 == null)
            {
                return;
            } 
            if(currentOperation == noneSelected)
            {
                operand1 = null;
                txtInputOutput.Text = "";
                return;
            }
            if(operand2 == null)
            {
                
                currentOperation = noneSelected;
                txtInputOutput.Text = operand1.ToString();
                return;
            }
            
            if (currentOperation == Operation.Addition)
            {
                operationChar = " + ";
            }
            if (currentOperation == Operation.Subtraction)
            {
                operationChar = " - ";
            }
            if (currentOperation == Operation.Division)
            {
                operationChar = " / ";
            }
            if (currentOperation == Operation.Multiplication)
            {
                operationChar = " x ";
            }
            operand2 = null;
            txtInputOutput.Text = operand1 + operationChar;
            return;
            
        }
        #endregion
        #region Number Button Events
        private void btnNine_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 9;
                    txtInputOutput.Text = "9";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 9;
                    txtInputOutput.Text += "9";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -9;
                    txtInputOutput.Text = "-9";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -9;
                    txtInputOutput.Text += "-9";
                }
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 8;
                    txtInputOutput.Text = "8";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 8;
                    txtInputOutput.Text += "8";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -8;
                    txtInputOutput.Text = "-8";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -8;
                    txtInputOutput.Text += "-8";
                }
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 7;
                    txtInputOutput.Text = "7";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 7;
                    txtInputOutput.Text += "7";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -7;
                    txtInputOutput.Text = "-7";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -7;
                    txtInputOutput.Text += "-7";
                }
            }

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 6;
                    txtInputOutput.Text = "6";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 6;
                    txtInputOutput.Text += "6";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -6;
                    txtInputOutput.Text = "-6";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -6;
                    txtInputOutput.Text += "-6";
                }
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 5;
                    txtInputOutput.Text = "5";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 5;
                    txtInputOutput.Text += "5";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -5;
                    txtInputOutput.Text = "-5";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -5;
                    txtInputOutput.Text += "-5";
                }
            }

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 4;
                    txtInputOutput.Text = "4";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 4;
                    txtInputOutput.Text += "4";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -4;
                    txtInputOutput.Text = "-4";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -4;
                    txtInputOutput.Text += "-4";
                }
            }

        }
        
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 3;
                    txtInputOutput.Text = "3";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 3;
                    txtInputOutput.Text += "3";
                }
            }
            else
            {
                if (operand1 == null)
                {
                    operand1 = -3;
                    txtInputOutput.Text = "-3";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -3;
                    txtInputOutput.Text += "-3";
                }
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        { if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 2;
                    txtInputOutput.Text = "2";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 2;
                    txtInputOutput.Text += "2";
                }
            } else
            {
                if (operand1 == null)
                {
                    operand1 = -2;
                    txtInputOutput.Text = "-2";
                    return;
                }
                if (operand2 == null)
                {
                    operand2 = -2;
                    txtInputOutput.Text += "-2";
                }
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        { if (!MinusOn)
            {
                if (operand1 == null)
                {
                    operand1 = 1;
                    txtInputOutput.Text = "1";

                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 1;
                    txtInputOutput.Text += "1";
                }
            } else
            {
                if (operand1 == null)
                {
                    operand1 = -1;
                    txtInputOutput.Text = "-1";

                    return;
                }
                if (operand2 == null)
                {
                    operand2 = 1;
                    txtInputOutput.Text += "-1";
                }
            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (operand1 == null)
            {
                operand1 = 0;
                txtInputOutput.Text = "0";
                return;
            }
            if (operand2 == null)
            {
                operand2 = 0;
                txtInputOutput.Text += "0";
            }


        }
        #endregion
        #region Arithmetic Button Events
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (operand1 == null)
            {
                
                txtInputOutput.Text = "Enter number first nerd!";
                return;
            }
            else
            {
                currentOperation = Operation.Division;
                txtInputOutput.Text += " / ";
            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (operand1 == null)
            {
               
                txtInputOutput.Text = "Enter number first nerd!";
                return;
            }
            else
            {
                currentOperation = Operation.Multiplication;
                txtInputOutput.Text += " x ";
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (operand1 == null)
            {
               
                txtInputOutput.Text = "Enter number first nerd!";
                return;
            }
            else
            {
                currentOperation = Operation.Subtraction;
                txtInputOutput.Text += " - ";
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (operand1 == null)
            {
                
                txtInputOutput.Text = "Enter number first nerd!";
                return;
            } else
            {
                currentOperation = Operation.Addition;
                txtInputOutput.Text += " + ";
            }
        }

        private void btnEquality_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
           if(MinusOn)
            {
                MinusOn = false;
                if(operand1 == null)
                {
                    txtInputOutput.Text = "";
                } if(currentOperation == noneSelected)
                {
                    txtInputOutput.Text = operand1.ToString();
                }
                if(operand2 == null)
                {
                    if (currentOperation == Operation.Addition)
                    {
                        operationChar = " + ";
                    }
                    if (currentOperation == Operation.Subtraction)
                    {
                        operationChar = " - ";
                    }
                    if (currentOperation == Operation.Division)
                    {
                        operationChar = " / ";
                    }
                    if (currentOperation == Operation.Multiplication)
                    {
                        operationChar = " x ";
                    }
                    txtInputOutput.Text = operand1.ToString() + operationChar;
                }
                return;
            }

            MinusOn = true;
            txtInputOutput.Text = "-" + txtInputOutput.Text;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (operand1 != null && operand2 != null)
            {
            
                if (currentOperation == Operation.Addition)
                {
                    output = operand1 + operand2;
                    txtInputOutput.Text = output.ToString();
                }
                if (currentOperation == Operation.Subtraction)
                {
                    output = operand1 - operand2;
                    txtInputOutput.Text = output.ToString();
                }
                if (currentOperation == Operation.Division)
                {
                    output = operand1 / operand2;
                    txtInputOutput.Text = output.ToString();
                }
                if (currentOperation == Operation.Multiplication)
                {
                    output = operand1 * operand2;
                    txtInputOutput.Text = output.ToString();
                }
                operand1 = output;
                operand2 = null;
                currentOperation = noneSelected;
            } else
            {
                txtHistory.Text = "Enter another number.";
            }
        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
