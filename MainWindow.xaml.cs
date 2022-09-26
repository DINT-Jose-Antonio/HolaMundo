using System.Windows;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nombreTextBlock.Text = "Hola " + nombreTextBox.Text;
            if (nombreTextBox.Text == "")
            {
                nombreTextBox.Text = "Hola Mundo";
            }

        }

        private void saludarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
