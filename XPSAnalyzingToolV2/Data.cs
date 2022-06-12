using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace XPSAnalyzingTool
{
    public class Data
    {
        public double[] X { get; set; }
        public double[] Y { get; set; }
        public double[] Error { get; set; }

        public Data(double[] x, double[] y, double[] err)
        {
            if(x.Length != y.Length || x.Length != err.Length || y.Length != err.Length)
            {
                throw new Exception("Data creation failed. Dimensions not in order.");
            }

            this.X = x;
            this.Y = y;
            this.Error = err;
        }


        public PointPairList CreateDataPPL()
        {
            PointPairList ppl = new PointPairList(this.X, this.Y);
            ppl.Sort();
            return ppl;
        }


        public PointPairList CreateErrorPPL()
        {
            double[] y_minus = new double[this.X.Length];
            double[] y_plus = new double[this.X.Length];

            Parallel.For(0, this.X.Length,(i,state) =>
            {
                y_minus[i] = this.Y[i] - this.Error[i];
                y_plus[i] = this.Y[i] + this.Error[i];
            });
            PointPairList ppl = new PointPairList(this.X, y_minus, y_plus);
            ppl.Sort();
            return ppl;
        }



    }
}
