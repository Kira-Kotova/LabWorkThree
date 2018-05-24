using System.Collections.Generic;
using System.Windows.Controls;

namespace Diagrams
{
    public class NormalizedHistogram : AbstractDiagram
    {
        public NormalizedHistogram(List<double[]> data, string title = "NormalizedHistogram") : base(data, title){}

        public override void Draw(Canvas canvas){}

        public override void Axis(params double[] x)
        {
            
        }

        public override void Legend(params string[] name)
        {
            
        }
        
    }
}