using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Calcu;
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        
        
        double a;
        int znach, b=0;
        bool znak = true;
        string tex_1="";
        public Form1()
        {
            InitializeComponent();
        }

       public void textBox1_TextChanged(object sender, EventArgs e)//Проверка водимых значений на корректность|| допустимый диапазон
        {
       
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string k = textBox1.Text;
            double num;
            if (k != "-" && k != "+")
                try
                {
                    num = double.Parse(textBox1.Text);
                }
                catch
                {
                    num = 0;
                }
            else
                num = 0;
            if ((num <= 4000000) && (num >= -2000000))
            {
                tex_1 = k;
                b++;
            }
            else
            {
                 textBox1.Text = tex_1;
                MessageBox.Show("Число вышло за допустимые рамки"); textBox1.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)//Ввод 1 в textbox
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button7_Click(object sender, EventArgs e)//Ввод 2 в textbox
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button8_Click(object sender, EventArgs e)//Ввод 3 в textbox
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)//Ввод 4 в textbox
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)//Ввод 5 в textbox
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)//Ввод 6 в textbox
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button14_Click(object sender, EventArgs e)//Ввод 7 в textbox
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button13_Click(object sender, EventArgs e)//Ввод 8 в textbox
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)//Ввод 9 в textbox
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button15_Click(object sender, EventArgs e)//Ввод 0 в textbox
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button5_Click(object sender, EventArgs e)//Ввод '.' в textbox
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)//Очистка поля textbox и label
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//Очистка поля textbox
        {
            textBox1.Text = "";
            
        }

        private void button16_Click(object sender, EventArgs e)//выбор операции вычитания
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znach = 2;
                label2.Text = a.ToString() + "-";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

        private void button18_Click(object sender, EventArgs e)//выбор операции умножения
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znach = 3;
                label2.Text = a.ToString() + "*";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

        private void button19_Click(object sender, EventArgs e)//выбор операции деления
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znach = 4;
                label2.Text = a.ToString() + "/";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

        private void button17_Click(object sender, EventArgs e)//выбор операции сложения
        {
            if(textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znach = 1;
                label2.Text = a.ToString() + "+";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

        private void button20_Click(object sender, EventArgs e)//Результат операции
        {
            if (textBox1.Text != "")
            {
                string per = textBox1.Text;
              string eqal =Calcu.Class1.calculate(per, a,znach);
                textBox1.Text = eqal;
            label2.Text = "";
            }
            else MessageBox.Show("Введите второй операнд!", "Сообщение"); textBox1.Focus();
        }

        private void button22_Click(object sender, EventArgs e)//выбор операции ^1/2
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znach = 5;
                label2.Text = a.ToString() + "^1/2";
                znak = true;
                string per = textBox1.Text;
                string eqal = Calcu.Class1.calculate(per, a, znach);
                textBox1.Text = eqal;
            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)//Проверка вводимых значений при нажатии клавиш
        { 
            textBox1.ShortcutsEnabled=false;
            if ((Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.') || (e.KeyChar == '-'))&(e.KeyChar != ','))
            {           
                string s = textBox1.Text;
                if (e.KeyChar == '.')          
                {
                    int i = s.IndexOf(".", 0, s.Length); 
                                                        
                    if (i != (-1))
                    {
                        e.KeyChar = (char)Keys.None;
                    } 
                      }                          
                if (e.KeyChar == '-')
                {
                    s = textBox1.Text;               
                    int i = s.Length;       
                    if (i > 0) e.KeyChar = (char)Keys.None;
                }
            }             else               
                e.KeyChar = (char)Keys.None;
        }

        private void button23_Click(object sender, EventArgs e)//выбор операции sin(a)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znach = 6;
                label2.Text = "sin("+a.ToString()+")" ;
                znak = true;
                string per = textBox1.Text;
                string eqal = Calcu.Class1.calculate(per, a, znach);
                textBox1.Text = eqal;
            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

        private void button21_Click(object sender, EventArgs e)//выбор операции поиска факториала
        {
            if (textBox1.Text != "")
            {
                a = Math.Ceiling(double.Parse(textBox1.Text));
                textBox1.Clear();
                znach = 7;
                label2.Text =  a.ToString() + "!";
                znak = true;
                string per = textBox1.Text;
                string eqal = Calcu.Class1.calculate(per, a, znach);
                textBox1.Text = eqal;
            }
            else MessageBox.Show("Введите первое число!", "Сообщение"); textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)//удаление последнего числа 
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)//смена знака на отрицательный || проверка числа на допустимый диапазон
        {
            if (textBox1.Text != "")
            {
                if (znak == true)
            {
                if (double.Parse(textBox1.Text) > 2000000)
                {
                    textBox1.Text = "-2000000";
                    znak = false;
                    MessageBox.Show("Минимальное допустимое при вводе значение = -2000000", "Сообщение"); textBox1.Focus();
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
            }
            else MessageBox.Show("Введите число!", "Сообщение"); textBox1.Focus();
        }

   
    }
      
    
}
