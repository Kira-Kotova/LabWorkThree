using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using Diagrams;

namespace WDiagrams
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
        /// <summary>
        /// Текущий тип диаграммы
        /// </summary>
        DiagramType currenType;
        

        
        
        private void PieChartButtonClick(object sender, RoutedEventArgs e)
        {
            currenType = DiagramType.Piechart;
            new DrawDiagramDialog(currenType).ShowDialog();
        }

        private void NormalizedHistogramButtonClick(object sender, RoutedEventArgs e)
        {
            currenType = DiagramType.NormalizaedHistogram;
            new DrawDiagramDialog(currenType).ShowDialog();
        }

        private void StackedHistogramButtonCLick(object sender, RoutedEventArgs e)
        {
            currenType = DiagramType.StackedHistogram;
            new DrawDiagramDialog(currenType).ShowDialog();
        }

        private void ExitButtonOnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}