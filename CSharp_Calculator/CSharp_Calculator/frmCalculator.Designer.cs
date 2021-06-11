namespace CSharp_Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputOutput = new System.Windows.Forms.TextBox();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEquality = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputOutput
            // 
            this.txtInputOutput.Location = new System.Drawing.Point(23, 12);
            this.txtInputOutput.Name = "txtInputOutput";
            this.txtInputOutput.Size = new System.Drawing.Size(186, 20);
            this.txtInputOutput.TabIndex = 0;
            this.txtInputOutput.Text = "0";
            this.txtInputOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInputOutput.TextChanged += new System.EventHandler(this.txtInputOutput_TextChanged);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(23, 36);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(42, 32);
            this.btnSquareRoot.TabIndex = 1;
            this.btnSquareRoot.Text = "Sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(23, 114);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(42, 31);
            this.btnSeven.TabIndex = 3;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(23, 190);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(42, 32);
            this.btnOne.TabIndex = 5;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(23, 150);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(42, 32);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(71, 115);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(42, 31);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(23, 74);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(42, 32);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(71, 36);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(42, 32);
            this.btnSquare.TabIndex = 7;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(71, 226);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(42, 31);
            this.btnZero.TabIndex = 12;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(71, 190);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(42, 32);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(71, 150);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(42, 32);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnEquality
            // 
            this.btnEquality.Location = new System.Drawing.Point(167, 226);
            this.btnEquality.Name = "btnEquality";
            this.btnEquality.Size = new System.Drawing.Size(42, 31);
            this.btnEquality.TabIndex = 24;
            this.btnEquality.Text = "=";
            this.btnEquality.UseVisualStyleBackColor = true;
            this.btnEquality.Click += new System.EventHandler(this.btnEquality_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(167, 190);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(42, 32);
            this.btnAddition.TabIndex = 23;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(167, 150);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(42, 32);
            this.btnSubtraction.TabIndex = 22;
            this.btnSubtraction.Text = "--";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(167, 115);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(42, 31);
            this.btnMultiplication.TabIndex = 21;
            this.btnMultiplication.Text = "X";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(167, 75);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(42, 32);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(167, 36);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(42, 32);
            this.btnReciprocal.TabIndex = 19;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Location = new System.Drawing.Point(119, 226);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(42, 31);
            this.btnDecimalPoint.TabIndex = 18;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btnDecimalPoint_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(119, 190);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(42, 32);
            this.btnThree.TabIndex = 17;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(119, 150);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(42, 32);
            this.btnSix.TabIndex = 16;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(119, 115);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(42, 31);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Del.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(119, 36);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(42, 32);
            this.btnPower.TabIndex = 13;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(23, 264);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(186, 20);
            this.txtHistory.TabIndex = 25;
            this.txtHistory.Text = "No input added.";
            this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 108);
            this.button1.TabIndex = 26;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(23, 291);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(203, 13);
            this.lblInstructions.TabIndex = 28;
            this.lblInstructions.Text = "Use the buttons to operate the calculator.";
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(23, 226);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(42, 31);
            this.btnPlusMinus.TabIndex = 6;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(71, 74);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(42, 32);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "CE";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 317);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnEquality);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.txtInputOutput);
            this.KeyPreview = true;
            this.Name = "frmCalculator";
            this.Text = "C# Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputOutput;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEquality;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button Clear;
    }
}

