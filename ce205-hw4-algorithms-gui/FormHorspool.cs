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
    public partial class FormHorspool : Form
    {
        public FormHorspool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Metin ve anahtar kelimeyi metin kutularından al
            string text = richTextBox.Text;
            string keyword = keywordTextBox.Text;

            // Anahtar kelimeyi arama
            int index = Horspool.Search(text, keyword);

            if (index >= 0)
            {
                // Anahtar kelimeyi metinde vurgula
                richTextBox.Select(index, keyword.Length);
                richTextBox.SelectionColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Anahtar kelime bulunamadı!");
            }
        }
    }
}
