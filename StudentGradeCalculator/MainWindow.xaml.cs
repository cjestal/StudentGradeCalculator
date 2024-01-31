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

namespace StudentGradeCalculator
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

        private void CalculateGrade(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0) {
                MessageBox.Show("Please provide a name");
                return;
            }

            try
            {
                float userScore = float.Parse(score.Text);
                if (userScore >= 90 && userScore <= 100)
                {
                    grade.Text = "A+";
                }
                else if (userScore >= 85 && userScore <= 89)
                {
                    grade.Text = "A";
                }
                else if (userScore >= 80 && userScore <= 84)
                {
                    grade.Text = "A-";
                }
                else if (userScore >= 75 && userScore <= 79)
                {
                    grade.Text = "B+";
                }
                else if (userScore >= 70 && userScore <= 74)
                {
                    grade.Text = "B";
                }
                else if (userScore >= 65 && userScore <= 69)
                {
                    grade.Text = "C+";
                }
                else if (userScore >= 60 && userScore <= 64)
                {
                    grade.Text = "C";
                }
                else if (userScore >= 55 && userScore <= 59)
                {
                    grade.Text = "D+";
                }
                else if (userScore >= 50 && userScore <= 54)
                {
                    grade.Text = "D";
                }
                else if (userScore >= 40 && userScore <= 49)
                {
                    grade.Text = "E";
                }
                else
                {
                    grade.Text = "F";
                }
            } catch {
                grade.Text = "?";
                score.Text = "";
                MessageBox.Show("Please provide a valid score number");
            }
            

            
        }
    }
}
