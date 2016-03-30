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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_ellipse_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 75;
            ellipse.Width = 150;
            
            SolidColorBrush fillColour = new SolidColorBrush();
            fillColour.Color = Colors.Orange;
            SolidColorBrush edgeColour = new SolidColorBrush();
            edgeColour.Color = Colors.Black;
            
            ellipse.StrokeThickness = 1;
            ellipse.Stroke = edgeColour;
            ellipse.Fill = fillColour;
            
            Drawarea.Children.Add(ellipse);
            Canvas.SetLeft(ellipse, 200);
            Canvas.SetTop(ellipse, 200);
        }

        private void btn_diamond_Click(object sender, RoutedEventArgs e)
        {
            Rectangle diamond = new Rectangle();
            diamond.Height = 75;
            diamond.Width = 75;
            int angle = 45;
            diamond.RenderTransform = new RotateTransform(angle, diamond.Height /2, diamond.Width /2);
            
            SolidColorBrush fillColour = new SolidColorBrush();
            fillColour.Color = Colors.Orange;
            SolidColorBrush edgeColour = new SolidColorBrush();
            edgeColour.Color = Colors.Black;
            
            diamond.StrokeThickness = 1;
            diamond.Stroke = edgeColour;
            diamond.Fill = fillColour;
            
            Drawarea.Children.Add(diamond);
            Canvas.SetLeft(diamond, 200);
            Canvas.SetTop(diamond, 100);
        }

        private void btn_box_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 75;
            rectangle.Width = 75;

            SolidColorBrush fillColour = new SolidColorBrush();
            fillColour.Color = Colors.Orange;
            SolidColorBrush edgeColour = new SolidColorBrush();
            edgeColour.Color = Colors.Black;
            
            rectangle.StrokeThickness = 1;
            rectangle.Stroke = edgeColour;
            rectangle.Fill = fillColour;
            
            Drawarea.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, 50);
            Canvas.SetTop(rectangle, 50);
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            string message = "Är du säker på att du vill rensa ritbordet?";

            MessageBoxResult result = MessageBox.Show(message, "FlowChartDesigner", MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Drawarea.Children.Clear();
            }
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
    }
}
