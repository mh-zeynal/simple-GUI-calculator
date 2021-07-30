namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberRepresenter = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.radical = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberRepresenter
            // 
            this.numberRepresenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numberRepresenter.ForeColor = System.Drawing.Color.White;
            this.numberRepresenter.Location = new System.Drawing.Point(12, 2);
            this.numberRepresenter.Name = "numberRepresenter";
            this.numberRepresenter.Size = new System.Drawing.Size(433, 123);
            this.numberRepresenter.TabIndex = 2;
            this.numberRepresenter.Text = "0";
            this.numberRepresenter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // one
            // 
            this.one.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("one.BackgroundImage")));
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Location = new System.Drawing.Point(3, 3);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(80, 80);
            this.one.TabIndex = 3;
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.factorial);
            this.panel1.Controls.Add(this.radical);
            this.panel1.Controls.Add(this.pi);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.point);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.changeSign);
            this.panel1.Controls.Add(this.zero);
            this.panel1.Controls.Add(this.nine);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.five);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.one);
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 344);
            this.panel1.TabIndex = 4;
            // 
            // log
            // 
            this.log.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("log.BackgroundImage")));
            this.log.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Location = new System.Drawing.Point(347, 261);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(80, 80);
            this.log.TabIndex = 20;
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // factorial
            // 
            this.factorial.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("factorial.BackgroundImage")));
            this.factorial.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.factorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Location = new System.Drawing.Point(347, 175);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(80, 80);
            this.factorial.TabIndex = 19;
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // radical
            // 
            this.radical.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("radical.BackgroundImage")));
            this.radical.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.radical.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radical.Location = new System.Drawing.Point(347, 89);
            this.radical.Name = "radical";
            this.radical.Size = new System.Drawing.Size(80, 80);
            this.radical.TabIndex = 18;
            this.radical.UseVisualStyleBackColor = true;
            this.radical.Click += new System.EventHandler(this.radical_Click);
            // 
            // pi
            // 
            this.pi.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pi.BackgroundImage")));
            this.pi.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pi.ForeColor = System.Drawing.Color.White;
            this.pi.Location = new System.Drawing.Point(347, 3);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(80, 80);
            this.pi.TabIndex = 17;
            this.pi.Text = "𝜋";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // divide
            // 
            this.divide.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("divide.BackgroundImage")));
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Location = new System.Drawing.Point(261, 175);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 80);
            this.divide.TabIndex = 16;
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equal
            // 
            this.equal.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("equal.BackgroundImage")));
            this.equal.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Location = new System.Drawing.Point(261, 261);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(80, 80);
            this.equal.TabIndex = 14;
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // product
            // 
            this.product.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("product.BackgroundImage")));
            this.product.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product.Location = new System.Drawing.Point(261, 89);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(80, 80);
            this.product.TabIndex = 15;
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // point
            // 
            this.point.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("point.BackgroundImage")));
            this.point.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Location = new System.Drawing.Point(175, 261);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(80, 80);
            this.point.TabIndex = 14;
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // plus
            // 
            this.plus.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("plus.BackgroundImage")));
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Location = new System.Drawing.Point(261, 3);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 80);
            this.plus.TabIndex = 13;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // changeSign
            // 
            this.changeSign.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("changeSign.BackgroundImage")));
            this.changeSign.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.changeSign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.changeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSign.Location = new System.Drawing.Point(3, 261);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(80, 80);
            this.changeSign.TabIndex = 13;
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.change_sign_Click);
            // 
            // zero
            // 
            this.zero.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("zero.BackgroundImage")));
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Location = new System.Drawing.Point(89, 261);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 80);
            this.zero.TabIndex = 12;
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nine
            // 
            this.nine.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("nine.BackgroundImage")));
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Location = new System.Drawing.Point(175, 175);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(80, 80);
            this.nine.TabIndex = 11;
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("eight.BackgroundImage")));
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Location = new System.Drawing.Point(89, 175);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(80, 80);
            this.eight.TabIndex = 10;
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("seven.BackgroundImage")));
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Location = new System.Drawing.Point(3, 175);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(80, 80);
            this.seven.TabIndex = 9;
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("six.BackgroundImage")));
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Location = new System.Drawing.Point(175, 89);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(80, 80);
            this.six.TabIndex = 8;
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // four
            // 
            this.four.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("four.BackgroundImage")));
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Location = new System.Drawing.Point(3, 89);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(80, 80);
            this.four.TabIndex = 7;
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("five.BackgroundImage")));
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Location = new System.Drawing.Point(89, 89);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(80, 80);
            this.five.TabIndex = 6;
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // three
            // 
            this.three.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("three.BackgroundImage")));
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Location = new System.Drawing.Point(175, 3);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(80, 80);
            this.three.TabIndex = 5;
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("two.BackgroundImage")));
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Location = new System.Drawing.Point(89, 3);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(80, 80);
            this.two.TabIndex = 4;
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(453, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numberRepresenter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button log;

        private System.Windows.Forms.Button factorial;

        private System.Windows.Forms.Button radical;

        private System.Windows.Forms.Button pi;

        private System.Windows.Forms.Button divide;

        private System.Windows.Forms.Button product;

        private System.Windows.Forms.Button point;

        private System.Windows.Forms.Button changeSign;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button equal;

        private System.Windows.Forms.Button plus;

        private System.Windows.Forms.Button zero;

        private System.Windows.Forms.Button nine;

        private System.Windows.Forms.Button eight;

        private System.Windows.Forms.Button seven;

        private System.Windows.Forms.Button six;

        private System.Windows.Forms.Button five;

        private System.Windows.Forms.Button four;

        private System.Windows.Forms.Button three;

        private System.Windows.Forms.Button two;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;

        private System.Windows.Forms.Button one;

        private System.Windows.Forms.Label numberRepresenter;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        #endregion
    }
}