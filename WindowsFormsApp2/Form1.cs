using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
    private StringBuilder num1;
    private StringBuilder num2;
    private string operation;
    private bool flag;
    private double result;
    public Form1()
    {
      flag = false;
      InitializeComponent();
      StretchImages();
    }

    /// <summary>
    /// this method resizes background images of buttons
    /// </summary>
    private void StretchImages()
    {
      one.BackgroundImageLayout = ImageLayout.Stretch;
      two.BackgroundImageLayout = ImageLayout.Stretch;
      three.BackgroundImageLayout = ImageLayout.Stretch;
      four.BackgroundImageLayout = ImageLayout.Stretch;
      five.BackgroundImageLayout = ImageLayout.Stretch;
      six.BackgroundImageLayout = ImageLayout.Stretch;
      seven.BackgroundImageLayout = ImageLayout.Stretch;
      eight.BackgroundImageLayout = ImageLayout.Stretch;
      nine.BackgroundImageLayout = ImageLayout.Stretch;
      zero.BackgroundImageLayout = ImageLayout.Stretch;
      plus.BackgroundImageLayout = ImageLayout.Stretch;
      equal.BackgroundImageLayout = ImageLayout.Stretch;
      changeSign.BackgroundImageLayout = ImageLayout.Stretch;
      point.BackgroundImageLayout = ImageLayout.Stretch;
      product.BackgroundImageLayout = ImageLayout.Stretch;
      divide.BackgroundImageLayout = ImageLayout.Stretch;
      pi.BackgroundImageLayout = ImageLayout.Stretch;
      radical.BackgroundImageLayout = ImageLayout.Stretch;
      factorial.BackgroundImageLayout = ImageLayout.Stretch;
      log.BackgroundImageLayout = ImageLayout.Stretch;
    }

    /// <summary>
    /// this method is used to append a value to the intended string builder
    /// </summary>
    /// <param name="value">intended value that should be added to string builder</param>
    private void SetValue(string value)
    {
      if (!flag)
      {
        if (num1 != null && num1.ToString()[0] == '0' && !num1.ToString().Contains("."))
                  num1.Clear();
        if (num1 == null)
          num1 = new StringBuilder();
       
        num1.Append(value);
        numberRepresenter.Text = num1.ToString();
      }
      else
      {
        if (num2 != null && num2.ToString()[0] == '0' && !num2.ToString().Contains("."))
          num2.Clear();
        if (num2 == null)
          num2 = new StringBuilder();
        num2.Append(value);
        numberRepresenter.Text = num2.ToString();
      }
    }
    
    /// <summary>
    /// this method is called whenever <see cref="one"/> button is pressed
    /// and appends one to the intended string builder
    /// </summary>
    private void one_Click(object sender, EventArgs e)
    {
      SetValue("1");
    }

    /// <summary>
    /// this method is called whenever <see cref="two"/> button is pressed
    /// and appends two to the intended string builder
    /// </summary>
    private void two_Click(object sender, EventArgs e)
    {
      SetValue("2");
    }

    /// <summary>
    /// this method is called whenever <see cref="three"/> button is pressed
    /// and appends three to the intended string builder
    /// </summary>
    private void three_Click(object sender, EventArgs e)
    {
      SetValue("3");
    }

    /// <summary>
    /// this method is called whenever <see cref="four"/> button is pressed
    /// and appends four to the intended string builder
    /// </summary>
    private void four_Click(object sender, EventArgs e)
    {
      SetValue("4");
    }

    /// <summary>
    /// this method is called whenever <see cref="five"/> button is pressed
    /// and appends five to the intended string builder
    /// </summary>
    private void five_Click(object sender, EventArgs e)
    {
      SetValue("5");
    }

    /// <summary>
    /// this method is called whenever <see cref="six"/> button is pressed
    /// and appends six to the intended string builder
    /// </summary>
    private void six_Click(object sender, EventArgs e)
    {
      SetValue("6");
    }

    /// <summary>
    /// this method is called whenever <see cref="seven"/> button is pressed
    /// and appends seven to the intended string builder
    /// </summary>
    private void seven_Click(object sender, EventArgs e)
    {
      SetValue("7");
    }

    /// <summary>
    /// this method is called whenever <see cref="eight"/> button is pressed
    /// and appends eight to the intended string builder
    /// </summary>
    private void eight_Click(object sender, EventArgs e)
    {
      SetValue("8");
    }

    /// <summary>
    /// this method is called whenever <see cref="nine"/> button is pressed
    /// and appends nine to the intended string builder
    /// </summary>
    private void nine_Click(object sender, EventArgs e)
    {
      SetValue("9");
    }

    /// <summary>
    /// this method is called whenever <see cref="zero"/> button is pressed
    /// and appends zero to the intended string builder
    /// </summary>
    private void zero_Click(object sender, EventArgs e)
    {
      SetValue("0");
    }

    /// <summary>
    /// this method is called whenever <see cref="plus"/> button is pressed
    /// and sets operation to plus
    /// </summary>
    private void plus_Click(object sender, EventArgs e)
    {
      operation = "+";
      flag = !flag;
      numberRepresenter.Text = "0";
    }

    /// <summary>
    /// this method is called whenever <see cref="product"/> button is pressed
    /// and sets operation to product
    /// </summary>
    private void product_Click(object sender, EventArgs e)
    {
      operation = "*";
      flag = !flag;
      numberRepresenter.Text = "0";
    }
    
    /// <summary>
    /// adds fraction point to the intended number
    /// </summary>
    private void point_Click(object sender, EventArgs e)
    {
      if (!flag)
      {
        if (num1 != null)
        {
          if(!num1.ToString().Contains("."))
          {
            num1.Append(".");
            numberRepresenter.Text = num1.ToString();
          }
        }
        else if (num1 == null)
        {
          num1 = new StringBuilder();
          num1.Append("0.");
          numberRepresenter.Text = num1.ToString();
        }
      }
      else
      {
        if (num2 != null)
        {
          if(!num2.ToString().Contains("."))
          {
            num2.Append(".");
            numberRepresenter.Text = num2.ToString();
          }
        }
        else if (num2 == null)
        {
          num2 = new StringBuilder();
          num2.Append("0.");
          numberRepresenter.Text = num2.ToString();
        }
      }
    }
    
    /// <summary>
    /// calculates result of an operation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void equal_Click(object sender, EventArgs e)
    {
      switch (operation)
      {
        case "+":
          DoSumOperation();
          break;
        case "*":
          DoProductOperation();
          break;
        case "/":
          DoDivision();
          break;
      }
    }
    
    /// <summary>
    /// this method is called whenever <see cref="divide"/> button is pressed
    /// and sets operation to division
    /// </summary>
    private void divide_Click(object sender, EventArgs e)
    {
      operation = "/";
      flag = !flag;
      numberRepresenter.Text = "0";
    }

    private void change_sign_Click(object sender, EventArgs e)
    {
      ChangeSign(!flag ? num1 : num2);
    }
    
    /// <summary>
    /// this method is called whenever <see cref="pi"/> button is pressed
    /// and sets value of pi number
    /// </summary>
    private void pi_Click(object sender, EventArgs e)
        {
          if (!flag)
          {
            if (num1 == null)
              num1 = new StringBuilder();
            num1.Clear();
            num1.Append(Math.PI);
            numberRepresenter.Text = num1.ToString();
          }
          else
          {
            if (num2 == null)
              num2 = new StringBuilder();
            num2.Clear();
            num2.Append(Math.PI);
            numberRepresenter.Text = num2.ToString();
          }
        }
    
    /// <summary>
    /// this method is called whenever <see cref="radical"/> button is pressed
    /// and uses <see cref="DoRadical"/> to calculate radical
    /// </summary>
    private void radical_Click(object sender, EventArgs e)
    {
      DoRadical(!flag ? num1 : num2);
    }
    
    /// <summary>
    /// this method is called whenever <see cref="factorial"/> button is pressed
    /// and uses <see cref="DoFactorial"/> to calculate factorial
    /// </summary>
    private void factorial_Click(object sender, EventArgs e)
    {
      DoFactorial(!flag ? num1 : num2);
    }
    
    /// <summary>
    /// this method is called whenever <see cref="log"/> button is pressed
    /// and uses <see cref="DoLogarithm"/> to calculate logarithm
    /// </summary>
    private void log_Click(object sender, EventArgs e)
    {
      DoLogarithm(!flag ? num1 : num2);
    }
    
    private void DoSumOperation()
    {
      if (num1 != null && num2 != null)
      {
        result = Convert.ToDouble(num1.ToString()) + Convert.ToDouble(num2.ToString());
        numberRepresenter.Text = Convert.ToString(result);
        num1 = null;
        num2 = null;
        flag = !flag;
      }
      else if (num1 != null && num2 == null)
      {
        result = Convert.ToDouble(num1.ToString()) + Convert.ToDouble(num1.ToString());
        numberRepresenter.Text = Convert.ToString(result);
        num1 = null;
        flag = !flag;
      }
    }

    private void DoProductOperation()
    {
      if (num1 != null && num2 != null)
      {
        result = Convert.ToDouble(num1.ToString()) * Convert.ToDouble(num2.ToString());
        numberRepresenter.Text = Convert.ToString(result);
        num1 = null;
        num2 = null;
        flag = !flag;
      }
      else if (num1 != null && num2 == null)
      {
        result = Convert.ToDouble(num1.ToString()) * Convert.ToDouble(num1.ToString());
        numberRepresenter.Text = Convert.ToString(result);
        num1 = null;
        flag = !flag;
      }
    }

    private void DoDivision()
    {
      if (num1 != null && num2 != null && Convert.ToDouble(num2.ToString()) != 0)
      {
        result = Convert.ToDouble(num1.ToString()) / Convert.ToDouble(num2.ToString());
        numberRepresenter.Text = Convert.ToString(result);
        num1 = null;
        num2 = null;
        flag = !flag;
      }
      else if(num1 != null && num2 != null && Convert.ToDouble(num2.ToString()) == 0)
      {
        numberRepresenter.Text = "error";
        num1 = null;
        num2 = null;
        flag = !flag;
      }
      else if (num1 != null && num2 == null)
      {
        result = Convert.ToDouble(num1.ToString()) / Convert.ToDouble(num1.ToString());
        numberRepresenter.Text = Convert.ToString(result);
        num1 = null;
        flag = !flag;
      }
    }

    private void ChangeSign(StringBuilder number)
    {
      double temp = Convert.ToDouble(number.ToString());
      if (number != null)
      {
        temp =  -1 * temp;
        number.Clear();
        number.Append(temp);
        numberRepresenter.Text = number.ToString();
      }
    }


    private void DoRadical(StringBuilder number)
    {
      double temp = Convert.ToDouble(number.ToString());
      if (temp >= 0)
      {
        number.Clear();
        number.Append(Math.Pow(temp, 0.5));
        numberRepresenter.Text = number.ToString();
      }
      else 
      {
        numberRepresenter.Text = "error";
        number.Clear();
      }
    }

    /// <summary>
    /// this method calculates factorial of number
    /// </summary>
    /// <param name="number">
    /// a string builder that holds the number that user enters
    /// </param>
    private void DoFactorial(StringBuilder number)
    {
      var temp = Convert.ToDouble(number.ToString());
      Int64 res = 1;
      for (int i = 1; i <= Convert.ToInt64(temp); i++)
      {
        res *= i;
      }
      number.Clear();
      number.Append(res);
      numberRepresenter.Text = number.ToString();
    }
    
    /// <summary>
    /// this method calculates logarithm of number
    /// </summary>
    /// <param name="number">
    /// a string builder that holds the number that user enters
    /// </param>
    private void DoLogarithm(StringBuilder number)
    {
      double temp = Convert.ToDouble(number.ToString());
      number.Clear();
      number.Append(Math.Log(temp, 10));
      numberRepresenter.Text = number.ToString();
    }
  }
}
