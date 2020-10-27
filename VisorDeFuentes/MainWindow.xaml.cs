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

namespace VisorDeFuentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int FontSize_small = 22;
        private const int FontSize_medium = 18;
        private const int FontSize_large = 24;
        public MainWindow()
        {

            InitializeComponent();
        }

        private void fuenteComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fuenteComboBox.SelectedItem != null)
            {
                string fuente = (string)(fuenteComboBox.SelectedItem as ComboBoxItem).Content;
                leyendaTexBlock.FontFamily = new FontFamily(familyName: fuente);
            }
        }

        private void cursivasCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            leyendaTexBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivasCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            leyendaTexBlock.FontStyle = FontStyles.Normal;
        }

        private void negritasCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            leyendaTexBlock.FontWeight = FontWeights.Bold;
        }

        private void negritasCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            leyendaTexBlock.FontWeight = FontWeights.Normal;
        }

        private void smallRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (smallRadioButton.IsChecked == true)
            {
                leyendaTexBlock.FontSize = 12;
            }
        }

        private void mediumRadioButton_Checked(object sender, RoutedEventArgs e)
        { 
            if (mediumRadioButton.IsChecked == true) 
            { 
                leyendaTexBlock.FontSize = FontSize_medium; 
            }
        }
        
        private void largeRadioButton_Checked(object sender, RoutedEventArgs e)
        { 
            
            
               leyendaTexBlock.FontSize = FontSize_large; 
            
        }
    }
}
