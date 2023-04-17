using System;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dictionary
{
    public partial class Dictionary : Form
    {
        //List<string> langs = new List<string>();

        Dictionary<string, string> langs = new Dictionary<string, string>();

        List<Word> words = new List<Word>();
        int l1, l2;
        public Dictionary()
        {
            InitializeComponent();
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {
            langs = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText("./langs.json"));
            langs1.Items.AddRange(langs.Keys.ToArray());
            langs2.Items.AddRange(langs.Keys.ToArray());

            words = JsonSerializer.Deserialize<List<Word>>(File.ReadAllText("./words.json"));

            langs1.Sorted = langs2.Sorted = true;
            langs2.SelectedIndex = (l2 = (langs1.SelectedIndex = (l1 = 0)) + 1);

            langs1.SelectedIndexChanged += langs_SelectedIndexChanged;
            langs2.SelectedIndexChanged += langs_SelectedIndexChanged;


            foreach (var item in langs)
            {
                Console.WriteLine(item.Key);
            }










        }

        private void button2_Click(object sender, EventArgs e)
        {
            string i = iInput.Text;
            foreach (var item in words)
            {
                if (item.Translations[langs[langs1.Text]] == i)
                {
                    iOutput.Text = item.Translations[langs[langs2.Text]];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                langs1.DropDownStyle = langs2.DropDownStyle = ComboBoxStyle.DropDownList;
                return;
            }
            
        }

        private void langs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
