using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPaint
{
    public partial class BrushSelector : Form
    {
        public BrushSelector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = this.Owner as Form1;
            x.paint.p.Brush = new SolidBrush(Color.Black);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
  
            Form1 x = this.Owner as Form1;
            Rectangle rect = new Rectangle(50, 30, 200, 200);
            LinearGradientBrush IBrush = new LinearGradientBrush(rect, Color.Red,Color.Green, LinearGradientMode.BackwardDiagonal);  
            x.paint.p.Brush = IBrush;

        }

    }
}
