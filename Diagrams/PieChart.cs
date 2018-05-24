using System.Collections.Generic;
using System.Windows.Controls;

namespace Diagrams
{
    public class PieChart : AbstractDiagram
    {
        public PieChart(double[] data, string title = "PieChart") : base(data, title){}

        public override void Draw(Canvas canvas)
        {
            
        }

        public override void Axis(params double[] x)
        {
            
        }

        public override void Legend(params string[] name)
        {
            
        }
    }
}