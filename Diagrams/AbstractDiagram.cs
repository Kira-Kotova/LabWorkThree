using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;
using Diagrams.Annotations;


namespace Diagrams
{
    public enum DiagramType
    {
        Piechart,
        StackedHistogram,
        NormalizaedHistogram
    }

    public abstract class AbstractDiagram : Canvas
    {
        //Данные
        public DataProvider DataSeries;
        //Диаграмма
        public abstract void Draw(Canvas canvas);
        //Оси
        public abstract void Axis(params double[] x);
        //Легенда
        public abstract void Legend(params string[] name);
        //Заголовок
        public string Title;

        public AbstractDiagram() {}

        public AbstractDiagram(DataProvider data, string title)
        {
            DataSeries = data;
            Title = title;
        }
        

    }
}