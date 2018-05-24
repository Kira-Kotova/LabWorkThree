using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Diagrams.Annotations;

namespace Diagrams
{
    public sealed class DataProvider
    {  

        public double[] Data { get; set; }

        public List<double[]> Series { get; set; }
        
        /// <summary>
        /// Для одной серии
        /// </summary>
        /// <param name="data">данные</param>
        public DataProvider(double[] data)
        {
            Data = data;;
        }

        /// <summary>
        /// Для нескольких серий
        /// </summary>
        /// <param name="series">данные</param>
        public DataProvider(List<double[]> series)
        {
            Series = series;
        }

         public static implicit operator DataProvider(double[] data) => new DataProvider(data);
         public static implicit operator DataProvider(List<double[]> data) => new DataProvider(data);
    }
}