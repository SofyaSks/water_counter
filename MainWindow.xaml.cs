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

namespace water_counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Counter c = new Counter();
            // string str = c.date.ToShortDateString();
            // lastCheckTB.Text = str;

            this.DataContext = new Counter
            {
                Maker = "Water.Co",
                Model = "Great",
                SerialID = 116,
                lastCheck = "12.09.2023",
                hotWater = true
            };

            

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"You made following changes:\nПроизводитель: { MakerTB.Text }\nМодель: {ModelTB.Text}\n" +
                $"Серийный номер: {IdTB.Text}\nДата последней проверки: {lastCheckTB.Text}\nПредназначен для горячей воды: {hotWaterChB.IsChecked}");

        }
    }
}
