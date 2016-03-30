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

namespace inlamning1
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

        // Avstängningsfunktion med en pop-up-funktion som kräver bekräftelse för att svsulta programmet.
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            string message = "Är du säker på att du vill avsluta?";

            MessageBoxResult result = MessageBox.Show(message, "FlowChartDesigner", MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ellipse_Click(object sender, RoutedEventArgs e)
        {
            // Create an Ellipse
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 75;
            ellipse.Width = 150;

            // Create a blue and a black Brush
            SolidColorBrush fillColour = new SolidColorBrush();
            fillColour.Color = Colors.Orange;
            SolidColorBrush edgeColour = new SolidColorBrush();
            edgeColour.Color = Colors.Black;

            // Set Ellipse's width and color
            ellipse.StrokeThickness = 1;
            ellipse.Stroke = edgeColour;
            // Fill rectangle with blue color
            ellipse.Fill = fillColour;

            // Add Ellipse to the Grid.
            Drawarea.Children.Add(ellipse);
        }

        private void btn_diamond_Click(object sender, RoutedEventArgs e)
        {
            // Create an Ellipse
            Rectangle diamond = new Rectangle();
            diamond.Height = 75;
            diamond.Width = 75;
            int angle = 45;
            diamond.RenderTransform = new RotateTransform(angle, diamond.Height /2, diamond.Width /2);


            // Create a blue and a black Brush
            SolidColorBrush fillColour = new SolidColorBrush();
            fillColour.Color = Colors.Orange;
            SolidColorBrush edgeColour = new SolidColorBrush();
            edgeColour.Color = Colors.Black;

            // Set Ellipse's width and color
            diamond.StrokeThickness = 1;
            diamond.Stroke = edgeColour;
            // Fill rectangle with blue color
            diamond.Fill = fillColour;

            // Add Ellipse to the Grid.
            Drawarea.Children.Add(diamond);
            
        }
    }
    
}
