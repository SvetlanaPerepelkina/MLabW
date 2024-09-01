using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Windows.Media.Converters;

namespace Calc
 {

    public partial class MainWindow : Window
    {
            public MainWindow()
            {
                InitializeComponent();
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                string str = (string)((Button)e.Source).Content;
                try
                {

                    if (str == "CE")
                    {
                        TextBox1.Text = "0";
                        TextBox2.Text += "\n";
                        Line.Text = " ";
                        TextBox3.Text = "0";
                        Line.Background = new SolidColorBrush(Colors.Bisque);
                }
                    else if (str == "=")
                    {
                        double value = Math.Round(Convert.ToDouble(new DataTable().Compute(TextBox1.Text, " ")),4);
                        TextBox1.Text = " " + Math.Round(value,4);
                        TextBox2.Text += str + Math.Round(value,4);
                        Line.Text = "         +     -      *     /        ";
                        Line.Background = new SolidColorBrush(Colors.LightBlue);
                }
                    else if (str == "Clear")
                    {
                        TextBox2.Text = " ";
                        TextBox1.Text = "0";
                        Line.Text = " ";
                        TextBox3.Text = "0";
                        Line.Background = new SolidColorBrush(Colors.Bisque);
                }
                    else
                    {
                        string value = str;
                        TextBox1.Text += value;
                        TextBox2.Text += str;
                    }
                }
                catch
                {
                    Exception ex = new Exception();
                }
            }

            private void Button_Click1(object sender, RoutedEventArgs e)
            {
                double value = Math.Round(Convert.ToDouble(TextBox1.Text),4);
                string str = (string)((Button)e.Source).Content;

                try
                {
                    if (str == "cos")
                    {
                        TextBox1.Text = Math.Round(Math.Cos(value),4).ToString();
                        TextBox2.Text += "\n" + str + Math.Round(value, 4) + " = " + TextBox1.Text;
                        Line.Text = "Косинус угла";
                        Line.Background = new SolidColorBrush(Colors.LightGreen);

                    }
                    else if (str == "sin")
                    {
                        TextBox1.Text = Math.Round(Math.Sin(value),4).ToString();
                        TextBox2.Text += "\n" + str + Math.Round(value, 4) + " = " + TextBox1.Text;
                        Line.Text = "Синус угла";
                        Line.Background = new SolidColorBrush(Colors.LightSeaGreen);
                    }
                    else if (str == "tg")
                    {
                        TextBox1.Text = Math.Round(Math.Tan(value),4).ToString();
                        TextBox2.Text += "\n" + str + value + " = " + TextBox1.Text;
                        Line.Text = "Тангенс угла";
                        Line.Background = new SolidColorBrush(Colors.LightSkyBlue);
                    }
                    else if (str == "√")
                    {
                        TextBox1.Text = Math.Round(Math.Sqrt(value),4).ToString();
                        TextBox2.Text += "\n" + str + value + " = " + TextBox1.Text;
                        Line.Text = "Корень квадратный";
                        Line.Background = new SolidColorBrush(Colors.LightSteelBlue);
                    }
                    else if (str == "1/n")
                    {
                        TextBox1.Text = Math.Round((1 / value),4).ToString();
                        TextBox2.Text += "\n" + 1 + "/" + Math.Round(value, 4) + " = " + TextBox1.Text;
                        Line.Text = "1/n";
                        Line.Background = new SolidColorBrush(Colors.LightPink);
                    }
                    else if (str == "^n")
                    {
                        double value1 = Convert.ToDouble(TextBox3.Text);
                        TextBox1.Text = Math.Round(Math.Pow(value, value1),4).ToString();
                        TextBox2.Text += "\n" + Math.Round(value, 4) + "^" + value1 + "=" + TextBox1.Text;
                        Line.Text = "Возведение в степень";
                        Line.Background = new SolidColorBrush(Colors.LightSalmon);

                        if (value1 == 2) Message.Content = "Укажите \n степень";
                        else Message.Content = " ";
                    }
                    else if (str == "rad")
                    {
                        TextBox1.Text = Math.Round((value * 180 / double.Pi),4).ToString();
                        TextBox2.Text += "\n" + Math.Round(value, 4) + " = " + TextBox1.Text; ;
                        Line.Text = "Градусы в радианы";
                        Line.Background = new SolidColorBrush(Colors.LightYellow);
                    }
                    else
                    {
                        TextBox2.Text += "";
                    }
                }
                catch
                {
                    Exception ex = new Exception();
                }
            }
    }
}

