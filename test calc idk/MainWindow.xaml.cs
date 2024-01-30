using System;
using System.Windows;
using System.Windows.Controls;


namespace test_calc_idk
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tb.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception)
            {
                tb.Text = "ah hell nah (result_click)";
            }
        }

        private void result()
        {
            String operation;
            int iOp = 0;
            switch (tb.Text)
            {
                case string a when a.Contains("+"):
                    {
                        iOp = tb.Text.IndexOf("+");
                        break;
                    }
                case string b when b.Contains("-"):
                    {
                        iOp = tb.Text.IndexOf("-");
                        break;
                    }
                case string c when c.Contains("/"):
                    {
                        iOp = tb.Text.IndexOf("/");
                        break;
                    }
                case string d when d.Contains("*"):
                    {
                        iOp = tb.Text.IndexOf("*");
                        break;
                    }
                default:
                    {
                        tb.Text = "ah hell nah (switch(case) failed)";
                        break;
                    }
            }

            operation = tb.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));
            switch (operation)
            {
                case "+":
                    {
                        tb.Text += "=" + (op1 + op2);
                        break;
                    }
                case "-":
                    {
                        tb.Text += "=" + (op1 - op2);
                        break;
                    }
                case "*":
                    {
                        tb.Text += "=" + (op1 * op2);
                        break;
                    }
                case "/":
                    {
                        tb.Text += "=" + (op1 / op2);
                        break;
                    }
            }
        }
        private void Del_Click(object sender, EventArgs e)
        {
            tb.Text = "";
        }
        private void Off_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }



    }
}
