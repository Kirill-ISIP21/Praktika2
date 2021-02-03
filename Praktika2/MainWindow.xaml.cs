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

namespace Praktika2
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
        
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int rozes, tulpanes;
            int.TryParse(tBoxRoz.Text, out rozes);
            int.TryParse(tBoxTulp.Text, out tulpanes);
            Calculate answer = new Calculate(rozes, tulpanes);
            lblAnswer.Content = answer.allPrice().ToString();
            if (tBoxRoz.Text=="" && tBoxTulp.Text == "")
            {
                lblAnswer.Content = "Введите кол-во цветов";
            }

        }
        private void tBoxRoz_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //отключает возможность писать в TextBox буквы и символы
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        private void tBoxTulp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
