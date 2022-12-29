using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ce205_hw4_algorithms_cs;

namespace ce205_hw4_algorithms_gui
{
    public partial class FormTrie : Form
    {
        private List<Keyword> _list = new List<Keyword>();
        public FormTrie()
        {
            InitializeComponent();
            InitializeList(_list);
            ConfigurinBuildInComboBox();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan girdi olarak alınan kelimeyi Trie sınıfını kullanarak ekleyin
            Trie.Insert(comboBox1.Text);

            // ListBox'a eklenecek kelimeleri saklayan liste
            List<string> words = new List<string>();
            // Trie sınıfındaki ağacın köküne gidin
            Trie.TrieNode current = Trie._root;
            // Ağaçtaki tüm kelimeleri dolaşın
            Traverse(current, "", words);
            // ListBox'a kelimeleri ekleyin
            listBox1.DataSource = words;
        }

        private void Traverse(Trie.TrieNode current, string word, List<string> words)
        {
            // Eğer kelime sonu isaretçisi true ise, kelimeyi words listesine ekleyin
            if (current.IsEndOfWord)
            {
                words.Add(word);
            }

            // Eğer ağaçtaki herhangi bir çocuk varsa, onları da dolaşın
            foreach (char c in current.Children.Keys)
            {
                Traverse(current.Children[c], word + c, words);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan girdi olarak alınan kelimeyi Trie sınıfını kullanarak arayın
            if (Trie.Search(comboBox1.Text))
            {
                MessageBox.Show("Kelime Trie ağacında bulundu!");
            }
            else
            {
                MessageBox.Show("Kelime Trie ağacında bulunamadı!");
            }
        }

        private void ConfigurinBuildInComboBox()
        {           
            _list = _list.OrderBy(x => x.Word).ToList();
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Word";
            comboBox1.SelectedIndex = -1;
            
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void InitializeList(List<Keyword> list)
        {
            list.Add(new Keyword { Word = "Apple"});
            list.Add(new Keyword { Word = "ACGTTACG"});
            list.Add(new Keyword { Word = "Semanur Ersoy"});
            list.Add(new Keyword { Word = "Rumeysa Er"});
            list.Add(new Keyword { Word = "Samsung"});
            list.Add(new Keyword { Word = "Pencil"});
            list.Add(new Keyword { Word = "Water"});
            list.Add(new Keyword { Word = "Ugur Coruh"});
            list.Add(new Keyword { Word = "Data"});
            list.Add(new Keyword { Word = "Algorithm and Programming"});
            list.Add(new Keyword { Word = "Code"});
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Keyword keyword = comboBox1.SelectedItem as Keyword;
            }
        }

    }

    public class Keyword
    {
        public string Word { get; set; }
    }
}
