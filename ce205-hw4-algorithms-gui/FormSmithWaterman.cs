using ce205_hw4_algorithms_cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ce205_hw4_algorithms_gui
{
    public partial class FormSmithWaterman : Form
    {
        public FormSmithWaterman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sequence1 = sequence1RichTextBox.Text;
            string sequence2 = sequence2RichTextBox.Text;
            int gapPenalty = Convert.ToInt32(gapPenaltyTextBox.Text);

            var sw = new SmithWaterman(sequence1, sequence2, gapPenalty);
            int score = sw.Compute();

            scoreLabel2.Text = "Benzerlik skoru: " + score.ToString();
        }

        private void FormSmithWaterman_Load(object sender, EventArgs e)
        {

        }
    }
}
