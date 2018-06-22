using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using Calcu;

namespace TP2_laba_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        int znach, b = 0;
        bool znak = true;
        string tex_1 = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
           textbox.Text = "";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
            label.Content = "";
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            int lenght = textbox.Text.Length - 1;
            string text = textbox.Text;
            textbox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textbox.Text = textbox.Text + text[i];
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 1;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 2;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 3;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 4;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 5;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 6;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 7;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 8;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 9;
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + ".";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = double.Parse(textbox.Text);
                textbox.Clear();
                znach = 2;
                label.Content = a.ToString() + "-";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = double.Parse(textbox.Text);
                textbox.Clear();
                znach = 3;
                label.Content = a.ToString() + "*";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = double.Parse(textbox.Text);
                textbox.Clear();
                znach = 1;
                label.Content = a.ToString() + "+";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = double.Parse(textbox.Text);
                textbox.Clear();
                znach = 4;
                label.Content = a.ToString() + "/";
                znak = true;

            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = double.Parse(textbox.Text);
                textbox.Clear();
                znach = 5;
                label.Content = a.ToString() + "^1/2";
                znak = true;
                string per = textbox.Text;
               string eqal = Calcu.Class1.calculate(per, a, znach);
                textbox.Text = eqal;
            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = double.Parse(textbox.Text);
                textbox.Clear();
                znach = 6;
                label.Content = "sin(" + a.ToString() + ")";
                znak = true;
                string per = textbox.Text;
                string eqal = Calcu.Class1.calculate(per, a, znach);
                textbox.Text = eqal;
            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                a = Math.Ceiling(double.Parse(textbox.Text));
                textbox.Clear();
                znach = 7;
                label.Content = a.ToString() + "!";
                znak = true;
                string per = textbox.Text;
                string eqal = Calcu.Class1.calculate(per, a, znach);
                textbox.Text = eqal;
            }
            else MessageBox.Show("Введите первое число!", "Сообщение"); textbox.Focus();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                string per = textbox.Text;
                string eqal = Calcu.Class1.calculate(per, a, znach);
                textbox.Text = eqal;
                label.Content = "";
            }
            else MessageBox.Show("Введите второй операнд!", "Сообщение"); textbox.Focus();
        }

  

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string k = textbox.Text;
            double num;
            if (k != "-" && k != "+")
                try
                {
                    num = double.Parse(textbox.Text);
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
                textbox.Text = tex_1;
                MessageBox.Show("Число вышло за допустимые рамки"); textbox.Focus();
            }
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void Otricanie_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                if (znak == true)
                {
                    if (double.Parse(textbox.Text) > 2000000)
                    {
                        textbox.Text = "-2000000";
                        znak = false;
                        MessageBox.Show("Минимальное допустимое при вводе значение = -2000000", "Сообщение"); textbox.Focus();
                    }
                    else
                    {
                        textbox.Text = "-" + textbox.Text;
                        znak = false;
                    }
                }
                else if (znak == false)
                {
                    textbox.Text = textbox.Text.Replace("-", "");
                    znak = true;
                }
            }
            else MessageBox.Show("Введите число!", "Сообщение"); textbox.Focus();
        }
    }
}
