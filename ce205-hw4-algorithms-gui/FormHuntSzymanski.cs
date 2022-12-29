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
    public partial class FormHuntSzymanski : Form
    {
        public FormHuntSzymanski()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text and keyword to search for
            string text = richTextBox.Text;
            string keyword = keywordBox.Text;

            // Use the Hunt-Szymanski algorithm to search for the keyword
            int index = HuntSzymanski.Search(text, keyword);

            // Change the foreground color of the matching and non-matching characters in the text
            if (index >= 0)
            {
                richTextBox.Select(index, keyword.Length);
                richTextBox.SelectionColor = Color.Green;
            }
            else
            {
                for (int i = 0; i < text.Length - keyword.Length + 1; i++)
                {
                    // Calculate the hash of the current substring
                    long textHash = HuntSzymanski.CalculateHash(text.Substring(i, keyword.Length));
                    long keywordHash = HuntSzymanski.CalculateHash(keyword);

                    // Check if the hash of the current substring matches the hash of the keyword
                    if (keywordHash == textHash)
                    {
                        richTextBox.SelectionStart = i;
                        richTextBox.Select(i, keyword.Length);
                        richTextBox.SelectionColor = Color.Red;
                    }
                }
            }
        }
    }
}
