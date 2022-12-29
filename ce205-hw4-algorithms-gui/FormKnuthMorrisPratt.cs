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
    public partial class FormKnuthMorrisPratt : Form
    {
        public FormKnuthMorrisPratt()
        {
            InitializeComponent();
        }

        private void SrchBtn_Click(object sender, EventArgs e)
        {
            // Get the pattern and text from the text boxes
            string pattern = patternTextBox.Text;
            string text = textRichTextBox.Text;

            // Search for the pattern in the text
            int index = KnuthMorrisPratt.Search(pattern, text);
            if (index >= 0)
            {
                textRichTextBox.Select(0, index);
                textRichTextBox.SelectionColor = Color.Black;
                textRichTextBox.Select(index, pattern.Length);
                textRichTextBox.SelectionColor = Color.Green;
                textRichTextBox.Select(index + pattern.Length, text.Length - index - pattern.Length);
                textRichTextBox.SelectionColor = Color.Black;
            }
        }
    }
}
