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

namespace WpfAppLessonWPF3
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily (fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSise = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            {
                textBox.FontSize = fontSise;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight != FontWeights.Bold)
                    textBox.FontWeight = FontWeights.Bold;
                else textBox.FontWeight = FontWeights.Normal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontStyle != FontStyles.Italic)
                    textBox.FontStyle = FontStyles.Italic;
                else textBox.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.TextDecorations != TextDecorations.Underline)
                    textBox.TextDecorations = TextDecorations.Underline;
                else textBox.TextDecorations = null;
            }
        }

        private void RadioButtonBlack_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                Brush brush = (sender as RadioButton).Foreground;
                if (brush != null)
                {
                    textBox.Foreground = brush;
                }
            }
        }

        private void radioBottonRed_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                Brush brush = (sender as RadioButton).Foreground;
                if (brush != null)
                {
                    textBox.Foreground = brush;
                }
            }

        }
    }
}
