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
    public partial class FormNeedlemanWunsch : Form
    {
        public FormNeedlemanWunsch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the DNA sequences to align
            string sequence1 = sequence1Box.Text;
            string sequence2 = sequence2Box.Text;

            // Align the DNA sequences using the Needleman-Wunsch algorithm
            (string aligned1, string aligned2) = NeedlemanWunsch.Align(sequence1, sequence2);

            // Clear the RichTextBox controls
            alignedSequence1Box.Clear();
            alignedSequence2Box.Clear();

            // Iterate through the aligned DNA sequences and add colored text to the RichTextBox controls
            for (int i = 0; i < aligned1.Length; i++)
            {
                // Set the text color based on whether the characters match
                if (aligned1[i] == aligned2[i])
                {
                    alignedSequence1Box.SelectionColor = Color.Green;
                    alignedSequence2Box.SelectionColor = Color.Green;
                }
                else
                {
                    alignedSequence1Box.SelectionColor = Color.Red;
                    alignedSequence2Box.SelectionColor = Color.Red;
                }

                // Add the characters to the RichTextBox controls
                alignedSequence1Box.AppendText(aligned1[i].ToString());
                alignedSequence2Box.AppendText(aligned2[i].ToString());
            }
        }
    }
}
