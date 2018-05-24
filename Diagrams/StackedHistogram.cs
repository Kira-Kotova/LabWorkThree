using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Drawing;

namespace Diagrams
{
    public class StackedHistogram : AbstractDiagram
    {

        public StackedHistogram(List<double[]> data, string title = "StackedHistogram") : base(data,title)
        {
            /*for (int k = 0; k < data.Count; k++)//идём по каждой серии
            {
                for (int i = 0; i < data[k].Length; i++)
                {
                    data[k][i] += data[k - 1][i];//накопление
                }
            }*/
            DataSeries.Series = data;
        }
        public override void Draw(Canvas canvas)
        {
            foreach (var array in DataSeries.Series)
            {
                canvas.Children.Clear();
                var height = canvas.Height / array.Length;
                var x = 5;
                var dx = 10;
                var y = 0;
                double dy;
                var g = new GeometryGroup();
                for (int i = 0; i < array.Length; i++)
                {
                    dy = (array[i] * 100) / array.Sum();
                    g.Children.Add(new RectangleGeometry(new Rect(x,y,dx,dy)));
                    
                }
            }
        }

        public override void Axis(params double[] x)
        {
            
        }

        public override void Legend(params string[] name)
        {
            
        }
    }
}