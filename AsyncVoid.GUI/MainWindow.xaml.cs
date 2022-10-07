using System;
using System.Windows;

namespace AsyncVoid.GUI
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

        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var writer = new DataWriter();

                await writer.WriteDataAsync($"New book: {Title.Text}");

                Message.Content = $"{Title.Text} successfully saved.";
            }
            catch (Exception ex)
            {
                Message.Content = $"Error {ex.Message}";
            }
        }
    }
}
