using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class ScoreView : Form,View
    {
        public ScoreView()
        {
            InitializeComponent();
        }

        private void ScoreView_Load(object sender, EventArgs e)
        {

        }
        public void Notify(Model m)
        {
            label2.Text = ((TwoZeroFourEightModel)m)._score.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
