using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Diagrams;

namespace WDiagrams
{
    public partial class DrawDiagramDialog : Window
    {
        
        private DiagramType Type;
        private DataProvider DataInfo;
 
        public DrawDiagramDialog(DiagramType type)
        {
            Type= type;
            
            InitializeComponent();         
        }   

        private void AddButtonOnClick(object sender, RoutedEventArgs e)
        {
            double result;
            if (double.TryParse(TextBoxWithData.Text, out result))
            {
                ListBoxWithData.Items.Add(TextBoxWithData.Text);
                TextBoxWithData.Text = string.Empty;
                if (DataInfo.Series.Count > 0 && ListBoxWithData.Items.Count == DataInfo.Series[0].Length)
                {
                    SeriesButton.IsEnabled = true;
                    AddButton.IsEnabled = false;
                }
            }
        }

        //test version
        private void DeleteButtonOnClick(object sender, RoutedEventArgs e)
        {
            ListBoxWithData.Items.RemoveAt(ListBoxWithData.SelectedIndex);
            DeleteButton.IsEnabled = false;
        }

        private void DrawButtonOnClick(object sender, RoutedEventArgs e)
        {
            DataInfo.Data = new double[ListBoxWithData.Items.Count];
            for (int i = 0; i < ListBoxWithData.Items.Count; i++)
            {
                DataInfo.Data[i] = double.Parse(ListBoxWithData.Items[i].ToString());
            }

            switch (Type)
            {
                case DiagramType.Piechart:
                    var pieChart = new PieChart(DataInfo.Data);
                    pieChart.Draw(MainCanvas);
                    TitleListBox.Text = pieChart.Title;
                    break;
                case DiagramType.NormalizaedHistogram:
                    var normHist = new NormalizedHistogram(DataInfo.Series);
                    normHist.Draw(MainCanvas);
                    TitleListBox.Text = normHist.Title;
                    break;
                case DiagramType.StackedHistogram:
                    var stHist = new StackedHistogram(DataInfo.Series);
                    stHist.Draw(MainCanvas);
                    TitleListBox.Text = stHist.Title;
                    break;     
            }

            AddButton.IsEnabled = false;
            SeriesButton.IsEnabled = false;
            DeleteButton.IsEnabled = false;
            DrawButton.IsEnabled = false;
            
            DataInfo.Series.Clear();
            ListBoxWithData.Items.Clear();
        }

        private void SeriesButtonOnClick(object sender, RoutedEventArgs e)
        {
            DataInfo.Data = new double[ListBoxWithData.Items.Count];
            for (int i = 0; i < ListBoxWithData.Items.Count; i++)
            {
                DataInfo.Data[i] = double.Parse(ListBoxWithData.Items[i].ToString());
            }
            DataInfo.Series.Add(DataInfo.Data);
            ListBoxWithData.Items.Clear();
            SeriesButton.IsEnabled = false;
            AddButton.IsEnabled = true;
        }


        private void ListBoxWithData_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxWithData.SelectedIndex >= 0)
                DeleteButton.IsEnabled = true;
        }

        
        /// <summary>
        /// Защита от ввода не чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWithData_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex r = new Regex("[^0-9]");//("[^0-9]+") regex - постоянное регулярное выражение
            e.Handled = r.IsMatch(e.Text); 
        }
    }
}
