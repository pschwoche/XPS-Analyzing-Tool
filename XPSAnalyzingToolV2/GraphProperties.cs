using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace XPSAnalyzingTool
{
    public class GraphProperties
    {
        
        public LineItem LineItem { get; }
        public ErrorBarItem Errorbaritem { get; }
        public bool IsVisible { set; get; }

        public GraphProperties(string name)
        {

            LineItem = new LineItem(name);
            Errorbaritem = new ErrorBarItem(name);

            SetDefaults();
        }

        private void SetDefaults()
        {
            IsVisible = true;

            LineItem.Line.Color = Color.Blue;
            LineItem.Line.IsVisible = false;
            LineItem.Symbol.Type = SymbolType.Circle;
            LineItem.Symbol.Size = 2f;
            LineItem.Symbol.Border.Color = Color.Blue;
            LineItem.Symbol.Fill.Color = Color.Blue;
            LineItem.Symbol.Fill.Type = FillType.Solid;
            LineItem.Symbol.Fill.IsVisible = true;
            LineItem.Symbol.IsVisible = true;

            LineItem.Line.IsAntiAlias = true;
            LineItem.Symbol.IsAntiAlias = true;


            Errorbaritem.Bar.Color = Color.LightBlue;
            Errorbaritem.Bar.PenWidth = 2f;
            Errorbaritem.Bar.Symbol.Type = SymbolType.None;
            Errorbaritem.Label.IsVisible = false;
        }
    }
}
