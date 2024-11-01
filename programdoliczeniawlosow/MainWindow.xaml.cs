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

namespace programdoliczeniawlosow
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Pobierz dane z TextBoxów i konwertuj na double
                double density = double.Parse(DensityTextBox.Text);
                double area = double.Parse(AreaTextBox.Text);

                // Oblicz liczbę włosów: liczba włosów = gęstość * powierzchnia
                double hairCount = density * area;

                // Wyświetl wynik w ResultLabel
                ResultLabel.Content = $"Liczba włosów: {hairCount}";
            }
            catch (FormatException)
            {
                // Obsługuje sytuację, gdy wprowadzone dane nie są poprawne
                MessageBox.Show("Proszę wprowadzić poprawne dane numeryczne.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}