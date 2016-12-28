using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplineChart
{
    public partial class RichSplineChart : UserControl
    {

        public RichSplineChart()
        {
            InitializeComponent();
        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.chart1.Width = this.Width;
            this.chart1.Height = this.Height - 3;

        }
    }
}
