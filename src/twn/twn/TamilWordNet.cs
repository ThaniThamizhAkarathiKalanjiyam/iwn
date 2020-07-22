using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace twn
{
    public partial class TamilWordNet : Form
    {
        public TamilWordNet()
        {
            InitializeComponent();
            loadAllWords();

        }

        private void loadAllWords()
        {
            foreach (string word in Directory.GetFiles("wn_synset"))
                listBox1.Items.Add(Path.GetFileName(word));
        }
    }
}
