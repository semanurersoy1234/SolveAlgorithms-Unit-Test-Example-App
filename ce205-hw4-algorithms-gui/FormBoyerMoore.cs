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
    public partial class FormBoyerMoore : Form
    {
        public FormBoyerMoore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text and keyword to search for
            string text = richTextBox.Text;
            string keyword = keywordBox.Text;

            // Use the Boyer-Moore algorithm to search for the keyword
            int index = BoyerMoore.Search(text, keyword);

            // Display the result
            if (index >= 0)
            {
                resultLabel.Text = "";
                richTextBox.Select(index, keyword.Length);
                richTextBox.SelectionColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Keyword not found";
            }
        }
    }
}
