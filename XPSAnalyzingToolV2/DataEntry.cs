using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace XPSAnalyzingTool
{
    public class DataEntry
    {

        public Data Data { set; get; }
        public GraphProperties GraphProperties { set; get; }

        public PointPairList PPL_data { set; get; }
        public PointPairList PPL_error { set; get; }


        public DataEntry(Data data, GraphProperties gp)
        {
            this.Data = data;
            this.GraphProperties = gp;
            InitPPLs();
        }

        public DataEntry(Data data, String name)
        {
            this.Data = data;
            this.GraphProperties = new GraphProperties(name);
            InitPPLs();
        }

        public DataEntry(double[] x, double[] y, double[] err, String name)
        {
            this.Data = new Data(x, y, err);
            this.GraphProperties = new GraphProperties(name);

            InitPPLs();
        }

        private void InitPPLs()
        {
            this.PPL_data = Data.CreateDataPPL();
            this.PPL_error = Data.CreateErrorPPL();
        }

    }
}
