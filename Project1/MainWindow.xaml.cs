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

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            //Initialize constant interest variable
            const double INTEREST = 0.0639;
            //Get text from textboxes as string then convert to double
            double monthlyPay = Convert.ToDouble(inMonthly.Text);
            double outstanding = Convert.ToDouble(outBalance.Text);
            //Calculates amount of interest you are paying and the amount going to principle
            double interestPayment = Math.Round((outstanding * INTEREST) / 12, 2);
            double principlePayment = Math.Round(monthlyPay - interestPayment, 2);
            //Message box showing answer
            MessageBox.Show("Your interest payment is $" + interestPayment + "\n"
                + "Your principle payment is $" + principlePayment);
        }
    }
}
