using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace angel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> numbers;
        public MainWindow()
        {
            InitializeComponent();
            numbers = new ObservableCollection<int>();

        }
        private void btnCalculate_click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb_ot.Text, out int A) && int.TryParse(tb_do.Text, out int B))
            {
                int evenCount = 0;
                int oddCount = 0;
                int[] array = (GenerateRandom.GenerateRandomArray(A, B));
                for (int i = 0; i < array.Length; i++) 
                {
                    numbers.Add(array[i]);
                }
               
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        evenCount++; // Увеличиваем счетчик четных чисел
                    }
                    else
                    {
                        oddCount++; // Увеличиваем счетчик нечетных чисел
                    }
                }

                lb_calc.Items.Add($"Количество четных чисел: {evenCount}\r\nКоличество нечетных чисел: {oddCount}");
            }         
        }          
    }
}
