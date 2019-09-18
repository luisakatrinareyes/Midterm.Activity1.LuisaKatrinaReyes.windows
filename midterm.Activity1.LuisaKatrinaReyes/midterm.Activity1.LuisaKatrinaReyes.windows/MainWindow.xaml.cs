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

namespace midterm.Activity1.LuisaKatrinaReyes.windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int grade = int.Parse(TextBox_PCT.Text);
            if (grade == 100 || grade == 99 || grade == 98)
            {
                lblResult.Content = "1.00";
            }

            else if (grade > 94 & grade < 98)
            {
                lblResult.Content = "1.25";
            }

            else if (grade > 91 & grade < 95)
            {
                lblResult.Content = "1.50";
            }

            else if (grade > 88 & grade < 92)
            {
                lblResult.Content = "1.75";
            }

            else if (grade > 85 & grade < 89)
            {
                lblResult.Content = "2.00";
            }

            else if (grade > 82 & grade < 86)
            {
                lblResult.Content = "2.25";
            }

            else if (grade > 79 & grade < 83)
            {
                lblResult.Content = "2.75";
            }

            else if (grade > 75)
            {
                lblResult.Content = "3.00";
            }

            else if (grade == 74 || grade == 73)
            {
                lblResult.Content = "3.75";
            }
            else if (grade == 72 || grade == 71)
            {
                lblResult.Content = "3.50";
            }

            else if (grade == 70 || grade == 69)
            {
                lblResult.Content = "3.25";
            }

            else if (grade == 68 || grade == 67)
            {
                lblResult.Content = "4.00";
            }

            else if (grade == 66 || grade == 65)
            {
                lblResult.Content = "4.75";
            }
            else if (grade == 64 || grade == 63)
            {
                lblResult.Content = "4.50";
            }

            else if (grade == 62 || grade == 61)
            {
                lblResult.Content = "4.75";
            }

            else if (grade == 60)
            {
                lblResult.Content = "5.00";
            }
        }
    }
}

