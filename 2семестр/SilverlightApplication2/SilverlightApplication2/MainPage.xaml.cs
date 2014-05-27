using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication2
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int temp = 0;
        int test = 0;

        int[,] matrix = new int[3, 3];

        public int Function(int[,] matrix)
        {
            if (matrix[0, 0] + matrix[0, 1] + matrix[0, 2] == 3 || matrix[1, 0] + matrix[1, 1] + matrix[1, 2] == 3 || matrix[2, 0] + matrix[2, 1] + matrix[2, 2] == 3 || matrix[0, 0] + matrix[1, 0] + matrix[2, 0] == 3 || matrix[0, 1] + matrix[1, 1] + matrix[2, 1] == 3 || matrix[0, 2] + matrix[1, 2] + matrix[2, 2] == 3 || matrix[0, 0] + matrix[1, 1] + matrix[2, 2] == 3 || matrix[2, 0] + matrix[1, 1] + matrix[0, 2] == 3)
            {
                return 1;
            }
            if (matrix[0, 0] + matrix[0, 1] + matrix[0, 2] == -3 || matrix[1, 0] + matrix[1, 1] + matrix[1, 2] == -3 || matrix[2, 0] + matrix[2, 1] + matrix[2, 2] == -3 || matrix[0, 0] + matrix[1, 0] + matrix[2, 0] == -3 || matrix[0, 1] + matrix[1, 1] + matrix[2, 1] == -3 || matrix[0, 2] + matrix[1, 2] + matrix[2, 2] == -3 || matrix[0, 0] + matrix[1, 1] + matrix[2, 2] == -3 || matrix[2, 0] + matrix[1, 1] + matrix[0, 2] == -3)
            {
                return 2;
            }
            else
                return 0;
        }
        private void button1Click(object sender, RoutedEventArgs e)
        {
            test++;
            if (temp == 0 && button1.Content.ToString() != "O")
            {
                button1.Content = "X";
                temp = 1;
                matrix[0, 0] = 1;
            }
            if (temp == 1 && button1.Content.ToString() != "X")
            {
                button1.Content = "O";
                temp = 0;
                matrix[0, 0] = -1;
            }
            if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
            if (test == 9)
            {
                MessageBox.Show("No Winners");
            }
        }

        private void button2Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button2.Content.ToString() != "O")
            {
                button2.Content = "X";
                temp = 1;
                matrix[0, 1] = 1;
            }
            if (temp == 1 && button2.Content.ToString() != "X")
            {
                button2.Content = "O";
                temp = 0;
                matrix[0, 1] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button3Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button3.Content.ToString() != "O")
            {
                button3.Content = "X";
                temp = 1;
                matrix[0, 2] = 1;
            }
            if (temp == 1 && button3.Content.ToString() != "X")
            {
                button3.Content = "O";
                temp = 0;
                matrix[0, 2] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button4Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button4.Content.ToString() != "O")
            {
                button4.Content = "X";
                temp = 1;
                matrix[1, 0] = 1;
            }
            if (temp == 1 && button4.Content.ToString() != "X")
            {
                button4.Content = "O";
                temp = 0;
                matrix[1, 0] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button5Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button5.Content.ToString() != "O")
            {
                button5.Content = "X";
                temp = 1;
                matrix[1, 1] = 1;
            }
            if (temp == 1 && button5.Content.ToString() != "X")
            {
                button5.Content = "O";
                temp = 0;
                matrix[1, 1] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button6Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button6.Content.ToString() != "O")
            {
                button6.Content = "X";
                temp = 1;
                matrix[1, 2] = 1;
            }
            if (temp == 1 && button6.Content.ToString() != "X")
            {
                button6.Content = "O";
                temp = 0;
                matrix[1, 2] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button7Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button7.Content.ToString() != "O")
            {
                button7.Content = "X";
                temp = 1;
                matrix[2, 0] = 1;
            }
            if (temp == 1 && button7.Content.ToString() != "X")
            {
                button7.Content = "O";
                temp = 0;
                matrix[2, 0] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button8Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button8.Content.ToString() != "O")
            {
                button8.Content = "X";
                temp = 1;
                matrix[2, 1] = 1;
            }
            if (temp == 1 && button8.Content.ToString() != "X")
            {
                button8.Content = "O";
                temp = 0;
                matrix[2, 1] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }

        private void button9Click(object sender, RoutedEventArgs e)
        {
            if (temp == 0 && button9.Content.ToString() != "O")
            {
                button9.Content = "X";
                temp = 1;
                matrix[2, 2] = 1;
            }
            if (temp == 1 && button9.Content.ToString() != "X")
            {
                button9.Content = "O";
                temp = 0;
                matrix[2, 2] = -1;
            }
             if (Function(matrix) == 1)
            {
                MessageBox.Show("Win The First Player");
                test = 0;
            }
             if (Function(matrix) == 2)
            {
                MessageBox.Show("Win The Second Player");
                test = 0;
            }
             test++;
             if (test == 9)
             {
                 MessageBox.Show("No Winners");
             }
        }
    }
}
