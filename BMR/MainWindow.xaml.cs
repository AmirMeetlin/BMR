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

namespace BMR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            
            if (boxWeight.Text == "" || boxWeight.Text == "" || boxWeight.Text == "" || boxWeight.Text == "" || boxWeight.Text == "")
            {
                MessageBox.Show("ты говнюк");
            }
            else
            {
                double BMR;
                double weight = Convert.ToDouble(boxWeight.Text);
                double height = Convert.ToDouble(boxHeight.Text);
                double age = Convert.ToDouble(boxAge.Text);
                if (rbFormMafDj.IsChecked == true)
                {
                    if (rbGenderM.IsChecked == true)
                    {
                        if (rbWeightKg.IsChecked == true)
                        {
                            BMR = 10 * weight + 6.25 * height - 5 * age + 5;
                        }
                        else
                        {
                            BMR = 10 * weight / 2.2 + 6.25 * height - 5 * age + 5;
                        }
                    }
                    else
                    {
                        if (rbWeightKg.IsChecked == true)
                        {
                            BMR = 10 * weight + 6.25 * height - 5 * age - 161;
                        }
                        else
                        {
                            BMR = 10 * weight / 2.2 + 6.25 * height - 5 * age - 161;
                        }
                    }
                }
                else
                {
                    if (rbGenderM.IsChecked == true)
                    {
                        if (rbWeightKg.IsChecked == true)
                        {
                            BMR = 66.5 + 13.75 * weight + 5.003 * height - 6.775 * age;
                        }
                        else
                        {
                            BMR = 66.5 + 13.75 * weight / 2.2 + 5.003 * height - 6.775 * age;
                        }
                    }
                    else
                    {
                        if (rbWeightKg.IsChecked == true)
                        {
                            BMR = 65.51 + 9.563 * weight + 1.85 * height - 4.676 * age;
                        }
                        else
                        {
                            BMR = 65.51 + 9.563 * weight / 2.2 + 1.85 * height - 4.676 * age;
                        }
                    }
                }
                int d =cbEnergy.SelectedIndex;
                switch(d)
                {
                    case 0:
                        BMR = BMR * 1;
                        break;
                    case 1:
                        BMR = BMR * 1.2;
                        break;
                    case 2:
                        BMR = BMR * 1.375;
                        break;
                    case 3:
                        BMR = BMR * 1.4625;
                        break;
                    case 4:
                        BMR = BMR * 1.550;
                        break;
                    case 5:
                        BMR = BMR * 1.6375;
                        break;
                    case 6:
                        BMR = BMR * 1.725;
                        break;
                    case 7:
                        BMR = BMR * 1.9;
                        break;
                }
                if(rbVarKal.IsChecked == true)
                {
                    MessageBox.Show("Для поддержания веса необходимо "+BMR+" ккалорий\n"+"Для похудения необходимо "+BMR*0.8+ " ккалорий");
                }
                else
                {
                    BMR = BMR * 4.1868;
                    MessageBox.Show("Для поддержания веса необходимо " + BMR + " килоджоулей\n" + "Для похудения необходимо " + BMR * 0.8 + " килоджоулей");
                }

            }
            
            
        }

        private void boxText_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Лет" || textBox.Text == "Сантиметров" )
            {
                textBox.Text = "";
            }
        }

        private void boxText_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == "boxAge" && textBox.Text == "")
            {
                boxAge.Text = "Лет";
            }
            if (textBox.Name == "boxHeight" && textBox.Text == "")
            {
                boxHeight.Text = "Сантиметров";
            }
        }
    }
}
