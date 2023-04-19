using System;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;

namespace Dictionary
{
    public partial class Dictionary : Form
    {
        Dictionary<string, string> langs = new Dictionary<string, string>();

        List<Word> words = new List<Word>();

        int l1, l2;

        string filelangs = "langs.json", filewords = "words.json";

        public Dictionary()
        {
            InitializeComponent();
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {
            langs = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(filelangs));
            langs1.Items.AddRange(langs.Keys.ToArray());
            langs2.Items.AddRange(langs.Keys.ToArray());

            words = JsonSerializer.Deserialize<List<Word>>(File.ReadAllText(filewords));

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
            string o = iOutput.Text;

            if(iInput.Text == "" || iOutput.Text == "")
            {
                MessageBox.Show("Пустое поле ввода!");
                return;
            }

            if (langs1.Text == langs2.Text)
            {
                MessageBox.Show("Выбран один и тот же язык \nдля исходного и переведонного слова!");
                return;
            }

            if (bTranslate.Text == "Добавить")
            {
                foreach (var item in words)
                {
                    if (item.Translations[langs1.Text] == i)
                    {
                        if (item.Translations[langs2.Text] == "")
                        {
                            item.Translations[langs2.Text] = o;
                        }
                        DialogResult dr = MessageBox.Show($"Уже существует перевод слова {i}\nХотите изменить перевод?", "Mood Test", MessageBoxButtons.YesNo);

                        switch(dr) 
                        {
                            case DialogResult.Yes:
                                item.Translations[langs2.Text] = o;
                                break;
                            case DialogResult.No:
                                return;
                        }
                    }
                }
                words.Add(new Word
                {
                    Translations = new Dictionary<string, string>
                    {
                        [langs[langs1.Text]] = iInput.Text,
                        [langs[langs2.Text]] = iOutput.Text,
                    }
                });

                iInput.Text = string.Empty;
                iOutput.Text = string.Empty;

                return;
            }
            else
            {
                
                foreach (var item in words)
                {
                    if (item.Translations[langs[langs1.Text]] == i)
                    {
                        if (item.Translations[langs[langs2.Text]] == null)
                        {
                            MessageBox.Show($"Не найден перевод слова {i} на {langs2.Text} язык");
                            return;
                        }
                        iOutput.Text = item.Translations[langs[langs2.Text]];
                        return;

                    }
                }

                MessageBox.Show($"Ошибка! В словаре не найденно слово {i}");
            }
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Panel panel1 = new Panel();
            panel1.Height = Height; panel1.Width = Width;
            panel1.BackgroundImage = new Bitmap(Image.FromFile("./langs.jpg"), Size);
            Controls.Add(panel1);
            panel1.BringToFront();
            Thread.Sleep(400);
            Controls.Remove(panel1);

            if (checkBox1.Checked)
            {
                iOutput.ReadOnly = false;

                langs1.DropDownStyle = ComboBoxStyle.DropDown;
                langs2.DropDownStyle = ComboBoxStyle.DropDown;
                langs2.Text = string.Empty;

                bTranslate.Text = "Добавить";

                return;
            }

            iOutput.ReadOnly = true;

            langs1.DropDownStyle = ComboBoxStyle.DropDownList;
            langs2.DropDownStyle = ComboBoxStyle.DropDownList;

            bTranslate.Text = "Перевести";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l1 = langs1.SelectedIndex; int l2 = langs2.SelectedIndex;
            langs1.SelectedIndex = l2;
            langs2.SelectedIndex = l1;

        }

        private void Dictionary_FormClosing(object sender, FormClosingEventArgs e)
        {
            var jsonToWrite = JsonSerializer.Serialize(words, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filewords, jsonToWrite);
        }

        private void langs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
