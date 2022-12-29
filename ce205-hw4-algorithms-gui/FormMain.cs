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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormNeedlemanWunsch formNeedlemanWunsch = new FormNeedlemanWunsch();
            formNeedlemanWunsch.TopLevel = false;
            pnlislem.Controls.Add(formNeedlemanWunsch);
            formNeedlemanWunsch.Show();
            formNeedlemanWunsch.Dock = DockStyle.Fill;
            formNeedlemanWunsch.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormSmithWaterman formSmithWaterman = new FormSmithWaterman();
            formSmithWaterman.TopLevel = false;
            pnlislem.Controls.Add(formSmithWaterman);
            formSmithWaterman.Show();
            formSmithWaterman.Dock = DockStyle.Fill;
            formSmithWaterman.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormHuntSzymanski formHuntSzymanski = new FormHuntSzymanski();
            formHuntSzymanski.TopLevel = false;
            pnlislem.Controls.Add(formHuntSzymanski);
            formHuntSzymanski.Show();
            formHuntSzymanski.Dock = DockStyle.Fill;
            formHuntSzymanski.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormKnuthMorrisPratt formKnuthMorrisPratt = new FormKnuthMorrisPratt();
            formKnuthMorrisPratt.TopLevel = false;
            pnlislem.Controls.Add(formKnuthMorrisPratt);
            formKnuthMorrisPratt.Show();
            formKnuthMorrisPratt.Dock = DockStyle.Fill;
            formKnuthMorrisPratt.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormHorspool formHorspool = new FormHorspool();
            formHorspool.TopLevel = false;
            pnlislem.Controls.Add(formHorspool);
            formHorspool.Show();
            formHorspool.Dock = DockStyle.Fill;
            formHorspool.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormBoyerMoore formBoyerMoore = new FormBoyerMoore();
            formBoyerMoore.TopLevel = false;
            pnlislem.Controls.Add(formBoyerMoore);
            formBoyerMoore.Show();
            formBoyerMoore.Dock = DockStyle.Fill;
            formBoyerMoore.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            FormTrie formTrie = new FormTrie();
            formTrie.TopLevel = false;
            pnlislem.Controls.Add(formTrie);
            formTrie.Show();
            formTrie.Dock = DockStyle.Fill;
            formTrie.BringToFront();
        }
    }
}
